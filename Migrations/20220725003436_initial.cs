using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuentinhasDoBill.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carrinho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_CarrinhoId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Canceled = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_PedidoId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_TipoId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "quentinhas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CarrinhoId = table.Column<int>(type: "int", nullable: true),
                    TipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_QuentinhaId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_quentinhas_carrinho_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "carrinho",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_quentinhas_tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "tipos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "itens_pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuentinhaId = table.Column<int>(type: "int", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_ItemPedidoId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_itens_pedido_pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "pedidos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_itens_pedido_quentinhas_QuentinhaId",
                        column: x => x.QuentinhaId,
                        principalTable: "quentinhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_itens_pedido_PedidoId",
                table: "itens_pedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_itens_pedido_QuentinhaId",
                table: "itens_pedido",
                column: "QuentinhaId");

            migrationBuilder.CreateIndex(
                name: "IX_quentinhas_CarrinhoId",
                table: "quentinhas",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_quentinhas_TipoId",
                table: "quentinhas",
                column: "TipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itens_pedido");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "quentinhas");

            migrationBuilder.DropTable(
                name: "carrinho");

            migrationBuilder.DropTable(
                name: "tipos");
        }
    }
}
