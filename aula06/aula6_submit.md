# BD: Guião 6

## Problema 6.1

### *a)* Todos os tuplos da tabela autores (authors);

```
select * from authors;
```

### *b)* O primeiro nome, o último nome e o telefone dos autores;

```
select au_fname,au_lname,phone from authors;
```

### *c)* Consulta definida em b) mas ordenada pelo primeiro nome (ascendente) e depois o último nome (ascendente); 

```
select  au_fname,au_lname,phone from authors ORDER BY au_fname ASC , au_lname ASC ;

```

### *d)* Consulta definida em c) mas renomeando os atributos para (first_name, last_name, telephone); 

```
select au_fname as first_name,au_lname as last_name,phone as telephone
from authors ORDER BY au_fname ASC , au_lname ASC 

```

### *e)* Consulta definida em d) mas só os autores da Califórnia (CA) cujo último nome é diferente de ‘Ringer’; 

```
select au_fname as first_name,au_lname as last_name,phone as telephone
from authors where state = 'CA' and au_lname = 'Ringer' ORDER BY au_fname ASC , au_lname ASC 


```

### *f)* Todas as editoras (publishers) que tenham ‘Bo’ em qualquer parte do nome; 

```
select * from publishers where pub_name LIKE '%Bo%';.
```

### *g)* Nome das editoras que têm pelo menos uma publicação do tipo ‘Business’; 

```select Distinct p.pub_name
From publishers p
JOIN titles t ON t.pub_id = p.pub_id
where t.type = 'Business';

```

### *h)* Número total de vendas de cada editora; 

```
SELECT p.pub_name, SUM(s.qty) AS total_vendas
FROM publishers p
JOIN titles t ON t.pub_id = p.pub_id
JOIN sales s ON s.title_id = t.title_id
GROUP BY p.pub_name;
```

### *i)* Número total de vendas de cada editora agrupado por título; 

```
SELECT p.pub_name, t.title, SUM(s.qty) AS total_vendas
FROM publishers p
JOIN titles t ON t.pub_id = p.pub_id
JOIN sales s ON s.title_id = t.title_id
GROUP BY p.pub_name, t.title
ORDER BY p.pub_name, t.title;

```

### *j)* Nome dos títulos vendidos pela loja ‘Bookbeat’; 

```
SELECT DISTINCT t.title
FROM stores st
JOIN sales s ON s.stor_id = st.stor_id
JOIN titles t ON t.title_id = s.title_id
WHERE st.stor_name = 'Bookbeat';

```

### *k)* Nome de autores que tenham publicações de tipos diferentes; 

```
SELECT a.au_fname, a.au_lname, a.au_id
FROM authors a
JOIN titleauthor ta ON ta.au_id = a.au_id
JOIN titles t ON t.title_id = ta.title_id
GROUP BY a.au_id, a.au_fname, a.au_lname
HAVING COUNT(DISTINCT t.type) > 1;


```

### *l)* Para os títulos, obter o preço médio e o número total de vendas agrupado por tipo (type) e editora (pub_id);

```
SELECT t.type, t.pub_id,
       AVG(t.price) AS preco_medio,
       SUM(s.qty) AS total_vendas
FROM titles t
LEFT JOIN sales s ON s.title_id = t.title_id
GROUP BY t.type, t.pub_id
ORDER BY t.type, t.pub_id;

```

### *m)* Obter o(s) tipo(s) de título(s) para o(s) qual(is) o máximo de dinheiro “à cabeça” (advance) é uma vez e meia superior à média do grupo (tipo);

```
SELECT type
FROM (
    SELECT type,
           MAX(advance) AS max_adv,
           AVG(advance) AS avg_adv
    FROM titles
    GROUP BY type
) x
WHERE max_adv >= 1.5 * avg_adv;

```

### *n)* Obter, para cada título, nome dos autores e valor arrecadado por estes com a sua venda;

```
SELECT t.title_id, t.title,
       a.au_fname, a.au_lname,
       SUM(s.qty * t.price * COALESCE(ta.royalty, 0)) AS valor_para_autor
FROM titles t
JOIN titleauthor ta ON ta.title_id = t.title_id
JOIN authors a ON a.au_id = ta.au_id
LEFT JOIN sales s ON s.title_id = t.title_id
GROUP BY t.title_id, t.title, a.au_fname, a.au_lname;

```

