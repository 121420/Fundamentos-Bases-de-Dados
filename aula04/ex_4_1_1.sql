CREATE TABLE TipoVeiculo (
	Codigo INT NOT NULL PRIMARY KEY,
	DESIGNACAO VARCHAR(50) NOT NULL,
	Arcondicionado BIT NOT NULL,

);

CREATE TABLE Veiculo (
	Matricula CHAR(8) NOT NULL PRIMARY KEY,
	Marca VARCHAR(50) NOT NULL,
	Ano INT NOT NULL,
	Codigo INT FOREIGN KEY REFERENCES TipoVeiculo(Codigo)

	UNIQUE(Matricula),
);

CREATE TABLE Similaridade (
	Tipo_Veiculo_Codigo_A INT NOT NULL FOREIGN KEY REFERENCES TipoVeiculo(Codigo), 
	Tipo_Veiculo_Codigo_B INT NOT NULL FOREIGN KEY REFERENCES TipoVeiculo(Codigo),
	PRIMARY KEY(Tipo_Veiculo_Codigo_A, Tipo_Veiculo_Codigo_B),
);

CREATE TABLE Ligeiro (
	Tipo_Veiculo_Codigo INT NOT NULL FOREIGN KEY REFERENCES TipoVeiculo(Codigo),
	PORTAS INT NOT NULL,
	Numero_Lugares INT NOT NULL,
	Combustivel VARCHAR(50) NOT NULL,
);

CREATE TABLE Pesado (
	Tipo_Veiculo_Codigo INT NOT NULL FOREIGN KEY REFERENCES TipoVeiculo(Codigo),
	Peso INT NOT NULL,
	Passageiros INT NOT NULL,
);

CREATE TABLE Balcao (
	Numero INT NOT NULL PRIMARY KEY,
	Nome VARCHAR(250) NOT NULL,
	Endereco VARCHAR(2000) NOT NULL,

	UNIQUE(Endereco),
);

CREATE TABLE Cliente (
	NIF INT NOT NULL PRIMARY KEY,
	Num_Carta INT NOT NULL,
	Nome VARCHAR(250) NOT NULL,
	Endereco VARCHAR(2000) NOT NULL,

	UNIQUE(Num_Carta),
);

CREATE TABLE Aluguer (
	Numero INT NOT NULL PRIMARY KEY,
	Data DATE NOT NULL,
	Duracao INT NOT NULL,
	NIF_Cliente INT NOT NULL FOREIGN KEY REFERENCES Cliente(NIF),
	Matricula_Veiculo CHAR(8) NOT NULL FOREIGN KEY REFERENCES Veiculo(Matricula),
	Numero_Balcao INT NOT NULL FOREIGN KEY REFERENCES Balcao(Numero),
);





