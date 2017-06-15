CREATE PROCEDURE seat_upd (
	@DBKey INT,
	@RowNumber INT,
	@SeatNumber INT,
	@DBKeyCinemaRoom INT,
	@Reserved BIT
)
AS 
BEGIN
	UPDATE dbo.Seats 
	SET
		RowNumber = @RowNumber,
		SeatNumber = @SeatNumber,
		DBKeyCinemaRoom = @DBKeyCinemaRoom,
		Reserved = @Reserved
	WHERE
		DBKey = @DBKey
END