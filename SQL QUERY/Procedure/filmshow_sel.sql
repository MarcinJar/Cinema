CREATE PROCEDURE filmshow_sel (
	@DBKey INT
)
AS
BEGIN
	SELECT * FROM dbo.FilmShows WHERE DBKey = @DBKey;
END
