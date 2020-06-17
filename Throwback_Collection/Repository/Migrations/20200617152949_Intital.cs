using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Intital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collectors",
                columns: table => new
                {
                    CollectorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CollectionId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    WishListId = table.Column<int>(nullable: false),
                    WishList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collectors", x => x.CollectorId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CollectorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Collectors_CollectorId",
                        column: x => x.CollectorId,
                        principalTable: "Collectors",
                        principalColumn: "CollectorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    CollectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GameTitle = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    System = table.Column<string>(nullable: true),
                    CollectorId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.CollectionId);
                    table.ForeignKey(
                        name: "FK_Collections_Collectors_CollectorId",
                        column: x => x.CollectorId,
                        principalTable: "Collectors",
                        principalColumn: "CollectorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Collections_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    WishListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WishList = table.Column<string>(nullable: true),
                    CollectorId = table.Column<int>(nullable: false),
                    CollectorId1 = table.Column<int>(nullable: true),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.WishListId);
                    table.ForeignKey(
                        name: "FK_Wishlists_Collectors_CollectorId1",
                        column: x => x.CollectorId1,
                        principalTable: "Collectors",
                        principalColumn: "CollectorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wishlists_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Collections_CollectorId",
                table: "Collections",
                column: "CollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_ItemId",
                table: "Collections",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Collectors_CollectionId",
                table: "Collectors",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Collectors_ItemId",
                table: "Collectors",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CollectorId",
                table: "Items",
                column: "CollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_CollectorId1",
                table: "Wishlists",
                column: "CollectorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_ItemId",
                table: "Wishlists",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collectors_Items_ItemId",
                table: "Collectors",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Collectors_Collections_CollectionId",
                table: "Collectors",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "CollectionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_Collectors_CollectorId",
                table: "Collections");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Collectors_CollectorId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "Collectors");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
