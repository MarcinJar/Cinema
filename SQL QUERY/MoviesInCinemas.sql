USE CinemaReservation

IF OBJECT_ID('MoviesInCinemas', 'U') IS NOT NULL 
	BEGIN
		PRINT '1';
		DROP TABLE MoviesInCinemas;
	END
ELSE
	BEGIN
		PRINT '2';
END


CREATE TABLE MoviesInCinemas (
	DBKey	INT IDENTITY(1,1),
	DBKeyCinema		INT NOT NULL,
	DBKeyMovie		INT NOT NULL,
	PeriodOfPlay	DATE NULL,
	CONSTRAINT PK_MoviesInCinemas PRIMARY KEY (DBKey),
	CONSTRAINT FK_MoviesInCinemas_Cinemas FOREIGN KEY (DBKeyCinema) REFERENCES Cinemas (DBKey),
	CONSTRAINT FK_MoviesInCinemas_Movies FOREIGN KEY (DBKeyMovie) REFERENCES Movies (DBKey)
)
