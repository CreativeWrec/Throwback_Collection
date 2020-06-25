using Microsoft.EntityFrameworkCore.Migrations;

namespace TB_Collection.Migrations
{
    public partial class IdentityUserAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Collectors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collectors_IdentityUserId",
                table: "Collectors",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collectors_AspNetUsers_IdentityUserId",
                table: "Collectors",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collectors_AspNetUsers_IdentityUserId",
                table: "Collectors");

            migrationBuilder.DropIndex(
                name: "IX_Collectors_IdentityUserId",
                table: "Collectors");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Collectors");
        }
    }
}
