using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WineCellar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedCountries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Wines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Wineries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Argentina" },
                    { 2, "Australia" },
                    { 3, "Austria" },
                    { 4, "Belgium" },
                    { 5, "Chile" },
                    { 6, "France" },
                    { 7, "Germany" },
                    { 8, "Greece" },
                    { 9, "Hungary" },
                    { 10, "Italy" },
                    { 11, "New Zealand" },
                    { 12, "Portugal" },
                    { 13, "South Africa" },
                    { 14, "Spain" },
                    { 15, "United States" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wines_CountryId",
                table: "Wines",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Wineries_CountryId",
                table: "Wineries",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wineries_Countries_CountryId",
                table: "Wineries",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Countries_CountryId",
                table: "Wines",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wineries_Countries_CountryId",
                table: "Wineries");

            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Countries_CountryId",
                table: "Wines");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Wines_CountryId",
                table: "Wines");

            migrationBuilder.DropIndex(
                name: "IX_Wineries_CountryId",
                table: "Wineries");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Wineries");
        }
    }
}
