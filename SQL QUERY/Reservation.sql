USE CinemaReservation

IF OBJECT_ID(N'Reservation', 'U') IS NOT NULL
	DROP TABLE dbo.Reservation;

CREATE TABLE Reservation (
	DBkey				INT IDENTITY(1,1),
	DBkeyPerson			INT NOT NULL,
	DataOfReservation	DATE NULL DEFAULT (GETDATE()),
	Discount			INT DEFAULT 0,
	DBKeyMovieInCinema		INT NOT NULL,
	CONSTRAINT PK_Reservation PRIMARY KEY (DBKey),
	CONSTRAINT FK_Reservation_Person FOREIGN KEY (DBkeyPerson) REFERENCES Person (DBKey),
	CONSTRAINT FK_Reservation_MovieInCinema FOREIGN KEY (DBKeyMovieInCinema) REFERENCES MoviesInCinema (DBKey)
)
GO

INSERT Reservation (DBkeyPerson) VALUES (2)

SELECT * FROM Reservation 