# BD: Trabalho Prático APF-T

**Grupo**: P4G4
- Kelvin Loforte, MEC: 121420
- Rómulo Monteiro, MEC: 127986

## Introdução / Introduction
O nosso projeto é uma base de dados sobre a Liga de Basquetebol NBA, que é a principal competição profissional de basquete do mundo.
O objetivo é de criar uma base de dados que armazene e organize informações sobre equipas, jogadores e estatísticas, permitindo gerar relatorios e consultas.

    Queremos que a base de dados possa responder a perguntas, tais como:
    . "Quais são os jogadores de cada equipa?"
    . "Quais foram os resultados de um determinado jogo?"
    . "Quem foi o campeão em cada temporada?"
    . "Quais são as estatisticas individuais dos jogadores e ou equipas?"
    . etc...

    Ou seja, o nosso foco é representar a estrutura e funcionamento da NBA de forma organizada e consultável.

## ​Análise de Requisitos / Requirements
###  . Requisitos funcionais
        1. Registar: 
            O sistema deve permitir o registo de:
                    - equipas da NBA(Nome,cidade,treinador princial, conferência e divisão)
                    - jogadores (Nome,posicao,nacionalidade,equipa atual, altura, peso, data de nascimento)
                    - jogos (equipas participantes (casa e fora) ,data, local, resultado (pontos casa/fora), temporada)
                    - temporadas (ano de início e fim, equipe campeã, total de jogos)
                    - contratos (jogador, equipa, datas de início e fim, salário)

        2. Guardar: 
            O sistema deve guardar:
                    - estatisticas dos jogadores por jogo (pontos, assistências, ressaltos, roubos, faltas, minutos jogados, eficiência)
                    - a relação entre jogadores e equipas (contratos)
                    - o resultado de cada jogo (pontuação final e vencedor)
                    - histórico de equipas em cada temporada: posição final, número de vitórias e derrotas.

        3. Consultar:
            O sistema deve permitir consultas como: 
                    - Top scorers da época (jogadores com mais pontos)
	                - Resultados de jogos entre duas equipas específicas.
	                - estatisticas médias por jogador (pontos, ressaltos, assistências, etc...)
                    - estatisticas gerais por equipa e temporada
                    - jogadores por nacionalidade, posição ou equipa.
                    - histórico de quipas campeãs por temporada
                    - Jogadores com mais assistências, ressaltos ou eficiência
                    - evolução estatístia de um jogador ao longo das temporadas.

        4. Atualizar:
            O sistema deve permitir atualizar:
                    - tranferências de jogadores (mudança de equipa)
                    - resultados de jogos e estatisticas
                    - contratos (renovação, fim de contrato)
        
        5. Eliminar:
            O sistema deve permitir remover:
                    - equipas, jogadores, jogos, ...
                    - contratos ou estatísticas desatualizadas.

###  . Requisitos não funcionais:
        - Os dados dever ser consistentes e fáceis de Consultar.
        - O modelo deve ser escalável, podendo crescer com novas temporadas ou equipas.    
        
## DER - Diagrama Entidade Relacionamento/Entity Relationship Diagram

### Versão final/Final version
![DER Diagram!](der.jpg "AnImage")

### Melhorias/Improvements 
Não foram feitas nenhuma alteração.

## ER - Esquema Relacional/Relational Schema

### Versão final/Final Version
![ER Diagram!](er.jpg "AnImage")

### Melhorias/Improvements
Não foram feitas nenhuma alteração.

## ​SQL DDL - Data Definition Language
[SQL DDL File](sql/01_ddl.sql "SQLFileQuestion")

## SQL DML - Data Manipulation Language

Uma secção por formulário.
A section for each form.

### Formulario exemplo/Example Form

![Exemplo Screenshot!](screenshots/customer_details_form.jpg "AnImage")

```sql
-- Show data on the form
SELECT * FROM MY_TABLE ....;

-- Insert new element
INSERT INTO MY_TABLE ....;
```

...

