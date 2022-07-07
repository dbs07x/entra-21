CREATE TABLE champions(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(10),
	descricao VARCHAR(30),
	habilidade_1 VARCHAR(35),
	habilidade_2 VARCHAR(35),
	habilidade_3 VARCHAR(35),
	habilidade_4 VARCHAR(35),
	habilidade_5 VARCHAR(35),
	);

INSERT INTO champions
	(nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES (
	'Katarina',
	'a Lâmina Sinistra',
	'Voracidade',
	'Lâmina Saltitante',
	'Preparação',
	'Shunpo',
	'Lótus da Morte');

INSERT INTO champions
	(nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES (
	'Yasuo',
	'',
	'Estilo do Errante',
	'Tempestade de Aço',
	'Parede de Vento',
	'Espada Ágil',
	'Último Suspiro');

INSERT INTO champions
	(nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES (
	'Master Yi',
	'o Espadachim Wuju',
	'Ataque Duplo',
	'',
	'',
	'',
	'');

INSERT INTO champions
	(nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES (
	'Vayne',
	'a Caçadora Noturna',
	'Caçadora Noturna',
	'Rolamento',
	'Dardos de Prata',
	'Condenar',
	'Hora Final');

INSERT INTO champions
	(nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES (
	'Lee Sin', 
	'O Monge Cego',
	'Agitação',
	'Onda Sônica / Ataque Ressonante',
	'Proteger / Vontade de Ferro',
	'Tempestade / Mutilar',
	'');

INSERT INTO champions
	(nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES (
	'Vi',
	'a Defensora de Piltover',
	'Blindagem',
	'',
	'Pancada Certeira',
	'Força Excessiva',
	'Saque e Enterrada');

INSERT INTO champions
	(nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES (
	'Diana',
	'o Escárnio da Lua',
	'Espada de Prata Lunar',
	'Golpe Crescente',
	'Cascata Lívida',
	'Colapso Minguante',
	'Zênite Lunar');

INSERT INTO champions
	(nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES (
	'Annie',
	'a Criança Sombria',
	'Piromania',
	'Desintegrar',
	'Incinerar',
	'Escudo Fundido',
	'Invocar Tibbers');

INSERT INTO champions
	(nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES (
	'Aatrox',
	'',
	'Poço de Sangue',
	'Voo Sombrio',
	'Sede de Sangue / Preço em Sangue',
	'Lâminas da Aflição',
	'Massacre');

SELECT
	nome AS 'Nome',
	descricao AS 'Descrição',
	habilidade_1 AS 'Habilidade 1',
	habilidade_2 AS 'Habilidade 2',
	habilidade_3 AS 'Habilidade 3',
	habilidade_4 AS 'Habilidade 4',
	habilidade_5 AS 'Habilidade 5'
	FROM champions;

	UPDATE champions SET descricao = 'o Imperdoável' WHERE id = 2;

	UPDATE champions SET descricao = 'a Espada Darkin' WHERE id = 9;

	UPDATE champions SET habilidade_2 = 'Ataque Alpha' WHERE id = 3;

	UPDATE champions SET habilidade_2 = 'Quebra-Cofres' WHERE id = 6;

	UPDATE champions SET habilidade_3 = 'Meditar' WHERE id = 3;

	UPDATE champions SET habilidade_4 = 'Estilo Wuju' WHERE id = 3;

	UPDATE champions SET habilidade_5 = 'Highlander' WHERE id = 3;

	UPDATE champions SET habilidade_5 = 'Furia do Dragão' WHERE id = 5;

	SELECT TOP(10)
	nome AS 'Nome',
	descricao AS 'Descrição',
	habilidade_1 AS 'Habilidade 1',
	habilidade_2 AS 'Habilidade 2',
	habilidade_3 AS 'Habilidade 3',
	habilidade_4 AS 'Habilidade 4',
	habilidade_5 AS 'Habilidade 5'
	FROM champions;