### *o)* Obter uma lista que incluía o número de vendas de um título (ytd_sales), o seu nome, a faturação total, o valor da faturação relativa aos autores e o valor da faturação relativa à editora;

```

WITH author_share AS (
    SELECT ta.title_id, SUM(COALESCE(ta.royalty,0)) AS total_author_royalty_frac
    FROM titleauthor ta
    GROUP BY ta.title_id
),
sales_by_title AS (
    SELECT t.title_id, t.title, t.price, SUM(s.qty) AS ytd_sales,
           SUM(s.qty * t.price) AS faturacao_total
    FROM titles t
    LEFT JOIN sales s ON s.title_id = t.title_id
    GROUP BY t.title_id, t.title, t.price
)
SELECT sbt.title_id, sbt.title, COALESCE(sbt.ytd_sales,0) AS ytd_sales,
       COALESCE(sbt.faturacao_total,0) AS faturacao_total,
       COALESCE(sbt.faturacao_total * COALESCE(asg.total_author_royalty_frac,0),0) AS faturacao_autores,
       COALESCE(sbt.faturacao_total,0) - COALESCE(sbt.faturacao_total * COALESCE(asg.total_author_royalty_frac,0),0) AS faturacao_editora
FROM sales_by_title sbt
LEFT JOIN author_share asg ON asg.title_id = sbt.title_id
ORDER BY sbt.title;

```

### *p)* Obter uma lista que incluía o número de vendas de um título (ytd_sales), o seu nome, o nome de cada autor, o valor da faturação de cada autor e o valor da faturação relativa à editora;

```
SELECT t.title_id, t.title, a.au_id, a.au_fname, a.au_lname,
       COALESCE(SUM(s.qty),0) AS ytd_sales,
       COALESCE(SUM(s.qty * t.price * COALESCE(ta.royalty,0)),0) AS faturacao_autor,
       COALESCE(SUM(s.qty * t.price),0) - COALESCE(SUM(s.qty * t.price * COALESCE(ta.royalty,0)),0) AS faturacao_editora
FROM titles t
JOIN titleauthor ta ON ta.title_id = t.title_id
JOIN authors a ON a.au_id = ta.au_id
LEFT JOIN sales s ON s.title_id = t.title_id
GROUP BY t.title_id, t.title, a.au_id, a.au_fname, a.au_lname;

```

### *q)* Lista de lojas que venderam pelo menos um exemplar de todos os livros;

```
SELECT st.stor_id, st.stor_name
FROM stores st
JOIN sales s ON s.stor_id = st.stor_id
GROUP BY st.stor_id, st.stor_name
HAVING COUNT(DISTINCT s.title_id) = (SELECT COUNT(*) FROM titles);


```

### *r)* Lista de lojas que venderam mais livros do que a média de todas as lojas;

```
WITH store_totals AS (
    SELECT s.stor_id, st.stor_name, SUM(s.qty) AS total_vendidos
    FROM stores st
    LEFT JOIN sales s ON s.stor_id = st.stor_id
    GROUP BY s.stor_id, st.stor_name
)
SELECT stt.stor_id, stt.stor_name, stt.total_vendidos
FROM store_totals stt
WHERE stt.total_vendidos > (SELECT AVG(total_vendidos) FROM store_totals);

```

### *s)* Nome dos títulos que nunca foram vendidos na loja “Bookbeat”;

```
-- obter stor_id da Bookbeat
SELECT t.title_id, t.title
FROM titles t
WHERE t.title_id NOT IN (
    SELECT s.title_id
    FROM sales s
    JOIN stores st ON st.stor_id = s.stor_id
    WHERE st.stor_name = 'Bookbeat'
);

```

### *t)* Para cada editora, a lista de todas as lojas que nunca venderam títulos dessa editora; 

```
SELECT p.pub_id, p.pub_name, st.stor_id, st.stor_name
FROM publishers p
CROSS JOIN stores st
WHERE NOT EXISTS (
    SELECT 1
    FROM sales s
    JOIN titles t ON t.title_id = s.title_id
    WHERE t.pub_id = p.pub_id
      AND s.stor_id = st.stor_id
)
ORDER BY p.pub_name, st.stor_name;

```

## Problema 6.2

### ​5.1

#### a) SQL DDL Script
 
