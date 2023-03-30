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

        builder.HasMany<Region>(x => x.Regions)
            .WithOne(y => y.Country);

        builder.HasData(
            new { Id = 1, Name = "Argentina" },
            new { Id = 2, Name = "Australia" },
            new { Id = 3, Name = "Austria" },
            new { Id = 4, Name = "Belgium" },
            new { Id = 5, Name = "Chile" },
            new { Id = 6, Name = "France" },
            new { Id = 7, Name = "Germany" },
            new { Id = 8, Name = "Greece" },
            new { Id = 9, Name = "Hungary" },
            new { Id = 10, Name = "Italy" },
            new { Id = 11, Name = "New Zealand" },
            new { Id = 12, Name = "Portugal" },
            new { Id = 13, Name = "South Africa" },
            new { Id = 14, Name = "Spain" },
            new { Id = 15, Name = "United States" }
        );
    }
}