## Normalização/Normalization

A normalização é um processo fundamental no design de bases de dados relacionais que visa minimizar a redundância de dados, eliminar anomalias de atualização e otimizar o espaço de armazenamento. Este processo consiste em aplicar uma série de formas normais (FN) progressivas ao esquema da base de dados.
O modelo relacional foi desenvolvido respeitando as principais formas normais: 1ª Forma Normal (1FN), 2ª Forma Normal (2FN) e 3ª Forma Normal (3FN).

### 1FN
Uma tabela encontra-se na 1FN quando: 
- Todos os atributos possuem valores atómicos (indivisíveis);
- Não existem grupos repetidos ou listas de valores;
- Cada registo é identificado por uma chave primária.

Neste projeto:
- Todas as tabelas possuem uma chave primária bem definida (ex.: ID_Jogador, ID_Equipa, ID_Jogo, CC).
- Os atributos armazenam apenas um valor por coluna (ex.: um jogador tem uma posição, uma equipa pertence a uma conferência).
- Estatísticas por jogo foram separadas em tabelas próprias (Estatistica_Jogador_Jogo, Estatistica_Equipa_Jogo), evitando colunas repetidas.

Ou seja, esquema cumpre com a 1FN.

### 2FN
Uma tabela encontra-se na 2FN quando:
- Está na 1FN;
- Todos os atributos não-chave dependem totalmente da chave primária;
- Não existem dependências parciais (em tabelas com chaves compostas).

Neste projeto, as tabelas com chave primária simples (ex.: Equipas, Pessoas, Jogadores) cumprem automaticamente a 2FN.

- As tabelas com chave composta, como: Estatistica_Jogador_Jogo (ID_Jogador, ID_Jogo) e Estatistica_Equipa_Jogo (ID_Equipa, ID_Jogo), possuem apenas atributos que dependem da combinação completa da chave, como pontos, minutos, assistências, etc.
- Dados como nome do jogador, equipa ou estádio não são repetidos nestas tabelas, sendo obtidos por junções (JOIN).

O esquema cumpre com a 2FN, eliminando dependências parciais.

### 3FN
Uma tabela encontra-se na 3FN quando:
- Está na 2FN;
- Não existem dependências transitivas;
- Os atributos não-chave dependem apenas da chave primária e não de outros atributos não-chave.

Neste projeto:
- Informações pessoais foram isoladas na tabela Pessoas, evitando repetição em Jogadores, Treinadores e Bilhete.
- Contratos foram separados em: Contrato, Contrato_Jogador, Contrato_Treinador. Garantindo assim flexibilidade e eliminando dependências desnecessárias.
- Informações de equipas, ligas, estádios e temporadas estão corretamente separadas, sem redundância.
- Relatórios e consultas complexas são suportados através de views, evitando duplicação de dados.

O esquema encontra-se em 3FN, garantindo integridade, consistência e escalabilidade.

#### Em suma:
O modelo de dados deste projeto NBA:
- Está normalizado até à 3ª Forma Normal (3FN);
- Evita redundância e anomalias de atualização;
- Facilita manutenção, expansão e consultas complexas;
- Está adequado a um sistema real de gestão de estatísticas desportivas.

## Índices/Indexes

```sql
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
```

## SQL Programming: Stored Procedures, Triggers, UDF

[SQL SPs and Functions File](sql/02_sp_functions.sql "SQLFileQuestion")

[SQL Triggers File](sql/03_triggers.sql "SQLFileQuestion")

[SQL User Definition Functions File](sql/06_udfs.sql "SQLFileQuestion")

[SQL Indexes File](sql/07_INDEX.sql "SQLFileQuestion")

### Dados iniciais da dabase de dados/Database init data

[SQL DB Init File](sql/04_db_init.sql "SQLFileQuestion")

### Apresentação

[Slides](slides.pdf "Sildes")

[Video](https://elearning.ua.pt/pluginfile.php/55992/mod_label/intro/VideoTrabalho2013.mp4)




 