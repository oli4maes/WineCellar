using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WineCellar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedDescriptionToCountryAndRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Regions_RegionId",
                table: "Wines");

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Wines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Wineries",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Regions",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Regions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Grapes",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Countries",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Countries");

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Wineries",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Grapes",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1498), "Seeding", null, null, "Argentina" },
                    { 2, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1502), "Seeding", null, null, "Australia" },
                    { 3, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1504), "Seeding", null, null, "Austria" },
                    { 4, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1506), "Seeding", null, null, "Belgium" },
                    { 5, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1508), "Seeding", null, null, "Chile" },
                    { 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1510), "Seeding", null, null, "France" },
                    { 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1511), "Seeding", null, null, "Germany" },
                    { 8, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1513), "Seeding", null, null, "Greece" },
                    { 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1514), "Seeding", null, null, "Hungary" },
                    { 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1516), "Seeding", null, null, "Italy" },
                    { 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1518), "Seeding", null, null, "New Zealand" },
                    { 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1520), "Seeding", null, null, "Portugal" },
                    { 13, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1521), "Seeding", null, null, "South Africa" },
                    { 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1523), "Seeding", null, null, "Spain" },
                    { 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1524), "Seeding", null, null, "United States" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "CountryId", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3088), "Seeding", null, null, "Salta" },
                    { 2, 1, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3091), "Seeding", null, null, "Tucamán" },
                    { 3, 1, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3093), "Seeding", null, null, "Catamarca" },
                    { 4, 1, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3095), "Seeding", null, null, "La Rioja" },
                    { 5, 1, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3097), "Seeding", null, null, "San Juan" },
                    { 6, 1, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3099), "Seeding", null, null, "Mendoza" },
                    { 7, 1, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3101), "Seeding", null, null, "Patagonia" },
                    { 8, 2, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3102), "Seeding", null, null, "Western Australia" },
                    { 9, 2, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3104), "Seeding", null, null, "South Australia" },
                    { 10, 2, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3106), "Seeding", null, null, "New South Wales" },
                    { 11, 2, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3107), "Seeding", null, null, "Victoria" },
                    { 12, 2, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3109), "Seeding", null, null, "Tasmania" },
                    { 13, 2, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3162), "Seeding", null, null, "Queensland" },
                    { 14, 3, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3164), "Seeding", null, null, "Niederösterreich" },
                    { 15, 3, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3166), "Seeding", null, null, "Burgenland" },
                    { 16, 3, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3168), "Seeding", null, null, "Steiermark" },
                    { 17, 3, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3170), "Seeding", null, null, "Wien" },
                    { 18, 4, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3171), "Seeding", null, null, "Flanders" },
                    { 19, 4, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3173), "Seeding", null, null, "Wallonia" },
                    { 20, 5, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3175), "Seeding", null, null, "Central Valley" },
                    { 21, 5, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3176), "Seeding", null, null, "Aconcagua" },
                    { 22, 5, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3179), "Seeding", null, null, "South Region" },
                    { 23, 5, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3181), "Seeding", null, null, "Coquimbo" },
                    { 24, 5, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3182), "Seeding", null, null, "Atacama" },
                    { 25, 5, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3184), "Seeding", null, null, "Austral Region" },
                    { 26, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3186), "Seeding", null, null, "Languadoc-Roussillon" },
                    { 27, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3187), "Seeding", null, null, "Rhône Valley" },
                    { 28, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3189), "Seeding", null, null, "Bordeaux" },
                    { 29, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3191), "Seeding", null, null, "Provence" },
                    { 30, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3192), "Seeding", null, null, "Loire Valley" },
                    { 31, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3194), "Seeding", null, null, "South-West" },
                    { 32, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3195), "Seeding", null, null, "Burgundy" },
                    { 33, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3197), "Seeding", null, null, "Champagne" },
                    { 34, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3199), "Seeding", null, null, "Alsace" },
                    { 35, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3200), "Seeding", null, null, "Beaujolais" },
                    { 36, 6, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3202), "Seeding", null, null, "Corsica" },
                    { 37, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3203), "Seeding", null, null, "Ahr" },
                    { 38, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3205), "Seeding", null, null, "Mosel" },
                    { 39, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3207), "Seeding", null, null, "Nahe" },
                    { 40, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3208), "Seeding", null, null, "Pfalz" },
                    { 41, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3211), "Seeding", null, null, "Baden" },
                    { 42, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3212), "Seeding", null, null, "Mittelrhein" },
                    { 43, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3214), "Seeding", null, null, "Rheingan" },
                    { 44, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3216), "Seeding", null, null, "Rheinhessen" },
                    { 45, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3217), "Seeding", null, null, "Hessische Bergstrasse" },
                    { 46, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3219), "Seeding", null, null, "Würtemberg" },
                    { 47, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3220), "Seeding", null, null, "Franken" },
                    { 48, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3222), "Seeding", null, null, "Saale-Unstrut" },
                    { 49, 7, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3224), "Seeding", null, null, "Sachsen" },
                    { 50, 8, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3225), "Seeding", null, null, "Southern Greece" },
                    { 51, 8, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3227), "Seeding", null, null, "Crete" },
                    { 52, 8, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3228), "Seeding", null, null, "Central Greece" },
                    { 53, 8, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3230), "Seeding", null, null, "Aegean Islands" },
                    { 54, 8, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3231), "Seeding", null, null, "Macedonia" },
                    { 55, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3235), "Seeding", null, null, "Badacsony" },
                    { 56, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3236), "Seeding", null, null, "Balatonboglár" },
                    { 57, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3237), "Seeding", null, null, "Villány" },
                    { 58, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3239), "Seeding", null, null, "Szekszárd" },
                    { 59, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3241), "Seeding", null, null, "Balatonfüred-Csopak" },
                    { 60, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3242), "Seeding", null, null, "Mátra" },
                    { 61, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3247), "Seeding", null, null, "Tokaj" },
                    { 62, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3249), "Seeding", null, null, "Eger" },
                    { 63, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3250), "Seeding", null, null, "Etyek-Buda" },
                    { 64, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3252), "Seeding", null, null, "Pannonhalma" },
                    { 65, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3253), "Seeding", null, null, "Sopron" },
                    { 67, 9, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3255), "Seeding", null, null, "Nagy-Somló" },
                    { 68, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3256), "Seeding", null, null, "Sicily" },
                    { 69, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3258), "Seeding", null, null, "Puglia" },
                    { 70, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3259), "Seeding", null, null, "Veneto" },
                    { 71, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3262), "Seeding", null, null, "Tuscany" },
                    { 72, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3264), "Seeding", null, null, "Emilia-Romagna" },
                    { 73, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3265), "Seeding", null, null, "Piedmont" },
                    { 74, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3267), "Seeding", null, null, "Abruzzo" },
                    { 75, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3269), "Seeding", null, null, "Lombardy" },
                    { 76, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3270), "Seeding", null, null, "Friuli-Venesia Giulia" },
                    { 77, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3272), "Seeding", null, null, "Sardegna" },
                    { 78, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3273), "Seeding", null, null, "Lazio" },
                    { 79, 10, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3275), "Seeding", null, null, "Umbria" },
                    { 80, 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3276), "Seeding", null, null, "Northland" },
                    { 81, 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3279), "Seeding", null, null, "Waikato / Bay Of Plenty" },
                    { 82, 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3281), "Seeding", null, null, "Gisborne" },
                    { 83, 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3282), "Seeding", null, null, "Wairarapa" },
                    { 84, 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3284), "Seeding", null, null, "Marlborough" },
                    { 85, 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3285), "Seeding", null, null, "Caterbury and Waipara" },
                    { 86, 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3287), "Seeding", null, null, "Central Otago" },
                    { 87, 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3288), "Seeding", null, null, "Nelson" },
                    { 88, 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3290), "Seeding", null, null, "Hawke's Bay" },
                    { 89, 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3291), "Seeding", null, null, "Auckland" },
                    { 90, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3293), "Seeding", null, null, "Vinho Verde" },
                    { 91, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3294), "Seeding", null, null, "Dão" },
                    { 92, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3295), "Seeding", null, null, "Bairrada" },
                    { 93, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3297), "Seeding", null, null, "Lisboa" },
                    { 94, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3299), "Seeding", null, null, "Setúbal" },
                    { 95, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3300), "Seeding", null, null, "Madeira" },
                    { 96, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3302), "Seeding", null, null, "Algarve" },
                    { 97, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3303), "Seeding", null, null, "Alentejo" },
                    { 98, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3305), "Seeding", null, null, "Tejo" },
                    { 99, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3306), "Seeding", null, null, "Beira Interior" },
                    { 100, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3308), "Seeding", null, null, "Tavaro-Varosa" },
                    { 101, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3309), "Seeding", null, null, "Douro Valley" },
                    { 102, 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3311), "Seeding", null, null, "Trás-os-Montes" },
                    { 103, 13, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3312), "Seeding", null, null, "Olifants River" },
                    { 104, 13, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3314), "Seeding", null, null, "Coastal Region" },
                    { 105, 13, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3315), "Seeding", null, null, "Breede River Valley" },
                    { 106, 13, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3317), "Seeding", null, null, "Northern Cape" },
                    { 107, 13, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3318), "Seeding", null, null, "Klein Karoo" },
                    { 108, 13, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3320), "Seeding", null, null, "Cape South Coast" },
                    { 109, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3321), "Seeding", null, null, "Galicia" },
                    { 110, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3323), "Seeding", null, null, "Pais Vasco" },
                    { 111, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3325), "Seeding", null, null, "La Rioja" },
                    { 112, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3326), "Seeding", null, null, "Navarra" },
                    { 113, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3328), "Seeding", null, null, "Aragon" },
                    { 114, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3329), "Seeding", null, null, "Catalonia" },
                    { 115, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3331), "Seeding", null, null, "Majorca" },
                    { 116, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3379), "Seeding", null, null, "Valencia" },
                    { 117, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3381), "Seeding", null, null, "Castilla-La Mancha" },
                    { 118, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3382), "Seeding", null, null, "Castilla y León" },
                    { 119, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3384), "Seeding", null, null, "Extremadura" },
                    { 120, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3385), "Seeding", null, null, "Andalucía" },
                    { 121, 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3387), "Seeding", null, null, "Canary Islands" },
                    { 122, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3389), "Seeding", null, null, "Oregon" },
                    { 123, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3390), "Seeding", null, null, "Washington" },
                    { 124, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3392), "Seeding", null, null, "Idaho" },
                    { 125, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3393), "Seeding", null, null, "California" },
                    { 126, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3395), "Seeding", null, null, "Colorado" },
                    { 127, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3396), "Seeding", null, null, "Arizona" },
                    { 128, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3398), "Seeding", null, null, "New Mexico" },
                    { 129, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3399), "Seeding", null, null, "Texas" },
                    { 130, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3401), "Seeding", null, null, "New York" },
                    { 131, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3402), "Seeding", null, null, "Midwest" },
                    { 132, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3404), "Seeding", null, null, "Southeast" },
                    { 133, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3405), "Seeding", null, null, "New Jersey" },
                    { 134, 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3407), "Seeding", null, null, "Virginia" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Regions_RegionId",
                table: "Wines",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
