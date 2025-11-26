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
(1, 'Boston Celtics', 'Boston', 'Atlantic', 1),
(2, 'Brooklyn Nets', 'Brooklyn', 'Atlantic', 1),
(3, 'New York Knicks', 'New York', 'Atlantic', 1),
(4, 'Philadelphia 76ers', 'Philadelphia', 'Atlantic', 1),
(5, 'Toronto Raptors', 'Toronto', 'Atlantic', 1),
(6, 'Chicago Bulls', 'Chicago', 'Central', 1),
(7, 'Cleveland Cavaliers', 'Cleveland', 'Central', 1),
(8, 'Detroit Pistons', 'Detroit', 'Central', 1),
(9, 'Indiana Pacers', 'Indianapolis', 'Central', 1),
(10, 'Milwaukee Bucks', 'Milwaukee', 'Central', 1),
(11, 'Atlanta Hawks', 'Atlanta', 'Southeast', 1),
(12, 'Charlotte Hornets', 'Charlotte', 'Southeast', 1),
(13, 'Miami Heat', 'Miami', 'Southeast', 1),
(14, 'Orlando Magic', 'Orlando', 'Southeast', 1),
(15, 'Washington Wizards', 'Washington D.C.', 'Southeast', 1),
(16, 'Denver Nuggets', 'Denver', 'Northwest', 1),
(17, 'Minnesota Timberwolves', 'Minneapolis', 'Northwest', 1),
(18, 'Oklahoma City Thunder', 'Oklahoma City', 'Northwest', 1),
(19, 'Portland Trail Blazers', 'Portland', 'Northwest', 1),
(20, 'Utah Jazz', 'Salt Lake City', 'Northwest', 1),
(21, 'Golden State Warriors', 'San Francisco', 'Pacific', 1),
(22, 'LA Clippers', 'Los Angeles', 'Pacific', 1),
(23, 'Los Angeles Lakers', 'Los Angeles', 'Pacific', 1),
(24, 'Phoenix Suns', 'Phoenix', 'Pacific', 1),
(25, 'Sacramento Kings', 'Sacramento', 'Pacific', 1),
(26, 'Dallas Mavericks', 'Dallas', 'Southwest', 1),
(27, 'Houston Rockets', 'Houston', 'Southwest', 1),
(28, 'Memphis Grizzlies', 'Memphis', 'Southwest', 1),
(29, 'New Orleans Pelicans', 'New Orleans', 'Southwest', 1),
(30, 'San Antonio Spurs', 'San Antonio', 'Southwest', 1);

/*-----Pessoas-----*/
INSERT INTO Pessoas (CC, Nome, data_nascimento, Nacionalidade, Genero, Email, Telefone) VALUES