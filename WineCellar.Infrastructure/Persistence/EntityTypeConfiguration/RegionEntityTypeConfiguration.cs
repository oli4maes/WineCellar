using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WineCellar.Infrastructure.Persistence.EntityTypeConfiguration;

public class RegionEntityTypeConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("Regions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(250);

        builder.HasData(
            // Argentina Id 1
            new Region { Id = 1, Name = "Salta", CountryId = 1, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 2, Name = "Tucamán", CountryId = 1, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 3, Name = "Catamarca", CountryId = 1, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 4, Name = "La Rioja", CountryId = 1, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 5, Name = "San Juan", CountryId = 1, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 6, Name = "Mendoza", CountryId = 1, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 7, Name = "Patagonia", CountryId = 1, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // Australia Id 2
            new Region
            {
                Id = 8, Name = "Western Australia", CountryId = 2, Created = DateTime.UtcNow, CreatedBy = "Seeding"
            },
            new Region
                { Id = 9, Name = "South Australia", CountryId = 2, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 10, Name = "New South Wales", CountryId = 2, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 11, Name = "Victoria", CountryId = 2, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 12, Name = "Tasmania", CountryId = 2, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 13, Name = "Queensland", CountryId = 2, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // Austria Id 3
            new Region
                { Id = 14, Name = "Niederösterreich", CountryId = 3, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 15, Name = "Burgenland", CountryId = 3, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 16, Name = "Steiermark", CountryId = 3, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 17, Name = "Wien", CountryId = 3, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // Belgium Id 4
            new Region
                { Id = 18, Name = "Flanders", CountryId = 4, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 19, Name = "Wallonia", CountryId = 4, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // Chile Id 5
            new Region
                { Id = 20, Name = "Central Valley", CountryId = 5, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 21, Name = "Aconcagua", CountryId = 5, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 22, Name = "South Region", CountryId = 5, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 23, Name = "Coquimbo", CountryId = 5, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 24, Name = "Atacama", CountryId = 5, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 25, Name = "Austral Region", CountryId = 5, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // France Id 6
            new Region
            {
                Id = 26, Name = "Languadoc-Roussillon", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding"
            },
            new Region
                { Id = 27, Name = "Rhône Valley", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 28, Name = "Bordeaux", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 29, Name = "Provence", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 30, Name = "Loire Valley", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 31, Name = "South-West", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 32, Name = "Burgundy", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 33, Name = "Champagne", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 34, Name = "Alsace", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 35, Name = "Beaujolais", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 36, Name = "Corsica", CountryId = 6, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // Germany Id 7
            new Region { Id = 37, Name = "Ahr", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 38, Name = "Mosel", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 39, Name = "Nahe", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 40, Name = "Pfalz", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 41, Name = "Baden", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 42, Name = "Mittelrhein", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 43, Name = "Rheingan", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 44, Name = "Rheinhessen", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
            {
                Id = 45, Name = "Hessische Bergstrasse", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding"
            },
            new Region
                { Id = 46, Name = "Würtemberg", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 47, Name = "Franken", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 48, Name = "Saale-Unstrut", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 49, Name = "Sachsen", CountryId = 7, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // Greece Id 8
            new Region
                { Id = 50, Name = "Southern Greece", CountryId = 8, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 51, Name = "Crete", CountryId = 8, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 52, Name = "Central Greece", CountryId = 8, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 53, Name = "Aegean Islands", CountryId = 8, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 54, Name = "Macedonia", CountryId = 8, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // Hungary Id 9
            new Region
                { Id = 55, Name = "Badacsony", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 56, Name = "Balatonboglár", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 57, Name = "Villány", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 58, Name = "Szekszárd", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
            {
                Id = 59, Name = "Balatonfüred-Csopak", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding"
            },
            new Region { Id = 60, Name = "Mátra", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 61, Name = "Tokaj", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 62, Name = "Eger", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 63, Name = "Etyek-Buda", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 64, Name = "Pannonhalma", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 65, Name = "Sopron", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 67, Name = "Nagy-Somló", CountryId = 9, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // Italy Id 10
            new Region { Id = 68, Name = "Sicily", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 69, Name = "Puglia", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 70, Name = "Veneto", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 71, Name = "Tuscany", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 72, Name = "Emilia-Romagna", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 73, Name = "Piedmont", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 74, Name = "Abruzzo", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 75, Name = "Lombardy", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
            {
                Id = 76, Name = "Friuli-Venesia Giulia", CountryId = 10, Created = DateTime.UtcNow,
                CreatedBy = "Seeding"
            },
            new Region
                { Id = 77, Name = "Sardegna", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 78, Name = "Lazio", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 79, Name = "Umbria", CountryId = 10, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // New Zealand Id 11
            new Region
                { Id = 80, Name = "Northland", CountryId = 11, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
            {
                Id = 81, Name = "Waikato / Bay Of Plenty", CountryId = 11, Created = DateTime.UtcNow,
                CreatedBy = "Seeding"
            },
            new Region
                { Id = 82, Name = "Gisborne", CountryId = 11, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 83, Name = "Wairarapa", CountryId = 11, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 84, Name = "Marlborough", CountryId = 11, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
            {
                Id = 85, Name = "Caterbury and Waipara", CountryId = 11, Created = DateTime.UtcNow,
                CreatedBy = "Seeding"
            },
            new Region
                { Id = 86, Name = "Central Otago", CountryId = 11, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 87, Name = "Nelson", CountryId = 11, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 88, Name = "Hawke's Bay", CountryId = 11, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 89, Name = "Auckland", CountryId = 11, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // Portugal Id 12
            new Region
                { Id = 90, Name = "Vinho Verde", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 91, Name = "Dão", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 92, Name = "Bairrada", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 93, Name = "Lisboa", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 94, Name = "Setúbal", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 95, Name = "Madeira", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 96, Name = "Algarve", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 97, Name = "Alentejo", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 98, Name = "Tejo", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 99, Name = "Beira Interior", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 100, Name = "Tavaro-Varosa", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 101, Name = "Douro Valley", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 102, Name = "Trás-os-Montes", CountryId = 12, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // South Africa Id 13
            new Region
                { Id = 103, Name = "Olifants River", CountryId = 13, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 104, Name = "Coastal Region", CountryId = 13, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
            {
                Id = 105, Name = "Breede River Valley", CountryId = 13, Created = DateTime.UtcNow, CreatedBy = "Seeding"
            },
            new Region
                { Id = 106, Name = "Northern Cape", CountryId = 13, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 107, Name = "Klein Karoo", CountryId = 13, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
            {
                Id = 108, Name = "Cape South Coast", CountryId = 13, Created = DateTime.UtcNow, CreatedBy = "Seeding"
            },

            // Spain Id 14
            new Region
                { Id = 109, Name = "Galicia", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 110, Name = "Pais Vasco", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 111, Name = "La Rioja", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 112, Name = "Navarra", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 113, Name = "Aragon", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 114, Name = "Catalonia", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 115, Name = "Majorca", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 116, Name = "Valencia", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
            {
                Id = 117, Name = "Castilla-La Mancha", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding"
            },
            new Region
            {
                Id = 118, Name = "Castilla y León", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding"
            },
            new Region
                { Id = 119, Name = "Extremadura", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 120, Name = "Andalucía", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 121, Name = "Canary Islands", CountryId = 14, Created = DateTime.UtcNow, CreatedBy = "Seeding" },

            // United States Id 15
            new Region
                { Id = 122, Name = "Oregon", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 123, Name = "Washington", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 124, Name = "Idaho", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 125, Name = "California", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 126, Name = "Colorado", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 127, Name = "Arizona", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 128, Name = "New Mexico", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region { Id = 129, Name = "Texas", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 130, Name = "New York", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 131, Name = "Midwest", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 132, Name = "Southeast", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 133, Name = "New Jersey", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Region
                { Id = 134, Name = "Virginia", CountryId = 15, Created = DateTime.UtcNow, CreatedBy = "Seeding" }
        );
    }
}