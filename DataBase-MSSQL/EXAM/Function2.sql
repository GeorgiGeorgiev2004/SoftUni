CREATE PROC usp_SearchByCategory(@category VARCHAR(50))
AS
BEGIN

SELECT b.Name, b.YearPublished, b.Rating, c.Name AS CategoryName, p.Name AS PublisherName, CONCAT_WS(' ', pr.PlayersMin , 'people') AS MinPlayers, CONCAT_WS(' ', pr.PlayersMax , 'people') AS MaxPlayers
FROM Boardgames AS b
JOIN Categories as c ON b.CategoryId = c.ID
JOIN Publishers as p ON b.PublisherId = p.ID
JOIN PlayersRanges as pr ON b.PlayersRangeId = pr.Id
WHERE c.Name = @category
ORDER BY p.Name, YearPublished DESC

END