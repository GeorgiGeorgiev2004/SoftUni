CREATE PROC usp_GetEmployeesFromTown  @TownName NVARCHAR(50)
	AS 
BEGIN
	SELECT FirstName,LastName FROM Employees AS e
	JOIN Addresses AS ad ON e.AddressID = ad.AddressID
	JOIN Towns AS t ON ad.TownID = t.TownID
	WHERE t.[Name] = @TownName
END

EXEC dbo.usp_GetTownsStartingWith