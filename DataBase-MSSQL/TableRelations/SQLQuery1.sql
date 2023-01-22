CREATE DATABASE TableRelations

USE TableRelations

CREATE TABLE Persons(
PersonID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
FirstName NVARCHAR(50) NOT NULL,
Salary DECIMAL(8,2) NOT NULL,
PassportID INT NOT NULL
);

CREATE TABLE Passports(
PassportID INT PRIMARY KEY IDENTITY(101,1) NOT NULL,
PassportNumber NVARCHAR(50) NOT NULL,
);

INSERT INTO Passports 
	(PassportNumber)
VALUES 
	('N34FG21B'),
	('K65LO4R7'),
	('ZE657QP2')

INSERT INTO Persons 
	(FirstName,Salary,PassportID)
VALUES 
	('Roberto ',43300.00,102),
	('Tom ',56100.00,103),
	('Yana ',60200.00,101)


ALTER TABLE Persons
ADD CONSTRAINT FK_PassportsPersons 
FOREIGN KEY (PassportID) REFERENCES Passports(PassportID)