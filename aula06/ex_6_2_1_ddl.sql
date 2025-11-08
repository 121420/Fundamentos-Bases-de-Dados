CREATE DATABASE Empresa;
GO
USE Empresa;

CREATE DATABASE Empresa;
GO
USE Empresa;
GO

-- Tabelas principais
CREATE TABLE department (
    Dname VARCHAR(50) NOT NULL,
    Dnumber INT PRIMARY KEY,
    Mgr_ssn CHAR(9) NULL,
    Mgr_start_date DATE NULL
);

CREATE TABLE employee (
    Fname VARCHAR(50) NOT NULL,
    Minit CHAR(1),
    Lname VARCHAR(50) NOT NULL,
    Ssn CHAR(9) PRIMARY KEY,
    Bdate DATE,
    Address VARCHAR(100),
    Sex CHAR(1) CHECK (Sex IN ('M','F')),
    Salary DECIMAL(8,2),
    Super_ssn CHAR(9) NULL,
    Dno INT,
    FOREIGN KEY (Super_ssn) REFERENCES employee(Ssn),
    FOREIGN KEY (Dno) REFERENCES department(Dnumber)
);

CREATE TABLE dependent (
    Essn CHAR(9),
    Dependent_name VARCHAR(50),
    Sex CHAR(1),
    Bdate DATE,
    Relationship VARCHAR(25),
    PRIMARY KEY (Essn, Dependent_name),
    FOREIGN KEY (Essn) REFERENCES employee(Ssn)
);

CREATE TABLE dept_location (
    Dnumber INT,
    Dlocation VARCHAR(50),
    PRIMARY KEY (Dnumber, Dlocation),
    FOREIGN KEY (Dnumber) REFERENCES department(Dnumber)
);

CREATE TABLE project (
    Pname VARCHAR(50),
    Pnumber INT PRIMARY KEY,
    Plocation VARCHAR(50),
    Dnum INT,
    FOREIGN KEY (Dnum) REFERENCES department(Dnumber)
);

CREATE TABLE works_on (
    Essn CHAR(9),
    Pno INT,
    Hours DECIMAL(5,2),
    PRIMARY KEY (Essn, Pno),
    FOREIGN KEY (Essn) REFERENCES employee(Ssn),
    FOREIGN KEY (Pno) REFERENCES project(Pnumber)
);