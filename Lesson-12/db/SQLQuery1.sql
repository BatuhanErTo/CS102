INSERT INTO Ogrenciler VALUES ('Pelin','Korkmaz','05417672677','Beylerbeyi');

INSERT INTO Ogrenciler(OgrAdi,OgrSoyadi,Telefon,Adress) VALUES ('Ömer','Demir','05478549342','Beykoz');

INSERT INTO Ogrenciler VALUES ('Mert','Kara','05485745','Uskudar')

INSERT INTO Notlar VALUES (329,'A101',100,75);
INSERT INTO Notlar VALUES (329,'B101',75,87);
INSERT INTO Notlar VALUES (330,'A101',98,41);
INSERT INTO Notlar VALUES (330,'B101',100,100);

UPDATE Notlar SET Final = Final + 5 where OgrNo = 329;
UPDATE Notlar SET Vize = Vize - 5 where OgrNo = 330;

DELETE FROM Ogrenciler WHERE OgrAdi = 'Mert';

SELECT OgrNo,Telefon from Ogrenciler where OgrAdi = 'Pelin';
SELECT Vize,Final from Notlar where OgrNo = 330 AND DersKodu = 'B101';

SELECT OgrNo,Vize,Final,(Vize*0.4+Final*0.6) AS Ortalama From Notlar ORDER BY Ortalama ASC;

SELECT OgrNo,(Vize*0.4+Final*0.6) AS Ortalama From Notlar WHERE (Vize*0.4+Final*0.6) > 75 ORDER BY Ortalama ASC;

SELECT Ogrenciler.OgrNo,OgrAdi,OgrSoyadi,(Vize*0.4+Final*0.6) AS Ortalama FROM Notlar INNER JOIN Ogrenciler ON Notlar.OgrNo = Ogrenciler.OgrNo;

SELECT AVG(Vize) from Notlar where DersKodu = 'A101';

SELECT COUNT(*) FROM Notlar WHERE Final > 70;

SELECT OgrNo, avg(Vize*0.4+Final*0.6) AS AVERAGE from Notlar GROUP BY OgrNo HAVING avg(Vize*0.4+Final*0.6) > 75

SELECT Notlar.OgrNo, SUM((Vize*0.4+Final*0.6)*Kredi)/SUM(Kredi) FROM Notlar INNER JOIN Dersler ON Dersler.DersKodu = Notlar.DersKodu GROUP BY OgrNo 

SELECT DersKodu, AVG(Vize*0.4+Final*0.6) AS DERS_ORT FROM Notlar GROUP BY DersKodu HAVING AVG(Vize*0.4+Final*0.6) > 60; 

