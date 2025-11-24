-------------------------------------------
-- PASSO A: Criar a base de dados
-------------------------------------------
IF DB_ID('Company') IS NULL
    CREATE DATABASE Company;
GO

USE Company;
GO

-------------------------------------------
-- PASSO B: Criar tabelas sem conflitos
-------------------------------------------

-- 1) Department (sem FK para manager)
DROP TABLE IF EXISTS department;

CREATE TABLE department (
    Dname NVARCHAR(100) NOT NULL,
    Dnumber INT PRIMARY KEY,
    Mgr_ssn CHAR(20) NULL,
    Mgr_start_date DATE NULL
);
GO

-- 2) Employee
DROP TABLE IF EXISTS employee;

CREATE TABLE employee (
    Fname NVARCHAR(50) NOT NULL,
    Minit CHAR(1),
    Lname NVARCHAR(50) NOT NULL,
    Ssn CHAR(20) PRIMARY KEY,
    Bdate DATE,
    Address NVARCHAR(200),
    Sex CHAR(1),
    Salary DECIMAL(10,2),
    Super_ssn CHAR(20),
    Dno INT,
    FOREIGN KEY (Dno) REFERENCES department(Dnumber)
);
GO

-- 3) Project
DROP TABLE IF EXISTS project;

CREATE TABLE project (
    Pname NVARCHAR(100),
    Pnumber INT PRIMARY KEY,
    Plocation NVARCHAR(100),
    Dnum INT,
    FOREIGN KEY (Dnum) REFERENCES department(Dnumber)
);
GO

-- 4) Works_on
DROP TABLE IF EXISTS works_on;

CREATE TABLE works_on (
    Essn CHAR(20),
    Pno INT,
    Hours DECIMAL(6,2),
    PRIMARY KEY (Essn, Pno),
    FOREIGN KEY (Essn) REFERENCES employee(Ssn),
    FOREIGN KEY (Pno) REFERENCES project(Pnumber)
);
GO

-- 5) Dependent
DROP TABLE IF EXISTS dependent;

CREATE TABLE dependent (
    Essn CHAR(20),
    Dependent_name NVARCHAR(100),
    Sex CHAR(1),
    Bdate DATE,
    Relationship NVARCHAR(50),
    PRIMARY KEY (Essn, Dependent_name),
    FOREIGN KEY (Essn) REFERENCES employee(Ssn)
);
GO

-- 6) Dept_Location
DROP TABLE IF EXISTS dept_location;

CREATE TABLE dept_location (
    Dnumber INT,
    Dlocation NVARCHAR(100),
    PRIMARY KEY (Dnumber, Dlocation),
    FOREIGN KEY (Dnumber) REFERENCES department(Dnumber)
);
GO

-------------------------------------------
-- PASSO C: Inserir dados na ordem correta
-------------------------------------------

-- 1º Departamento (sem gestor ainda!)
INSERT INTO department VALUES
('Investigacao', 1, NULL, '2010-08-02'),
('Comercial', 2, NULL, '2013-05-16'),
('Logistica', 3, NULL, '2013-05-16'),
('Recursos Humanos', 4, NULL, '2014-04-02'),
('Desporto', 5, NULL, NULL);

-- 2º Employees
INSERT INTO employee VALUES
('Paula','A','Sousa','183623612','2001-08-11','Rua da FRENTE','F',1450,NULL,3),
('Carlos','D','Gomes','21312332','2000-01-01','Rua XPTO','M',1200,NULL,1),
('Juliana','A','Amaral','321233765','1980-08-11','Rua BZZZZ','F',1350,NULL,3),
('Maria','I','Pereira','342343434','2001-05-01','Rua JANOTA','F',1250,'21312332',2),
('Joao','G','Costa','41124234','2001-01-01','Rua YGZ','M',1300,'21312332',2),
('Ana','L','Silva','12652121','1990-03-03','Rua ZIG ZAG','F',1400,'21312332',2);

-- 3º Atualizar Gestores (agora que os employees existem)
UPDATE department SET Mgr_ssn='21312332' WHERE Dnumber=1;
UPDATE department SET Mgr_ssn='321233765' WHERE Dnumber=2;
UPDATE department SET Mgr_ssn='41124234'  WHERE Dnumber=3;
UPDATE department SET Mgr_ssn='12652121'  WHERE Dnumber=4;

-- 4º Dependentes
INSERT INTO dependent VALUES
('21312332','Joana Costa','F','2008-04-01','Filho'),
('21312332','Maria Costa','F','1990-10-05','Neto'),
('21312332','Rui Costa','M','2000-08-04','Neto'),
('321233765','Filho Lindo','M','2001-02-22','Filho'),
('342343434','Rosa Lima','F','2006-03-11','Filho'),
('41124234','Ana Sousa','F','2007-04-13','Neto'),
('41124234','Gaspar Pinto','M','2006-02-08','Sobrinho');

-- 5º Dept Locations
INSERT INTO dept_location VALUES
(2,'Aveiro'),
(3,'Coimbra');

-- 6º Projects
INSERT INTO project VALUES
('Aveiro Digital',1,'Aveiro',3),
('BD Open Day',2,'Espinho',2),
('Dicoogle',3,'Aveiro',3),
('GOPACS',4,'Aveiro',3);

-- 7º Works_on
INSERT INTO works_on VALUES
('183623612',1,20),
('183623612',3,10),
('21312332',1,20),
('321233765',1,25),
('342343434',1,20),
('342343434',4,25),
('41124234',2,20),
('41124234',3,30);

-------------------------------------------
-- PASSO D: Adicionar FK do gestor
-------------------------------------------
ALTER TABLE department
ADD CONSTRAINT FK_department_manager FOREIGN KEY (Mgr_ssn) REFERENCES employee(Ssn);
GO
