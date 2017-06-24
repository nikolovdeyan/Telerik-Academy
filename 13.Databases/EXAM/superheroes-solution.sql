USE SuperheroesUniverse

-- 01. List all superheroes in Earth

SELECT s.Id,
       s.Name
FROM Superheroes s
    JOIN PlanetSuperheroes pns
    ON s.Id = pns.Superhero_Id
        JOIN Planets p
        ON pns.Planet_Id = p.Id
WHERE p.Name = 'Earth'

-- 02. List all superheroes with their powers and powerTypes 

SELECT s.Name AS [Superhero],
       p.Name + ' (' + pt.Name + ')' AS [Power]
FROM Superheroes s
    JOIN PowerSuperheroes pws
    ON s.Id = pws.Superhero_Id
        JOIN Powers p
        ON pws.Power_Id = p.Id
            JOIN PowerTypes pt
            ON p.PowerTypeId = pt.Id

-- 03. List the top 5 planets, sorted by count of superheroes with alignment 'Good', then by Planet Name 

SELECT TOP(5)
    p.Name AS [Planet],
    COALESCE(COUNT(*), 0) AS [Protectors]
FROM Superheroes s
    LEFT JOIN PlanetSuperheroes pns
    ON s.Id = pns.Superhero_Id
        LEFT JOIN Planets p
        ON pns.Planet_Id = p.Id
    JOIN Alignments a
    ON s.Alignment_Id = a.Id
WHERE a.Name = 'Good'
GROUP BY a.Name, p.Name
ORDER BY [Protectors] DESC, [Planet] DESC

-- 04. Create a stored procedure to edit superheroes Bio, by provided Superhero's Id and the new bio

CREATE PROC usp_UpdateSuperheroBio
(
    @heroId int,
    @heroBio nvarchar(500)
)
AS
    UPDATE Superheroes
    SET Bio = @heroBio
FROM Superheroes
WHERE Id = @heroId
GO

-- testing the procedure:
EXEC usp_UpdateSuperheroBio
    @heroId = 3,
    @heroBio = 'Testing bio for superhero with id 3'
GO

-- 05. Create a stored prodecure, that gives full information about a superhero, by provided Superhero's Id

CREATE PROC usp_GetSuperheroInfo
(
    @heroId int
)
AS
SELECT s.Id, 
       s.Name,
       s.SecretIdentity AS [Secret Identity],
       s.Bio,
       a.Name AS [Alignment],
       p.Name AS [Planet],
       pw.Name AS [Power]
FROM Superheroes s
    JOIN PlanetSuperheroes pns
    ON s.Id = pns.Superhero_Id
        JOIN Planets p
        ON pns.Planet_Id = p.Id
    JOIN Alignments a
    ON s.Alignment_Id = a.Id
        JOIN PowerSuperheroes pws
        ON s.Id = pws.Superhero_Id
            JOIN Powers pw
            ON pws.Power_Id = pw.Id
WHERE s.Id = @heroId
GO

-- testing the procedure:
EXEC usp_GetSuperheroInfo
    @heroId = 6
GO

-- 06. Create a stored procedure that prints the number of heroes with Good, Evil and Neutral alignment for each Planet 

CREATE PROC usp_GetPlanetsWithHeroesCount
AS
SELECT p.Name AS [Planet],
       SUM(CASE a.Name WHEN 'Good' THEN 1 ELSE 0 END) AS [Good heroes],
       SUM(CASE a.Name WHEN 'Neutral' THEN 1 ELSE 0 END) AS [Neutral heroes],
       SUM(CASE a.Name WHEN 'Evil' THEN 1 ELSE 0 END) AS [Evil heroes]
FROM Superheroes s
    JOIN Alignments a 
    ON s.Alignment_Id = a.Id
    JOIN PlanetSuperheroes pns
    ON s.Id = pns.Superhero_Id
        JOIN Planets p
        ON pns.Planet_Id = p.Id
GROUP BY p.Name
ORDER BY [Good heroes] DESC, [Neutral heroes] DESC, [Evil heroes] DESC
GO

-- testing the procedure:
EXEC usp_GetPlanetsWithHeroesCount
GO

-- 07. Create a stored procedure for creating a Superhero, with provided name, secret identity, bio, alignment, a planet and 3 powers (with their types)

CREATE PROC usp_CreateHero
(
    @heroName nvarchar(100),
    @heroSecretIdentity nvarchar(100),
    @heroBio nvarchar(500),
    @heroAlignment nvarchar(100),
    @heroPlanet nvarchar(100),
    @heroPower1 nvarchar(100),
    @heroPower2 nvarchar(100),
    @heroPower3 nvarchar(100)
)
AS
INSERT INTO Superheroes
(
    Name,
    SecretIdentity,
    Alignment_Id,
    Bio
)
VALUES
(
    @heroName,
    @heroSecretIdentity,
    SCOPE_IDENTITY(),
    @heroBio
)

INSERT INTO Alignments 
(
    Id,
    Name
)
VALUES
(
    SCOPE_IDENTITY(),
    @heroAlignment
)
GO

-- 08. Create a stored procedure that prints the number of powers by alignment of their superheroes
CREATE PROC usp_PowersUsageByAlignment
AS
SELECT a.Name AS [Alignment],
       COUNT(*) AS [Powers Count]
FROM Alignments a
    JOIN Superheroes s
    ON a.Id = s.Alignment_Id
    JOIN PowerSuperheroes pws
    ON s.Id = pws.Superhero_Id
    JOIN Powers p
    ON pws.Power_Id = p.Id
GROUP BY a.Name
GO

-- testing the procedure:
EXEC usp_PowersUsageByAlignment
GO
