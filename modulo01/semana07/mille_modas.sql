--Comando criação banco de dados da loja MILLE MODAS
CREATE DATABASE mille_modas;

USE mille_modas;

--Comando para criar tabelas
CREATE TABLE produto(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100) NOT NULL UNIQUE,
tamanho CHAR(3) NOT NULL,
valor DECIMAL(5,2) NOT NULL CHECK(valor > 50.00)
);

CREATE TABLE pagamento(
id INT PRIMARY KEY IDENTITY(1,1),
tipo VARCHAR(100) NOT NULL UNIQUE,
parcelas CHAR(3) NOT NULL
);

CREATE TABLE estado(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE cidade(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100) NOT NULL UNIQUE,
estado_id INT NOT NULL,
CONSTRAINT FK_cidade_estado FOREIGN KEY (estado_id) REFERENCES estado (id)
);

CREATE TABLE cliente(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100) NOT NULL UNIQUE,
CPF VARCHAR(14) NOT NULL UNIQUE,
endereço VARCHAR(100) NOT NULL,
telefone INT NOT NULL,
cidade_id INT NOT NULL,
CONSTRAINT FK_cliente_cidade FOREIGN KEY (cidade_id) REFERENCES cidade (id)
);

CREATE TABLE pedido(
id INT PRIMARY KEY IDENTITY(1,1),
data_pedido DATETIME NOT NULL,
pagamento_id INT NOT NULL,
cliente_id INT NOT NULL,
CONSTRAINT FK_pedido_pagamento FOREIGN KEY (pagamento_id) REFERENCES pagamento (id),
CONSTRAINT FK_pedido_cliente FOREIGN KEY (cliente_id) REFERENCES cliente (id)
);

CREATE TABLE itens_pedido(
id INT PRIMARY KEY IDENTITY(1,1),
quantidade INT NOT NULL,
produto_id INT NOT NULL,
pedido_id INT NOT NULL,
CONSTRAINT FK_itens_produto FOREIGN KEY (produto_id) REFERENCES produto (id),
CONSTRAINT FK_itens_pedido FOREIGN KEY (pedido_id) REFERENCES pedido (id)
);

