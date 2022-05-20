using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopAppMVC.Migrations
{
    public partial class UserIdj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ShopItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopItems_UserId",
                table: "ShopItems",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItems_Users_UserId",
                table: "ShopItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopItems_Users_UserId",
                table: "ShopItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_ShopItems_UserId",
                table: "ShopItems");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ShopItems");
        }
    }
}
