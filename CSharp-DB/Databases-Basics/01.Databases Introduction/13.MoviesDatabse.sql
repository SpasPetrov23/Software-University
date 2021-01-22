CREATE TABLE Directors
(
	Id INT PRIMARY KEY NOT NULL,
	DirectorName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Directors (Id, DirectorName, Notes)
VALUES
	(1, 'James Cameron', 'Director of Titanic, Aliens, Terminator and more.'),
	(2, 'George Lucas', 'Director of Star Wars.'),
	(3, 'Steven Spielberg', 'Director of Jaws, Jurassic Park, Saving Private Ryan and more.'),
	(4, 'Joss Whedon', NULL),
	(5, 'John Favreau', NULL)

CREATE TABLE Genres
(
	Id INT PRIMARY KEY NOT NULL,
	GenreName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Genres (Id, GenreName, Notes)
VALUES
	(1, 'Horror', 'Scary movies.'),
	(2, 'Sci-fi', NULL),
	(3, 'Action', 'Explosions.'),
	(4, 'Thriller', NULL),
	(5, 'Drama', 'Crying.')

CREATE TABLE Categories
(
	Id INT PRIMARY KEY NOT NULL,
	CategoryName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Categories(Id, CategoryName, Notes)
VALUES
	(1, 'Oscar Movies', 'Nominations included.'),
	(2, 'PG-13', NULL),
	(3, 'Classics', NULL),
	(4, '90s', NULL),
	(5, 'Hits', NULL)

CREATE TABLE Movies
(
	Id INT PRIMARY KEY NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id) NOT NULL,
	CopyrightYear SMALLINT,
	[Length] INT,
	GenreId INT FOREIGN KEY REFERENCES Genres(Id) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	Rating Float,
	Notes NVARCHAR(MAX)
)

INSERT INTO Movies
(Id, Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes)
VALUES
	(1, 'Star Wars: A New Hope', 2, 1977, 125, 2, 3, 8.7, 'A long time ago..'),
	(2, 'Jaws', 3, 1975, 120, 1, 1, 9.0, 'Scary..'),
	(3, 'Terminator', 1, 1984, 128, 2, 2, 9.0, 'Hes back.'),
	(4, 'Avengers', 4, 2012, 135, 3, 5, 8.2, 'Assemble.'),
	(5, 'Iron Man', 5, 2008, 132, 3, 5, 8.4, NULL)