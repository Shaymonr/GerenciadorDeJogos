using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeJogos.Migrations
{
    /// <inheritdoc />
    public partial class CarrinhoCompras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carrinhoCompras",
                columns: table => new
                {
                    CarrinhoComprasItensId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JogoId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarrinhoComprasId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carrinhoCompras", x => x.CarrinhoComprasItensId);
                    table.ForeignKey(
                        name: "FK_carrinhoCompras_Jogos_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogos",
                        principalColumn: "JogoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_carrinhoCompras_JogoId",
                table: "carrinhoCompras",
                column: "JogoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carrinhoCompras");
        }
    }
}
