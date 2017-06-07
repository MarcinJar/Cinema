USE CinemaReservation

IF OBJECT_ID(N'Seats', 'U') IS NOT NULL
	DROP TABLE dbo.Seats;

CREATE TABLE Seats (
	DBKey			INT IDENTITY(1,1),
	RowNumber		INT NOT NULL,
	SeatNumber		INT NOT NULL,
	DBKeyCinemaRoom	INT NOT NULL,
	Reserved		BIT NOT NULL DEFAULT(0),
	CONSTRAINT PK_Seats PRIMARY KEY (DBKey),
	CONSTRAINT FK_Seats_CinemaRooms FOREIGN KEY (DBKeyCinemaRoom) REFERENCES CinemaRooms (DBKey)
)