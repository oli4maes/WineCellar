using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCellar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameUserWineToBottle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Regions_RegionId",
                table: "Wines");

            migrationBuilder.DropTable(
                name: "UserWines");

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DropColumn(
                name: "IsSpotlit",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "IsSpotlit",
                table: "Wineries");

            migrationBuilder.DropColumn(
                name: "IsSpotlit",
                table: "Regions");

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
                name: "CreatedBy",
                table: "Wines",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Wineries",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Regions",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "GrapeWine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "GrapeWine",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "GrapeWine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "GrapeWine",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "GrapeWine",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Grapes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Countries",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Countries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Countries",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bottles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineId = table.Column<int>(type: "int", nullable: false),
                    Auth0Id = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Vintage = table.Column<int>(type: "int", nullable: true),
                    BottleSize = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bottles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bottles_Wines_WineId",
                        column: x => x.WineId,
                        principalTable: "Wines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1498), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1502), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1504), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1506), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1508), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1510), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1511), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1513), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1514), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1516), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1518), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1520), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1521), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1523), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy", "LastModified", "LastModifiedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(1524), "Seeding", null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3088), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3091), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3093), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3095), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3097), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3099), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3101), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3102), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3104), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3106), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3107), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3109), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3162), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3164), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3166), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3168), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3170), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3171), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3173), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3175), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3176), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3179), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3181), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3182), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3184), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3186), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3187), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3189), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3191), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3192), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3194), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3195), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3197), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3199), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3200), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3202), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3203), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3205), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3207), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3208), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3211), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3212), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3214), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3216), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3217), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3219), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3220), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3222), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3224), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3225), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3227), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3228), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3230), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3231), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3235), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3236), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3237), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3239), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3241), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3242), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3247), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3249), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3250), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3252), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3253), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3255), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3256), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3258), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3259), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3262), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3264), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3265), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3267), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3269), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3270), "Seeding" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3272), "Seeding", "Sardegna" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3273), "Seeding", "Lazio" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3275), "Seeding", "Umbria" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CountryId", "Created", "CreatedBy", "Name" },
                values: new object[] { 11, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3276), "Seeding", "Northland" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3279), "Seeding", "Waikato / Bay Of Plenty" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3281), "Seeding", "Gisborne" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3282), "Seeding", "Wairarapa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3284), "Seeding", "Marlborough" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3285), "Seeding", "Caterbury and Waipara" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3287), "Seeding", "Central Otago" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3288), "Seeding", "Nelson" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3290), "Seeding", "Hawke's Bay" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3291), "Seeding", "Auckland" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CountryId", "Created", "CreatedBy", "Name" },
                values: new object[] { 12, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3293), "Seeding", "Vinho Verde" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3294), "Seeding", "Dão" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3295), "Seeding", "Bairrada" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3297), "Seeding", "Lisboa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3299), "Seeding", "Setúbal" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3300), "Seeding", "Madeira" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3302), "Seeding", "Algarve" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3303), "Seeding", "Alentejo" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3305), "Seeding", "Tejo" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3306), "Seeding", "Beira Interior" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3308), "Seeding", "Tavaro-Varosa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3309), "Seeding", "Douro Valley" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3311), "Seeding", "Trás-os-Montes" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CountryId", "Created", "CreatedBy", "Name" },
                values: new object[] { 13, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3312), "Seeding", "Olifants River" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3314), "Seeding", "Coastal Region" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3315), "Seeding", "Breede River Valley" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3317), "Seeding", "Northern Cape" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3318), "Seeding", "Klein Karoo" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3320), "Seeding", "Cape South Coast" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CountryId", "Created", "CreatedBy", "Name" },
                values: new object[] { 14, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3321), "Seeding", "Galicia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3323), "Seeding", "Pais Vasco" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3325), "Seeding", "La Rioja" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3326), "Seeding", "Navarra" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3328), "Seeding", "Aragon" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3329), "Seeding", "Catalonia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3331), "Seeding", "Majorca" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3379), "Seeding", "Valencia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3381), "Seeding", "Castilla-La Mancha" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3382), "Seeding", "Castilla y León" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3384), "Seeding", "Extremadura" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3385), "Seeding", "Andalucía" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3387), "Seeding", "Canary Islands" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CountryId", "Created", "CreatedBy", "Name" },
                values: new object[] { 15, new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3389), "Seeding", "Oregon" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3390), "Seeding", "Washington" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3392), "Seeding", "Idaho" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3393), "Seeding", "California" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3395), "Seeding", "Colorado" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3396), "Seeding", "Arizona" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3398), "Seeding", "New Mexico" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3399), "Seeding", "Texas" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3401), "Seeding", "New York" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3402), "Seeding", "Midwest" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3404), "Seeding", "Southeast" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3405), "Seeding", "New Jersey" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 9, 7, 46, 306, DateTimeKind.Utc).AddTicks(3407), "Seeding", "Virginia" });

            migrationBuilder.CreateIndex(
                name: "IX_Bottles_WineId",
                table: "Bottles",
                column: "WineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Regions_RegionId",
                table: "Wines",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Regions_RegionId",
                table: "Wines");

            migrationBuilder.DropTable(
                name: "Bottles");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "GrapeWine");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "GrapeWine");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GrapeWine");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "GrapeWine");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "GrapeWine");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Countries");

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Wines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Wines",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<bool>(
                name: "IsSpotlit",
                table: "Wines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Wineries",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<bool>(
                name: "IsSpotlit",
                table: "Wineries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Regions",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<bool>(
                name: "IsSpotlit",
                table: "Regions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Grapes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.CreateTable(
                name: "UserWines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Auth0Id = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserWines_Wines_WineId",
                        column: x => x.WineId,
                        principalTable: "Wines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3850), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3930), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3930), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3930), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null, "Abruzzo" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null, "Sardegna" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null, "Lazio" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CountryId", "Created", "CreatedBy", "Name" },
                values: new object[] { 10, new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null, "Umbria" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null, "Northland" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null, "Waikato / Bay Of Plenty" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null, "Gisborne" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null, "Wairarapa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null, "Marlborough" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940), null, "Caterbury and Waipara" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Central Otago" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Nelson" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Hawke's Bay" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CountryId", "Created", "CreatedBy", "Name" },
                values: new object[] { 11, new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Auckland" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Vinho Verde" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Dão" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Bairrada" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Lisboa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Setúbal" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Madeira" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Algarve" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Alentejo" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950), null, "Tejo" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Beira Interior" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Tavaro-Varosa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Douro Valley" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CountryId", "Created", "CreatedBy", "Name" },
                values: new object[] { 12, new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Trás-os-Montes" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Olifants River" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Coastal Region" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Breede River Valley" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Northern Cape" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Klein Karoo" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CountryId", "Created", "CreatedBy", "Name" },
                values: new object[] { 13, new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Cape South Coast" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Galicia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "Pais Vasco" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960), null, "La Rioja" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Navarra" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Aragon" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Catalonia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Majorca" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Valencia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Castilla-La Mancha" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Castilla y León" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Extremadura" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Andalucía" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CountryId", "Created", "CreatedBy", "Name" },
                values: new object[] { 14, new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Canary Islands" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Oregon" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Washington" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970), null, "Idaho" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980), null, "California" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980), null, "Colorado" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980), null, "Arizona" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980), null, "New Mexico" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980), null, "Texas" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980), null, "New York" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980), null, "Midwest" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980), null, "Southeast" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "CreatedBy", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980), null, "New Jersey" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "CountryId", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[] { 135, 15, new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3990), null, null, null, "Virginia" });

            migrationBuilder.CreateIndex(
                name: "IX_UserWines_WineId",
                table: "UserWines",
                column: "WineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Regions_RegionId",
                table: "Wines",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id");
        }
    }
}
