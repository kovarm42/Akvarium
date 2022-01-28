/* SELECT [Akvarium_nazev],[Zakaznik].[Jmeno],[Zakaznik].[Prijmeni]
FROM [Akvarium]  
INNER JOIN [Zakaznik] ON [Akvarium].[Id_zakaznik] = [Zakaznik].[Id_Zakaznik]
ORDER BY [Akvarium_nazev];



SELECT [Ryba_nazev],[Akvarium_nazev],[Datum_pridani],[Datum_odebrani]
FROM [Obsah_akvaria]  
INNER JOIN [Ryba] ON [Obsah_akvaria].[Id_Ryba] = [Ryba].[Id_Ryba]
INNER JOIN [Akvarium] ON [Obsah_akvaria].[Id_akvarium] = [Akvarium].[Id_Akvarium];*/


SELECT [Ryba_nazev],[Akvarium_nazev],[Datum_pridani],[Datum_odebrani]
FROM [Obsah_akvaria]  
INNER JOIN [Ryba] ON [Obsah_akvaria].[Id_Ryba] = [Ryba].[Id_Ryba]
INNER JOIN [Akvarium] ON [Obsah_akvaria].[Id_akvarium] = [Akvarium].[Id_Akvarium];

