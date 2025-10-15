/*create database GestãoConferências;*/
use GestãoConferências;


create table Pessoa(
	CC int Primary key,
	Nome varchar(30) NOT NULL,
	Morada varchar(30) NOT NULL UNIQUE,
	Email varchar(20) NOT NULL UNIQUE,
	DataNascimento Date,
);

create table Professor(
	ProfessorID int primary key,
	CC int Foreign key References Pessoa(CC),
);
create table Turma(
	IDTurma int primary key,
	Designacao varchar(20),
	Capacidade int NOT NULL,
	Classe varchar(20),
	AnoLetivo int NOT NULL,
	IDProfessor int Foreign key References Professor(ProfessorID),
);
create table Atividades(
	IDAtividade int Primary key,
	Designacao  varchar(20) NOT NULL, 
);

create table Alunos(
	AlunoID int Primary key,
	CC int Foreign key references Pessoa(CC),
	IDTrma int Foreign  key references Turma(IDTurma),
	IDAtividade int Foreign key references Atividades(IDAtividade)
);
create table Encarregado(
	IDEncarregado int primary key ,
	CC int Foreign key references Pessoa(CC),
	IDAluno int Foreign key references Alunos(AlunoID),
);
create table PessoaAutorizada(
	IDPessoaAutorizada int Primary key,
	CC int foreign key references Pessoa(CC),
	IDAluno int foreign key references Alunos(AlunoID),
);