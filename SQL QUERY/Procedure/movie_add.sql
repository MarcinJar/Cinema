CREATE PROCEDURE movie_add (
	@Name NVARCHAR(200),
	@Genre NVARCHAR(200),
	@AcceptableAge INT,
	@DurationTime INT,
	@Author VARCHAR(200),
	@Description VARCHAR(MAX)
)
AS
BEGIN
	INSERT INTO dbo.Movies(
		Name, 
		Genre, 
		AcceptableAge, 
		DurationTime, 
		Author, 
		Description
	)
	VALUES(
		@Name,
		@Genre,
		@AcceptableAge,
		@DurationTime,
		@Author,
		@Description
	)
END