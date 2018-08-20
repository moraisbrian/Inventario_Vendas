CREATE DATABASE BD_Locacao;
GO
USE BD_Locacao;

CREATE TABLE TB_Filmes(
Cod int,
Titulo varchar(20),
Observacoes varchar(30),
TipoDeMidia varchar(10),
qtd int,
CONSTRAINT PK_TB_Filmes PRIMARY KEY (Cod)
);

CREATE TABLE TB_Login(
Usuario varchar(20),
Senha varchar(30),
NivelAcesso varchar(10),
CONSTRAINT PK_TB_Login PRIMARY KEY (Usuario, senha)
);

CREATE TABLE TB_Clientes(
Cod int,
Nome varchar(30)
CONSTRAINT PK_TB_Clientes PRIMARY KEY (Cod)
);

CREATE TABLE TB_Locacao(
Cod int identity,
CodCliente int,
DataLocacao date default getdate(),
CONSTRAINT PK_TB_Locacao PRIMARY KEY (Cod),
CONSTRAINT FK_TB_Clientes FOREIGN KEY (CodCliente)
REFERENCES TB_Clientes(Cod)
);

CREATE TABLE TB_Locacao_Filme(
Cod int identity,
CodLocacao int,
CodFilme int,
CONSTRAINT PK_TB_Locacao_Filme PRIMARY KEY (Cod),
CONSTRAINT FK_TB_Locacao FOREIGN KEY (CodLocacao)
REFERENCES TB_Locacao (Cod)
);

INSERT INTO TB_Login (Usuario, Senha, NivelAcesso) VALUES ('admin', '123', 'admin');
INSERT INTO TB_Login (Usuario, Senha, NivelAcesso) VALUES ('usuario', '456', 'user');
INSERT INTO TB_Clientes (Cod, Nome) VALUES (1, 'Fulano');


select TB_Locacao.Cod, 
	   TB_Locacao.CodCliente, 
	   TB_Locacao.DataLocacao,
       TB_Locacao_Filme.CodFilme, 
	   TB_Locacao_Filme.Cod
from TB_Locacao
inner join TB_Locacao_Filme
on TB_Locacao.Cod = TB_Locacao_Filme.CodLocacao
inner join TB_Clientes
on TB_Locacao.CodCliente = TB_Clientes.Cod;

