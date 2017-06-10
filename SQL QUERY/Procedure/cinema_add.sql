CREATE PROCEDURE cinema_add (
	@Name NVARCHAR(200),
	@City NVARCHAR(200),
	@Street NVARCHAR(200),
	@BuildNumber INT,
	@Apartment VARCHAR(20),
	@PostCode INT
)
AS
BEGIN
	INSERT INTO dbo.Cinemas(
		Name, 
		City, 
		Street, 
		BulidNumber, 
		Apartments, 
		PostCode
	)
	VALUES(
		@Name,
		@City,
		@Street,
		@BuildNumber,
		@Apartment,
		@PostCode
	)
END