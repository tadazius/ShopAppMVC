using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopAppMVC.Migrations
{
    public partial class shopservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpiryDate",
                table: "ShopItems",
                newName: "ExpireDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpireDate",
                table: "ShopItems",
                newName: "ExpiryDate");
        }
    }
}
