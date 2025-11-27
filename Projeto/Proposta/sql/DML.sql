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

