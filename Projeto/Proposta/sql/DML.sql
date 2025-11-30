use p4g4;

/*________Inserts  nas tabelas_________  */
/*NBA TEAMS:
- ATLANTIC: Boston Celtic, Brooklyn Nets, New York Knicks, Philadelphia 76ers, Toronto Raptors

- CENTRAL: Chicago Bulls, Cleveland Cavaliers, Detroit Pistons, Indiana Pacers, Milwaukee Bucks

- SOUTHEAST: Atlanta Hawks, Charlotte Hornets, Miami Heat, Orlando Magic, Washington Wizards

- NORTHWEST: Denver Nuggets, Minnesota Timberwolves, Oklahoma City Thunder, Portland Trail Blazers, Utah Jazz

- PACIFIC: Golden State Warriors, LA Clippers, Los Angeles Lakers, Phoenix Suns, Sacramento Kings

- SOUTHWEST: Dallas Mavericks, Houston Rockets, Memphis Grizzlies, New Orleans Pelicans, San Antônio Spurs


Per Conferences:

- Eastern Conference: Pistons, Cavaliers, Raptors, Hawks, Knicks, 76ers, Heat, Bulls, Bucks, Magic, Celtics, Hornets, Nets, Wizerds, Pacers

- Western Conference: Thunder, Nuggets, Rockets, Lakers, Spurs,Timberwolves, Warriors, Suns, Trail Blazers, Jazz, Grizzlies, Clippers, Mavericks, Kings, Pelicans*/

/*-----Ligas-----*/
INSERT INTO Ligas (ID_Liga, Nome, Pais, Nivel) VALUES
(1, 'NBA', 'EUA', 'Profissional');

/*-----Equipas-----*/
INSERT INTO Equipas (ID_Equipas, Nome, Cidade, Conferencia, ID_Liga) VALUES
(1, 'Boston Celtics', 'Boston', 'Leste', 1),
(2, 'Brooklyn Nets', 'Brooklyn', 'Leste', 1),
(3, 'New York Knicks', 'New York', 'Leste', 1),
(4, 'Philadelphia 76ers', 'Philadelphia', 'Leste', 1),
(5, 'Toronto Raptors', 'Toronto', 'Leste', 1),
(6, 'Chicago Bulls', 'Chicago', 'Leste', 1),
(7, 'Cleveland Cavaliers', 'Cleveland', 'Leste', 1),
(8, 'Detroit Pistons', 'Detroit', 'Leste', 1),
(9, 'Indiana Pacers', 'Indianapolis', 'Leste', 1),
(10, 'Milwaukee Bucks', 'Milwaukee', 'Leste', 1),
(11, 'Atlanta Hawks', 'Atlanta', 'Leste', 1),
(12, 'Charlotte Hornets', 'Charlotte', 'Leste', 1),
(13, 'Miami Heat', 'Miami', 'Leste', 1),
(14, 'Orlando Magic', 'Orlando', 'Leste', 1),
(15, 'Washington Wizards', 'Washington D.C.', 'Leste', 1),
(16, 'Denver Nuggets', 'Denver', 'Oeste', 1),
(17, 'Minnesota Timberwolves', 'Minneapolis', 'Oeste', 1),
(18, 'Oklahoma City Thunder', 'Oklahoma City', 'Oeste', 1),
(19, 'Portland Trail Blazers', 'Portland', 'Oeste', 1),
(20, 'Utah Jazz', 'Salt Lake City', 'Oeste', 1),
(21, 'Golden State Warriors', 'San Francisco', 'Oeste', 1),
(22, 'LA Clippers', 'Los Angeles', 'Oeste', 1),
(23, 'Los Angeles Lakers', 'Los Angeles', 'Oeste', 1),
(24, 'Phoenix Suns', 'Phoenix', 'Oeste', 1),
(25, 'Sacramento Kings', 'Sacramento', 'Oeste', 1),
(26, 'Dallas Mavericks', 'Dallas', 'Oeste', 1),
(27, 'Houston Rockets', 'Houston', 'Oeste', 1),
(28, 'Memphis Grizzlies', 'Memphis', 'Oeste', 1),
(29, 'New Orleans Pelicans', 'New Orleans', 'Oeste', 1),
(30, 'San Antonio Spurs', 'San Antonio', 'Oeste', 1);

