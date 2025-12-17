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

-- Função para calcular a idade da pessoa (usada no FormPessoas)
CREATE FUNCTION fn_CalcularIdade (@DataNascimento DATE)
RETURNS INT
AS
BEGIN
    DECLARE @Idade INT;
    SET @Idade = DATEDIFF(YEAR, @DataNascimento, GETDATE()) - 
                 CASE WHEN (MONTH(@DataNascimento) > MONTH(GETDATE())) OR 
                 (MONTH(@DataNascimento) = MONTH(GETDATE()) AND DAY(@DataNascimento) > DAY(GETDATE())) 
                 THEN 1 ELSE 0 END;
    RETURN @Idade;
END;
GO