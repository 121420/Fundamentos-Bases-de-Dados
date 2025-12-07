# BD: Guião 9


## ​9.1. Complete a seguinte tabela.
Complete the following table.

| #       | Query                                                 | Rows   | Cost  | Pag. Reads | Time (ms) | Index used                             | Index Op.                            | Discussion                                                                            |
| ------- | ----------------------------------------------------- | ------ | ----- | ---------- | --------- | -------------------------------------- | ------------------------------------ | ------------------------------------------------------------------------------------- |
| **1**   | `SELECT * FROM Production.WorkOrder`                  | 72 591 | 0.48  | 531        | 1100–1300 | PK (Clustered)                         | Clustered Index Scan                 | Varre a tabela toda (full scan). Natural, pois não há filtro. Custo dominado por I/O. |
| **2**   | `WHERE WorkOrderID = 1234`                            | 1      | 0.003 | 3          | 3–6       | PK (Clustered)                         | Clustered Index Seek                 | Seek direto na PK → muito rápido, quase nada de leitura.                              |
| **3.1** | `WHERE WorkOrderID BETWEEN 10000 AND 10010`           | 11     | 0.006 | 4          | 4–8       | PK (Clustered)                         | Clustered Index Seek + Range Scan    | Intervalo pequeno → seek + poucas páginas lidas.                                      |
| **3.2** | `WHERE WorkOrderID BETWEEN 1 AND 72591`               | 72 591 | 0.48  | 531        | 1100–1300 | PK (Clustered)                         | Clustered Index Scan                 | Intervalo cobre tudo → mesmo resultado que Query #1.                                  |
| **4**   | `WHERE StartDate = '2007-06-25'`                      | ~90    | 0.12  | 180–230    | 40–70     | PK (Clustered)                         | Clustered Index Scan                 | Sem índice em StartDate → precisa scan completo.                                      |
| **5**   | `WHERE ProductID = 757`                               | ~350   | 0.02  | 40–70      | 10–20     | Nonclustered Index (ProductID)         | Nonclustered Index Seek + Key Lookup | Seek bom, mas muitos key lookups tornam mais lento.                                   |
| **6.1** | `SELECT WorkOrderID, StartDate WHERE ProductID = 757` | ~350   | 0.015 | 30–40      | 8–15      | Nonclustered ProductID *covered*       | Index Seek                           | Covered → evita Key Lookup → mais rápido que #5.                                      |
| **6.2** | `WHERE ProductID = 945`                               | ~120   | 0.01  | 15–25      | 5–10      | Nonclustered ProductID *covered*       | Index Seek                           | Poucas linhas. Desempenho excelente.                                                  |
| **6.3** | `WHERE ProductID = 945 AND StartDate = '2006-01-04'`  | 1      | 0.005 | 3–5        | 3–6       | Nonclustered ProductID *covered*       | Index Seek + Residual Predicate      | Índice não é composto → SQL faz seek por ProductID e filtra por StartDate.            |
| **7**   | `WHERE ProductID = 945 AND StartDate = '2006-01-04'`  | 1      | 0.003 | 2–3        | 3–5       | Composite Index (ProductID, StartDate) | Index Seek Precisão                  | Seek direto nos dois atributos → menor custo.                                         |
| **8**   | `WHERE ProductID = 945 AND StartDate = '2006-01-04'`  | 1      | 0.003 | 2–3        | 3–5       | Composite Index (ProductID, StartDate) | Index Seek                           | Mesmo comportamento da #7 porque usa índice composto criado.                          |

## ​9.2.

### a)

```
... Write here your answer ...
ALTER TABLE mytemp 
ADD CONSTRAINT PK_mytemp PRIMARY KEY CLUSTERED (rid);
```

### b)

```
... Write here your answer ...
Verificação da fragmentação e ocupação:
SELECT 
    OBJECT_NAME(ips.object_id) AS NomeTabela,
    i.name AS NomeIndice,
    ips.avg_fragmentation_in_percent AS FragmentacaoPercentagem,
    ips.avg_page_space_used_in_percent AS OcupacaoPaginasPercentagem
FROM sys.dm_db_index_physical_stats(DB_ID(), OBJECT_ID('mytemp'), NULL, NULL, 'DETAILED') AS ips
INNER JOIN sys.indexes AS i ON ips.object_id = i.object_id AND ips.index_id = i.index_id
WHERE ips.index_id > 0;

- Tempo de inserção: 114.530 ms
    Inserted: 50000 total records
    Milliseconds used: 114530   
- Fragmentação dos índices: 99,04%
- Ocupação das páginas: 68,69%
```

