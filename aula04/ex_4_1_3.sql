/*create database gestaoStock;*/
use gestaoStock;

create table TipoFornecedor(
	CodigoTipo int Primary Key,
	Designacao VARCHAR(30) NOT NULL
);
create table Fornecedor (
	Nif		INT,
	Nome	VARCHAR(20) NOT NULL,
	Fax		INT Unique,
	Endereco VARCHAR(40) NOT NULL,
	CondicaoPagamento VarcHar(40) NOT NULL,
	CodigoTipo int  NOT NULL,

	PRIMARY KEY(Nif),
	FOREIGN KEY(CodigoTipo) REFERENCES TipoFornecedor(CodigoTipo),
);
create table Produto(
	IDProduto Int Primary Key,
	Nome VARCHAR(20) NOT NULL,
	UnidadesEmArmazenamento Int NOT NULL,
	TaxaIva INT,
	Preco INT NOT NULL,
	NifFornecedor int NOT NULL FOREIGN KEY References Fornecedor(Nif),

);

create table Encomenda(
	IDEncomenda INT PRIMARY kEY,
	IDProduto int NOT NULL,
	Nome VARCHAR(20) NOT NULL ,
	DataEcomenda Date,
	
	unique(Nome),
	FOREIGN KEY(IDProduto) References Produto(IDProduto)
);

Create table ItemEncomenda(
	IDEncomenda int NOT NULL  FOREIGN Key References Encomenda(IDEncomenda),
	IDProduto int FOREIGN Key References Produto(IDProduto),
	PrecoUnitario int not null, 
	Quantidade int not null
);


