SELECT [Akvarium_nazev],[Zakaznik].[Jmeno],[Zakaznik].[Prijmeni]
FROM [Akvarium]  
INNER JOIN [Zakaznik] ON [Akvarium].[Id_zakaznik] = [Zakaznik].[Id_Zakaznik]
ORDER BY [Akvarium_nazev];