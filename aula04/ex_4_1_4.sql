/*create database PrescricaoEletronica;*/
use PrescricaoEletronica;


create table Medico(
	IDMedico int Primary key,
	Nome varchar(30) NOT NULL,
	Especielidade varchar(30) NOT NULL
);
create table Paciente (
	NUtente INT Primary key,
	Nome varchar(30) NOT NULL,
	Endereco varchar(30) Not NULL,
	DataNascimento Date NOT NULL,
	IDMedico int Foreign key References Medico(IDMedico)
);
create table Prescricao(
	IDPrescricao int Primary key,
	ddata Date NOT NULL,
	DataProcessamento Date NOT NULL ,
	NUtente Int Foreign key References Paciente(NUtente)
)

create table Farmacias(
	NIF int primary key,
	nome varchar(30) NOT NULL,
	endereco varchar(30) NOT NULL UNIQUE,
	Telefone int UNIQUE,
	IDprescricao int Foreign key References Prescricao(IDPrescricao) 
);

create table CompaniaFarmaceutica(
	NRN int Primary key,
	Nome varchar(30) NOT NULL,
	Endereco varchar(30) NOT NULL UNIQUE,
	Telefone Int
);
create table Farmaco(
	Formula int Primary key ,
	NRN int Foreign key References CompaniaFarmaceutica(NRN),
	NIF int Foreign key References Farmacias(NIF),
	NomeComercial varchar(30)

);

