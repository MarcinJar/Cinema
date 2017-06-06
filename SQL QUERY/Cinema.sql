USE CinemaReservation

IF OBJECT_ID(N'dbo.Cinema', 'U') IS NOT NULL
	DROP TABLE dbo.Cinema;

CREATE TABLE Cinema (
	DBKey					INT IDENTITY(1,1),
	[Name]					NVARCHAR(200) NOT NULL,
	NumberOfSeats			INT NOT NULL DEFAULT 60,
	NumberOfReservedSeats	INT NOT NULL DEFAULT 0,
	CONSTRAINT PK_Cinema PRIMARY KEY (DBKey)
)
GO

INSERT Cinema (Name, NumberOfSeats) VALUES ('Sala D', 87) 
GO

SELECT * FROM Cinema
GO