# BD: Guião 5


## ​Problema 5.1
 
### *a)*

```
Write here your answer e.g:
(π Pname, Pnumber (project) ⨝ Pno=Pnumber (works_on)) ⨝.... 
```


### *b)* 

```
... Write here your answer ...
```


### *c)* 

```
... Write here your answer ...
```


### *d)* 

```
... Write here your answer ...
```


### *e)* 

```
... Write here your answer ...
```


### *f)* 

```
... Write here your answer ...
```


### *g)* 

```
... Write here your answer ...
```


### *h)* 

```
... Write here your answer ...
```


### *i)* 

```
... Write here your answer ...
```


## ​Problema 5.2

### *a)*

```
a = π nome (σ numero = null (fornecedor ⟕ (nif = fornecedor) encomenda))

- ⟕ -> junnção
- σ numero = null -> mantém apenas os qu não têm encomenda
- π nome -> mostra só o nome do fornecedor

```

### *b)* 

```
b = γ codProd; AVG(unidades) → media_unidades (item)


- γ -> agrupamento 
- codProd -> atributo de agrupamento
- Avg(unidades) -> média do número de unidades encomendadas (TotalUnidades item)
```


### *c)* 

```
Produtos = γ numEnc; COUNT(codProd) → total_prod (item)
γ AVG(total_prod) → media_produtos (γ numEnc; COUNT(codProd) → total_prod (item))
```


### *d)* 

```
γ fornecedor.nome, produto.nome; SUM(item.unidades) → total_unidades
(
  ( (fornecedor ⨝ (nif = encomenda.fornecedor) encomenda)
    ⨝ (encomenda.numero = item.numEnc) item )
    ⨝ (item.codProd = produto.codigo) produto
)

```

## ​Problema 5.3

### *a)*

```
... Write here your answer ...
```

### *b)* 

```
... Write here your answer ...
```


### *c)* 

```
... Write here your answer ...
```


### *d)* 

```
... Write here your answer ...
```

### *e)* 

```
... Write here your answer ...
```

### *f)* 

```
... Write here your answer ...
```
