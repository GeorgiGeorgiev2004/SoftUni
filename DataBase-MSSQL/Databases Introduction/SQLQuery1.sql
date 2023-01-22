CREATE DATABASE Minions2023

USE Minions2023

CREATE TABLE Minions(
id INT NOT NULL PRIMARY KEY ,
[Name] NVARCHAR(125),
Age INT
);

CREATE TABLE Towns(
id INT NOT NULL PRIMARY KEY,
[Name] NVARCHAR(125),
);

ALTER TABLE Minions
ADD TownID INT

ALTER TABLE Minions
ADD CONSTRAINT FK_Town FOREIGN KEY (TownId) 	
REFERENCES Towns (Id)

INSERT INTO Towns
	(Id, [Name])
VALUES 
	(1, 'Sofia'),
    (2, 'Plovdiv'),
    (3, 'Varna');

INSERT INTO Minions 
	(Id,[Name], Age, TownId)
VALUES 
	(1, 'Kevin', 22, 1),
    (2, 'Bob', 15, 3),
	(3, 'Steward', NULL, 2);

TRUNCATE TABLE Minions

DROP TABLE Minions

DROP TABLE Towns



CREATE TABLE People(
id INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(200) NOT NULL,
Picture image,
Height float(2) NOT NULL,
[Weight] float(2) NOT NULL,
[Gender] CHAR(1) NOT NULL,
[Birthdate] date NOT NULL,
[Biography] NVARCHAR(MAX) NULL
);

INSERT INTO People 
	([Name], Picture, Height,[Weight],[Gender], [Birthdate],[Biography])
VALUES 
	('SilakLasovRespektanski',Null,6.90,42.05,'m','2000-09-22',Null),
	('Stefan',Null,2.15,95.55,'m','1989-11-02',Null),
	('Ivailo',Null,1.55,33.00,'m','2010-04-11',Null),
	('MesopotamskaKaterica',Null,2.15,55.55,'f','2021-11-11',Null),
	('Skalichkata',Null,1.85,90.00,'m','1983-07-22',Null);

CREATE TABLE Users(
id INT PRIMARY KEY IDENTITY(1,1),
[UserName] VARCHAR(30) NOT NULL,
[Password] VARCHAR(26) NOT NULL,
[ProfilePicture] VARBINARY(MAX),
[LastLoginTime] DATETIME,
IsDeleeted BIT
);

INSERT INTO Users 
	([UserName], [Password], [ProfilePicture],[LastLoginTime], IsDeleeted)
VALUES 
	('LinchTupoto','111222333',NULL,'2000-01-12',0),
	('LinchTupoto2','211222333',NULL,'2020-04-02',0),
	('LinchTupoto3','311222333',NULL,'2010-09-01',0),
	('LinchTupoto4','411222333',NULL,'1932-09-11',0),
	('LinchTupoto5','511222333',NULL,'2030-11-09',0);

ALTER TABLE Users
DROP CONSTRAINT PK__Users__3213E83F7569B082,

ALTER TABLE Users
ADD CONSTRAINT PK_Person PRIMARY KEY (ID,UserName);

ALTER TABLE Users
ADD CONSTRAINT CHK_PASSMINLEN CHECK (LEN([Password])>=5)

ALTER TABLE Users
ADD CONSTRAINT DEF_LLIDATE DEFAULT GETDATE() FOR [LastLoginTime];

ALTER TABLE Users
DROP CONSTRAINT PK_Person 

ALTER TABLE Users
ADD CONSTRAINT PK_Person PRIMARY KEY (ID);
 
ALTER TABLE Users
ADD CONSTRAINT UC_UserNameC UNIQUE (UserName);

