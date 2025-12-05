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
```

### b)

```
... Write here your answer ...
```

### c)

```
... Write here your answer ...
```

### d)

```
... Write here your answer ...
```

### e)

```
... Write here your answer ...
```

## ​9.3.

```
... Write here your answer ...
```
