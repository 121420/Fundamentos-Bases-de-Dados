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

GO
SELECT * FROM employeeProjects('183623612');