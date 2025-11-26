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