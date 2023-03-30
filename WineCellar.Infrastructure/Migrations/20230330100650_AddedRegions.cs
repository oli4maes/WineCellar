using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WineCellar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Countries_CountryId",
                table: "Wines");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Wines",
                newName: "RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Wines_CountryId",
                table: "Wines",
                newName: "IX_Wines_RegionId");

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "CountryId", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3873), null, null, null, "Salta" },
                    { 2, 1, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3877), null, null, null, "Tucamán" },
                    { 3, 1, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3879), null, null, null, "Catamarca" },
                    { 4, 1, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3880), null, null, null, "La Rioja" },
                    { 5, 1, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3881), null, null, null, "San Juan" },
                    { 6, 1, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3882), null, null, null, "Mendoza" },
                    { 7, 1, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3883), null, null, null, "Patagonia" },
                    { 8, 2, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3884), null, null, null, "Western Australia" },
                    { 9, 2, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3884), null, null, null, "South Australia" },
                    { 10, 2, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3885), null, null, null, "New South Wales" },
                    { 11, 2, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3886), null, null, null, "Victoria" },
                    { 12, 2, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3887), null, null, null, "Tasmania" },
                    { 13, 2, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3888), null, null, null, "Queensland" },
                    { 14, 3, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3888), null, null, null, "Niederösterreich" },
                    { 15, 3, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3889), null, null, null, "Burgenland" },
                    { 16, 3, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3891), null, null, null, "Steiermark" },
                    { 17, 3, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3892), null, null, null, "Wien" },
                    { 18, 4, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3892), null, null, null, "Flanders" },
                    { 19, 4, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3893), null, null, null, "Wallonia" },
                    { 20, 5, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3894), null, null, null, "Central Valley" },
                    { 21, 5, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3894), null, null, null, "Aconcagua" },
                    { 22, 5, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3895), null, null, null, "South Region" },
                    { 23, 5, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3896), null, null, null, "Coquimbo" },
                    { 24, 5, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3897), null, null, null, "Atacama" },
                    { 25, 5, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3897), null, null, null, "Austral Region" },
                    { 26, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3898), null, null, null, "Languadoc-Roussillon" },
                    { 27, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3899), null, null, null, "Rhône Valley" },
                    { 28, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3900), null, null, null, "Bordeaux" },
                    { 29, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3900), null, null, null, "Provence" },
                    { 30, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3901), null, null, null, "Loire Valley" },
                    { 31, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3902), null, null, null, "South-West" },
                    { 32, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3940), null, null, null, "Burgundy" },
                    { 33, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3941), null, null, null, "Champagne" },
                    { 34, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3942), null, null, null, "Alsace" },
                    { 35, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3943), null, null, null, "Beaujolais" },
                    { 36, 6, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3944), null, null, null, "Corsica" },
                    { 37, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3945), null, null, null, "Ahr" },
                    { 38, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3946), null, null, null, "Mosel" },
                    { 39, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3947), null, null, null, "Nahe" },
                    { 40, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3947), null, null, null, "Pfalz" },
                    { 41, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3948), null, null, null, "Baden" },
                    { 42, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3949), null, null, null, "Mittelrhein" },
                    { 43, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3950), null, null, null, "Rheingan" },
                    { 44, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3950), null, null, null, "Rheinhessen" },
                    { 45, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3951), null, null, null, "Hessische Bergstrasse" },
                    { 46, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3952), null, null, null, "Würtemberg" },
                    { 47, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3953), null, null, null, "Franken" },
                    { 48, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3953), null, null, null, "Saale-Unstrut" },
                    { 49, 7, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3954), null, null, null, "Sachsen" },
                    { 50, 8, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3955), null, null, null, "Southern Greece" },
                    { 51, 8, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3956), null, null, null, "Crete" },
                    { 52, 8, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3956), null, null, null, "Central Greece" },
                    { 53, 8, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3957), null, null, null, "Aegean Islands" },
                    { 54, 8, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3958), null, null, null, "Macedonia" },
                    { 55, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3958), null, null, null, "Badacsony" },
                    { 56, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3959), null, null, null, "Balatonboglár" },
                    { 57, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3960), null, null, null, "Villány" },
                    { 58, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3961), null, null, null, "Szekszárd" },
                    { 59, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3961), null, null, null, "Balatonfüred-Csopak" },
                    { 60, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3962), null, null, null, "Mátra" },
                    { 61, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3963), null, null, null, "Tokaj" },
                    { 62, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3965), null, null, null, "Eger" },
                    { 63, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3965), null, null, null, "Etyek-Buda" },
                    { 64, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3966), null, null, null, "Pannonhalma" },
                    { 65, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3967), null, null, null, "Sopron" },
                    { 67, 9, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3968), null, null, null, "Nagy-Somló" },
                    { 68, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3968), null, null, null, "Sicily" },
                    { 69, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3969), null, null, null, "Puglia" },
                    { 70, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3970), null, null, null, "Veneto" },
                    { 71, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3971), null, null, null, "Tuscany" },
                    { 72, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3971), null, null, null, "Emilia-Romagna" },
                    { 73, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3972), null, null, null, "Piedmont" },
                    { 74, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3973), null, null, null, "Abruzzo" },
                    { 75, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3974), null, null, null, "Lombardy" },
                    { 76, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3974), null, null, null, "Friuli-Venesia Giulia" },
                    { 77, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3975), null, null, null, "Abruzzo" },
                    { 78, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3976), null, null, null, "Sardegna" },
                    { 79, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3976), null, null, null, "Lazio" },
                    { 80, 10, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3977), null, null, null, "Umbria" },
                    { 81, 11, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3978), null, null, null, "Northland" },
                    { 82, 11, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3979), null, null, null, "Waikato / Bay Of Plenty" },
                    { 83, 11, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3979), null, null, null, "Gisborne" },
                    { 84, 11, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3980), null, null, null, "Wairarapa" },
                    { 85, 11, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3981), null, null, null, "Marlborough" },
                    { 86, 11, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3981), null, null, null, "Caterbury and Waipara" },
                    { 87, 11, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3982), null, null, null, "Central Otago" },
                    { 88, 11, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3983), null, null, null, "Nelson" },
                    { 89, 11, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3984), null, null, null, "Hawke's Bay" },
                    { 90, 11, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3984), null, null, null, "Auckland" },
                    { 91, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3985), null, null, null, "Vinho Verde" },
                    { 92, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3987), null, null, null, "Dão" },
                    { 93, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3987), null, null, null, "Bairrada" },
                    { 94, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3988), null, null, null, "Lisboa" },
                    { 95, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3989), null, null, null, "Setúbal" },
                    { 96, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(3989), null, null, null, "Madeira" },
                    { 97, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4026), null, null, null, "Algarve" },
                    { 98, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4027), null, null, null, "Alentejo" },
                    { 99, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4027), null, null, null, "Tejo" },
                    { 100, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4028), null, null, null, "Beira Interior" },
                    { 101, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4029), null, null, null, "Tavaro-Varosa" },
                    { 102, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4030), null, null, null, "Douro Valley" },
                    { 103, 12, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4030), null, null, null, "Trás-os-Montes" },
                    { 104, 13, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4031), null, null, null, "Olifants River" },
                    { 105, 13, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4032), null, null, null, "Coastal Region" },
                    { 106, 13, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4033), null, null, null, "Breede River Valley" },
                    { 107, 13, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4034), null, null, null, "Northern Cape" },
                    { 108, 13, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4034), null, null, null, "Klein Karoo" },
                    { 109, 13, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4035), null, null, null, "Cape South Coast" },
                    { 110, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4036), null, null, null, "Galicia" },
                    { 111, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4037), null, null, null, "Pais Vasco" },
                    { 112, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4037), null, null, null, "La Rioja" },
                    { 113, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4038), null, null, null, "Navarra" },
                    { 114, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4039), null, null, null, "Aragon" },
                    { 115, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4040), null, null, null, "Catalonia" },
                    { 116, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4040), null, null, null, "Majorca" },
                    { 117, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4041), null, null, null, "Valencia" },
                    { 118, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4042), null, null, null, "Castilla-La Mancha" },
                    { 119, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4042), null, null, null, "Castilla y León" },
                    { 120, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4043), null, null, null, "Extremadura" },
                    { 121, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4044), null, null, null, "Andalucía" },
                    { 122, 14, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4045), null, null, null, "Canary Islands" },
                    { 123, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4045), null, null, null, "Oregon" },
                    { 124, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4046), null, null, null, "Washington" },
                    { 125, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4047), null, null, null, "Idaho" },
                    { 126, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4048), null, null, null, "California" },
                    { 127, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4048), null, null, null, "Colorado" },
                    { 128, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4049), null, null, null, "Arizona" },
                    { 129, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4050), null, null, null, "New Mexico" },
                    { 130, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4050), null, null, null, "Texas" },
                    { 131, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4051), null, null, null, "New York" },
                    { 132, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4052), null, null, null, "Midwest" },
                    { 133, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4053), null, null, null, "Southeast" },
                    { 134, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4053), null, null, null, "New Jersey" },
                    { 135, 15, new DateTime(2023, 3, 30, 10, 6, 49, 982, DateTimeKind.Utc).AddTicks(4054), null, null, null, "Virginia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regions_CountryId",
                table: "Regions",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Regions_RegionId",
                table: "Wines",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Regions_RegionId",
                table: "Wines");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.RenameColumn(
                name: "RegionId",
                table: "Wines",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Wines_RegionId",
                table: "Wines",
                newName: "IX_Wines_CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Countries_CountryId",
                table: "Wines",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
