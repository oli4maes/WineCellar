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
    }
}