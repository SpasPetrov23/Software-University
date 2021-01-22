CREATE TABLE People
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR (200) NOT NULL,
	Picture VARBINARY(MAX) CHECK (DATALENGTH(Picture) <= 900*1024),
	Height FLOAT,
	[Weight] FLOAT,
	Gender Char(1) NOT NULL,
	Birthdate DATETIME NOT NULL,
	Biography NVARCHAR (MAX)
)
INSERT INTO People ([Name], Picture, Height, [Weight], Gender, Birthdate, Biography)
	VALUES
		('Spas Petrov', 100, 188, 61, 'm', '04-23-1993', 'Me.'),
		('Nadya Georgieva', 105, 165, 45, 'f', '01-06-1995', 'Gf.'),
		('Martin Lazarov', 110, 187, 70, 'm', '11-29-1993', 'Bfr.'),
		('Vladislav Vasev', 115, 180, 80, 'm', '07-25-1998', 'Son.'),
		('Lubomira Neycheva', 120, 160, 55, 'f', '08-02-1992', 'Mira.')