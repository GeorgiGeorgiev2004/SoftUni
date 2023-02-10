CREATE PROC usp_EmployeesBySalaryLevel @SalaryLevel NVARCHAR(10)
AS 
BEGIN 
 SELECT FirstName,LastName 
     FROM Employees 
    WHERE dbo.ufn_GetSalaryLevel(Salary) = @SalaryLevel
END