--INSERT Reservation (DBkeyPerson, DataOfReservation) VALUES (3, '2017-07-24')
SELECT * FROM Reservation 


INSERT Person (Name, Surname, DoceumentId, DateOfBirth) VALUES ('Anna', 'Tesla', 'IUB762', '1993-02-22')
INSERT Person (Name, Surname, DoceumentId, DateOfBirth) VALUES ('Tomasz', 'Kempa', 'ZTR561', '1990-07-12')
INSERT Person (Name, Surname, DoceumentId, DateOfBirth) VALUES ('Alicja', 'Wojszkun', 'REH743', '1966-05-15')
INSERT Person (Name, Surname, DoceumentId, DateOfBirth) VALUES ('Darjusz', 'Nela', 'UJM982', '1991-02-21')
SELECT * FROM Person


SELECT pr.DBKey AS 'PersonDBkey', re.DBKey AS 'ReservationDBkey', pr.Name, pr.Surname, re.DataOfReservation 
FROM Person pr 
FULL JOIN Reservation re ON pr.DBKey = re.DBKeyPerson