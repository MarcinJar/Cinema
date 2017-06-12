CREATE PROCEDURE person_upd (
	@DBKey INT,
	@Name NVARCHAR(200),
	@Surname NVARCHAR(200),
	@DateOfBirth DATE,
	@Discount INT,
	@Login NVARCHAR(200),
	@Password NVARCHAR(200)
)
AS 
BEGIN
	UPDATE dbo.Persons 
	SET
		Name = @Name,
		Surname = @Surname,
		DateOfBirth = @DateOfBirth,
		Discount = @Discount,
		Login = @Login,
		Password = @Password
	WHERE
		DBKey = @DBKey
END