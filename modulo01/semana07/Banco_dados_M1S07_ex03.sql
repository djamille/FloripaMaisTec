--Comando para criação do banco de dados
CREATE DATABASE bd_m1s07_ex2;

--Comandos para criação das tabelas ALUNO, DISCIPLINA e PROFESSOR
CREATE TABLE aluno(
id_aluno INT PRIMARY KEY IDENTITY(1,1),
nome_aluno VARCHAR(100) NOT NULL UNIQUE,
endereco VARCHAR(100) NOT NULL,
idade INT NOT NULL
);

CREATE TABLE disciplina(
id_disc INT PRIMARY KEY IDENTITY(1,1),
nome_disc VARCHAR(100) NOT NULL UNIQUE,
carga_hor INT NOT NULL
);

CREATE TABLE professor(
id_prof INT PRIMARY KEY IDENTITY(1,1),
nome_prof VARCHAR(100) NOT NULL UNIQUE,
graduacao VARCHAR(100) NOT NULL
);

--Inserindo dados na tabela ALUNO uma linha por vez
INSERT INTO aluno (nome_aluno, endereco, idade) VALUES ('José Pereira da SIlva', 'Av. Conde da Boa Vista, 100, Recife-PE', 25);
--Inserindo dados na tabela ALUNO quatro linhas por vez
INSERT INTO aluno (nome_aluno, endereco, idade) VALUES ('Maria Joaquina dos Anjos', 'Av. Norte, 250, Recife-PE', 23), ('Luiz Ricardo Soares', 'Av. Transamazônica, 1012, Recife-PE', 26), ('Daniela Cristina de Souza', 'Av. Presidente Kennedy, 456, Olinda-PE', 25), ('Rodrigo dos Santos Silva', 'Rua Venezuela, 47, Recife-PE', 22);

--Inserindo dados na tabela DISCIPLINA uma linha por vez
INSERT INTO disciplina (nome_disc, carga_hor) VALUES ('Metodologia Científica', 40);
--Inserindo dados na tabela DISCIPLINA duas linhas por vez
INSERT INTO disciplina (nome_disc, carga_hor) VALUES ('Introdução a Programação', 80), ('Banco de Dados', 80);

--Inserindo dados na tabela PROFESSOR uma linha por vez
INSERT INTO professor (nome_prof, graduacao) VALUES ('Ana Maria Tavares', 'Licenciaturas em Letras');
--Inserindo dados na tabela PROFESSOR duas linhas por vez
INSERT INTO professor (nome_prof, graduacao) VALUES ('Fernando Soares Araújo', 'Engenharia da Computação'), ('Helena Maria Bezerra', 'Sistemas da Iinformação');
