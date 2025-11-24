CREATE TABLE Employee (
    Fname        VARCHAR(30) NOT NULL,
    Minit        CHAR(1),
    Lname        VARCHAR(30) NOT NULL,
    Ssn          CHAR(9)     NOT NULL PRIMARY KEY,
    Bdate        DATE,
    Address      VARCHAR(100),
    Sex          CHAR(1) CHECK (Sex IN ('M','F')),
    Salary       DECIMAL(10,2),
    Super_ssn    CHAR(9) NULL,
    Dno          INT NOT NULL,

    FOREIGN KEY (Super_ssn) REFERENCES Employee(Ssn)
);

CREATE TABLE Department (
    Dname           VARCHAR(40) NOT NULL,
    Dnumber         INT NOT NULL PRIMARY KEY,
    Mgr_ssn         CHAR(9),
    Mgr_start_date  DATE,

    FOREIGN KEY (Mgr_ssn) REFERENCES Employee(Ssn)
);

CREATE TABLE Dept_location (
    Dnumber     INT NOT NULL,
    Dlocation   VARCHAR(40) NOT NULL,
    
    PRIMARY KEY (Dnumber, Dlocation),

    FOREIGN KEY (Dnumber) REFERENCES Department(Dnumber)
);

CREATE TABLE Project (
    Pname     VARCHAR(50) NOT NULL,
    Pnumber   INT NOT NULL PRIMARY KEY,
    Plocation VARCHAR(50),
    Dnum      INT NOT NULL,

    FOREIGN KEY (Dnum) REFERENCES Department(Dnumber)
);

CREATE TABLE Works_on (
    Essn   CHAR(9) NOT NULL,
    Pno    INT NOT NULL,
    Hours  DECIMAL(4,1),

    PRIMARY KEY (Essn, Pno),

    FOREIGN KEY (Essn) REFERENCES Employee(Ssn),
    FOREIGN KEY (Pno)  REFERENCES Project(Pnumber)
);


CREATE TABLE Dependent (
    Essn            CHAR(9) NOT NULL,
    Dependent_name  VARCHAR(40) NOT NULL,
    Sex             CHAR(1) CHECK (Sex IN ('M','F')),
    Bdate           DATE,
    Relationship    VARCHAR(40),

    PRIMARY KEY (Essn, Dependent_name),

    FOREIGN KEY (Essn) REFERENCES Employee(Ssn)
);


