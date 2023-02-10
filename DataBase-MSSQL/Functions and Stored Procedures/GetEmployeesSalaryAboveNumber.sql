CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber @Num DECIMAL(18,4)
	AS 
BEGIN
	SELECT FirstName,LastName FROM Employees
	WHERE Salary>=@Num
END

EXEC dbo.usp_GetEmployeesSalaryAboveNumber