using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_Digital.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes_Bk",
                columns: table => new
                {
                    Clientes_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clientes_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clientes_Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clientes_Edad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes_Bk", x => x.Clientes_Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos_Bk",
                columns: table => new
                {
                    Producto_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Producto_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producto_Cantidad = table.Column<int>(type: "int", nullable: false),
                    Producto_Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos_Bk", x => x.Producto_Id);
                });

            migrationBuilder.CreateTable(
                name: "Ventas_Productos_Bk",
                columns: table => new
                {
                    VentasP_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VentasP_Comprador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VentasP_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VentasP_Cantidad = table.Column<int>(type: "int", nullable: false),
                    VentasP_Fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VentasP_PrecioF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas_Productos_Bk", x => x.VentasP_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes_Bk");

            migrationBuilder.DropTable(
                name: "Productos_Bk");

            migrationBuilder.DropTable(
                name: "Ventas_Productos_Bk");
        }
    }
}
