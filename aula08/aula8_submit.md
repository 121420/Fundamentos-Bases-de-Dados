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
```

### *d)* 

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
