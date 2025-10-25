use NBA;

create Table Pessoas(
	CC int primary key,
	Nome varchar(20) not null,
	data_nascimento date not null,
	Nacionalidade varchar(20) not null,
	Genero varchar(10) not null check(genero IN ('Masculino','Feminino')),
	Email varchar(20) not null,
	Telefone int not null
);
create Table Equipas(
	ID_Equipas int primary key,
	Nome varchar(20) not null,
	Cidade varchar (20) not null,
	Conferencia Varchar(10) not null,
	ID_Liga int not null,

	FOREIGN KEY (ID_Liga) REferences Ligas(ID_Liga)
);
create Table Jogadores(
	ID_Jogador int Primary key,
	CC int not null,
	Nome_Camisola varchar(10) not null,
	Posicao varchar(10) not null,
	altura Decimal(4,2) not null check(altura >0),
	peso decimal(5,2) not null,
	Numero int not null,
	Mao_Dominante varchar (10),
	ID_Equipa int not null,

	Foreign key (CC) REFERENCES Pessoas(CC),
	Foreign key(ID_Equipa) REFERENCES Equipas(ID_Equipas) 
	
);
create Table Treinadores (
	ID_Treinador int Primary key,
	CC int not null,
	Experiencia_anos int not null,
	Especialidade varchar(20) not null,
	Licenca int not null,

	FOREIGN KEY (CC) REFERENCES Pessoas(CC),

);
create Table Ligas(
	ID_Liga int Primary key,
	Nome varchar(20) not null,
	Pais varchar(20) not null,
	Nivel varchar(10) not null,

	);
create Table Estadios (
	ID_Estadio int Primary key,
	Nome Varchar(20) not null,
	cidade Varchar(20)not null,
	capacidade Int not null,
	Morada Varchar(20)not null,
	ID_Equipa int not null,

	Foreign key (ID_Equipa) REFERENCES Equipas(ID_Equipas),


);
create Table Temporada (
	ID_Temporada int Primary key,
	Ano_Inicio int not null,
	Ano_Fim int not null,
	ID_Liga int not null,
	Campeao varchar(20),---POSSIVEL ALTERACAO PARA ID_EQUIPA_CAMPEAO  PARA OBTER OS DADOS DA EQUIPA CAMPEAO
	Foreign key (ID_Liga) References Ligas(ID_Liga)
);
