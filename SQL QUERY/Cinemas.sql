USE CinemaReservation

IF OBJECT_ID(N'dbo.Cinemas', 'U') IS NOT NULL
	DROP TABLE dbo.Cinemas;

CREATE TABLE Cinemas (
	DBKey			INT IDENTITY(1,1),
	[Name]			NVARCHAR(200) NOT NULL,
	City			NVARCHAR(200) NOT NULL,
	Street			NVARCHAR(200) NOT NULL,
	BulidNumber		INT NOT NULL,
	Apartments		VARCHAR(20) NULL,
	PostCode		INT NOT NULL,
	CONSTRAINT PK_Cinemas PRIMARY KEY (DBKey)
)
GO

--INSERT Cinemas (Name, NumberOfSeats) VALUES ('Sala D', 87) 
--GO

--SELECT * FROM Cinemas
GO