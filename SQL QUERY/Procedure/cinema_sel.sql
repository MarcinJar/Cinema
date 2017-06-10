CREATE PROCEDURE cinema_sel (
	@DBKey INT
)
AS
BEGIN
	SELECT * FROM dbo.Cinemas WHERE DBKey = @DBKey;
END

--exec dbo.cinema_sel 1

--INSERT INTO Cinemas ([Name], City, Street, BulidNumber, PostCode) VALUES('Alfa', 'Bia³ystok', 'Nowa', 23, 44120)