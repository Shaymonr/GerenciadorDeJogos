using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeJogos.Migrations
{
    /// <inheritdoc />
    public partial class AddJogoPreco : Migration
    {
        /// <inheritdoc />
        // Método responsável por aplicar as alterações no banco de dados, adicionando a coluna JogoPreco à tabela Jogos
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "JogoPreco",
                table: "Jogos",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        // Método responsável por reverter as alterações no banco de dados, removendo a coluna JogoPreco da tabela Jogos
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JogoPreco",
                table: "Jogos");
        }
    }
}
