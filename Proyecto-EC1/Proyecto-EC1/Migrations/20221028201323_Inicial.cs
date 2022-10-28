using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_EC1.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id_catg = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_catg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    desp_catg = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id_catg);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fech_nac = table.Column<int>(type: "int", nullable: false),
                    ruc = table.Column<int>(type: "int", nullable: false),
                    tip_doc = table.Column<int>(type: "int", nullable: false),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id_prod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomb_prod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    prec_prod = table.Column<float>(type: "real", nullable: false),
                    stock_prod = table.Column<int>(type: "int", nullable: false),
                    Id_catg = table.Column<int>(type: "int", nullable: false),
                    CategoriaId_catg = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id_prod);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CategoriaId_catg",
                        column: x => x.CategoriaId_catg,
                        principalTable: "Categoria",
                        principalColumn: "Id_catg",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    id_cita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    distrito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<int>(type: "int", nullable: false),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false),
                    ClienteId_Cliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.id_cita);
                    table.ForeignKey(
                        name: "FK_Cita_Cliente_ClienteId_Cliente",
                        column: x => x.ClienteId_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id_pedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id_factura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fech_ped = table.Column<int>(type: "int", nullable: false),
                    hor_ped = table.Column<int>(type: "int", nullable: false),
                    hor_entr = table.Column<int>(type: "int", nullable: false),
                    num_ped = table.Column<int>(type: "int", nullable: false),
                    fech_entr = table.Column<int>(type: "int", nullable: false),
                    obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteId_Cliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id_pedido);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteId_Cliente",
                        column: x => x.ClienteId_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_pedido",
                columns: table => new
                {
                    Id_dped = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_pedido = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Id_prod = table.Column<int>(type: "int", nullable: false),
                    producto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cant = table.Column<int>(type: "int", nullable: false),
                    und = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<float>(type: "real", nullable: false),
                    subtotal = table.Column<float>(type: "real", nullable: false),
                    ProductoId_prod = table.Column<int>(type: "int", nullable: true),
                    PedidoId_pedido = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_pedido", x => x.Id_dped);
                    table.ForeignKey(
                        name: "FK_Detalle_pedido_Pedido_PedidoId_pedido",
                        column: x => x.PedidoId_pedido,
                        principalTable: "Pedido",
                        principalColumn: "Id_pedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalle_pedido_Producto_ProductoId_prod",
                        column: x => x.ProductoId_prod,
                        principalTable: "Producto",
                        principalColumn: "Id_prod",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cita_ClienteId_Cliente",
                table: "Cita",
                column: "ClienteId_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_pedido_PedidoId_pedido",
                table: "Detalle_pedido",
                column: "PedidoId_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_pedido_ProductoId_prod",
                table: "Detalle_pedido",
                column: "ProductoId_prod");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId_Cliente",
                table: "Pedido",
                column: "ClienteId_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId_catg",
                table: "Producto",
                column: "CategoriaId_catg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "Detalle_pedido");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
