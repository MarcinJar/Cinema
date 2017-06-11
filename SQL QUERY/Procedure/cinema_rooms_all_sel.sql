CREATE PROCEDURE cinema_rooms_all_sel (
	@DBKeyCinema INT
)
AS
BEGIN
	SELECT * FROM dbo.CinemaRooms WHERE DBKeyCinema = @DBKeyCinema
END

--SELECT * FROM Movies
--SELECT * FROM Cinemas
--SELECT * FROM CinemaRooms

----INSERT Movies(AcceptableAge, Author, DurationTime, Genre, Name) VALUES(18, 'Sdas', 145, 'Horror', 'gtr')
--INSERT CinemaRooms(DBKeyCinema, Name) VALUES(1, 'DRd4')

--DECLARE @DBkey INT
--SET @DBkey = 1;


