using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoesPizzeriaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AppetizerMenuMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemModels",
                table: "ItemModels");

            migrationBuilder.RenameTable(
                name: "ItemModels",
                newName: "AppetizerMenu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppetizerMenu",
                table: "AppetizerMenu",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppetizerMenu",
                table: "AppetizerMenu");

            migrationBuilder.RenameTable(
                name: "AppetizerMenu",
                newName: "ItemModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemModels",
                table: "ItemModels",
                column: "ItemId");
        }
    }
}
