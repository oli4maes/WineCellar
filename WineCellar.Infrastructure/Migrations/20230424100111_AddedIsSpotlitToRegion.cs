using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCellar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsSpotlitToRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSpotlit",
                table: "Regions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                column: "Created",
                value: new DateTime(2023, 4, 24, 10, 1, 11, 448, DateTimeKind.Utc).AddTicks(3990));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSpotlit",
                table: "Regions");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                column: "Created",
                value: new DateTime(2023, 4, 3, 7, 32, 18, 684, DateTimeKind.Utc).AddTicks(4261));
        }
    }
}