/*-----Pessoas-----*/
INSERT INTO Pessoas (CC, Nome, data_nascimento, Nacionalidade, Genero, Email, Telefone) VALUES
('10101010', 'Ana Silva', '1995-05-15', 'Portuguesa', 'Feminino', 'ana.silva@email.pt', '910000001'),
('11211211', 'Bruno Costa', '1988-11-20', 'Portuguesa', 'Masculino', 'bruno.costa@email.pt', '930000002'),
('12321232', 'Carla Mendes', '2001-03-25', 'Brasileira', 'Feminino', 'carla.mendes@email.pt', '960000003'),
('13431343', 'Diogo Pereira', '1976-07-01', 'Portuguesa', 'Masculino', 'diogo.pereira@email.pt', '910000004'),
('14541454', 'Elsa Rodrigues', '1999-01-10', 'Espanhola', 'Feminino', 'elsa.rodrigues@email.pt', '930000005'),
('15651565', 'Filipe Almeida', '1985-09-30', 'Portuguesa', 'Masculino', 'filipe.almeida@email.pt', '960000006'),
('16761676', 'Gabriela Santos', '1993-02-14', 'Angolana', 'Feminino', 'gabriela.santos@email.pt', '910000007'),
('17871787', 'Hugo Martins', '1980-04-05', 'Portuguesa', 'Masculino', 'hugo.martins@email.pt', '930000008'),
('18981898', 'Inês Fernandes', '2003-12-03', 'Moçambicana', 'Feminino', 'ines.fernandes@email.pt', '960000009'),
('19091909', 'João Ribeiro', '1972-06-18', 'Portuguesa', 'Masculino', 'joao.ribeiro@email.pt', '910000010'),
('20102010', 'Laura Gomes', '1990-08-28', 'Portuguesa', 'Feminino', 'laura.gomes@email.pt', '930000011'),
('21212121', 'Miguel Oliveira', '1983-10-12', 'Francesa', 'Masculino', 'miguel.oliveira@email.pt', '960000012'),
('22322232', 'Núria Correia', '1997-04-04', 'Portuguesa', 'Feminino', 'nuria.correia@email.pt', '910000013'),
('23432343', 'Paulo Teixeira', '1979-01-22', 'Portuguesa', 'Masculino', 'paulo.teixeira@email.pt', '930000014'),
('24542454', 'Quitéria Rocha', '1994-06-16', 'Alemã', 'Feminino', 'quiteria.rocha@email.pt', '960000015'),
('25652565', 'Ricardo Soares', '1987-03-08', 'Portuguesa', 'Masculino', 'ricardo.soares@email.pt', '910000016'),
('26762676', 'Sofia Pinto', '2000-09-09', 'Cabo-Verdiana', 'Feminino', 'sofia.pinto@email.pt', '930000017'),
('27872787', 'Tiago Nunes', '1974-11-29', 'Portuguesa', 'Masculino', 'tiago.nunes@email.pt', '960000018'),
('28982898', 'Vera Monteiro', '1982-05-17', 'Ucraniana', 'Feminino', 'vera.monteiro@email.pt', '910000019'),
('29092909', 'Vítor Jorge', '1996-07-27', 'Portuguesa', 'Masculino', 'vitor.jorge@email.pt', '930000020');


