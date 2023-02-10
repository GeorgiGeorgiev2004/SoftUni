SELECT Name,PhoneNumber,Address,AnimalId,DepartmentId FROM Volunteers
ORDER BY Name,AnimalId,DepartmentId

SELECT a.Name,aa.AnimalType ,FORMAT(a.BirthDate,'dd.MM.yyyy') AS BirthDate FROM Animals AS a
JOIN AnimalTypes AS aa ON a.AnimalTypeId=aa.Id 
ORDER BY a.Name


SELECT TOP(5)  o.Name, COUNT(OwnerId) FROM Animals AS a
JOIN Owners AS o ON a.OwnerId = o.Id
GROUP BY o.Name
ORDER BY COUNT(OwnerId) DESC,o.Name

SELECT o.Name+'-'+a.Name AS OwnersAnimals, PhoneNumber, ac.CageId FROM Owners AS o
JOIN Animals AS a ON o.Id=a.OwnerId
JOIN AnimalsCages AS ac ON a.Id = ac.AnimalId
WHERE a.AnimalTypeId = (
	SELECT Id FROM AnimalTypes
	WHERE AnimalType = 'Mammals')
ORDER BY o.Name,a.Name DESC


SELECT Name,PhoneNumber,Address FROM Volunteers
WHERE DepartmentId = (	
	SELECT Id FROM VolunteersDepartments

	)