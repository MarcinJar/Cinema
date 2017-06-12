CREATE PROCEDURE person_del (
	@DBKey INT
)
AS 
BEGIN
	DELETE dbo.Persons WHERE DBKey = @DBKey
END