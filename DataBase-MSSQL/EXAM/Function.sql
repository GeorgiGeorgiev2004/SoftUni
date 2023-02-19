CREATE FUNCTION udf_CreatorWithBoardgames(@name VARCHAR(50)) 
RETURNS INT
AS 
	BEGIN
	DECLARE @count INT;
  SELECT @count = COUNT(BoardgameId) FROM CreatorsBoardgames
  WHERE CreatorId=(SELECT Id FROM Creators AS c
  WHERE c.FirstName = @name);
  RETURN  @count
  END;
