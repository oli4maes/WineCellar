﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineCellar.Domain.Enums;

namespace WineCellar.Infrastructure.Persistence.EntityTypeConfiguration;

public class BottleEntityTypeConfiguration : IEntityTypeConfiguration<Bottle>
{
    public void Configure(EntityTypeBuilder<Bottle> builder)
    {
        builder.ToTable("Bottles");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Auth0Id)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(x => x.BottleSize)
            .HasDefaultValue(BottleSize.Standard)
            .IsRequired();

        builder.Property(x => x.Status)
            .HasDefaultValue(BottleStatus.InCellar)
            .IsRequired();

        builder.Property(x => x.AddedOn)
            .IsRequired();

        builder.Property(x => x.Price)
            .HasDefaultValue(0d)
            .IsRequired();
    }
}