using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCellar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditedEntityConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GrapeWine_Grapes_GrapesId",
                table: "GrapeWine");

            migrationBuilder.DropForeignKey(
                name: "FK_GrapeWine_Wines_WinesId",
                table: "GrapeWine");

            migrationBuilder.RenameColumn(
                name: "WinesId",
                table: "GrapeWine",
                newName: "WineId");

            migrationBuilder.RenameColumn(
                name: "GrapesId",
                table: "GrapeWine",
                newName: "GrapeId");

            migrationBuilder.RenameIndex(
                name: "IX_GrapeWine_WinesId",
                table: "GrapeWine",
                newName: "IX_GrapeWine_WineId");

            migrationBuilder.AddForeignKey(
                name: "FK_GrapeWine_Grapes_GrapeId",
                table: "GrapeWine",
                column: "GrapeId",
                principalTable: "Grapes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GrapeWine_Wines_WineId",
                table: "GrapeWine",
                column: "WineId",
                principalTable: "Wines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GrapeWine_Grapes_GrapeId",
                table: "GrapeWine");

            migrationBuilder.DropForeignKey(
                name: "FK_GrapeWine_Wines_WineId",
                table: "GrapeWine");

            migrationBuilder.RenameColumn(
                name: "WineId",
                table: "GrapeWine",
                newName: "WinesId");

            migrationBuilder.RenameColumn(
                name: "GrapeId",
                table: "GrapeWine",
                newName: "GrapesId");

            migrationBuilder.RenameIndex(
                name: "IX_GrapeWine_WineId",
                table: "GrapeWine",
                newName: "IX_GrapeWine_WinesId");

            migrationBuilder.AddForeignKey(
                name: "FK_GrapeWine_Grapes_GrapesId",
                table: "GrapeWine",
                column: "GrapesId",
                principalTable: "Grapes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GrapeWine_Wines_WinesId",
                table: "GrapeWine",
                column: "WinesId",
                principalTable: "Wines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