[a) SQL DDL File](ex_6_2_1_ddl.sql "SQLFileQuestion")

#### b) Data Insertion Script

[b) SQL Data Insertion File](ex_6_2_1_data.sql "SQLFileQuestion")

#### c) Queries

##### *a)*

```
... Write here your answer ...
Lista contendo os projetos e funcionários (ssn e nome completo) que 
lá trabalham:
SELECT employee.Ssn, employee.Fname, employee.Minit, employee.Lname, project.Pnumber, project.Pname
FROM employee, works_on, project
WHERE employee.Ssn = works_on.Essn AND works_on.Pno = project.Pnumber
ORDER BY project.Pnumber

```

##### *b)* 

```
... Write here your answer ...
Nome de todos os funcionários supervisionados por ‘Carlos D Gomes’:
SELECT funcionario.Fname, funcionario.Minit, funcionario.Lname
FROM employee AS funcionario, employee AS super
WHERE funcionario.Super_ssn = super.Ssn 
  AND super.Fname = 'Carlos' 
  AND super.Minit = 'D' 
  AND super.Lname = 'Gomes'

```

##### *c)* 

```
... Write here your answer ...
Para cada projeto, listar o seu nome e o número de horas (por semana) gastos nesse 
projeto por todos os funcionários:
SELECT project.Pname, SUM(works_on.Hours) AS horas_semana
FROM project, works_on
WHERE works_on.Pno = project.Pnumber
GROUP BY project.Pname


```

##### *d)* 

```
... Write here your answer ...
Obter o nome de todos os funcionários do departamento 3 que trabalham mais de 
20 horas por semana no projeto ‘Aveiro Digital’:
SELECT employee.Fname, employee.Lname
FROM employee, works_on, project
WHERE employee.Ssn = works_on.Essn 
  AND works_on.Pno = project.Pnumber
  AND employee.Dno = 3 
  AND project.Pname = 'Aveiro Digital' 
  AND works_on.Hours > 20
```

##### *e)* 

```
... Write here your answer ...
Nome dos funcionários que não trabalham para projetos: 
SELECT employee.Fname, employee.Lname
FROM employee LEFT OUTER JOIN works_on ON employee.Ssn = works_on.Essn
WHERE works_on.Essn IS NULL
```

##### *f)* 

```
... Write here your answer ...
Para cada departamento, listar o seu nome e o salário médio dos seus funcionários 
do sexo feminino:
SELECT department.Dname, AVG(employee.Salary) AS salario_medio
FROM employee, department
WHERE employee.Dno = department.Dnumber AND employee.Sex = 'F'
GROUP BY department.Dname
```

##### *g)* 

```
... Write here your answer ...
Obter uma lista de todos os funcionários com mais do que dois dependentes:
SELECT employee.Fname, employee.Lname, COUNT(dependent.Dependent_name) AS Numero
FROM employee, dependent
WHERE employee.Ssn = dependent.Essn
GROUP BY employee.Fname, employee.Lname
HAVING COUNT(dependent.Dependent_name) > 2

```

##### *h)* 

```
... Write here your answer ...
Obtenha uma lista de todos os funcionários gestores de departamento que não têm 
dependentes:
SELECT employee.Fname, employee.Lname
FROM employee 
JOIN department ON employee.Ssn = department.Mgr_ssn 
LEFT JOIN dependent ON employee.Ssn = dependent.Essn
WHERE dependent.Essn IS NULL

```

##### *i)* 

```
... Write here your answer ...
Obter os nomes e endereços de todos os funcionários que trabalham em, pelo menos, 
um  projeto  localizado  em  Aveiro  mas  o  seu  departamento  não  tem  nenhuma 
localização em Aveiro:
SELECT DISTINCT employee.Fname, employee.Lname, employee.Address
FROM employee, works_on, project, dept_location
WHERE employee.Ssn = works_on.Essn
  AND works_on.Pno = project.Pnumber
  AND employee.Dno = dept_location.Dnumber
  AND project.Plocation = 'Aveiro'
  AND dept_location.Dlocation <> 'Aveiro'

```

### 5.2

#### a) SQL DDL Script
 
[a) SQL DDL File](ex_6_2_2_ddl.sql "SQLFileQuestion")

#### b) Data Insertion Script

[b) SQL Data Insertion File](ex_6_2_2_data.sql "SQLFileQuestion")

