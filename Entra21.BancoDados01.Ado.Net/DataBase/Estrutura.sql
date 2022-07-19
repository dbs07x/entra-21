﻿CREATE TABLE tipos_personagens(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	tipo VARCHAR(20));

CREATE TABLE editoras(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	apelido VARCHAR(20),
	nome VARCHAR(50),
	faturamento DECIMAL(13,2),
	data_criacao DATETIME2);

CREATE TABLE personagens(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_editora INTEGER,
	id_tipo_personagem INTEGER,

	nome VARCHAR(50),

	FOREIGN KEY(id_editora) REFERENCES editoras(id),
	FOREIGN KEY(id_tipo_personagem) REFERENCES tipos_personagens(id));

SELECT * FROM tipos_personagens

--INSERT INTO editoras (nome, apelido, data_criacao, faturamento) VALUES
--('DC', 'DC Comics', '1939-01-20', 2727000000.00),
--('Marvel', 'Marvel Comics', '1939-01-01', 3200000000.00),
--('The boys', 'The Boys Comics', '2006-01-01', 1000000000.00);
--SELECT * FROM editoras;