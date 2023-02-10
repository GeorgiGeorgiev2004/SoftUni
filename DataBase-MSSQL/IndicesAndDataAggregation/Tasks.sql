SELECT COUNT(Id) AS [Count] FROM WizzardDeposits

SELECT MAX(MagicWandSize) AS LongestMagicWand FROM WizzardDeposits

SELECT DepositGroup,MAX(MagicWandSize) AS LongestMagicWand FROM WizzardDeposits
GROUP BY DepositGroup

SELECT TOP 2 DepositGroup FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

SELECT DepositGroup,SUM(DepositAmount) AS TotalSum FROM WizzardDeposits
GROUP BY DepositGroup

SELECT DepositGroup,SUM(DepositAmount) AS TotalSum FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

SELECT DepositGroup,SUM(DepositAmount) AS TotalSum FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family' 
GROUP BY DepositGroup
HAVING SUM(DepositAmount)<150000
ORDER BY SUM(DepositAmount) DESC


SELECT DepositGroup,MagicWandCreator,MIN(DepositCharge) FROM WizzardDeposits
GROUP BY MagicWandCreator,DepositGroup
ORDER BY MagicWandCreator,DepositGroup


SELECT 
	CASE
	  WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN w.Age >= 61 THEN '[61+]'
	END AS [AgeGroup],
COUNT(*) AS [WizardCount]
	FROM WizzardDeposits AS w
GROUP BY CASE
	  WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN w.Age >= 61 THEN '[61+]'
	END


SELECT SUBSTRING(FirstName,1,1) AS Letter FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY SUBSTRING(FirstName,1,1)
ORDER BY SUBSTRING(FirstName,1,1)


SELECT DepositGroup,IsDepositExpired,AVG(DepositInterest) AS Letter FROM WizzardDeposits
WHERE DepositStartDate > '01-01-1985'
GROUP BY DepositGroup,IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired



USE SoftUni


SELECT DepartmentID,SUM(Salary) FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID


SELECT DepartmentID,MIN(Salary) FROM Employees
WHERE DepartmentID IN (2,5,7) AND HireDate > '01-01-2000'
GROUP BY DepartmentID
ORDER BY DepartmentID




SELECT * INTO [EmployeesFake] FROM Employees
WHERE [Salary] > 30000
 
DELETE FROM [EmployeesFake]
WHERE [ManagerID] = 42
 
UPDATE [EmployeesFake]
SET [Salary] += 5000
WHERE [DepartmentID] = 1
 
SELECT [DepartmentID],AVG([Salary]) as [AverageSalary] FROM [EmployeesFake]
GROUP BY [DepartmentID]


SELECT DepartmentID,MAX(Salary) FROM Employees
GROUP BY DepartmentID
HAVING NOT MAX(Salary) BETWEEN 30000 AND 70000


SELECT COUNT(Salary) FROM Employees
WHERE ManagerID IS NULL