USE CinemaReservation

IF OBJECT_ID(N'FilmShows', 'U') IS NOT NULL
	DROP TABLE dbo.FilmShows;

CREATE TABLE FilmShows (
	DBKey				INT IDENTITY(1,1),
	DateOfFilmShow		DATE NOT NULL,
	DisplayMode			VARCHAR DEFAULT ('Lector'),
	DisplayKind			BIT DEFAULT (0),
	PriceOfTicket		DECIMAL NOT NULL,
	DBKeyCinemaRooms	INT NOT NULL,
	DBKeyMovies			INT NOT NULL,
	CONSTRAINT PK_FilmShows PRIMARY KEY (DBKey),
	CONSTRAINT FK_FilmShows_CinemaRooms FOREIGN KEY (DBKeyCinemaRooms) REFERENCES CinemaRooms (DBKey),
	CONSTRAINT FK_FilmShows_Movies FOREIGN KEY (DBKeyMovies) REFERENCES Movies (DBKey)
)