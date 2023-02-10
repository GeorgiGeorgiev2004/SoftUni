CREATE FUNCTION ufn_GetSalaryLevel(@Salary DECIMAL(18,4)) 
RETURNS VARCHAR(10) AS 
BEGIN 
	DECLARE @SalaryLevel VARCHAR(10) = 'Average'
	IF(@Salary < 30000)
	BEGIN 
	 SET @SalaryLevel = 'Low'
	END
	ELSE IF (@Salary>50000)
	BEGIN 
	 SET @SalaryLevel = 'High'
	END
RETURN @SalaryLevel
END