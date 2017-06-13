CREATE PROCEDURE filmshow_del (
	@DBKey INT
)
AS 
BEGIN
	DELETE dbo.FilmShows WHERE DBKey = @DBKey
END