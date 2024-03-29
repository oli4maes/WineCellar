﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WineCellar.Infrastructure.Persistence.EntityTypeConfiguration;

public class WineryEntityTypeConfiguration : IEntityTypeConfiguration<Winery>
{
    public void Configure(EntityTypeBuilder<Winery> builder)
    {
        builder.ToTable("Wineries");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(x => x.Description)
            .HasMaxLength(5000);

        builder.HasMany(x => x.Wines)
            .WithOne(x => x.Winery);

        builder.HasOne(x => x.Country)
            .WithMany()
            .HasForeignKey(x => x.CountryId);
    }
}