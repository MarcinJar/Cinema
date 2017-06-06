USE CinemaReservation

IF OBJECT_ID(N'dbo.Person', 'U') IS NOT NULL
	DROP TABLE dbo.Person;

CREATE TABLE Person (
	DBKey			INT IDENTITY(1,1),
	[Name]			VARCHAR(200) NOT NULL,
	Surname			VARCHAR(200) NOT NULL,
	DoceumentId		VARCHAR(100) NOT NULL,
	DateOfBirth		DATE NOT NULL,
	CONSTRAINT PK_Person Primary Key (DBKey)
)
GO

INSERT Person (Name, Surname, DoceumentId, DateOfBirth) VALUES ('Wojtek', 'Zieliñski', 'SER990', '1994-11-10')

SELECT * FROM Person