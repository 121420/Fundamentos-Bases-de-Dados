# BD: Guião 8


## ​8.1
 
### *a)*

```
... Write here your answer ...
GO
CREATE OR ALTER PROCEDURE remover_funcionario 
    @ssn CHAR(9)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verifica se o funcionário existe
        IF NOT EXISTS (SELECT 1 FROM Employee WHERE Ssn = @ssn)
        BEGIN
            RAISERROR ('Funcionário não existe.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;

        -- Remover dependentes
        DELETE FROM Dependent WHERE Essn = @ssn;

        -- Remover registos em works_on
        DELETE FROM Works_on WHERE Essn = @ssn;

        -- Funcionários que tinham este como supervisor passam a NULL
        UPDATE Employee 
        SET Super_ssn = NULL 
        WHERE Super_ssn = @ssn;

        -- Remover de gestor de departamento (se for gestor)
        UPDATE Department
        SET Mgr_ssn = NULL, Mgr_start_date = NULL
        WHERE Mgr_ssn = @ssn;

        -- Remover o funcionário
        DELETE FROM Employee WHERE Ssn = @ssn;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RAISERROR ('Erro ao remover funcionário.', 16, 1);
    END CATCH
END;
GO

Preocupações adicionais discutidas:
- Garantir atomicidade - usando TRANSACTION
- Validar existência do funcionário
- Garantir consistência referencial
- Impedir valores órfãos (Super_ssn, Mgr_ssn)
- Tratar EXCEÇÕES
- Assegurar permissões

```

### *b)* 

```
... Write here your answer ...
CREATE OR ALTER PROCEDURE getManagerInfo
AS
BEGIN
    SET NOCOUNT ON;

    ;WITH Gestores AS (
        SELECT 
            E.Ssn, 
            E.Fname, 
            E.Minit, 
            E.Lname,
            DATEDIFF(YEAR, D.Mgr_start_date, GETDATE()) AS YearsOfService
        FROM Department D
        JOIN Employee E ON D.Mgr_ssn = E.Ssn
        WHERE D.Mgr_ssn IS NOT NULL
    )
    SELECT * FROM Gestores;

    -- Gestor + antig
    SELECT TOP 1 * 
    FROM Gestores
    ORDER BY YearsOfService DESC;
END;
GO

```

### *c)* 
```
... Write here your answer ...
CREATE OR ALTER TRIGGER tr_check_manager_assignment
ON Department
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT Mgr_ssn
        FROM Department
        WHERE Mgr_ssn IN (SELECT Mgr_ssn FROM inserted WHERE Mgr_ssn IS NOT NULL)
        GROUP BY Mgr_ssn
        HAVING COUNT(*) > 1
    )
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR ('Um funcionário não pode ser gestor de mais do que um departamento.', 16, 1);
        RETURN;
    END;
END;
GO

```

### *d)* 

```
... Write here your answer ...
CREATE OR ALTER TRIGGER tr_check_salary
ON Employee
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE e
    SET e.Salary = m.Salary - 1
    FROM Employee e
    JOIN inserted i ON e.Ssn = i.Ssn
    JOIN Department d ON e.Dno = d.Dnumber
    JOIN Employee m ON d.Mgr_ssn = m.Ssn
    WHERE e.Salary >= m.Salary;
END;
GO


```

### *e)* 

```
... Write here your answer ...
CREATE OR ALTER FUNCTION employeeProjects (@ssn CHAR(9))
RETURNS TABLE
AS
RETURN
(
    SELECT P.Pname, P.Plocation
    FROM Project P
    JOIN Works_on W ON P.Pnumber = W.Pno
    WHERE W.Essn = @ssn
);
GO


Uso:
GO
SELECT * FROM employeeProjects('183623612');

```

### *f)* 

