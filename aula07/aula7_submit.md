# BD: Guião 7


## ​7.2 
 
### *a)*

```
... Write here your answer ...
It is possible to <u>underline</u> -> {A, B,.. } -> R1 (_A_, B, C) -> R2 (B,F)
A relação Livro está apenas na primeira forma normal (1FN), pois há depenência parcial (Nome_Autor -> Afiliacao_Autor) e dependências transistivas (Tipo_Livro, NoPaginas -> Preco e Editor -> Endereco-Editor), e mais, os seus atributos são atómicos (não admite atributos composto ou multivalores) e não suporta relações dentro de relações.
```

### *b)* 

```
... Write here your answer ...
- Segunda forma normal (2FN), pois precisamos primeiro passar a segunda antes da terceira:
Livro (_Titulo_Livro_, _Nome_Autor_, Tipo_Livro, Preco, NoPaginas, Editor, Endereco_Editor, Ano_Puublicacao)
Autor (_Nome_Autor_, Afiliacao_Autor)

- Terceira forma normal (3FN):
R1 (_Titulo_Livro_, _Nome_Autor_, Tipo_Livro, NoPaginas, Editor, Ano_Puublicacao)
R2 (_Nome_Autor_, Afiliacao_Autor)
R3 (_Tipo_Livro_, _NoPaginas_, Preco)
R4 (_Editor_, Endereco_Editor)
```




## ​7.3
 
### *a)*

```
... Write here your answer ...
{A,B} é a chave primária.
```


### *b)* 

```
... Write here your answer ...
R1 (_A_, _B_, C)
R2 (_B_, F, G, H)
R3 (_A_, D, E, I, J)
```


### *c)* 

```
... Write here your answer ...
R1 (_A_, _B_, C)
R2 (_B_, F)
R3 (_F_, G, H)
R4 (_A_, D, E)
R5 (_D_, I, J)
```


## ​7.4
 
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



## ​7.5
 
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