/*----Jogador------*/
INSERT INTO Jogadores (ID_Jogador, CC, Nome_Camisola, Posicao, Altura, Peso, Numero, Mao_Dominante, ID_Equipa) VALUES
(1, '10101010', 'A. SILVA', 'Base (PG)', 1.88, 85, 3, 'Direita', 1),
(2, '11211211', 'B. COSTA', 'Extremo (SF)', 2.03, 100, 23, 'Direita', 6),
(3, '12321232', 'C. MENDES', 'Poste (C)', 2.11, 115, 44, 'Esquerda', 13),
(4, '13431343', 'PEREIRA', 'Base (PG)', 1.91, 88, 10, 'Esquerda', 16),
(5, '14541454', 'E. RODS', 'Extremo-Base (SG)', 1.96, 95, 8, 'Direita', 21),
(6, '15651565', 'ALMEIDA', 'Extremo-P. (PF)', 2.06, 108, 34, 'Direita', 26),
(7, '16761676', 'SANTOS', 'Base (PG)', 1.85, 82, 9, 'Direita', 3),
(8, '17871787', 'MARTINS', 'Extremo (SF)', 2.01, 98, 1, 'Esquerda', 10),
(9, '18981898', 'FERNANDES', 'Extremo-P. (PF)', 2.08, 110, 5, 'Direita', 18),
(10, '19091909', 'RIBEIRO', 'Poste (C)', 2.16, 120, 55, 'Direita', 24);
/*
Alter table Treinadores
Alter Column Especialidade varchar(30)

Alter table Treinadores
Alter Column Licensa varchar(20)
*/
INSERT INTO Treinadores (ID_Treinador, CC, Experiencia_anos, Especialidade, Licenca) VALUES
(1, 20102010, 15, 'Defesa Zonal', 'Nivel A'),
(2, 21212121, 8, 'Ataque Rápido', 'Nivel B+'),
(3, 22322232, 22, 'Desenvolvimento Jovem', 'Nivel Pro'),
(4, 23432343, 5, 'Lançamento Exterior', 'Nivel C'),
(5, 24542454, 18, 'Gestão de Jogo', 'Nivel A'),
(6, 25652565, 12, 'Transição Rápida', 'Nivel B'),
(7, 26762676, 3, 'Análise de Vídeo', 'Nivel C+'),
(8, 27872787, 25, 'Poste e Pivôs', 'Nivel Pro'),
(9, 28982898, 9, 'Recrutamento', 'Nivel B'),
(10, 29092909, 14, 'Marcação Individual', 'Nivel A');


/*--Estadios-----*/
/*
Alter Table Estadios
Alter Column Nome VARCHAR (30)
*/
INSERT INTO Estadios (ID_Estadio, Nome, Cidade, Capacidade, Morada, ID_Equipa) VALUES
(1, 'TD Garden', 'Boston', 19580, '100 Legends Way', 1),
(2, 'Barclays Center', 'Brooklyn', 17732, '620 Atlantic Ave', 2),
(3, 'Madison Square Garden', 'New York', 19812, '4 Pennsylvania Plaza', 3),
(4, 'Wells Fargo Center', 'Philadelphia', 20478, '3601 S Broad St', 4),
(5, 'Scotiabank Arena', 'Toronto', 19800, '40 Bay St', 5),
(6, 'United Center', 'Chicago', 20917, '1901 W Madison St', 6),
(7, 'Rocket Mortgage FieldHouse', 'Cleveland', 19432, '1 Center Court', 7),
(8, 'Little Caesars Arena', 'Detroit', 20332, '2645 Woodward Ave', 8),
(9, 'Gainbridge Fieldhouse', 'Indianapolis', 17923, '125 S Pennsylvania St', 9),
(10, 'Fiserv Forum', 'Milwaukee', 17385, '1111 Vel R. Phillips Ave', 10),
(11, 'State Farm Arena', 'Atlanta', 16600, '1 State Farm Dr', 11),
(12, 'Spectrum Center', 'Charlotte', 19077, '333 E Trade St', 12),
(13, 'Kaseya Center', 'Miami', 19600, '601 Biscayne Blvd', 13),
(14, 'Amway Center', 'Orlando', 18846, '400 W Church St', 14),
(15, 'Capital One Arena', 'Washington D.C.', 20356, '601 F St NW', 15),
(16, 'Ball Arena', 'Denver', 19520, '1000 Chopper Cir', 16),
(17, 'Target Center', 'Minneapolis', 18978, '600 N 1st Ave', 17),
(18, 'Paycom Center', 'Oklahoma City', 18203, '100 W Reno Ave', 18),
(19, 'Moda Center', 'Portland', 19393, '1 N Center Ct St', 19),
(20, 'Vivint Arena', 'Salt Lake City', 18306, '301 W S Temple', 20),
(21, 'Chase Center', 'San Francisco', 18064, '3 Warriors Way', 21),
(22, 'Crypto.com Arena', 'Los Angeles', 19060, '1111 S Figueroa St', 22),
(23, 'Crypto.com Arena', 'Los Angeles', 19060, '1111 S Figueroa St', 23),
(24, 'Footprint Center', 'Phoenix', 17071, '201 E Jefferson St', 24),
(25, 'Golden 1 Center', 'Sacramento', 17608, '500 David J Stern Walk', 25),
(26, 'American Airlines Center', 'Dallas', 19200, '2500 Victory Ave', 26),
(27, 'Toyota Center', 'Houston', 18055, '1510 Polk St', 27),
(28, 'FedExForum', 'Memphis', 17794, '191 Beale St', 28),
(29, 'Smoothie King Center', 'New Orleans', 16867, '1501 Dave Dixon Dr', 29),
(30, 'Frost Bank Center', 'San Antonio', 18418, '1 AT&T Center Pkwy', 30);

