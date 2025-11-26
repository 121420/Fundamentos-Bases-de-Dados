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