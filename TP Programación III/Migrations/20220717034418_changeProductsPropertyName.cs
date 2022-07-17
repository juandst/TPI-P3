using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Programación_III.Migrations
{
    public partial class changeProductsPropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OnSale",
                table: "Products",
                newName: "HasDiscount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasDiscount",
                table: "Products",
                newName: "OnSale");
        }
    }
}
