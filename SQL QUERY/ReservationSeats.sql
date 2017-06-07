USE CinemaReservation

IF OBJECT_ID(N'ReservationSeats', 'U') IS NOT NULL
	DROP TABLE dbo.ReservationSeats;

CREATE TABLE ReservationSeats (
	DBKey				INT IDENTITY(1,1),
	DBKeyReservation	INT NOT NULL,
	DBKeySeat			INT NOT NULL,
	CONSTRAINT PK_ResrevationSeats PRIMARY KEY (DBKey),
	CONSTRAINT FK_ReservationSeats_Reservation FOREIGN KEY (DBKeyReservation) REFERENCES Reservations (DBKey),
	CONSTRAINT FK_ReservationSeats_Seats FOREIGN KEY (DBKeySeat) REFERENCES Seats (DBKey)
)