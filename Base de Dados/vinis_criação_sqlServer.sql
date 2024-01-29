-- Use master to ensure the database is created in the correct location
USE master;

-- fix Cannot drop database "VinilDB" because it is currently in use.
ALTER DATABASE VinilDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

-- Drop the database if it already exists
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'VinilDB')
    DROP DATABASE VinilDB;

-- Create the new database
CREATE DATABASE VinilDB;

-- Switch to the new database
USE VinilDB;

-- Table Cliente
CREATE TABLE Cliente (
    idCliente INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Email VARCHAR(45) NOT NULL,
    Pass VARCHAR(1024) NOT NULL,
    Dinheiro FLOAT NOT NULL    
);


-- Table Leilao
CREATE TABLE Leilao (
    idLeilao INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Estado VARCHAR(45) NOT NULL,
	Comprador INT NULL,
    Valor_base FLOAT NOT NULL,
    Valor_minimo FLOAT NOT NULL,
	TempoCriacao DATETIME NOT NULL,
	Preco_venda FLOAT NOT NULL,
	Vendedor INT NOT NULL,
	CONSTRAINT fk_Leilao_Cliente1 FOREIGN KEY (Vendedor)
		REFERENCES Cliente (idCliente)
);

-- Table Vinil
CREATE TABLE Vinil (
    idVinil INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Artista VARCHAR(45) NULL,
    Album VARCHAR(45) NULL,
    AnoLancamento DATE NULL,
	Condicao_disco INT NULL,
	Condicao_capa INT NULL,
	Categoria VARCHAR(45) NULL,
	Duracao INT NULL,
	Tamanho INT NULL,
	Rotacoes INT NULL,
	Tipo VARCHAR(100) NULL,
	Gravadora VARCHAR(45) NULL,
    Edicao_especial TINYINT NULL,
	Remasterizado TINYINT NULL,
	Fotos_vinil VARCHAR(1024) NULL,
	Cliente INT NOT NULL,
	Leilao INT NULL,
	CONSTRAINT fk_Vinil_Cliente1 FOREIGN KEY (Cliente)
        REFERENCES Cliente (idCliente),
	CONSTRAINT fk_Vinil_Leilao1 FOREIGN KEY (Leilao)
        REFERENCES Leilao (idLeilao)
);

Use VinilDB;
