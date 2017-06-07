USE CinemaReservation

IF OBJECT_ID(N'Reservations', 'U') IS NOT NULL
	DROP TABLE dbo.Reservations;

CREATE TABLE Reservations (
	DBkey				INT IDENTITY(1,1),
	DBkeyPerson			INT NOT NULL,
	DataOfReservation	DATE NULL DEFAULT (GETDATE()),
	DBKeyFilmShow		INT NOT NULL,
	CONSTRAINT PK_Reservations PRIMARY KEY (DBKey),
	CONSTRAINT FK_Reservation_Persons FOREIGN KEY (DBkeyPerson) REFERENCES Persons (DBKey),
	CONSTRAINT FK_Reservation_FilmShows FOREIGN KEY (DBKeyFilmShow) REFERENCES FilmShows (DBKey)
)
GO
