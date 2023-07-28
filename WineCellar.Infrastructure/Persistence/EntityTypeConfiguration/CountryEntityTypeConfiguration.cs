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

        builder.Property(x => x.Description)
            .HasMaxLength(5000);

        builder.Property(x => x.IsArchived)
            .HasDefaultValue(false);

        builder.HasMany(x => x.Regions)
            .WithOne(y => y.Country);
    }
}