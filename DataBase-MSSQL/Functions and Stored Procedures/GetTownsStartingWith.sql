CREATE PROC usp_GetTownsStartingWith  @String NVARCHAR(50)
	AS 
BEGIN
	DECLARE @Len INT = LEN(@String)
	SELECT [Name] FROM Towns
	WHERE LEFT([Name],@Len) = @String
END

EXEC dbo.usp_GetTownsStartingWith