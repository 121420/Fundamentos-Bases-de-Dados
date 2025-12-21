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



-- Função para calcular bilhetes restantes para um jogo
CREATE FUNCTION fn_BilhetesRestantes (@ID_Jogo INT)
RETURNS INT
AS
BEGIN
    DECLARE @Capacidade INT;
    DECLARE @Vendidos INT;

    SELECT @Capacidade = Es.Capacidade 
    FROM JOGO J JOIN Estadios Es ON J.ID_estadio = Es.ID_Estadio 
    WHERE J.ID_Jogo = @ID_Jogo;

    SELECT @Vendidos = COUNT(*) FROM Bilhete WHERE ID_Jogo = @ID_Jogo;

    RETURN @Capacidade - @Vendidos;
END;
GO

