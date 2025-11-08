CREATE DATABASE Prescricao;;
GO
USE Prescricao;

CREATE TABLE medico (
    numSNS INT PRIMARY KEY,
    nome VARCHAR(100),
    especialidade VARCHAR(100)
);

CREATE TABLE paciente (
    numUtente INT PRIMARY KEY,
    nome VARCHAR(100),
    dataNasc DATE,
    endereco VARCHAR(255)
);

CREATE TABLE farmacia (
    nome VARCHAR(100) PRIMARY KEY,
    telefone VARCHAR(20),
    endereco VARCHAR(255)
);

CREATE TABLE farmaceutica (
    numReg INT PRIMARY KEY,
    nome VARCHAR(100),
    endereco VARCHAR(255)
);

CREATE TABLE farmaco (
    numReg INT,
    nome VARCHAR(100),
    formula VARCHAR(50),
    PRIMARY KEY (numReg, nome),
    FOREIGN KEY (numReg) REFERENCES farmaceutica(numReg)
);

CREATE TABLE prescricao (
    numPresc INT PRIMARY KEY,
    numUtente INT,
    numMedico INT,
    farmacia VARCHAR(100),
    data DATE,
    FOREIGN KEY (numUtente) REFERENCES paciente(numUtente),
    FOREIGN KEY (numMedico) REFERENCES medico(numSNS),
    FOREIGN KEY (farmacia) REFERENCES farmacia(nome)
);

CREATE TABLE presc_farmaco (
    numPresc INT,
    numReg INT,
    nomeFarmaco VARCHAR(100),
    PRIMARY KEY (numPresc, numReg, nomeFarmaco),
    FOREIGN KEY (numPresc) REFERENCES prescricao(numPresc),
    FOREIGN KEY (numReg, nomeFarmaco) REFERENCES farmaco(numReg, nome)
);
