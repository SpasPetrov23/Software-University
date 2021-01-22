CREATE TABLE Users
(
	Id BIGINT PRIMARY KEY IDENTITY,
	Username VARCHAR (30) NOT NULL,
	[Password] VARCHAR (26) NOT NULL,
	ProfilePicture VARCHAR (MAX),
	LastLoginTime DATETIME,
	IsDeleted BIT
)
INSERT INTO Users(Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
VALUES
('Spas', 'TopPass23', 'https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855','12/1/2021', 0),
('Marto', 'TopPass29', 'https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855','08/1/2021', 0),
('Luba', 'TopPass02', 'https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855','02/11/2020', 0),
('Nade', 'GolqmProzorec', 'https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855','04/12/2019', 0),
('Vladis', 'TopPass25', 'https://www.hiveworkshop.com/data/avatars/m/186/186388.jpg?1605866855','12/1/2021', 0)