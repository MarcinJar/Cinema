CREATE PROCEDURE person_sel (
	@DBKey INT
)
AS
BEGIN
	SELECT * FROM dbo.Persons WHERE DBKey = @DBKey;
END