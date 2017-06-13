CREATE PROCEDURE filmshow_upd (
	@DBKey INT,
	@DateOfFilmShow DATE,
	@DisplayMode VARCHAR(50),
	@DisplayKind BIT,
	@PriceOfTicket DECIMAL,
	@DBKeyCinemaRoom INT,
	@DBKeyMovie INT
)
AS 
BEGIN
	UPDATE dbo.FilmShows 
	SET
		DateOfFilmShow = @DateOfFilmShow,
		DisplayMode = @DisplayMode,
		DisplayKind = @DisplayKind,
		PriceOfTicket = @PriceOfTicket,
		DBKeyCinemaRooms = @DBKeyCinemaRoom,
		DBKeyMovies = @DBKeyMovie
	WHERE
		DBKey = @DBKey
END