/*
-------------------
Conferir Resultados
---------------------
Select E.Nome as ESTADIO ,Eq.nome as Equipa from Estadios E
JOIN Equipas Eq ON E.ID_Equipa = Eq.ID_Equipas
---------------------
*/


/*********************
Select * from Contrato
alter table Contrato 
Drop COlumn ID_Equipa
*/

INSERT INTO Contrato (ID_contrato, data_inicio, data_fim, salario_total, clausula_rescisao, bonus_objetivos, CC) VALUES
-- Contratos de Jogadores (ID_Contrato 1 a 10)
(1, '2024-10-01', '2029-09-30', 30000000.00, 1000000.00, 500000.00, 10101010), -- Jogador 1
(2, '2024-10-01', '2028-09-30', 15000000.00, 500000.00, 250000.00, 11211211), -- Jogador 2
(3, '2024-10-01', '2027-09-30', 8000000.00, 250000.00, 100000.00, 12321232), -- Jogador 3
(4, '2024-10-01', '2029-09-30', 22000000.00, 750000.00, 350000.00, 13431343), -- Jogador 4
(5, '2024-10-01', '2028-09-30', 12000000.00, 400000.00, 200000.00, 14541454), -- Jogador 5
(6, '2024-10-01', '2027-09-30', 5000000.00, 100000.00, 50000.00, 15651565), -- Jogador 6
(7, '2024-10-01', '2029-09-30', 25000000.00, 900000.00, 450000.00, 16761676), -- Jogador 7
(8, '2024-10-01', '2028-09-30', 18000000.00, 600000.00, 300000.00, 17871787), -- Jogador 8
(9, '2024-10-01', '2027-09-30', 7000000.00, 200000.00, 80000.00, 18981898), -- Jogador 9
(10, '2024-10-01', '2029-09-30', 10000000.00, 300000.00, 150000.00, 19091909), -- Jogador 10

-- Contratos de Treinadores (ID_Contrato 11 a 20)
(11, '2024-07-01', '2027-06-30', 5000000.00, 0.00, 100000.00, 20102010), -- Treinador 1
(12, '2024-07-01', '2026-06-30', 2500000.00, 0.00, 50000.00, 21212121), -- Treinador 2
(13, '2024-07-01', '2028-06-30', 8000000.00, 0.00, 200000.00, 22322232), -- Treinador 3
(14, '2024-07-01', '2026-06-30', 1500000.00, 0.00, 30000.00, 23432343), -- Treinador 4
(15, '2024-07-01', '2027-06-30', 4000000.00, 0.00, 80000.00, 24542454), -- Treinador 5
(16, '2024-07-01', '2028-06-30', 6000000.00, 0.00, 120000.00, 25652565), -- Treinador 6
(17, '2024-07-01', '2026-06-30', 1000000.00, 0.00, 20000.00, 26762676), -- Treinador 7
(18, '2024-07-01', '2028-06-30', 7500000.00, 0.00, 150000.00, 27872787), -- Treinador 8
(19, '2024-07-01', '2027-06-30', 3500000.00, 0.00, 70000.00, 28982898), -- Treinador 9
(20, '2024-07-01', '2028-06-30', 6500000.00, 0.00, 130000.00, 29092909); -- Treinador 10


