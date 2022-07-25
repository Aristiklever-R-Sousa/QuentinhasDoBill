using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuentinhasDoBill.Migrations
{
    public partial class initial_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "itens_pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "itens_carrinho",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "itens_pedido");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "itens_carrinho");
        }
    }
}
