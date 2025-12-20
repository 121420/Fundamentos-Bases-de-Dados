-- Vista para simplificar o FormTreinadores (SELECT * FROM vw_TreinadoresDetalhes)
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

-- Vista para encontrar pessoas que ainda não são treinadores nem jogadores (SELECt * FROM vw_PessoasDisponiveis)
CREATE VIEW vw_PessoasDisponiveis AS
SELECT P.CC, P.Nome
FROM Pessoas P
LEFT JOIN Treinadores T ON P.CC = T.CC
LEFT JOIN Jogadores J ON P.CC = J.CC -- Assumindo que a tabela Jogadores existe
WHERE T.CC IS NULL AND J.CC IS NULL;
GO

-- vista para o FormClassificacao (SELECT * FROM vw_Classificacao ORDER BY Vitorias DESC)
CREATE VIEW vw_Classificacao AS
SELECT 
    E.Nome AS Equipa,
    COUNT(CASE WHEN (J.ID_equipa_Casa = E.ID_Equipas AND J.pontos_casa > J.pontos_fora) OR 
                    (J.ID_equipa_Fora = E.ID_Equipas AND J.pontos_fora > J.pontos_casa) THEN 1 END) AS Vitorias,
    COUNT(CASE WHEN (J.ID_equipa_Casa = E.ID_Equipas AND J.pontos_casa < J.pontos_fora) OR 
                    (J.ID_equipa_Fora = E.ID_Equipas AND J.pontos_fora < J.pontos_casa) THEN 1 END) AS Derrotas,
    SUM(CASE WHEN J.ID_equipa_Casa = E.ID_Equipas THEN J.pontos_casa ELSE J.pontos_fora END) AS PontosMarcados
FROM Equipas E
LEFT JOIN JOGO J ON E.ID_Equipas = J.ID_equipa_Casa OR E.ID_Equipas = J.ID_equipa_Fora
GROUP BY E.Nome;
GO

-- Vista para o FormJogadores (SELECT * FROM vw_JogadoresDetalhes)
CREATE VIEW vw_JogadoresDetalhes AS
SELECT 
    J.ID_Jogador,
    P.Nome,
    P.CC,
    J.Posicao,
    J.Numero_Camisola,
    E.Nome AS Equipa
FROM Jogadores J
JOIN Pessoas P ON J.CC = P.CC
JOIN Equipas E ON J.ID_Equipa = E.ID_Equipas;
GO

-- Vista para o FormJogos (mostra nomes em vez de IDs) added (SELECT * FROM vw_CalendarioJogos)
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

--jogos do Futuro added (SELECT * FROM vw_JogosFuturos)
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