/* ----- Contrato_Jogador ----- */
INSERT INTO Contrato_Jogador (ID_contrato, ID_jogador, ID_equipa) VALUES
(1, 1, 1),  -- Jogador 1 (Ana Silva) -> Celtics (1)
(2, 2, 6),  -- Jogador 2 (Bruno Costa) -> Bulls (6)
(3, 3, 13), -- Jogador 3 (Carla Mendes) -> Heat (13)
(4, 4, 16), -- Jogador 4 (Diogo Pereira) -> Nuggets (16)
(5, 5, 21), -- Jogador 5 (Elsa Rodrigues) -> Warriors (21)
(6, 6, 26), -- Jogador 6 (Filipe Almeida) -> Mavericks (26)
(7, 7, 3),  -- Jogador 7 (Gabriela Santos) -> Knicks (3)
(8, 8, 10), -- Jogador 8 (Hugo Martins) -> Bucks (10)
(9, 9, 18), -- Jogador 9 (Inês Fernandes) -> Thunder (18)
(10, 10, 24); -- Jogador 10 (João Ribeiro) -> Suns (24)


/* ----- Contrato_Treinador ----- */
INSERT INTO Contrato_Treinador (ID_contrato, ID_treinador, ID_equipa, cargo) VALUES
(11, 1, 2, 'Treinador Principal'), -- Treinador 1 -> Nets (2)
(12, 2, 4, 'Treinador Adjunto'), -- Treinador 2 -> 76ers (4)
(13, 3, 5, 'Treinador Principal'), -- Treinador 3 -> Raptors (5)
(14, 4, 7, 'Treinador Adjunto'), -- Treinador 4 -> Cavaliers (7)
(15, 5, 8, 'Treinador Principal'), -- Treinador 5 -> Pistons (8)
(16, 6, 9, 'Treinador Adjunto'), -- Treinador 6 -> Pacers (9)
(17, 7, 11, 'Treinador Principal'), -- Treinador 7 -> Hawks (11)
(18, 8, 12, 'Treinador Adjunto'), -- Treinador 8 -> Hornets (12)
(19, 9, 14, 'Treinador Principal'), -- Treinador 9 -> Magic (14)
(20, 10, 15, 'Treinador Adjunto'); -- Treinador 10 -> Wizards (15)



/* ----- Temporada (Com ID_Equipa_Campeao) ----- */
INSERT INTO Temporada (ID_Temporada, Ano_Inicio, Ano_Fim, Nome_Temporada, ID_Liga, ID_Equipa_Campeao) VALUES
(1, 2021, 2022, 'Temporada 2021-2022', 1, 21), -- Golden State Warriors (ID 21)
(2, 2022, 2023, 'Temporada 2022-2023', 1, 16), -- Denver Nuggets (ID 16)
(3, 2023, 2024, 'Temporada 2023-2024', 1, 1), -- Boston Celtics (ID 1)
(4, 2024, 2025, 'Temporada Regular 2024-2025', 1, NULL), -- Em curso (Campeão ainda não definido)
(5, 2025, 2026, 'Próxima Temporada', 1, NULL); -- Futuro (Campeão ainda não definido)

select * from Temporada

select * from Jogo

/* ----- Jogo ----- */
INSERT INTO Jogo (ID_Jogo, dataHora_jogo, ID_estadio, ID_equipa_Casa, ID_equipa_Fora, pontos_casa, pontos_fora, fase, ID_temporada) VALUES
(1, '2023-11-05 19:30:00', 1, 1, 3, 125, 113, 'Regular Season', 3), -- Celtics vs Knicks
(2, '2023-11-06 20:00:00', 21, 21, 23, 134, 145, 'Regular Season', 3), -- Warriors vs Lakers (Vitória Lakers)
(3, '2024-01-20 17:00:00', 16, 16, 26, 115, 112, 'Regular Season', 3), -- Nuggets vs Mavericks
(4, '2024-05-15 21:00:00', 13, 13, 10, 105, 98, 'Playoffs', 3), -- Heat vs Bucks
(5, '2024-06-06 20:30:00', 1, 1, 16, 107, 104, 'Finais', 3); -- Celtics vs Nuggets



