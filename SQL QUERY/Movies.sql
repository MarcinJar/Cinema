USE CinemaReservation

IF OBJECT_ID(N'dbo.Movies', 'U') IS NOT NULL 
	DROP TABLE dbo.Movies; 

CREATE TABLE Movies (
	DBKey				INT IDENTITY(1,1),
	[Name]				NVARCHAR(200) NOT NULL,
	Genre				NVARCHAR(200) NOT NULL,
	AcceptableAge		INT NOT NULL DEFAULT 3,
	DurationTime		INT NOT NULL,
	Author				NVARCHAR(200) NOT NULL,
	[Description]		NVARCHAR(MAX) NULL,
	CONSTRAINT PK_Movies PRIMARY KEY (DBKey)
)
GO

--INSERT INTO Movies (Name, Genre, DurationTime) VALUES ('Obcy', 'Horror', 210)
--GO

--SELECT * FROM Movies 
--GO