### c)

```
... Write here your answer ...
-- CREATE UNIQUE CLUSTERED INDEX  ridIndex_c1 ON mytemp(rid) WITH (FILLFACTOR = 65, PAD_INDEX = ON)
-- Tempo: 1:56

-- CREATE UNIQUE CLUSTERED INDEX  ridIndex_c1 ON mytemp(rid) WITH (FILLFACTOR = 80, PAD_INDEX = ON)
-- Tempo: 1:52

-- CREATE UNIQUE CLUSTERED INDEX  ridIndex_c1 ON mytemp(rid) WITH (FILLFACTOR = 90, PAD_INDEX = ON)
-- Tempo: 1:53

Fill Factor 65: 116.000 ms (~116 segundos)
Fill Factor 80: 112.000 ms (~112 segundos)
Fill Factor 90: 113.000 ms (~113 segundos)

Com valores aleatórios de rid, o fill factor tem impacto reduzido nos tempos de inserção, pois as inserções desordenadas causam page splits independentemente do espaço reservado. Fill factors mais baixos (65) deixam mais espaço livre mas também aumentam ligeiramente o número de páginas a processar.
```

### d)

```
... Write here your answer ...
CREATE TABLE mytemp (
    rid BIGINT IDENTITY(1, 1) NOT NULL,
    at1 INT NULL,
    at2 INT NULL,
    at3 INT NULL,
    lixo varchar(100) NULL
);

-- CREATE UNIQUE CLUSTERED INDEX  ridIndex_c1 ON mytemp(rid) WITH (FILLFACTOR = 65, PAD_INDEX = ON)
-- Tempo: 1:55

-- CREATE UNIQUE CLUSTERED INDEX  ridIndex_c1 ON mytemp(rid) WITH (FILLFACTOR = 80, PAD_INDEX = ON)
-- Tempo: 1:55

-- CREATE UNIQUE CLUSTERED INDEX  ridIndex_c1 ON mytemp(rid) WITH (FILLFACTOR = 90, PAD_INDEX = ON)
-- Tempo: 1:54

Com IDENTITY, os valores de rid são sequenciais e automáticos. Os tempos permanecem similares devido ao DBCC DROPCLEANBUFFERS dentro do loop. No entanto, a fragmentação seria próxima de 0% e a ocupação próxima de 100%, pois as inserções são sempre no final da tabela (ordenadas).
```

### e)

```
... Write here your answer ...

Criar índices nos outros atributos:
CREATE INDEX IX_mytemp_at1 ON mytemp(at1);
CREATE INDEX IX_mytemp_at2 ON mytemp(at2);
CREATE INDEX IX_mytemp_at3 ON mytemp(at3);

R.: Como a operação está a ser efectuada para cada índice criado, os tempos de execução aumentam.

```

## ​9.3.

```
... Write here your answer ...
i.      O funcionário com determinado número ssn;  
CREATE UNIQUE CLUSTERED INDEX ssnEmployee ON employee(Ssn);

ii.     O(s) funcionário(s) com determinado primeiro e último nome;
CREATE INDEX names ON employee(Lname, Fname);

iii.    Os funcionários que trabalham para determinado departamento;
CREATE INDEX Dno ON employe(Dno);

iv.     Os funcionários que trabalham para determinado projeto;
CREATE UNIQUE CLUSTERED INDEX Works ON WORKS_ON(Essn, Pno);
CREATE INDEX IX_WorksOn_Pno ON WORKS_ON(Pno); -- Para consulta inversa


v.      Os dependentes de determinado funcionário; 
CREATE UNIQUE CLUSTERED INDEX PK_Dependent 
ON DEPENDENT(Essn, Dependent_name);

vi.     Os projetos associados a determinado departamento;
CREATE INDEX DNum ON project(Dnum); 
```
