SELECT TOP (5) EmployeeID,JobTitle,e.AddressID,AddressText FROM Employees AS e
JOIN Addresses AS a
ON a.AddressID=e.AddressID
ORDER BY AddressID;


SELECT TOP (50) FirstName,LastName,t.[Name] AS Town,AddressText FROM Employees AS e
LEFT JOIN Addresses AS a ON a.AddressID=e.AddressID
LEFT JOIN Towns AS t ON a.TownID=t.TownID
ORDER BY FirstName,LastName 


SELECT EmployeeID,FirstName,LastName,d.[Name] AS DepartmentName FROM Employees AS e
LEFT JOIN Departments AS d ON d.DepartmentID=e.DepartmentID
WHERE d.[Name] = 'Sales'
ORDER BY EmployeeID


SELECT TOP(5) EmployeeID,FirstName,Salary,d.[Name] AS DepartmentName FROM Employees AS e
 JOIN Departments AS d ON d.DepartmentID=e.DepartmentID
WHERE Salary > 15000
ORDER BY d.DepartmentID ASC


SELECT TOP(3) e.EmployeeID,e.FirstName FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep ON e.EmployeeID=ep.EmployeeID
WHERE ep.EmployeeID IS NULL
ORDER BY e.EmployeeID 


SELECT e.FirstName,e.LastName,e.HireDate,d.[Name] AS DeptName FROM Employees AS e
JOIN Departments AS d ON d.DepartmentID=e.DepartmentID
WHERE YEAR(HireDate)>1998 AND d.[Name] = 'Sales' OR d.[Name] = 'Finance'
ORDER BY e.HireDate


SELECT TOP(5) e.EmployeeID,e.FirstName,p.[Name] AS ProjectName FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID=ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID=p.ProjectID
WHERE p.StartDate > '08-13-2002' AND p.EndDate IS NULL
ORDER BY e.EmployeeID

SELECT e.EmployeeID,e.FirstName,
	CASE 
   WHEN P.StartDate > '01/01/2005' THEN NULL
   ELSE P.NAME
	END  
  FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID=ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID=p.ProjectID
WHERE e.EmployeeID = '24'

--TASK 9
SELECT e.EmployeeID,e.FirstName,m.EmployeeID,m.FirstName FROM Employees AS e
JOIN Employees AS m ON m.EmployeeID=e.ManagerID
WHERE e.ManagerID IN (3,7)
ORDER BY e.EmployeeID


SELECT TOP(50) 
	e.EmployeeID,
	e.FirstName +' '+ e.LastName AS EmployeeName,
	m.FirstName +' '+ m.LastName  AS ManagerName,
	d.[Name] AS DepartmentName 
FROM Employees AS e
JOIN Employees AS m ON m.EmployeeID=e.ManagerID
JOIN Departments AS d ON e.DepartmentID=d.DepartmentID
ORDER BY e.EmployeeID


SELECT MIN([avg]) AS [MinAverageSalary]
FROM (
       SELECT AVG(Salary) AS [avg]
       FROM Employees
       GROUP BY DepartmentID
     ) AS AverageSalary


	 USE Geography


SELECT CountryCode,m.MountainRange,p.PeakName,p.Elevation FROM MountainsCountries AS mc
JOIN Peaks AS p ON mc.MountainId = p.MountainId
JOIN Mountains AS m ON mc.MountainId = m.Id
WHERE mc.CountryCode = 'BG' AND p.Elevation>2835
ORDER BY p.Elevation DESC


SELECT c.CountryCode, count(m.MountainRange)
FROM Countries AS c
JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
JOIN Mountains AS m ON mc.MountainId = m.Id
WHERE c.CountryName in ('United States', 'Russia', 'Bulgaria')
GROUP BY c.CountryCode


SELECT TOP (5)
c.CountryName,
CASE 
	WHEN r.RiverName IS NULL THEN NULL
	ELSE r.RiverName
	END
FROM Countries AS c
LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName


SELECT COUNT(c.CountryCode) as CountryCount FROM Countries as c
LEFT JOIN MountainsCountries as mc ON c.CountryCode = mc.CountryCode
WHERE mc.MountainId IS NULL;


SELECT TOP(5) c.CountryName, MAX(p.Elevation) AS [HighestPeakElevation], MAX(r.[Length]) AS [LongestRiverLength]
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
LEFT JOIN Peaks AS p ON p.MountainId = mc.MountainId
LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
GROUP BY c.CountryName
ORDER BY [HighestPeakElevation] DESC, [LongestRiverLength] DESC, c.CountryName