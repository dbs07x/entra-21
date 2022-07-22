﻿CREATE TABLE unidades_federativas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	nome VARCHAR(100),
	sigla VARCHAR(2));

CREATE TABLE cidades(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_unidade_federativa INTEGER,

	nome VARCHAR(100),
	quantidade_habitantes INTEGER,
	data_hora_fundacao DATETIME2,
	pib DECIMAL(16,2)

	FOREIGN KEY(id_unidade_federativa) REFERENCES unidades_federativas(id));

SELECT * FROM cidades, unidades_federativas