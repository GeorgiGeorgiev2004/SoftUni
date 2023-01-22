CREATE DATABASE Movies

CREATE TABLE Directors(
id INT PRIMARY KEY IDENTITY(1,1),
DirectorName NVARCHAR(70) NOT NULL,
Notes TEXT);

CREATE TABLE Genres (
id INT PRIMARY KEY IDENTITY(1,1),
GenreName NVARCHAR(70) NOT NULL,
Notes TEXT);

CREATE TABLE Categories (
id INT PRIMARY KEY IDENTITY(1,1),
CategorieName NVARCHAR(70) NOT NULL,
Notes TEXT);

CREATE TABLE Movies  (
id INT PRIMARY KEY IDENTITY(1,1),
Title NVARCHAR(70) NOT NULL,
DirectorId INT NOT NULL,
CopyrightYear DATE NOT NULL,
Lenght FLOAT(2) NOT NULL,
GenreID INT NOT NULL,
CategoryId int NOT NULL,
Rating FLOAT(2) ,
Notes TEXT 
);

INSERT INTO Directors
	(DirectorName,Notes)
VALUES
	('MartinScorsesse',NULL),
	('DaivdRobbinson',NULL),
	('SteffKetsnitski',NULL),
	('KillianMbape',NULL),
	('MessiMessiMessiii',NULL);

INSERT INTO Categories
	(CategorieName,Notes)
VALUES
	('Historical',NULL),
	('Action',NULL),
	('Drama',NULL),
	('Horror',NULL),
	('Comedy',NULL);

INSERT INTO Genres
	(GenreName,Notes)
VALUES
	('Thriller',NULL),
	('Adventure',NULL),
	('Animated',NULL),
	('Vintage',NULL),
	('Romance',NULL);

INSERT INTO Movies
	(Title,DirectorId,CopyrightYear,Lenght,GenreID,CategoryId,Rating,Notes)
VALUES
	('Vikings',1,'2000-02-01',2.12,2,3,NUll,NULL),
	('TheWalkingDead',2,'1987-02-01',4.12,4,4,NUll,NULL),
	('Interstellar',4,'2013-09-15',1.80,1,2,NUll,NULL),
	('Vikings',1,'2010-02-21',2.12,5,1,NUll,NULL),
	('Vikings',1,'1823-05-14',2.12,4,3,NUll,NULL);