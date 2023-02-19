DELETE CreatorsBoardgames
FROM CreatorsBoardgames AS CB
JOIN Boardgames AS B
ON B.Id=CB.BoardgameId
JOIN Publishers AS P 
ON B.PublisherId=P.Id
JOIN Addresses AS A
ON A.Id=P.AddressId
WHERE A.Town LIKE 'L%'
DELETE Boardgames
FROM Boardgames AS B
JOIN Publishers AS P 
ON B.PublisherId=P.Id
JOIN Addresses AS A
ON A.Id=P.AddressId
WHERE A.Town LIKE 'L%'
DELETE Publishers
FROM Publishers AS P 
JOIN Addresses AS A
ON A.Id=P.AddressId
WHERE A.Town LIKE 'L%'
DELETE FROM Addresses
WHERE Town LIKE 'L%'