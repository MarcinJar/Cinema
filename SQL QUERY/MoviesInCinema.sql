USE CinemaReservation

IF OBJECT_ID('MoviesInCinema', 'U') IS NOT NULL 
	BEGIN
		PRINT '1';
		DROP TABLE MoviesInCinema;
	END
ELSE
	BEGIN
		PRINT '2';
END


CREATE TABLE MoviesInCinema (
	DBKey	INT IDENTITY(1,1),
	DBKeyCinema		INT,
	DBKeyMovie		INT,
	PeriodOfPlay	DATE NOT NULL,
	CONSTRAINT PK_MoviesInCinema PRIMARY KEY (DBKey),
	CONSTRAINT FK_MoviesInCinema_Cinema FOREIGN KEY (DBKeyCinema) REFERENCES Cinema (DBKey),
	CONSTRAINT FK_MoviesInCinema_Movie FOREIGN KEY (DBKeyMovie) REFERENCES Movie (DBKey)
)
