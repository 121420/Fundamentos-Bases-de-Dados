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