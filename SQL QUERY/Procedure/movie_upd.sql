CREATE PROCEDURE movie_upd (
	@DBKey INT,
	@Name NVARCHAR(200),
	@Genre NVARCHAR(200),
	@AcceptableAge INT,
	@DurationTime INT,
	@Author VARCHAR(200),
	@Description VARCHAR(MAX)
)
AS
BEGIN
	UPDATE dbo.Movies
		SET Name = @Name, 
			Genre = @Genre, 
			AcceptableAge = @AcceptableAge, 
			DurationTime = @DurationTime, 
			Author = @Author, 
			Description = @Description
	WHERE DBKey = @DBKey
END