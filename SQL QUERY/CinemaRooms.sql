USE CinemaReservation

IF OBJECT_ID(N'dbo.CinemaRooms', 'U') IS NOT NULL 
	DROP TABLE dbo.CinemaRooms; 

CREATE TABLE CinemaRooms (
	DBKey		INT IDENTITY(1,1),
	DBKeyCinema	INT NOT NULL,
	[Name]		VARCHAR(200) NOT NULL,
	CONSTRAINT PK_CinemaRooms PRIMARY KEY (DBKey),
	CONSTRAINT PF_CinemaRooms_Cinemas FOREIGN KEY (DBKeyCinema) REFERENCES Cinemas (DBKEY)
)
GO