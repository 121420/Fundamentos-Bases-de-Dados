/*Este Ficheiro é destinado para fazer Pesquisas de Testes na BD*/
/*Pode ser util futuramente*/
/**/


select * from Pessoas
select * from Jogadores
Select * from Contrato
Select *from Equipas
Select * from Contrato_Jogador

select P.Nome,E.Nome,J.Nome_Camisola,C.salario_total 
from Contrato C
JOIN Pessoas P ON P.CC = C.CC
JOIN Jogadores J ON J.CC = P.CC
JOIN Contrato_Jogador CJ ON J.ID_Equipa = CJ.ID_equipa
JOIN Equipas E ON E.ID_Equipas = CJ.ID_equipa




Select T.CC,P.Nome,T.Especialidade,CT.cargo,C.salario_total,E.Nome
from Treinadores T
JOIN Pessoas P ON P.CC = T.CC
JOin Contrato_treinador CT ON CT.ID_Treinador = T.ID_Treinador
JOIN Contrato C ON C.CC = P.CC
JOIN Equipas E ON CT.ID_equipa = E.ID_Equipas


Select * from Contrato_Treinador
select * from Contrato
select * from Equipas