#### c) Queries

##### *a)*

```
... Write here your answer ...
Lista dos fornecedores que nunca tiveram encomendas:
SELECT fornecedor.nome
FROM fornecedor 
LEFT OUTER JOIN encomenda ON fornecedor.nif = encomenda.fornecedor
WHERE encomenda.fornecedor IS NULL
```

##### *b)* 

```
... Write here your answer ...
Número médio de unidades encomendadas para cada produto:
SELECT item.codProd, AVG(item.unidades) AS media
FROM item
GROUP BY item.codProd
```


##### *c)* 

```
... Write here your answer ...
Número  médio  de  produtos  por  encomenda;  (nota:  não  interessa  o  número  de 
unidades):
SELECT AVG(produtos_por_encomenda.total_produtos) AS media_produto_encomenda
FROM (
    SELECT item.numEnc, COUNT(item.codProd) AS total_produtos
    FROM item
    GROUP BY item.numEnc
) AS produtos_por_encomenda
```


##### *d)* 

```
... Write here your answer ...
Lista de produtos (e quantidades) fornecidas por cada fornecedor:
SELECT fornecedor.nome, produto.nome, SUM(item.unidades) AS quantidade
FROM fornecedor, encomenda, item, produto
WHERE fornecedor.nif = encomenda.fornecedor
  AND encomenda.numero = item.numEnc
  AND item.codProd = produto.codigo
GROUP BY fornecedor.nome, produto.nome
ORDER BY fornecedor.nome
```

### 5.3

#### a) SQL DDL Script
 
[a) SQL DDL File](ex_6_2_3_ddl.sql "SQLFileQuestion")

#### b) Data Insertion Script

[b) SQL Data Insertion File](ex_6_2_3_data.sql "SQLFileQuestion")

#### c) Queries

##### *a)*

```
... Write here your answer ...
Lista de pacientes que nunca tiveram uma prescrição
SELECT paciente.nome
FROM paciente 
LEFT OUTER JOIN prescricao ON paciente.numUtente = prescricao.numUtente
WHERE prescricao.numUtente IS NULL
```

##### *b)* 

```
... Write here your answer ...
Número de prescrições por especialidade médica:
SELECT medico.especialidade, COUNT(*) AS numero_prescricoes
FROM medico, prescricao
WHERE medico.numSNS = prescricao.numMedico
GROUP BY medico.especialidade

```


##### *c)* 

```
... Write here your answer ...
Número de prescrições processadas por farmácia:
SELECT farmacia.nome, COUNT(prescricao.numPresc) AS prescricoes_processadas
FROM farmacia, prescricao
WHERE farmacia.nome = prescricao.farmacia
GROUP BY farmacia.nome
```


##### *d)* 

```
... Write here your answer ...
Para  a  farmacêutica  com  registo  número  906,  lista  dos  seus  fármacos  nunca 
prescritos:
SELECT farmaco.nome
FROM farmaco
WHERE farmaco.numRegFarm = 906
AND farmaco.nome NOT IN (
    SELECT presc_farmaco.nomeFarmaco
    FROM prescricao, presc_farmaco
    WHERE prescricao.numPresc = presc_farmaco.numPresc
    AND presc_farmaco.numRegFarm = 906
)
```

##### *e)* 

```
... Write here your answer ...
Para cada farmácia, o número de fármacos de cada farmacêutica vendidos:
SELECT prescricao.farmacia, farmaceutica.nome, COUNT(presc_farmaco.nomeFarmaco) AS farmaco_vendido_farmacia
FROM prescricao, presc_farmaco, farmaceutica
WHERE prescricao.dataProc IS NOT NULL
  AND presc_farmaco.numPresc = prescricao.numPresc
  AND presc_farmaco.numRegFarm = farmaceutica.numReg
GROUP BY prescricao.farmacia, farmaceutica.nome
ORDER BY prescricao.farmacia
```

##### *f)* 

```
... Write here your answer ...
Pacientes que tiveram prescrições de médicos diferentes:
SELECT prescricao.numUtente, paciente.nome
FROM prescricao, medico, paciente
WHERE prescricao.numMedico = medico.numSNS
  AND prescricao.numUtente = paciente.numUtente
GROUP BY prescricao.numUtente, paciente.nome
HAVING COUNT(prescricao.numMedico) > 1
```
