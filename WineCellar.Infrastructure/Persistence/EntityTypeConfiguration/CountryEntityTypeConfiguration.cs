using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WineCellar.Infrastructure.Persistence.EntityTypeConfiguration;

public class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Countries");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(250);

        builder.HasMany(x => x.Regions)
            .WithOne(y => y.Country);

        builder.HasData(
            new Country { Id = 1, Name = "Argentina", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 2, Name = "Australia", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 3, Name = "Austria", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 4, Name = "Belgium", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 5, Name = "Chile", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 6, Name = "France", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 7, Name = "Germany", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 8, Name = "Greece", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 9, Name = "Hungary", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 10, Name = "Italy", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 11, Name = "New Zealand", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 12, Name = "Portugal", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 13, Name = "South Africa", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 14, Name = "Spain", Created = DateTime.UtcNow, CreatedBy = "Seeding" },
            new Country { Id = 15, Name = "United States", Created = DateTime.UtcNow, CreatedBy = "Seeding" }
        );
    }
}