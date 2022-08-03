using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaShopApp.Migrations
{
    public partial class RenameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "city",
                table: "Customers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "StreeAddress",
                table: "Customers",
                newName: "StreetAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Customers",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Customers",
                newName: "StreeAddress");
        }
    }
}
