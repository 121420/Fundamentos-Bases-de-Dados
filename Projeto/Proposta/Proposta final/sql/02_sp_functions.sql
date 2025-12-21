use p4g4;
DROP PROCEDURE IF EXISTS sp_VenderBilhete;
DROP PROCEDURE IF EXISTS sp_InserirJogo;
GO
-- Procedure para inserir jogo com validação de equipas
CREATE PROCEDURE sp_InserirJogo
    @ID_Jogo INT,
    @DataHora DATETIME,
    @ID_Estadio INT,
    @ID_Casa INT,
    @ID_Fora INT,
    @PtsCasa INT,
    @PtsFora INT,
    @Fase VARCHAR(50),
    @ID_Temp INT
AS
BEGIN
    IF @ID_Casa = @ID_Fora
    BEGIN
        RAISERROR('Uma equipa não pode jogar contra si mesma.', 16, 1);
        RETURN;
    END
    
    INSERT INTO JOGO (ID_Jogo, dataHora_jogo, ID_estadio, ID_equipa_Casa, ID_equipa_Fora, pontos_casa, pontos_fora, fase, ID_Temporada)
    VALUES (@ID_Jogo, @DataHora, @ID_Estadio, @ID_Casa, @ID_Fora, @PtsCasa, @PtsFora, @Fase, @ID_Temp);
END;
GO

-- Procedure para vender bilhete com validação de lotação

CREATE PROCEDURE sp_VenderBilhete
    @ID_Bilhete INT,
    @ID_Jogo INT,
	@CC INT,
	@ID_EStadio INT,
    @Preco DECIMAL(10,2),
	@setor INT,
    @Lugar VARCHAR(10)
AS
BEGIN
    -- Validação: Não vender bilhetes para jogos que já aconteceram
    IF (SELECT dataHora_jogo FROM JOGO WHERE ID_Jogo = @ID_Jogo) < GETDATE()
    BEGIN
        RAISERROR('Não é possível vender bilhetes para jogos passados.', 16, 1);
        RETURN;
    END
    INSERT INTO Bilhete (ID_bilhete,ID_estadio, ID_Jogo,setor, preco, lugar,CC)
    VALUES (@ID_Bilhete, @ID_Estadio,@ID_Jogo,@setor, @Preco, @Lugar,@CC);
END;
GO



