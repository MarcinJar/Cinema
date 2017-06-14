CREATE PROCEDURE reservation_upd (
	@DBKey INT,
	@DBKeyPerson INT,
	@DateOfReservation DATE,
	@DBKeyFilmShow INT
)
AS 
BEGIN
	UPDATE dbo.Reservations 
	SET
		DBkeyPerson = @DBKeyPerson,
		DataOfReservation = @DateOfReservation,
		DBKeyFilmShow = @DBKeyFilmShow
	WHERE
		DBKey = @DBKey
END