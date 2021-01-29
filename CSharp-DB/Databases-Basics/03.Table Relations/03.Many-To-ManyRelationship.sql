CREATE TABLE Students
(
	StudentID INT PRIMARY KEY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL
)

INSERT INTO Students
VALUES
(1, 'Mila') ,                                     
(2, 'Toni'),
(3, 'Ron')

CREATE TABLE Exams
(
	ExamID INT PRIMARY KEY NOT NULL,
	[Name] NVARCHAR(50)
)

INSERT INTO Exams
VALUES
(101, 'SpringMVC'),
(102, 'Neo4j'),
(103, 'Oracle 11g')


CREATE TABLE StudentsExams
(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	ExamID INT FOREIGN KEY REFERENCES Exams(ExamID)

	CONSTRAINT PK_Students_Exams PRIMARY KEY(StudentID, ExamID),
	CONSTRAINT FK_Students FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
	CONSTRAINT FK_Exams FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
)

INSERT INTO StudentsExams
VALUES
(1,	101),
(1,	102),
(2,	101),
(3,	103),
(2,	102),
(2,	103)