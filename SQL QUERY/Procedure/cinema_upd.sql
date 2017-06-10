CREATE PROCEDURE cinema_upd (
	@DBKey INT,
	@Name NVARCHAR(200),
	@City NVARCHAR(200),
	@Street NVARCHAR(200),
	@BuildNumber INT,
	@Apartment VARCHAR(20),
	@PostCode INT
)
AS 
BEGIN
	UPDATE dbo.cinemas 
	SET
		Name = @Name,
		City = @City,
		Street = @Street,
		BulidNumber = @BuildNumber,
		Apartments = @Apartment,
		PostCode = @PostCode
	WHERE
		DBKey = @DBKey
END