using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuentinhasDoBill.Migrations
{
    public partial class initial_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_quentinhas_carrinho_CarrinhoId",
                table: "quentinhas");

            migrationBuilder.DropIndex(
                name: "IX_quentinhas_CarrinhoId",
                table: "quentinhas");

            migrationBuilder.DropColumn(
                name: "CarrinhoId",
                table: "quentinhas");

            migrationBuilder.CreateTable(
                name: "itens_carrinho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuentinhaId = table.Column<int>(type: "int", nullable: false),
                    CarrinhoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_ItemCarrinhoId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_itens_carrinho_carrinho_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "carrinho",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_itens_carrinho_quentinhas_QuentinhaId",
                        column: x => x.QuentinhaId,
                        principalTable: "quentinhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_itens_carrinho_CarrinhoId",
                table: "itens_carrinho",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_itens_carrinho_QuentinhaId",
                table: "itens_carrinho",
                column: "QuentinhaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itens_carrinho");

            migrationBuilder.AddColumn<int>(
                name: "CarrinhoId",
                table: "quentinhas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_quentinhas_CarrinhoId",
                table: "quentinhas",
                column: "CarrinhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_quentinhas_carrinho_CarrinhoId",
                table: "quentinhas",
                column: "CarrinhoId",
                principalTable: "carrinho",
                principalColumn: "Id");
        }
    }
}
