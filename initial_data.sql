USE [WineCellar]
GO
SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT TOP 1 Name FROM Countries)
BEGIN
    SET IDENTITY_INSERT [Countries] ON

    INSERT INTO Countries([Id], [Name], [Created], [CreatedBy])
    VALUES
        (1, 'Argentina', GETDATE(), 'SEEDING'),
        (2, 'Australia', GETDATE(), 'SEEDING'),
        (3, 'Austria', GETDATE(), 'SEEDING'),
        (4, 'Belgium', GETDATE(), 'SEEDING'),
        (5, 'Chile', GETDATE(), 'SEEDING'),
        (6, 'France', GETDATE(), 'SEEDING'),
        (7, 'Germany', GETDATE(), 'SEEDING'),
        (8, 'Greece', GETDATE(), 'SEEDING'),
        (9, 'Hungary', GETDATE(), 'SEEDING'),
        (10, 'Italy', GETDATE(), 'SEEDING'),
        (11, 'New Zealand', GETDATE(), 'SEEDING'),
        (12, 'Portugal', GETDATE(), 'SEEDING'),
        (13, 'South Africa', GETDATE(), 'SEEDING'),
        (14, 'Spain', GETDATE(), 'SEEDING'),
        (15, 'United States', GETDATE(), 'SEEDING')

    SET IDENTITY_INSERT [Countries] OFF

    INSERT INTO Regions([CountryId], [Name], [Created], [CreatedBy])
    VALUES
        -- Argentina
        (1, 'Salta', GETDATE(), 'SEEDING'),
        (1, 'Tucamán', GETDATE(), 'SEEDING'),
        (1, 'Catamarca', GETDATE(), 'SEEDING'),
        (1, 'La Rioja', GETDATE(), 'SEEDING'),
        (1, 'San Juan', GETDATE(), 'SEEDING'),
        (1, 'Mendoza', GETDATE(), 'SEEDING'),
        (1, 'Patagonia', GETDATE(), 'SEEDING'),

        -- Australia
        (2, 'Western Australia', GETDATE(), 'SEEDING'),
        (2, 'South Australia', GETDATE(), 'SEEDING'),
        (2, 'New South Wales', GETDATE(), 'SEEDING'),
        (2, 'Victoria', GETDATE(), 'SEEDING'),
        (2, 'Tasmania', GETDATE(), 'SEEDING'),
        (2, 'Queensland', GETDATE(), 'SEEDING'),

        -- Austria
        (3, 'Niederösterreich', GETDATE(), 'SEEDING'),
        (3, 'Burgenland', GETDATE(), 'SEEDING'),
        (3, 'Steiermark', GETDATE(), 'SEEDING'),
        (3, 'Wien', GETDATE(), 'SEEDING'),

        -- Belgium
        (4, 'Flanders', GETDATE(), 'SEEDING'),
        (4, 'Wallonia', GETDATE(), 'SEEDING'),

        -- Chile
        (5, 'Central Valley', GETDATE(), 'SEEDING'),
        (5, 'Aconcagua', GETDATE(), 'SEEDING'),
        (5, 'South Region', GETDATE(), 'SEEDING'),
        (5, 'Coquimbo', GETDATE(), 'SEEDING'),
        (5, 'Atacama', GETDATE(), 'SEEDING'),
        (5, 'Austral Region', GETDATE(), 'SEEDING'),

        -- France
        (6, 'Languadoc-Roussillon', GETDATE(), 'SEEDING'),
        (6, 'Rhône Valley', GETDATE(), 'SEEDING'),
        (6, 'Bordeaux', GETDATE(), 'SEEDING'),
        (6, 'Provence', GETDATE(), 'SEEDING'),
        (6, 'Loire Valley', GETDATE(), 'SEEDING'),
        (6, 'South-West', GETDATE(), 'SEEDING'),
        (6, 'Burgundy', GETDATE(), 'SEEDING'),
        (6, 'Champagne', GETDATE(), 'SEEDING'),
        (6, 'Alsace', GETDATE(), 'SEEDING'),
        (6, 'Beaujolais', GETDATE(), 'SEEDING'),
        (6, 'Corsica', GETDATE(), 'SEEDING'),

        -- Germany
        (7, 'Ahr', GETDATE(), 'SEEDING'),
        (7, 'Mosel', GETDATE(), 'SEEDING'),
        (7, 'Nahe', GETDATE(), 'SEEDING'),
        (7, 'Pfalz', GETDATE(), 'SEEDING'),
        (7, 'Baden', GETDATE(), 'SEEDING'),
        (7, 'Mittelrhein', GETDATE(), 'SEEDING'),
        (7, 'Rheingan', GETDATE(), 'SEEDING'),
        (7, 'Rheinhessen', GETDATE(), 'SEEDING'),
        (7, 'Hessische Bergstrasse', GETDATE(), 'SEEDING'),
        (7, 'Würtemberg', GETDATE(), 'SEEDING'),
        (7, 'Franken', GETDATE(), 'SEEDING'),
        (7, 'Saale-Unstrut', GETDATE(), 'SEEDING'),
        (7, 'Sachsen', GETDATE(), 'SEEDING'),

        -- Greece
        (8, 'Southern Greece', GETDATE(), 'SEEDING'),
        (8, 'Crete', GETDATE(), 'SEEDING'),
        (8, 'Central Greece', GETDATE(), 'SEEDING'),
        (8, 'Aegean Islands', GETDATE(), 'SEEDING'),
        (8, 'Macedonia', GETDATE(), 'SEEDING'),

        -- Hungary
        (9, 'Badacsony', GETDATE(), 'SEEDING'),
        (9, 'Balatonboglár', GETDATE(), 'SEEDING'),
        (9, 'Villány', GETDATE(), 'SEEDING'),
        (9, 'Szekszárd', GETDATE(), 'SEEDING'),
        (9, 'Balatonfüred-Csopak', GETDATE(), 'SEEDING'),
        (9, 'Mátra', GETDATE(), 'SEEDING'),
        (9, 'Tokaj', GETDATE(), 'SEEDING'),
        (9, 'Eger', GETDATE(), 'SEEDING'),
        (9, 'Etyek-Buda', GETDATE(), 'SEEDING'),
        (9, 'Pannonhalma', GETDATE(), 'SEEDING'),
        (9, 'Sopron', GETDATE(), 'SEEDING'),
        (9, 'Nagy-Somló', GETDATE(), 'SEEDING'),

        -- Italy
        (10, 'Sicily', GETDATE(), 'SEEDING'),
        (10, 'Puglia', GETDATE(), 'SEEDING'),
        (10, 'Veneto', GETDATE(), 'SEEDING'),
        (10, 'Tuscany', GETDATE(), 'SEEDING'),
        (10, 'Emilia-Romagna', GETDATE(), 'SEEDING'),
        (10, 'Piedmont', GETDATE(), 'SEEDING'),
        (10, 'Abruzzo', GETDATE(), 'SEEDING'),
        (10, 'Lombardy', GETDATE(), 'SEEDING'),
        (10, 'Friuli-Venesia Giulia', GETDATE(), 'SEEDING'),
        (10, 'Sardegna', GETDATE(), 'SEEDING'),
        (10, 'Lazio', GETDATE(), 'SEEDING'),
        (10, 'Umbria', GETDATE(), 'SEEDING'),
        (10, 'Trentino - Alto Adige', GETDATE(), 'SEEDING'),

        -- New Zealand
        (11, 'Northland', GETDATE(), 'SEEDING'),
        (11, 'Waikato / Bay Of Plenty', GETDATE(), 'SEEDING'),
        (11, 'Gisborne', GETDATE(), 'SEEDING'),
        (11, 'Wairarapa', GETDATE(), 'SEEDING'),
        (11, 'Marlborough', GETDATE(), 'SEEDING'),
        (11, 'Caterbury and Waipara', GETDATE(), 'SEEDING'),
        (11, 'Central Otago', GETDATE(), 'SEEDING'),
        (11, 'Nelson', GETDATE(), 'SEEDING'),
        (11, 'Hawke''s Bay', GETDATE(), 'SEEDING'),
        (11, 'Auckland', GETDATE(), 'SEEDING'),

        -- Portugal
        (12, 'Vinho Verde', GETDATE(), 'SEEDING'),
        (12, 'Dão', GETDATE(), 'SEEDING'),
        (12, 'Bairrada', GETDATE(), 'SEEDING'),
        (12, 'Lisboa', GETDATE(), 'SEEDING'),
        (12, 'Setúbal', GETDATE(), 'SEEDING'),
        (12, 'Madeira', GETDATE(), 'SEEDING'),
        (12, 'Algarve', GETDATE(), 'SEEDING'),
        (12, 'Alentejo', GETDATE(), 'SEEDING'),
        (12, 'Tejo', GETDATE(), 'SEEDING'),
        (12, 'Beira Interior', GETDATE(), 'SEEDING'),
        (12, 'Tavaro-Varosa', GETDATE(), 'SEEDING'),
        (12, 'Douro Valley', GETDATE(), 'SEEDING'),
        (12, 'Trás-os-Montes', GETDATE(), 'SEEDING'),

        -- South Africa
        (13, 'Olifants River', GETDATE(), 'SEEDING'),
        (13, 'Coastal Region', GETDATE(), 'SEEDING'),
        (13, 'Breede River Valley', GETDATE(), 'SEEDING'),
        (13, 'Northern Cape', GETDATE(), 'SEEDING'),
        (13, 'Klein Karoo', GETDATE(), 'SEEDING'),
        (13, 'Cape South Coast', GETDATE(), 'SEEDING'),

        -- Spain
        (14, 'Galicia', GETDATE(), 'SEEDING'),
        (14, 'Pais Vasco', GETDATE(), 'SEEDING'),
        (14, 'La Rioja', GETDATE(), 'SEEDING'),
        (14, 'Navarra', GETDATE(), 'SEEDING'),
        (14, 'Aragon', GETDATE(), 'SEEDING'),
        (14, 'Catalonia', GETDATE(), 'SEEDING'),
        (14, 'Majorca', GETDATE(), 'SEEDING'),
        (14, 'Valencia', GETDATE(), 'SEEDING'),
        (14, 'Castilla-La Mancha', GETDATE(), 'SEEDING'),
        (14, 'Castilla y León', GETDATE(), 'SEEDING'),
        (14, 'Extremadura', GETDATE(), 'SEEDING'),
        (14, 'Andalucía', GETDATE(), 'SEEDING'),
        (14, 'Canary Islands', GETDATE(), 'SEEDING'),

        -- United States
        (15, 'Oregon', GETDATE(), 'SEEDING'),
        (15, 'Washington', GETDATE(), 'SEEDING'),
        (15, 'Idaho', GETDATE(), 'SEEDING'),
        (15, 'California', GETDATE(), 'SEEDING'),
        (15, 'Colorado', GETDATE(), 'SEEDING'),
        (15, 'Arizona', GETDATE(), 'SEEDING'),
        (15, 'New Mexico', GETDATE(), 'SEEDING'),
        (15, 'Texas', GETDATE(), 'SEEDING'),
        (15, 'New York', GETDATE(), 'SEEDING'),
        (15, 'Midwest', GETDATE(), 'SEEDING'),
        (15, 'Southeast', GETDATE(), 'SEEDING'),
        (15, 'New Jersey', GETDATE(), 'SEEDING'),
        (15, 'Virginia', GETDATE(), 'SEEDING')

END
