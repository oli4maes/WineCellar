﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WineCellar.Infrastructure.Persistence;

#nullable disable

namespace WineCellar.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221125141536_AddedAuth0IdToUserWine")]
    partial class AddedAuth0IdToUserWine
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WineCellar.Domain.Entities.Grape", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Grapes");
                });

            modelBuilder.Entity("WineCellar.Domain.Entities.GrapeWine", b =>
                {
                    b.Property<int>("GrapesId")
                        .HasColumnType("int");

                    b.Property<int>("WinesId")
                        .HasColumnType("int");

                    b.HasKey("GrapesId", "WinesId");

                    b.HasIndex("WinesId");

                    b.ToTable("GrapeWine");
                });

            modelBuilder.Entity("WineCellar.Domain.Entities.UserWine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Auth0Id")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("WineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WineId");

                    b.ToTable("UserWines");
                });

            modelBuilder.Entity("WineCellar.Domain.Entities.Wine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("WineType")
                        .HasColumnType("int");

                    b.Property<int>("WineryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WineryId");

                    b.ToTable("Wines");
                });

            modelBuilder.Entity("WineCellar.Domain.Entities.Winery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Wineries");
                });

            modelBuilder.Entity("WineCellar.Domain.Entities.GrapeWine", b =>
                {
                    b.HasOne("WineCellar.Domain.Entities.Grape", "Grape")
                        .WithMany("GrapeWines")
                        .HasForeignKey("GrapesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WineCellar.Domain.Entities.Wine", "Wine")
                        .WithMany("GrapeWines")
                        .HasForeignKey("WinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grape");

                    b.Navigation("Wine");
                });

            modelBuilder.Entity("WineCellar.Domain.Entities.UserWine", b =>
                {
                    b.HasOne("WineCellar.Domain.Entities.Wine", "Wine")
                        .WithMany()
                        .HasForeignKey("WineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wine");
                });

            modelBuilder.Entity("WineCellar.Domain.Entities.Wine", b =>
                {
                    b.HasOne("WineCellar.Domain.Entities.Winery", "Winery")
                        .WithMany("Wines")
                        .HasForeignKey("WineryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Winery");
                });

            modelBuilder.Entity("WineCellar.Domain.Entities.Grape", b =>
                {
                    b.Navigation("GrapeWines");
                });

            modelBuilder.Entity("WineCellar.Domain.Entities.Wine", b =>
                {
                    b.Navigation("GrapeWines");
                });

            modelBuilder.Entity("WineCellar.Domain.Entities.Winery", b =>
                {
                    b.Navigation("Wines");
                });
#pragma warning restore 612, 618
        }
    }
}
