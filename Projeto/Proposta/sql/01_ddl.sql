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

CREATE TABLE Jogo (
	ID_Jogo INT PRIMARY KEY,
	dataHora_jogo DATETIME NOT NULL,
	ID_estadio INT NOT NULL,
	ID_equipa_Casa INT NOT NULL,
	ID_equipa_Fora INT NOT NULL,
	pontos_casa INT,
	pontos_fora INT,
	fase VARCHAR(20),
	ID_temporada INT NOT NULL,
	FOREIGN KEY (ID_estadio) REFERENCES Estadios(ID_Estadio),
	FOREIGN KEY (ID_equipa_Casa) REFERENCES Equipas(ID_Equipas),
	FOREIGN KEY (ID_equipa_Fora) REFERENCES Equipas(ID_Equipas),
	FOREIGN KEY (ID_temporada) REFERENCES Temporada(ID_Temporada)
);

CREATE TABLE Estatistica_Jogador_Jogo (
	ID_jogador INT NOT NULL,
	ID_Jogo INT NOT NULL,
	minutos INT,
	pontos INT,
	assistencias INT,
	ressaltos INT,
	roubos INT,
	blocos INT,
	faltas INT,
	PRIMARY KEY (ID_jogador, ID_Jogo),
	FOREIGN KEY (ID_jogador) REFERENCES Jogadores(ID_Jogador),
	FOREIGN KEY (ID_Jogo) REFERENCES Jogo(ID_Jogo)
);

CREATE TABLE Estatistica_Equipa_Jogo (
	ID_equipa INT NOT NULL,
	ID_Jogo INT NOT NULL,
	pontos_totais INT,
	assistencias_totais INT,
	ressaltos_totais INT,
	faltas_totais INT,
	percentagem_lancamentos DECIMAL(5,2),
	PRIMARY KEY (ID_equipa, ID_Jogo),
	FOREIGN KEY (ID_equipa) REFERENCES Equipas(ID_Equipas),
	FOREIGN KEY (ID_Jogo) REFERENCES Jogo(ID_Jogo)
);

CREATE TABLE Contrato (
	ID_contrato INT PRIMARY KEY,
	data_inicio DATE NOT NULL,
	data_fim DATE NOT NULL,
	salario_total DECIMAL(10,2) NOT NULL,
	clausula_rescisao DECIMAL(10,2),
	bonus_objetivos DECIMAL(10,2),
	ID_equipa INT NOT NULL,
	CC INT NOT NULL,
	FOREIGN KEY (ID_equipa) REFERENCES Equipas(ID_Equipas),
	FOREIGN KEY (CC) REFERENCES Pessoas(CC)
);

CREATE TABLE Contrato_Jogador (
	ID_contrato INT PRIMARY KEY,
	ID_jogador INT NOT NULL,
	ID_equipa INT NOT NULL,
	FOREIGN KEY (ID_contrato) REFERENCES Contrato(ID_contrato),
	FOREIGN KEY (ID_jogador) REFERENCES Jogadores(ID_Jogador),
	FOREIGN KEY (ID_equipa) REFERENCES Equipas(ID_Equipas)
);

CREATE TABLE Contrato_Treinador (
	ID_contrato INT PRIMARY KEY,
	ID_treinador INT NOT NULL,
	ID_equipa INT NOT NULL,
	cargo VARCHAR(20),
	FOREIGN KEY (ID_contrato) REFERENCES Contrato(ID_contrato),
	FOREIGN KEY (ID_treinador) REFERENCES Treinadores(ID_Treinador),
	FOREIGN KEY (ID_equipa) REFERENCES Equipas(ID_Equipas)
);

CREATE TABLE Bilhete (
	ID_bilhete INT PRIMARY KEY,
	ID_estadio INT NOT NULL,
	ID_Jogo INT NOT NULL,
	setor VARCHAR(10),
	lugar VARCHAR(10),
	preco DECIMAL(8,2),
	vendido BIT DEFAULT 0,
	CC INT,
	FOREIGN KEY (ID_estadio) REFERENCES Estadios(ID_Estadio),
	FOREIGN KEY (ID_Jogo) REFERENCES Jogo(ID_Jogo),
	FOREIGN KEY (CC) REFERENCES Pessoas(CC)
);