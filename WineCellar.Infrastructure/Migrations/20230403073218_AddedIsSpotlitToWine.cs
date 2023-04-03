using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCellar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsSpotlitToWine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSpotlit",
                table: "Wines",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSpotlit",
                table: "Wines");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                column: "Created",
                value: new DateTime(2023, 3, 31, 14, 3, 6, 669, DateTimeKind.Utc).AddTicks(3708));
        }
    }
}
