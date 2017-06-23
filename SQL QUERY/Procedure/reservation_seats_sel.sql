CREATE PROCEDURE [dbo].[reservation_seats_sel] (
	@DBKey INT
)
AS
BEGIN
	SELECT se.* FROM dbo.Seats se
	INNER JOIN dbo.ReservationSeats rese ON se.DBKey = rese.DBKeySeat 
	RIGHT JOIN dbo.Reservations re ON re.DBkey = rese.DBKeyReservation
END
GO