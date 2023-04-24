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
        
        builder.Property(x => x.IsSpotlit)
            .HasDefaultValue(false);

        builder.HasOne<Country>(x => x.Country)
            .WithMany(y => y.Regions)
            .HasForeignKey(x => x.CountryId);

        builder.HasData(
            // Argentina Id 1
            new Region() { Id = 1, Name = "Salta", CountryId = 1 },
            new Region() { Id = 2, Name = "Tucamán", CountryId = 1 },
            new Region() { Id = 3, Name = "Catamarca", CountryId = 1 },
            new Region() { Id = 4, Name = "La Rioja", CountryId = 1 },
            new Region() { Id = 5, Name = "San Juan", CountryId = 1 },
            new Region() { Id = 6, Name = "Mendoza", CountryId = 1 },
            new Region() { Id = 7, Name = "Patagonia", CountryId = 1 },

            // Australia Id 2
            new Region() { Id = 8, Name = "Western Australia", CountryId = 2 },
            new Region() { Id = 9, Name = "South Australia", CountryId = 2 },
            new Region() { Id = 10, Name = "New South Wales", CountryId = 2 },
            new Region() { Id = 11, Name = "Victoria", CountryId = 2 },
            new Region() { Id = 12, Name = "Tasmania", CountryId = 2 },
            new Region() { Id = 13, Name = "Queensland", CountryId = 2 },

            // Austria Id 3
            new Region() { Id = 14, Name = "Niederösterreich", CountryId = 3 },
            new Region() { Id = 15, Name = "Burgenland", CountryId = 3 },
            new Region() { Id = 16, Name = "Steiermark", CountryId = 3 },
            new Region() { Id = 17, Name = "Wien", CountryId = 3 },

            // Belgium Id 4
            new Region() { Id = 18, Name = "Flanders", CountryId = 4 },
            new Region() { Id = 19, Name = "Wallonia", CountryId = 4 },

            // Chile Id 5
            new Region() { Id = 20, Name = "Central Valley", CountryId = 5 },
            new Region() { Id = 21, Name = "Aconcagua", CountryId = 5 },
            new Region() { Id = 22, Name = "South Region", CountryId = 5 },
            new Region() { Id = 23, Name = "Coquimbo", CountryId = 5 },
            new Region() { Id = 24, Name = "Atacama", CountryId = 5 },
            new Region() { Id = 25, Name = "Austral Region", CountryId = 5 },

            // France Id 6
            new Region() { Id = 26, Name = "Languadoc-Roussillon", CountryId = 6 },
            new Region() { Id = 27, Name = "Rhône Valley", CountryId = 6 },
            new Region() { Id = 28, Name = "Bordeaux", CountryId = 6 },
            new Region() { Id = 29, Name = "Provence", CountryId = 6 },
            new Region() { Id = 30, Name = "Loire Valley", CountryId = 6 },
            new Region() { Id = 31, Name = "South-West", CountryId = 6 },
            new Region() { Id = 32, Name = "Burgundy", CountryId = 6 },
            new Region() { Id = 33, Name = "Champagne", CountryId = 6 },
            new Region() { Id = 34, Name = "Alsace", CountryId = 6 },
            new Region() { Id = 35, Name = "Beaujolais", CountryId = 6 },
            new Region() { Id = 36, Name = "Corsica", CountryId = 6 },

            // Germany Id 7
            new Region() { Id = 37, Name = "Ahr", CountryId = 7 },
            new Region() { Id = 38, Name = "Mosel", CountryId = 7 },
            new Region() { Id = 39, Name = "Nahe", CountryId = 7 },
            new Region() { Id = 40, Name = "Pfalz", CountryId = 7 },
            new Region() { Id = 41, Name = "Baden", CountryId = 7 },
            new Region() { Id = 42, Name = "Mittelrhein", CountryId = 7 },
            new Region() { Id = 43, Name = "Rheingan", CountryId = 7 },
            new Region() { Id = 44, Name = "Rheinhessen", CountryId = 7 },
            new Region() { Id = 45, Name = "Hessische Bergstrasse", CountryId = 7 },
            new Region() { Id = 46, Name = "Würtemberg", CountryId = 7 },
            new Region() { Id = 47, Name = "Franken", CountryId = 7 },
            new Region() { Id = 48, Name = "Saale-Unstrut", CountryId = 7 },
            new Region() { Id = 49, Name = "Sachsen", CountryId = 7 },

            // Greece Id 8
            new Region() { Id = 50, Name = "Southern Greece", CountryId = 8 },
            new Region() { Id = 51, Name = "Crete", CountryId = 8 },
            new Region() { Id = 52, Name = "Central Greece", CountryId = 8 },
            new Region() { Id = 53, Name = "Aegean Islands", CountryId = 8 },
            new Region() { Id = 54, Name = "Macedonia", CountryId = 8 },

            // Hungary Id 9
            new Region() { Id = 55, Name = "Badacsony", CountryId = 9 },
            new Region() { Id = 56, Name = "Balatonboglár", CountryId = 9 },
            new Region() { Id = 57, Name = "Villány", CountryId = 9 },
            new Region() { Id = 58, Name = "Szekszárd", CountryId = 9 },
            new Region() { Id = 59, Name = "Balatonfüred-Csopak", CountryId = 9 },
            new Region() { Id = 60, Name = "Mátra", CountryId = 9 },
            new Region() { Id = 61, Name = "Tokaj", CountryId = 9 },
            new Region() { Id = 62, Name = "Eger", CountryId = 9 },
            new Region() { Id = 63, Name = "Etyek-Buda", CountryId = 9 },
            new Region() { Id = 64, Name = "Pannonhalma", CountryId = 9 },
            new Region() { Id = 65, Name = "Sopron", CountryId = 9 },
            new Region() { Id = 67, Name = "Nagy-Somló", CountryId = 9 },

            // Italy Id 10
            new Region() { Id = 68, Name = "Sicily", CountryId = 10 },
            new Region() { Id = 69, Name = "Puglia", CountryId = 10 },
            new Region() { Id = 70, Name = "Veneto", CountryId = 10 },
            new Region() { Id = 71, Name = "Tuscany", CountryId = 10 },
            new Region() { Id = 72, Name = "Emilia-Romagna", CountryId = 10 },
            new Region() { Id = 73, Name = "Piedmont", CountryId = 10 },
            new Region() { Id = 74, Name = "Abruzzo", CountryId = 10 },
            new Region() { Id = 75, Name = "Lombardy", CountryId = 10 },
            new Region() { Id = 76, Name = "Friuli-Venesia Giulia", CountryId = 10 },
            new Region() { Id = 77, Name = "Abruzzo", CountryId = 10 },
            new Region() { Id = 78, Name = "Sardegna", CountryId = 10 },
            new Region() { Id = 79, Name = "Lazio", CountryId = 10 },
            new Region() { Id = 80, Name = "Umbria", CountryId = 10 },

            // New Zealand Id 11
            new Region() { Id = 81, Name = "Northland", CountryId = 11 },
            new Region() { Id = 82, Name = "Waikato / Bay Of Plenty", CountryId = 11 },
            new Region() { Id = 83, Name = "Gisborne", CountryId = 11 },
            new Region() { Id = 84, Name = "Wairarapa", CountryId = 11 },
            new Region() { Id = 85, Name = "Marlborough", CountryId = 11 },
            new Region() { Id = 86, Name = "Caterbury and Waipara", CountryId = 11 },
            new Region() { Id = 87, Name = "Central Otago", CountryId = 11 },
            new Region() { Id = 88, Name = "Nelson", CountryId = 11 },
            new Region() { Id = 89, Name = "Hawke's Bay", CountryId = 11 },
            new Region() { Id = 90, Name = "Auckland", CountryId = 11 },

            // Portugal Id 12
            new Region() { Id = 91, Name = "Vinho Verde", CountryId = 12 },
            new Region() { Id = 92, Name = "Dão", CountryId = 12 },
            new Region() { Id = 93, Name = "Bairrada", CountryId = 12 },
            new Region() { Id = 94, Name = "Lisboa", CountryId = 12 },
            new Region() { Id = 95, Name = "Setúbal", CountryId = 12 },
            new Region() { Id = 96, Name = "Madeira", CountryId = 12 },
            new Region() { Id = 97, Name = "Algarve", CountryId = 12 },
            new Region() { Id = 98, Name = "Alentejo", CountryId = 12 },
            new Region() { Id = 99, Name = "Tejo", CountryId = 12 },
            new Region() { Id = 100, Name = "Beira Interior", CountryId = 12 },
            new Region() { Id = 101, Name = "Tavaro-Varosa", CountryId = 12 },
            new Region() { Id = 102, Name = "Douro Valley", CountryId = 12 },
            new Region() { Id = 103, Name = "Trás-os-Montes", CountryId = 12 },

            // South Africa Id 13
            new Region() { Id = 104, Name = "Olifants River", CountryId = 13 },
            new Region() { Id = 105, Name = "Coastal Region", CountryId = 13 },
            new Region() { Id = 106, Name = "Breede River Valley", CountryId = 13 },
            new Region() { Id = 107, Name = "Northern Cape", CountryId = 13 },
            new Region() { Id = 108, Name = "Klein Karoo", CountryId = 13 },
            new Region() { Id = 109, Name = "Cape South Coast", CountryId = 13 },

            // Spain Id 14
            new Region() { Id = 110, Name = "Galicia", CountryId = 14 },
            new Region() { Id = 111, Name = "Pais Vasco", CountryId = 14 },
            new Region() { Id = 112, Name = "La Rioja", CountryId = 14 },
            new Region() { Id = 113, Name = "Navarra", CountryId = 14 },
            new Region() { Id = 114, Name = "Aragon", CountryId = 14 },
            new Region() { Id = 115, Name = "Catalonia", CountryId = 14 },
            new Region() { Id = 116, Name = "Majorca", CountryId = 14 },
            new Region() { Id = 117, Name = "Valencia", CountryId = 14 },
            new Region() { Id = 118, Name = "Castilla-La Mancha", CountryId = 14 },
            new Region() { Id = 119, Name = "Castilla y León", CountryId = 14 },
            new Region() { Id = 120, Name = "Extremadura", CountryId = 14 },
            new Region() { Id = 121, Name = "Andalucía", CountryId = 14 },
            new Region() { Id = 122, Name = "Canary Islands", CountryId = 14 },

            // United States Id 15
            new Region() { Id = 123, Name = "Oregon", CountryId = 15 },
            new Region() { Id = 124, Name = "Washington", CountryId = 15 },
            new Region() { Id = 125, Name = "Idaho", CountryId = 15 },
            new Region() { Id = 126, Name = "California", CountryId = 15 },
            new Region() { Id = 127, Name = "Colorado", CountryId = 15 },
            new Region() { Id = 128, Name = "Arizona", CountryId = 15 },
            new Region() { Id = 129, Name = "New Mexico", CountryId = 15 },
            new Region() { Id = 130, Name = "Texas", CountryId = 15 },
            new Region() { Id = 131, Name = "New York", CountryId = 15 },
            new Region() { Id = 132, Name = "Midwest", CountryId = 15 },
            new Region() { Id = 133, Name = "Southeast", CountryId = 15 },
            new Region() { Id = 134, Name = "New Jersey", CountryId = 15 },
            new Region() { Id = 135, Name = "Virginia", CountryId = 15 }
        );
    }
}