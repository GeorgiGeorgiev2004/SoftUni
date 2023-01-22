CREATE DATABASE Hotel

USE Hotel

CREATE TABLE Employees(
id INT PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(75)  NOT NULL,
LastName VARCHAR(75)  NOT NULL,
Title VARCHAR(150)  NOT NULL,
Notes TEXT
);

CREATE TABLE Customers (
AccountNumber INT PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(75)  NOT NULL,
LastName VARCHAR(75)  NOT NULL,
PhoneNumber VARCHAR(75)  NOT NULL,
EmergencyName VARCHAR(75)  NOT NULL,
EmergencyNumber VARCHAR(75)  NOT NULL,
Notes TEXT
);

CREATE TABLE RoomStatus  (
RoomStatus CHAR(1),
Notes TEXT
);

CREATE TABLE RoomTypes(
RoomType VARCHAR(50) PRIMARY KEY,
Notes TEXT
)

CREATE TABLE BedTypes (
BedType VARCHAR(50) PRIMARY KEY,
Notes TEXT
)

CREATE TABLE Rooms  (
RoomNumber INT PRIMARY KEY,
RoomType VARCHAR(50) NOT NULL,
BedType VARCHAR(50) NOT NULL,
Rate FLOAT(2),
RoomStatus CHAR(1) NOT NULL,
Notes TEXT
)

CREATE TABLE Payments(
Id INT PRIMARY KEY,
EmployeeId INT NOT NULL,
PaymentDate DATE NOT NULL,
AccountNumber INT,
FirstDateOccupied DATE NOT NULL,
LastDateOccupied DATE NOT NULL,
TotalDays INT NOT NULL,
AmountCharged FLOAT(2) NOT NULL,
TaxRate FLOAT(2) NOT NULL,
TaxAmount FLOAT(2) NOT NULL,
PaymentTotal FLOAT(2) NOT NULL,
Notes TEXT
)

CREATE TABLE Occupancies (
Id INT PRIMARY KEY IDENTITY(1,1),
EmployeeId INT NOT NULL,
DateOccupied DATE NOT NULL,
AccountNumber INT,
RoomNumber INT NOT NULL,
RateApplied FLOAT(2) NOT NULL,
PhoneCharge FLOAT(2) NOT NULL,
Notes TEXT
)


INSERT INTO Employees
	(FirstName,LastName,Title)
VALUES
	('Kircho','Skalikersi','NevedomiSaPutishtataSkalisti'),
	('Lu4ichk0','Listeronski','TheUnimaginableTroublesAToplanerGoesThrough'),
	('Stefo','Kleso','TravmataINachinaDaSePreborishSKPrqkoraSi')


INSERT INTO Customers
	(FirstName,LastName,PhoneNumber,EmergencyName,EmergencyNumber)
VALUES
	('Kircho','Skalikersi',0876600660,'Skalichkata',2213),
	('Lu4ichk0','Listeronski',0876600661,'Lu4000',2211),
	('Stefo','Kleso',0876600662,'Stef',0321)


INSERT INTO RoomStatus
	(RoomStatus)
VALUES
	(0),
	(1)

INSERT INTO RoomTypes
	(RoomType)
VALUES
	('Small'),
	('Medium'),
	('Big');

INSERT INTO BedTypes
	(BedType)
VALUES
	('King'),
	('NoBed'),
	('x-small')

INSERT INTO Rooms
	(RoomNumber,RoomType,BedType,Rate,RoomStatus)
VALUES
	(1,'Small','King',5.21,0),
	(2,'Medium','NoBed',6.43,0),
	(3,'Big','x-small',10.00,0)

INSERT INTO Payments 
	(Id,EmployeeId,PaymentDate,AccountNumber,FirstDateOccupied, LastDateOccupied,TotalDays,AmountCharged,TaxRate,TaxAmount,PaymentTotal,Notes)
VALUES
	(1,1,'2022-12-21',11,'2012-12-21','2013-01-21',30, 65.55,421.23,21.31,441,NULL),
	(2,2,'2022-12-21',21,'2014-12-21','2015-01-21',30, 66.55,451.23,22.31,481,NULL),
	(3,4,'2022-12-21',31,'2015-12-21','2016-01-21',30, 67.55,481.23,23.31,521,NULL);

INSERT INTO Occupancies 
	(EmployeeId,DateOccupied,AccountNumber,RoomNumber, RateApplied,PhoneCharge, Notes) 
VALUES
	(1,'2022-12-21',11,12, 65.55,421.23, 'Too'),
	(1,'2012-12-21',41,2, 54.55,221.23, 'much'),
	(1,'2002-12-21',32,1, 45.55,211.23, 'typing');