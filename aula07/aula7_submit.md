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
R1: Livro(<u>_Titulo_Livro_</u>, <u>_Nome_Autor_</u>, Tipo_Livro, Preco, NoPaginas, Editor, Endereco_Editor, Ano_Puublicacao)
R2: Autor(<u>_Nome_Autor_</u>, Afiliacao_Autor)

- Terceira forma normal (3FN):
R1: AUTOR(<u>_Nome_Autor_</u>, Afiliacao_Autor)
R2: EDITOR(<u>_Editor_</u>, Endereco_Editor)
R3: Livro(<u>_Titulo_Livro_</u>, <u>_Nome_Autor_</u>, Tipo_Livro NoPaginas, Editor, Ano_Puublicacao)
R4: PRECO_POR_TIPO_PAG(<u>_Tipo_Livro_</u>, <u>_NoPaginas_</u>, Preco)
```




## ​7.3
 
### *a)*

```
... Write here your answer ...
{A,B} é a chave (super-chave).
```


### *b)* 

```
... Write here your answer ...
R1 ((<u>A(</u>, D, E, I, J)
R2 ((<u>B(</u>, F, G, H)
R3 ((<u>A(</u>, B, C)
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
