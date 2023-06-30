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

        builder.Property(x => x.Description)
            .HasMaxLength(5000);

        builder.Property(x => x.IsArchived)
            .HasDefaultValue(false);
    }
}