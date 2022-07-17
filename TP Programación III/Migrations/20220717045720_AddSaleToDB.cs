using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Programación_III.Migrations
{
    public partial class AddSaleToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    ShippingPlace = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ProductCategory = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "ID", "Name", "PaymentType", "Price", "ProductCategory", "ShippingPlace" },
                values: new object[] { 4, "Vitalcan Complete x20", 0, 9500, 1, "Formosa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
