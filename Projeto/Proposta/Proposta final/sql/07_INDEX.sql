drop index IF EXISTS IX_Jogadores_Equipa on Jogadores;
drop index IF EXISTS IX_Equipas_Nome on Equipas;
drop index IF EXISTS IX_Pessoas_Nome on Pessoas;
drop index IF EXISTS IX_Jogadores_Posicao on Jogadores;
drop index IF EXISTS IX_Jogadores_Mao on Jogadores;
Drop index IF EXISTs UQ_Pessoas_Email on Pessoas


--  busca de jogadores por equipa
CREATE INDEX IX_Jogadores_Equipa ON Jogadores (ID_Equipa);

-- ComboBox de Equipas que usa ORDER BY Nome
CREATE INDEX IX_Equipas_Nome ON Equipas (Nome);

-- Acelera buscas por nome na tabela de Pessoas
CREATE INDEX IX_Pessoas_Nome ON Pessoas (Nome);

-- Não podem existir dois emails iguais 
CREATE UNIQUE INDEX UQ_Pessoas_Email ON Pessoas (Email);

-- Acelera pesquisas por posição (ex: todos os Bases)
CREATE INDEX IX_Jogadores_Posicao ON Jogadores (Posicao);

-- Acelera pesquisas por mão dominante (Direita/Esquerda)
CREATE INDEX IX_Jogadores_Mao ON Jogadores (Mao_Dominante);




