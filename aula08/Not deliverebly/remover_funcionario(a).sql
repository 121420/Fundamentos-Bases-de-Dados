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