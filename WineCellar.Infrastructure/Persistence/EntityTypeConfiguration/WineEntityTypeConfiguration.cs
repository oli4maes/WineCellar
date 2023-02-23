using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WineCellar.Infrastructure.Persistence.EntityTypeConfiguration;

public class WineEntityTypeConfiguration : IEntityTypeConfiguration<Wine>
{
    public void Configure(EntityTypeBuilder<Wine> builder)
    {
        builder.ToTable("Wines");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(250);

        builder.Property(x => x.WineType)
            .IsRequired();

        builder
            .HasOne(x => x.Winery)
            .WithMany(x => x.Wines);

        builder
            .HasMany(x => x.Grapes)
            .WithMany(x => x.Wines)
            .UsingEntity<GrapeWine>(
                j => j
                    .HasOne(pt => pt.Grape)
                    .WithMany(t => t.GrapeWines)
                    .HasForeignKey(pt => pt.GrapesId),
                j => j
                    .HasOne(pt => pt.Wine)
                    .WithMany(p => p.GrapeWines)
                    .HasForeignKey(pt => pt.WinesId));
    }
}