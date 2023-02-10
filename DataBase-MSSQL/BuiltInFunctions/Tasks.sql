SELECT FirstName,LastName FROM Employees
WHERE FirstName LIKE 'Sa%'


SELECT FirstName,LastName FROM Employees
WHERE LastName LIKE '%ei%'


SELECT FirstName FROM Employees
WHERE DepartmentID=3 OR DepartmentID=10
AND HireDate BETWEEN '01-01-1995' AND '01-01-2005'


SELECT FirstName,LastName FROM Employees
WHERE JobTitle NOT LIKE '%Engineer%'


SELECT[Name] FROM Towns
WHERE LEN([Name]) =5 OR LEN([Name]) =6
ORDER BY [Name]


SELECT [TownID],[Name] FROM Towns
WHERE [Name] LIKE 'M%' OR [Name] LIKE 'K%' OR [Name] LIKE 'B%' OR [Name] LIKE 'E%'
ORDER BY [Name]

SELECT [TownID],[Name] FROM Towns
WHERE [Name] NOT LIKE 'R%' AND [Name] NOT LIKE 'D%' AND [Name] NOT LIKE 'B%'
ORDER BY [Name];

CREATE VIEW [V_EmployeesHiredAfter2000] AS
SELECT FirstName,LastName FROM Employees
WHERE YEAR(HireDate) >2000;


SELECT FirstName,LastName FROM Employees
WHERE LEN(LastName) =5


SELECT*FROM(
SELECT EmployeeID,FirstName,LastName,Salary,DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID ) AS DRank
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000 )AS MyTABLE
WHERE DRank =2
ORDER BY Salary DESC


USE Geography


SELECT CountryName,IsoCode FROM Countries
WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode;

SELECT
PeakName,
RiverName,
LOWER(
CONCAT(
SUBSTRING(PeakName,1,CHAR_LENGTH(PeakName)-1),
RiverName)) AS mix
FROM peaks,rivers
WHERE
SUBSTRING(RiverName,1,1) = SUBSTRING(PeakName,-1)
ORDER by mix;

--................



USE Diablo


SELECT TOP(50) [Name], FORMAT([Start],'yyyy-MM-dd')  FROM Games
WHERE YEAR([Start]) = 2011 OR YEAR([Start]) = 2012
ORDER BY [Start],[Name] ;

-- Respectfully what is wrong with this jump in difficulty??? 
--13 and 14 tasks DOGGERS???

SELECT Username, SUBSTRING(Email,CHARINDEX('@',Email,1)+1,LEN(Email)) 
AS 'Email Provider' 
FROM Users
ORDER BY [Email Provider], Username

SELECT Username, IpAddress FROM Users 
WHERE [IpAddress] LIKE '___.1_%._%.___'
ORDER BY Username   

SELECT [Name],
CASE 
WHEN DATEPART(HOUR,[Start]) BETWEEN 0 AND 11 THEN 'Morning'
WHEN DATEPART(HOUR,[Start]) BETWEEN 12 AND 17 THEN 'Afternoon'
WHEN DATEPART(HOUR,[Start]) BETWEEN 18 AND 23 THEN 'Evening'
END AS [Part of the Day],
CASE
WHEN Duration <=3 THEN 'Extra Short'
WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
WHEN Duration >6 THEN 'Long'
WHEN Duration IS NULL THEN 'Extra Long'
END AS [Duration]
FROM Games
Order BY [Name] ASC,
[Duration],
[Part of the Day]


USE Orders


SELECT ProductName, OrderDate, 
    DATEADD(DAY,3,OrderDate) AS [Pay Due],
    DATEADD(MONTH,1,OrderDate) AS [Deliver Due]
    FROM Orders