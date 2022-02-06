/*SELECT [Akvarium_nazev],[Zakaznik].[Jmeno],[Zakaznik].[Prijmeni]
FROM [Akvarium]  
INNER JOIN [Zakaznik] ON [Akvarium].[Id_zakaznik] = [Zakaznik].[Id_Zakaznik]
ORDER BY [Akvarium_nazev];*/



/*SELECT [Ryba_nazev],[Akvarium_nazev],[Datum_pridani],[Datum_odebrani]
FROM [Obsah_akvaria]  
INNER JOIN [Ryba] ON [Obsah_akvaria].[Id_Ryba] = [Ryba].[Id_Ryba]
INNER JOIN [Akvarium] ON [Obsah_akvaria].[Id_akvarium] = [Akvarium].[Id_Akvarium];*/


/*SELECT [Ryba_nazev],Id_Akvarium
FROM [Obsah_akvaria],[Ryba] Where Id_Akvarium='1' AND [Obsah_akvaria].Id_Ryba=[Ryba].Id_Ryba; */

SELECT Vztah.Id_ryba_2
FROM Vztah, Ryba, Obsah_akvaria 
WHERE Id_Akvarium ='1' and Obsah_akvaria.Id_Ryba = Ryba.Id_Ryba and Ryba.Id_Ryba = Vztah.Id_ryba_1 and Vztah.Vztah = '0'; 

SELECT Ryba_nazev
FROM Ryba
WHERE Ryba.Id_ryba = (
SELECT TOP 1 Vztah.Id_ryba_2
FROM Vztah, Ryba, Obsah_akvaria 
WHERE Id_Akvarium ='1' and Obsah_akvaria.Id_Ryba = Ryba.Id_Ryba and Ryba.Id_Ryba = Vztah.Id_ryba_1 and Vztah.Vztah = '0');