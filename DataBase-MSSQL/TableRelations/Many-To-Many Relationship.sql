CREATE TABLE Students(
StudentID INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(34)
);

CREATE TABLE Exams(
ExamID INT PRIMARY KEY IDENTITY(101,1),
[Name] NVARCHAR(50)
);

CREATE TABLE StudentsExams(
StudentID INT,
ExamID INT,
CONSTRAINT PK_StudentsExamsId
PRIMARY KEY (StudentID,ExamID),
CONSTRAINT FK_Student_StudentExams 
FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
CONSTRAINT FK_Exams_StudentExams 
FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)

);

INSERT INTO Students
VALUES
	('Mila'),
	('Toni'),
	('Ron')

INSERT INTO Exams
VALUES
	('SpringMVC'),
	('Neo4j'),
	('Oracle 11g')

INSERT INTO StudentsExams
	(StudentID,ExamID)
VALUES
	(1,101),
	(1,102),
	(2,101),
	(3,103),
	(2,102),
	(2,103)