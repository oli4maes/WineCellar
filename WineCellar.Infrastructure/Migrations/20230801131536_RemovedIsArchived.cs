using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCellar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedIsArchived : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Countries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Regions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