```
<<<<<<< HEAD
CREATE FUNCTION dbo.getMediaFuncionarios(@Dno INT)
Returns TABLE
AS
Return
(
-------calcular o salario medio do departamento dado pelo pela var @dno
	WITH DepAvgSalary AS (
		SELECT AVG(E.Salary) as AvgSalary 
		FROM EMPLOYEE E
		Where E.Dno = @Dno
		)

		--consulataa retirnar o funcionario com join

		Select E.Fname,E.Lname,E.Salary,E.Dno
		FROM EMPLOYEE E
		CROSS JOIN DepAvgSalary D Where E.Dno = @dno 
		AND E.Salary > D.AvgSalary

);

=======
... Write here your answer ...
>>>>>>> b0e8178ff6af75f2b7b6b4be88b312acc9f555f2
```

### *g)* 

```
<<<<<<< HEAD


Create FUNCTION dbo.GetDepartmentProjectCosts(@Dno INT)
RETURNS @ProjectCost Table(
	Pname varchar(15),
	Pnumber INt,
	Plocation varchar(20),
	dnum int,
	budget DECIMAL(18,2),
	totalbudjet DECIMAL(18,2)
)AS
BEGIN
	----variaveis control do cursir
	DECLARE @CurrentPnumber INT;
	DECLARE @CurrentPname varchar(15);
	DECLARE @Plocation varchar(20);
	DECLARE @Dnum int;
	DECLARE @budjet DECIMAL (18,2);
	DECLARE @totalBujet DECIMAL (18,2) = 0.00; --incici

	--selecionar os projetos do departamento
	DECLARE ProjectCursor CURSOR FOR
		SELECT Pname,Pnumber,Plocation,Dnum
		FROM PROJECT
		Where Dnum = @Dno
		Order By Pnumber;

	--abre o cursor
	OPEN ProjectCursor
	--Busca primeiro projeto
	FETCH NEXT FROM ProjectCursor INTO @CurrentPname,@CurrentPnumber,@Plocation,@Dnum;

	--2 loop do cursor
	WHILE @@FETCH_STATUS = 0 
	BEGIN
	--calcula o custo mensa d mao de obra
		SELECT @budjet = ISNULL(SUM( E.Salary / (52 * 40.) * W.Hours * 4),0.00)
		From WORKS_ON W
		Join Employee E ON W.Essn = E.Ssn
		Where W.Pno = @CurrentPnumber;

		--atalizaa o custo acomulado
		SET @totalbujet = @totalbujet + @budjet;

		--insira o registo na tabela de retorno
		INSERT INTO @ProjectCost (Pname,Pnumber,Plocation,Dnum,budget,totalbudjet)
		VALUES
		(@CurrentPname,@CurrentPnumber,@Plocation,@Dnum,@budjet,@totalBujet);

		FETCH NEXT FROM ProjectCursor INTO @CurrentPname,@CurrentPnumber,@Plocation,@Dnum;
	END

	Close ProjectCursor;
	DEALLOCATE ProjectCursor;
	return;
END
GO


=======
... Write here your answer ...
>>>>>>> b0e8178ff6af75f2b7b6b4be88b312acc9f555f2
```

### *h)* 

```
TRIGGER "AFTER DELETE "
--Criar trigger afeter delete
CREATE TRIGGER trg_Department_AfterDelete
ON DEPARTMENT AFTER DELETE
As
BEGIN
	SET NOCOUNT ON;

	--verificar e criar tabela destino

	IF NOT EXISTS(Select * from INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'departament_deleted')

	BEGIN
	--criar tabela
	Select * INTO dbo.department_deleted FROM DEPARTMENT where 1 = 0 ;
	End


	-- coloca os registos
	INSERT INTO dbo.department_deleted(Dname,Dnumber,Mgr_ssn,Mgr_start_date)
	SELECT Dname,Dnumber,Mgr_ssn,Mgr_start_date
	From deleted;
END
GO
	

TRIGER "INSTEAD OF DELETE"

CREATE TRIGGER trg_Department_InsteadOfDelete
ON DEPARTMENT
INSTEAD OF DELETE
AS
BEgin

	SET NOCOUNT ON

	IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'department_deleted')

	BEGIN
		SELECT *INTO dbo.department_deleted FROM DEPARTMENT WHERE 1 = 0
	END

	INSERT INTO dbo.department_deleted (Dname,Dnumber,Mgr_ssn,Mgr_start_date)
	SELECT Dname,Dnumber,Mgr_ssn,Mgr_start_date
	FROM deleted

	DELETE D FROM DEPARTMENT D INNER JOIN deleted del ON D.Dnumber = del.Dnumber

END
GO

CONCLUINDO:
O AFTER DELETE é um trigger de reacao.Ele espera que o comando de DELETE seja completado e tenta aquivar os dados na tabela department_deleted depois disso .Sua vantagem principal é a seguranca transcional.Se a logica de arquivamento falhar,o SQL Server automaticamente faz um rollback e desfaz a exclusao da tabela principal DEPARMENT, grantido que nenhum dado seja perdido.A dewsvantegme é que ao fazer a exclusao primeiro,pode haver um pequene desprdicio de esforco se for necessario desfazer o trabalho
Por outro lado o INSTEAD OF DELED é um trigger de substicuicao que lhe dá controle total.
Quando alguem tenta deletar um departamento,o DELETE original é interceptado e nunca é executado.EM vez disso o codigo é acionado salvar os dados na table department_deleted e depois executar o comando DELETE na tabela principal .ESSA abordagem é mais eficionte para aequivamento e oferece flexiblidade


```

