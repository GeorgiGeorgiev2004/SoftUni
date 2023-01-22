CREATE TABLE Majors(
MajorID INT PRIMARY KEY,
[Name] NVARCHAR(50)
);

CREATE TABLE Students(
StudentID INT PRIMARY KEY,
StudentNumber INT,
[StudentName] NVARCHAR(50),
MajorID INT,
CONSTRAINT FK_Students_Majors
FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)
);

CREATE TABLE Payments(
PaymentID INT PRIMARY KEY,
PaymentDate DATE,
PaymentAmmount DECIMAL(28,2),
StudentID INT,
CONSTRAINT FK_Payments_Student
FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);

CREATE TABLE Subjects(
SubjectID INT PRIMARY KEY,
[SubjectName] NVARCHAR(50)
);

CREATE TABLE Agenda(
StudentID INT,
SubjectID INT,
CONSTRAINT Double_Key_SandS
PRIMARY KEY (StudentID,SubjectID),
CONSTRAINT FK_Agenda_Student
FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
CONSTRAINT FK_Agenda_Sunjects
FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
);