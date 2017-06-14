CREATE PROCEDURE restervation_add (
	@DBKeyPerson INT,
	@DateOfReservation DATE,
	@DBKeyFilmShow INT
)
AS
BEGIN
	INSERT INTO dbo.Reservations(
		DBkeyPerson,
		DataOfReservation,
		DBKeyFilmShow
	)
	VALUES(
		@DBKeyPerson,
		@DateOfReservation,
		@DBKeyFilmShow
	)
END
GO