### *i)* 

```

Distinções Fundamentais:

Uma UDF existe para calcular um valor ou retornar um conjunto de dados para ser usado dentro de uma consulta, agindo como uma função matemática ou uma subconsulta parametrizada. Por isso, a regra mais crítica é que as UDFs não podem modificar o estado do banco de dados; são restritas a comandos SELECT e não podem usar INSERT, UPDATE, DELETE ou gerenciar transações (COMMIT/ROLLBACK). Uma UDF pode ser chamada diretamente em cláusulas como SELECT, WHERE ou JOIN.

Já uma Stored Procedure existe para executar uma tarefa ou processar dados. As SPs podem modificar o estado do banco de dados e são a única ferramenta para gerenciar explicitamente o fluxo de programação complexo (usando IF/ELSE, WHILE) e as transações. Uma SP é chamada sozinha através do comando EXEC.


Vantagens:
As SPs são superiores quando o objetivo é a segurança e o processamento. Elas permitem a um utilizador executar operações de modificação de dados (como a criação de uma nova conta de funcionário) sem ter permissão direta nas tabelas, garantindo um controlo de permissões robusto. Além disso, por serem pré-compiladas no servidor, as SPs reduzem o tráfego de rede ao executar uma sequência complexa de lógica em apenas uma chamada.

As UDFs, por sua vez, são inestimáveis para a reutilização de lógica de cálculo ou para simplificar consultas. Uma UDF de valor escalar pode encapsular uma fórmula complexa (ex: cálculo de imposto e desconto) e ser integrada em qualquer coluna de um SELECT. Já as Table-Valued Functions (UDFs que retornam tabelas) são excelentes para criar fontes de dados parametrizadas que simplificam JOINs complexos ou filtros em relatórios.

A escolha entre as duas ferramentas deve seguir a regra: Ação (SP) vs. Cálculo/Filtro (UDF).

Utilize uma Stored Procedure quando:

Processar em Lote: Mover milhares de registos de uma tabela de vendas ativa para uma tabela de histórico.

Transações Múltiplas: Criar um novo cliente, o que exige um INSERT na tabela de clientes, outro INSERT na tabela de contactos e um UPDATE no log do sistema.

Controlo Lógico: Implementar um procedimento complexo que verifica se um valor é válido (IF/ELSE) e, se não for, tenta um novo cálculo (WHILE).

Utilize uma UDF quando:

Cálculo Recorrente: Calcular a idade exata de um funcionário com base na data de nascimento (Bdate), sendo que esse valor deve ser incluído em múltiplas consultas.

Filtro Complexo: Criar uma função que aceita um código de projeto e retorna apenas os funcionários que trabalharam mais de 100 horas nesse projeto, para ser usada numa cláusula JOIN.

Formatação: Converter um valor em segundos para um formato de horas, minutos e segundos (hh:mm:ss) para visualização em relatórios.

```