/* ----- Estatistica_Equipa_Jogo (10 registos) ----- */
INSERT INTO Estatistica_Equipa_Jogo (ID_equipa, ID_Jogo, pontos_totais, assistencias_totais, ressaltos_totais, faltas_totais, percentagem_lancamentos) VALUES
-- Jogo 1: Celtics (125) vs Knicks (113)
(1, 1, 125, 30, 50, 18, 0.49),
(3, 1, 113, 25, 45, 22, 0.45),

-- Jogo 2: Warriors (134) vs Lakers (145)
(21, 2, 134, 33, 48, 20, 0.52),
(23, 2, 145, 35, 55, 19, 0.55),

-- Jogo 3: Nuggets (115) vs Mavericks (112)
(16, 3, 115, 27, 42, 16, 0.48),
(26, 3, 112, 24, 39, 15, 0.47),

-- Jogo 4: Heat (105) vs Bucks (98)
(13, 4, 105, 21, 40, 17, 0.44),
(10, 4, 98, 19, 38, 21, 0.41),

-- Jogo 5: Celtics (107) vs Nuggets (104)
(1, 5, 107, 26, 45, 19, 0.46),
(16, 5, 104, 23, 41, 18, 0.45);


select * from Estatistica_Jogador_Jogo

/* ----- Estatistica_Jogador_Jogo (4 registos) ----- */
INSERT INTO Estatistica_Jogador_Jogo (ID_jogador, ID_Jogo, minutos, pontos, assistencias, ressaltos, roubos, blocos, faltas) VALUES
-- Jogo 1: Celtics (1) vs Knicks (3)
(1, 1, 35, 28, 7, 4, 2, 0, 3), -- Ana Silva (Celtics)
(7, 1, 38, 25, 9, 3, 1, 0, 4), -- Gabriela Santos (Knicks)

-- Jogo 3: Nuggets (16) vs Mavericks (26)
(4, 3, 40, 32, 10, 5, 1, 1, 2), -- Diogo Pereira (Nuggets)
(6, 3, 30, 18, 4, 8, 0, 1, 3); -- Filipe Almeida (Mavericks)


select * from Bilhete
/* ----- Bilhete (15 registos para o Jogo 1) ----- */
INSERT INTO Bilhete (ID_bilhete, ID_estadio, ID_Jogo, setor, lugar, preco, vendido, CC) VALUES
(1, 1, 1, 'A1', '101', 150.00, 1, 10101010), -- Vendido, Ligado ao Jogador 1 (Ana Silva)
(2, 1, 1, 'A1', '102', 150.00, 1, 11211211), -- Vendido, Ligado ao Jogador 2 (Bruno Costa)
(3, 1, 1, 'B2', '205', 95.00, 1, 12321232), -- Vendido, Ligado ao Jogador 3 (Carla Mendes)
(4, 1, 1, 'B2', '206', 95.00, 1, 13431343), -- Vendido, Ligado ao Jogador 4 (Diogo Pereira)
(5, 1, 1, 'C3', '315', 60.00, 1, 14541454), -- Vendido, Ligado ao Jogador 5 (Elsa Rodrigues)
(6, 1, 1, 'C3', '316', 60.00, 1, NULL),
(7, 1, 1, 'C3', '317', 60.00, 1, NULL),
(8, 1, 1, 'D4', '401', 45.00, 1, NULL),
(9, 1, 1, 'D4', '402', 45.00, 1, NULL),
(10, 1, 1, 'D4', '403', 45.00, 1, NULL),
(11, 1, 1, 'D4', '404', 45.00, 0, NULL), -- Não vendido
(12, 1, 1, 'A1', '103', 150.00, 0, NULL), -- Não vendido
(13, 1, 1, 'E5', '501', 30.00, 1, NULL),
(14, 1, 1, 'E5', '502', 30.00, 1, NULL),
(15, 1, 1, 'E5', '503', 30.00, 0, NULL); -- Não vendido