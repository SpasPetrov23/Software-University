CREATE TABLE Categories
(
	Id INT PRIMARY KEY NOT NULL,
	CategoryName NVARCHAR(50) NOT NULL,
	DailyRate DECIMAL (10,2),
	WeeklyRate DECIMAL (10,2),
	MonthlyRate DECIMAL (10,2),
	WeekendRate DECIMAL (10,2)
)

INSERT INTO Categories (Id, CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
VALUES
	(1, 'Sports', 4.2, 3.4, 6.8, 2.0),
	(2, 'Luxury', 3.8, 2.5, 8.3, 2.4),
	(3, 'Family', 5.4, 3.1, 7.2, 3.0)


CREATE TABLE Cars
(
	Id INT PRIMARY KEY NOT NULL,
	PlateNumber SMALLINT,
	Manufacturer NVARCHAR (50),
	Model NVARCHAR (50) NOT NULL,
	CarYear DATETIME NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories (Id),
	Doors SMALLINT NOT NULL,
	Picture VARCHAR (MAX),
	Condition NVARCHAR (50),
	Available BIT NOT NULL
)

INSERT INTO Cars
(Id, PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available)
VALUES
	(1, 4866, 'Audi', 'A3', 2013, 1, 4, 'https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855', 'Good', 1),
	(2, 3152, 'Volkswagen', 'Golf', 2008, 3, 2, 'https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855', 'Average', 1),
	(3, 5162, 'BMW', 'X2', 2010, 2, 2, 'https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855', 'Very Good', 0)


CREATE TABLE Employees
(
	Id INT PRIMARY KEY NOT NULL,
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	Title VARCHAR(20),
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees (Id, FirstName,LastName,Title,Notes)
VALUES
	(1, 'Spas', 'Petrov', 'Designer', 'CEO'),
	(2, 'Nadya', 'Georgieva', NULL, NULL),
	(3, 'Vladislav', 'Vasev', 'Driver', NULL)

CREATE TABLE Customers
(
	Id INT PRIMARY KEY NOT NULL,
	DriverLicenseNumber SMALLINT NOT NULL,
	FullName NVARCHAR (50) NOT NULL,
	[Address] NVARCHAR (50),
	City NVARCHAR(50),
	ZIPCode SMALLINT,
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers (Id, DriverLicenseNumber, FullName, [Address], City, ZIPCode, Notes)
VALUES
	(1, 354, 'Martin Lazarov', 'Manastirski Livadi', 'Sofia', 2451, NULL),
	(2, 354, 'Lubomira Neycheva', 'Manastirski Livadi', 'Sofia', 2451, NULL),
	(3, 354, 'Evgeni Gechev', 'Bukston', 'Sofia', 1495, NULL)

CREATE TABLE RentalOrders
(
	Id INT PRIMARY KEY NOT NULL,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
	CarId INT FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
	TankLevel SMALLINT,
	KilometrageStart INT,
	KilometrageEnd INT,
	TotalKilometrage INT,
	StartDate DATETIME,
	EndDate DATETIME,
	TotalDays INT,
	RateApplied DECIMAL(10,2),
	TaxRate DECIMAL (10,2),
	OrderStatus BIT,
	Notes VARCHAR(MAX)
)

INSERT INTO RentalOrders (Id, EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart,
KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate,
OrderStatus, Notes)
VALUES
	(1, 2, 2, 1, 25, 49825, 52212, 52212, '01.10.2021', '01.24.2021', 5, 4.24, 1.24, 1, NULL),
	(2, 3, 1, 2, 25, 49825, 52212, 52212, '01.10.2021', '01.24.2021', 5, 4.24, 1.24, 1, NULL),
	(3, 1, 3, 3, 25, 49825, 52212, 52212, '01.10.2021', '01.24.2021', 5, 4.24, 1.24, 1, NULL)