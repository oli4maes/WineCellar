using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WineCellar.Infrastructure.Persistence.EntityTypeConfiguration;

public class UserWineEntityTypeConfiguration : IEntityTypeConfiguration<UserWine>
{
    public void Configure(EntityTypeBuilder<UserWine> builder)
    {
        builder.ToTable("UserWines");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Auth0Id)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(x => x.Amount)
            .IsRequired();
    }
}