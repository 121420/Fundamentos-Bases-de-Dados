
-- Vista para simplificar o FormTreinadores
CREATE VIEW vw_TreinadoresDetalhes AS
SELECT 
    T.ID_Treinador,
    P.CC,
    P.Nome,
    T.Experiencia_anos,
    T.Especialidade,
    T.Licenca,
    P.Email
FROM Treinadores T
JOIN Pessoas P ON T.CC = P.CC;
GO

-- Vista para o FormJogos (mostra nomes em vez de IDs)
CREATE VIEW vw_CalendarioJogos AS
SELECT 
    J.ID_Jogo,
    J.dataHora_jogo,
    EC.Nome AS Equipa_Casa,
    J.pontos_casa,
    J.pontos_fora,
    EF.Nome AS Equipa_Fora,
    J.fase,
    J.ID_estadio,
    J.ID_Temporada
FROM JOGO J
JOIN Equipas EC ON J.ID_equipa_Casa = EC.ID_Equipas
JOIN Equipas EF ON J.ID_equipa_Fora = EF.ID_Equipas;
GO

-- Vista para encontrar pessoas que ainda não são treinadores nem jogadores
CREATE VIEW vw_PessoasDisponiveis AS
SELECT P.CC, P.Nome
FROM Pessoas P
LEFT JOIN Treinadores T ON P.CC = T.CC
LEFT JOIN Jogadores J ON P.CC = J.CC -- Assumindo que a tabela Jogadores existe
WHERE T.CC IS NULL AND J.CC IS NULL;
GO

--jogos do Futuro
CREATE VIEW vw_JogosFuturos AS
SELECT 
    J.ID_Jogo,
    E1.Nome AS Equipa_Casa,
    E2.Nome AS Equipa_Fora,
    J.dataHora_jogo,
    Es.Nome AS Estadio
FROM Jogo J
JOIN Equipas E1 ON E1.ID_Equipas = J.ID_Equipa_Casa
JOIN Equipas E2 ON E2.ID_Equipas = J.ID_Equipa_Fora
JOIN Estadios Es ON Es.ID_Estadio = J.ID_Estadio
WHERE J.dataHora_jogo >= CAST(GETDATE() AS DATE);
GO

Select * FROM vw_JogosFuturos