CREATE TABLE Manufacturers
(
	ManufacturerID INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] NVARCHAR (20) NOT NULL,
	EstablishedOn DATETIME
)

INSERT INTO Manufacturers
VALUES
('BMW', '07/03/1916'),
('Tesla', '01/01/2003'),
('Lada', '01/05/1966')

CREATE TABLE Models
(
	ModelID INT PRIMARY KEY IDENTITY (100,1) NOT NULL,
	[Name] NVARCHAR(30) NOT NULL,
	ManufacturerID INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Models
VALUES
('X1', 1),
('i6', 1),
('Model S', 2),
('Model X', 2),
('Model 3', 2),
('Nova	3', 3)