using Microsoft.EntityFrameworkCore.Migrations;

namespace TB_Collection.Migrations
{
    public partial class UpdatedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteConsole",
                table: "Collectors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FavoriteGame",
                table: "Collectors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FavoriteGamingMoment",
                table: "Collectors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FavoriteGenre",
                table: "Collectors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uimg",
                table: "Collectors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriteConsole",
                table: "Collectors");

            migrationBuilder.DropColumn(
                name: "FavoriteGame",
                table: "Collectors");

            migrationBuilder.DropColumn(
                name: "FavoriteGamingMoment",
                table: "Collectors");

            migrationBuilder.DropColumn(
                name: "FavoriteGenre",
                table: "Collectors");

            migrationBuilder.DropColumn(
                name: "Uimg",
                table: "Collectors");
        }
    }
}
