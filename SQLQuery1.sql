/* SELECT [Akvarium_nazev],[Zakaznik].[Jmeno],[Zakaznik].[Prijmeni]
FROM [Akvarium]  
INNER JOIN [Zakaznik] ON [Akvarium].[Id_zakaznik] = [Zakaznik].[Id_Zakaznik]
ORDER BY [Akvarium_nazev];*/



SELECT [Akvarium].[Akvarium_nazev],[Ryba].[Ryba_nazev],[Obsah_akvaria].[Datum_prijeti],[Obsah_akvaria].[Datum_odebrani]
FROM [Obsah_akvaria]  
INNER JOIN [Ryba] ON [Obsah_akvaria].[Id_Ryba] = [Ryba].[Ryba_nazev]
ORDER BY [Akvarium_nazev];
