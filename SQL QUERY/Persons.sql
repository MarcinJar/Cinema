USE CinemaReservation

IF OBJECT_ID(N'dbo.Persons', 'U') IS NOT NULL
	DROP TABLE dbo.Persons;

CREATE TABLE Persons (
	DBKey			INT IDENTITY(1,1),
	[Name]			VARCHAR(200) NOT NULL,
	Surname			VARCHAR(200) NOT NULL,
	DateOfBirth		DATE NOT NULL,
	Discount		INT DEFAULT 0,
	[Login]			NVARCHAR(200) NULL,
	[Password]		NVARCHAR(200) NULL,
	CONSTRAINT PK_Persosns PRIMARY KEY (DBKey)
)
GO

--INSERT Persons (Name, Surname, DoceumentId, DateOfBirth) VALUES ('Wojtek', 'Zieliñski', 'SER990', '1994-11-10')

--SELECT * FROM Persons