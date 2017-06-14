CREATE PROCEDURE reservation_del (
	@DBKey INT
)
AS 
BEGIN
	DELETE dbo.Reservations WHERE DBKey = @DBKey
END