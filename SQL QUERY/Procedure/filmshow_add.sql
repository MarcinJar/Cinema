CREATE PROCEDURE filmshow_add (
	@DateOfFilmShow DATE,
	@DisplayMode VARCHAR(50),
	@DisplayKind BIT,
	@PriceOfTicket DECIMAL,
	@DBKeyCinemaRoom INT,
	@DBKeyMovie INT
)
AS
BEGIN
	INSERT INTO dbo.FilmShows(
		DateOfFilmShow, 
		DisplayMode, 
		DisplayKind, 
		PriceOfTicket, 
		DBKeyCinemaRooms,
		DBKeyMovies
	)
	VALUES(
		@DateOfFilmShow,
		@DisplayMode,
		@DisplayKind,
		@PriceOfTicket,
		@DBKeyCinemaRoom,
		@DBKeyMovie
	)
END