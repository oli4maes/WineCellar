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
            .HasMany(wine => wine.Grapes)
            .WithMany(grape => grape.Wines)
            .UsingEntity<GrapeWine>(
                gw => gw
                    .HasOne(gw => gw.Grape)
                    .WithMany(grape => grape.GrapeWines)
                    .HasForeignKey(gw => gw.GrapeId),
                gw => gw
                    .HasOne(gw => gw.Wine)
                    .WithMany(wine => wine.GrapeWines)
                    .HasForeignKey(gw => gw.WineId),
                gw => { gw.HasKey(gw => new { gw.GrapeId, gw.WineId }); }
            );

        builder.HasOne(x => x.Country)
            .WithMany()
            .HasForeignKey(x => x.CountryId);
    }
}