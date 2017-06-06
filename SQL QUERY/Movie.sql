USE CinemaReservation

IF OBJECT_ID(N'dbo.Movie', 'U') IS NOT NULL 
	DROP TABLE dbo.Movie; 

CREATE TABLE Movie (
	DBKey				INT IDENTITY(1,1),
	[Name]				NVARCHAR(200) NOT NULL,
	Genre				NVARCHAR(200) NOT NULL,
	AcceptableAge		INT NOT NULL DEFAULT 3,
	DurationTime		INT NOT NULL,
	CONSTRAINT PK_Movie PRIMARY KEY (DBKey)
)
GO

INSERT INTO Movie (Name, Genre, DurationTime) VALUES ('Obcy', 'Horror', 210)
GO

SELECT * FROM Movie 
GO
