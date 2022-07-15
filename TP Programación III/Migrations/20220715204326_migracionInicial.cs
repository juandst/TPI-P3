using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Programación_III.Migrations
{
    public partial class migracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    ProductCategory = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    OnSale = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Name", "OnSale", "Price", "ProductCategory" },
                values: new object[] { 1, "Eukanuba Puppy es un producto ideal para mascotas menores al año de edad y entre 11 y 25 Kg. Considerado un alimento super premium, es de lo mejor que hay en el mercado", "Eukanuba Puppy x15", false, 14600, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Name", "OnSale", "Price", "ProductCategory" },
                values: new object[] { 2, "Proplan Adult es un producto ideal para mascotas mayores al año y con un peso menor a 10 kg. Considerado un alimento super premium, es de lo mejor que hay en el mercado", "Proplan Adult x3", false, 4900, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Name", "OnSale", "Price", "ProductCategory" },
                values: new object[] { 3, "Raza Adultos es un alimento masivo para perros adultos", "Raza Adult x20", true, 8100, 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { 1, "pepito@email.com", false, "Pepito", "123456" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { 2, "juan@email.com", true, "Juan", "765432" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { 3, "carlos@email.com", false, "Carlos", "123456" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
