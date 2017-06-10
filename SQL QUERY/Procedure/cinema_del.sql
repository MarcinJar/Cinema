CREATE PROCEDURE cinema_del (
	@DBKey INT
)
AS 
BEGIN
	DELETE dbo.cinemas WHERE DBKey = @DBKey
END