SELECT Name,Rating FROM Boardgames
ORDER BY YearPublished,Name DESC


SELECT b.Id,b.Name,b.YearPublished,c.Name FROM Boardgames AS b
JOIN Categories AS c ON  b.CategoryId=c.Id
WHERE c.Name = 'Strategy Games' OR c.Name = 'Wargames'
ORDER BY YearPublished DESC


SELECT c.Id,c.FirstName+' '+c.LastName AS CreatorName,c.Email FROM Creators AS c
FULL OUTER JOIN CreatorsBoardgames AS cb ON c.Id=cb.CreatorId
WHERE cb.BoardgameId IS NULL



SELECT TOP(5) b.Name,b.Rating,c.Name FROM Boardgames AS b
JOIN Categories AS c ON  b.CategoryId=c.Id
JOIN PlayersRanges AS pr ON  b.PlayersRangeId=pr.Id
WHERE b.Rating > 7 AND CHARINDEX('a', b.Name) = 1
OR b.Rating > 7.50 AND pr.PlayersMin>=2 AND pr.PlayersMax <=5
ORDER BY b.Name ,b.Rating DESC


SELECT c.FirstName+' '+c.LastName AS FullName,c.Email,MAX(b.Rating) FROM Creators AS c
JOIN CreatorsBoardgames AS cb ON c.Id=cb.CreatorId
JOIN Boardgames AS b ON cb.BoardgameId=b.Id
WHERE RIGHT(c.Email,4)='.com'
GROUP BY c.FirstName+' '+c.LastName , c.Email
ORDER BY FullName


SELECT c.LastName,CEILING(AVG(b.Rating)),p.Name FROM Creators AS c
JOIN CreatorsBoardgames AS cb ON c.Id=cb.CreatorId
JOIN Boardgames AS b ON cb.BoardgameId=b.Id
JOIN Publishers AS p ON b.PublisherId = p.Id
WHERE p.Name='Stonemaier Games'
GROUP BY c.LastName,p.Name
ORDER BY AVG(b.Rating) DESC

