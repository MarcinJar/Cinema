CREATE PROCEDURE person_add (
	@Name NVARCHAR(200),
	@Surname NVARCHAR(200),
	@DateOfBirth DATE,
	@Discount INT,
	@Login NVARCHAR(200),
	@Password NVARCHAR(200)
)
AS
BEGIN
	INSERT INTO dbo.Persons(
		Name, 
		Surname, 
		DateOfBirth, 
		Discount, 
		Login, 
		Password
	)
	VALUES(
		@Name,
		@Surname,
		@DateOfBirth,
		@Discount,
		@Login,
		@Password
	)
END