CREATE TABLE Employees
(
	Id INT PRIMARY KEY NOT NULL,
	FirstName NVARCHAR (20) NOT NULL,
	LastName NVARCHAR (20) NOT NULL,
	Title NVARCHAR (50),
	Notes NVARCHAR (MAX)
)

INSERT INTO Employees (Id, FirstName, LastName, Title, Notes)
VALUES
	(1, 'Spas', 'Petrov', 'CEO', NULL),
	(2, 'Stefan', 'Georgiev', 'Executive', NULL),
	(3, 'Georgi', 'Ivanov', 'Producer', NULL)

CREATE TABLE Customers
(
	AccountNumber INT PRIMARY KEY NOT NULL,
	FirstName NVARCHAR (20) NOT NULL,
	LastName NVARCHAR (20) NOT NULL,
	PhoneNumber INT,
	EmergencyName NVARCHAR (50),
	EmergencyNumber INT,
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers
(AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
VALUES
	(1, 'Nikolay', 'Sevliev', 0857264124, 'Sava', 0895662125, NULL),
	(2, 'Kristian', 'Kostov', 0582616523, 'Kris', 0998566212, NULL),
	(3, 'Ilia', 'Pavolv', 0872547213, 'Opet', 0895662125, NULL)

CREATE TABLE RoomStatus
(
	RoomStatus BIT NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO RoomStatus (RoomStatus, Notes)
VALUES
	(1, '321'),
	(0, '469'),
	(1, '984')

CREATE TABLE RoomTypes
(
	RoomType VARCHAR(50) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO RoomTypes (RoomType, Notes)
VALUES
	('Prestige', '321'),
	('Appartment', '469'),
	('Standard', NULL)

CREATE TABLE BedTypes
(
	BedType VARCHAR(50) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO BedTypes(BedType, Notes)
VALUES
	('Twin', '321'),
	('Single', '469'),
	('Twin', NULL)

CREATE TABLE Rooms
(
	RoomNumber INT PRIMARY KEY NOT NULL,
	RoomType VARCHAR(50) NOT NULL,
	BedType VARCHAR(50) NOT NULL,
	Rate DECIMAL (10,2) NOT NULL,
	RoomStatus BIT NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)
VALUES
	(234, 'Standard', 'Twin', 1.25, 0, NULL),
	(238, 'Luxury', 'Triple', 1.50, 1, NULL),
	(415, 'Appartment', 'Single', 1.75, 0, NULL)

CREATE TABLE Payments
(
	Id INT PRIMARY KEY NOT NULL,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	PaymentDate DATETIME NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers (AccountNumber) NOT NULL,
	FirstDateOccupied DATETIME,
	LastDateOccupied DATETIME,
	TotalDays DATETIME,
	AmountCharged DECIMAL (10, 2),
	TaxRate DECIMAL (10, 2),
	TaxAmount DECIMAL (10, 2),
	PaymentTotal DECIMAL (10, 2),
	Notes VARCHAR(MAX)
)

INSERT INTO Payments (Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied,
TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes)
VALUES
	(1, 1, '12.01.2021', 1, '12.01.2021', '12.01.2021', 1, 402.87, 1.25, 80.0, 420, NULL),
	(2, 2, '12.01.2021', 2, '12.01.2021', '12.01.2021', 2, 402.87, 1.25, 80.0, 420, NULL),
	(3, 3, '12.01.2021', 3, '12.01.2021', '12.01.2021', 3, 402.87, 1.25, 80.0, 420, NULL)

CREATE TABLE Occupancies
(
	Id INT PRIMARY KEY NOT NULL,
	EmployeeId INT NOT NULL,
	DateOccupied DATETIME,
	AccountNumber INT NOT NULL,
	RoomNumber INT NOT NULL,
	RateApplied DECIMAL(10,2) NOT NULL,
	PhoneCharge BIT,
	Notes VARCHAR(MAX)
)

INSERT INTO Occupancies (Id, EmployeeId, DateOccupied, AccountNumber,
RoomNumber, RateApplied, PhoneCharge, Notes)
VALUES
	(1, 1, '12.01.2021', 1, 100, 1.25, 0, NULL),
	(2, 2, '12.01.2021', 2, 200, 1.50, 1, NULL),
	(3, 3, '12.01.2021', 3, 300, 1.25, 0, NULL)