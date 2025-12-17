-- Trigger para impedir a eliminação de pessoas que têm cargos ativos
CREATE TRIGGER trg_ProtegerPessoas
ON Pessoas
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Treinadores WHERE CC IN (SELECT CC FROM deleted))
    BEGIN
        RAISERROR('Não é possível eliminar: Esta pessoa está registada como Treinador.', 16, 1);
    END
    ELSE
    BEGIN
        DELETE FROM Pessoas WHERE CC IN (SELECT CC FROM deleted);
    END
END;
GO

-- Trigger para validar se a especialidade do treinador não é vazia antes do insert
CREATE TRIGGER trg_CheckTreinadorEspecialidade
ON Treinadores
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted WHERE Especialidade IS NULL OR Especialidade = '')
    BEGIN
        PRINT 'Aviso: Treinador inserido sem especialidade definida.';
    END
END;
GO