CREATE PROCEDURE reservation_sel (
	@DBKey INT
)
AS
BEGIN
	SELECT * FROM dbo.Reservations WHERE DBKey = @DBKey;
END