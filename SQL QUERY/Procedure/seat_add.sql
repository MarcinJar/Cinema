CREATE PROCEDURE seat_add (
	@RowNumber INT,
	@SeatNumber INT,
	@DBKeyCinemaRoom INT,
	@Reserved BIT
)
AS
BEGIN
	INSERT INTO dbo.Seats(
		RowNumber,
		SeatNumber,
		DBKeyCinemaRoom,
		Reserved 
	)
	VALUES(
		@RowNumber,
		@SeatNumber,
		@DBKeyCinemaRoom,
		@Reserved
	)
END