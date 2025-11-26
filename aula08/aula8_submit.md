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

```

### *g)* 

```


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


```

### *h)* 

```
... Write here your answer ...
```

### *i)* 

```
... Write here your answer ...
```
