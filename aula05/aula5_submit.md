# BD: Guião 5


## ​Problema 5.1
 
### *a)*

```

works_with_project = works_on ⨝ Pno = Pnumber project

funcionarios_projeto = employee ⨝ Ssn = Essn works_with_project

resultado_a = π Ssn, Fname, Minit, Lname, Pnumber, Pname (funcionarios_projeto)


```


### *b)* 

```
ssn_carlos = π Ssn (σ Fname='Carlos' ∧ Minit='D' ∧ Lname='Gomes' (employee))

funcionarios_supervisionados = σ Super_ssn = ssn_carlos (employee)

resultado_b = π Ssn, Fname, Minit, Lname (funcionarios_supervisionados)


```


### *c)* 

```
projetos_funcionarios = project ⨝ Pnumber = Pno works_on

resultado_c = γ Pnumber, Pname; sum(Hours) → Total_Horas (projetos_funcionarios)

```


### *d)* 

```
funcionarios_projetos = employee ⨝ Ssn = Essn works_on

funcionarios_projeto_aveiro = funcionarios_projetos ⨝ Pno = Pnumber project

resultado_d = π Ssn, Fname, Minit, Lname (σ Dno = 3 ∧ Hours > 20 ∧ Pname = 'Aveiro Digital' (funcionarios_projeto_aveiro))

```


### *e)* 

```

employee_works_left = employee ⟕ Ssn = Essn works_on


resultado_e = π Ssn, Fname, Minit, Lname (σ Pno = null (employee_works_left))

```


### *f)* 

```
funcionarias = σ Sex='F' (employee)

funcionarias_departamento = funcionarias ⨝ Dno = Dnumber department

resultado_f = γ Dname; avg(Salary) → Salario_Medio (funcionarias_departamento)

```


### *g)* 

```
dependentes_por_funcionario = γ Essn; count(Dependent_name) → Num_Dependentes (dependent)

resultado_g = π Ssn, Fname, Minit, Lname (employee ⨝ Ssn = Essn σ Num_Dependentes > 2 (dependentes_por_funcionario))

```


### *h)* 

```
gerentes = employee ⨝ Ssn = Mgr_ssn department

funcionarios_sem_dependentes = gerentes ⟕ Ssn = Essn dependent

resultado_h = π Ssn, Fname, Minit, Lname (σ Essn IS NULL (funcionarios_sem_dependentes))

```


### *i)* 

```
projetos_aveiro = σ Plocation='Aveiro' project

funcionarios_projetos_aveiro = employee ⨝ Ssn = Essn works_on ⨝ Pno = Pnumber projetos_aveiro

departamentos_aveiro = σ Dnumber = Dnumber ∧ Dlocation='Aveiro' dept_locations

resultado_i = π Fname, Lname, Address (σ Dno ∉ π Dnumber (departamentos_aveiro) (funcionarios_projetos_aveiro))

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
P_all = Paciente

P_com_presc = π IDPaciente (Prescricao)

resultado_a = π IDPaciente, Nome ( P_all − (Paciente ⨝ Paciente.IDPaciente = P_com_presc.IDPaciente P_com_presc) )

resultado_a = π IDPaciente, Nome ( Paciente − π IDPaciente (Prescricao) )

```

### *b)* 

```
-- juntar prescrições com o médico para obter a especialidade
presc_med = Prescricao ⨝ Prescricao.IDMedico = Medico.IDMedico Medico

-- agrupar por especialidade e contar prescrições
resultado_b = γ Especialidade; COUNT(IDPrescricao) → NumPrescricoes ( presc_med )

```


### *c)* 

```
-- agrupar por farmácia e contar prescrições processadas
proc_por_farm = γ IDFarmacia; COUNT(IDPrescricao) → NumProcessadas ( Prescricao_Processada )

-- para mostrar nome da farmácia também
resultado_c = π IDFarmacia, Nome, NumProcessadas ( Farmacia ⨝ Farmacia.IDFarmacia = proc_por_farm.IDFarmacia proc_por_farm )

```


### *d)* 

```
farmac_906 = σ Registo = 906 ( Farmaceutica )
farmacos_906 = π IDFarmaco, Nome ( farmac_906 ⨝ Farmaceutica.IDFarmaceutica = Farmaco.IDFarmaceutica Farmaco )

farmacos_prescritos = π IDFarmaco ( Prescricao_Farmaco )

resultado_d = farmacos_906 − π IDFarmaco, Nome ( farmacos_906 ⨝ farmacos_906.IDFarmaco = Prescricao_Farmaco.IDFarmaco Prescricao_Farmaco )

```

### *e)* 

```
vendas_join = Venda ⨝ Venda.IDFarmaco = Farmaco.IDFarmaco Farmaco
vendas_join = vendas_join ⨝ Farmaco.IDFarmaceutica = Farmaceutica.IDFarmaceutica Farmaceutica

resultado_e = γ IDFarmacia, Farmaceutica.IDFarmaceutica; SUM(Quantidade) → TotalVendido ( vendas_join )

resultado_e = π IDFarmacia, Farmacia.Nome, Farmaceutica.IDFarmaceutica, Farmaceutica.Nome, TotalVendido
              ( Farmacia ⨝ Farmacia.IDFarmacia = resultado_e.IDFarmacia
                ⨝ Farmaceutica.IDFarmaceutica = resultado_e.IDFarmaceutica resultado_e )

```

### *f)* 

```

medicos_por_paciente = γ IDPaciente; COUNT(IDMedico) → NumMedicos ( Prescricao )

pacientes_multimed = σ NumMedicos > 1 ( medicos_por_paciente )

resultado_f = π IDPaciente, Nome ( Paciente ⨝ Paciente.IDPaciente = pacientes_multimed.IDPaciente pacientes_multimed )

```
