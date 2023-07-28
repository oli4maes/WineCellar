using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCellar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedStatusToBottle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Bottles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Bottles");
        }
    }
}
