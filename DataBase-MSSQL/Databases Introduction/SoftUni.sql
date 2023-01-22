CREATE DATABASE SoftUni

USE SoftUni

CREATE TABLE Towns(
ID INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100) NOT NULL
);

CREATE TABLE Addresses (
ID INT PRIMARY KEY IDENTITY(1,1),
AddressText NVARCHAR(100) NOT NULL,
TownId INT NOT NULL
FOREIGN KEY (TownId) REFERENCES Towns(ID)
);

CREATE TABLE Departments  (
ID INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100) NOT NULL
);

CREATE TABLE Employees  (
ID INT PRIMARY KEY IDENTITY(1,1),
FirstName NVARCHAR(100) NOT NULL,
MiddleName NVARCHAR(100) NOT NULL,
LastName NVARCHAR(100) NOT NULL,
JobTitle NVARCHAR(50),
DepartmentId INT NOT NULL,
HireDate DATE NOT NULL,
Salary FLOAT(2) NOT NULL,
AddressId INT ,
FOREIGN KEY (AddressId) REFERENCES Addresses(ID),
FOREIGN KEY (DepartmentId) REFERENCES Departments(ID)
);


INSERT INTO Towns
	([Name])
VALUES
	('Sofia'), 
	('Plovdiv'), 
	('Varna'),
	('Burgas')

INSERT INTO Departments
	([Name])
VALUES
	('Engineering'), 
	('Sales'), 
	('Marketing'),
	('Software Development'),
	('Quality Assurance')

INSERT INTO Employees
	(FirstName,MiddleName,LastName,JobTitle,DepartmentId,HireDate,Salary)
VALUES
	('Ivan ', 'Ivanov ', 'Ivanov','.NET Developer',4,'2013-02-01',3500.00), 
	('Petar ', 'Petrov ', 'Petrov','Senior Engineer',1,'2004-03-02',4000.00), 
	('Maria ', 'Petrova ', 'Ivanova','Intern',5,'2016-08-28',525.25), 
	('Georgi ', 'Teziev ', 'Ivanov','CEO',2,'2007-12-09',3000.00), 
	('Peter ', 'Pan ', 'Pan','Intern',3,'2016-08-28',599.88);

SELECT * FROM Towns
ORDER BY [Name]

SELECT * FROM Departments 
ORDER BY [Name]

SELECT * FROM Employees 
ORDER BY Salary DESC



SELECT [Name] FROM Towns
ORDER BY [Name]

SELECT [Name] FROM Departments 
ORDER BY [Name]

SELECT FirstName, LastName, JobTitle, Salary FROM Employees 
ORDER BY Salary DESC


UPDATE Employees
SET Salary*=1.10; 

SELECT Salary FROM Employees 
ORDER BY Salary DESC