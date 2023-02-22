using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WineCellar.Infrastructure.Persistence.EntityTypeConfiguration;

public class GrapeEntityTypeConfiguration : IEntityTypeConfiguration<Grape>
{
    public void Configure(EntityTypeBuilder<Grape> builder)
    {
        builder.ToTable("Grapes");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(250);
        
        builder.Property(x => x.Description)
            .HasMaxLength(2000);
        
        builder
            .HasMany(x => x.Wines)
            .WithMany(x => x.Grapes)
            .UsingEntity<GrapeWine>(
                j => j
                    .HasOne(pt => pt.Wine)
                    .WithMany(t => t.GrapeWines)
                    .HasForeignKey(pt => pt.WinesId),
                j => j
                    .HasOne(pt => pt.Grape)
                    .WithMany(p => p.GrapeWines)
                    .HasForeignKey(pt => pt.GrapesId));
    }
}