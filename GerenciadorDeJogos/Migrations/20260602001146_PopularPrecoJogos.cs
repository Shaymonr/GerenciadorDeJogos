using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeJogos.Migrations
{
    /// <inheritdoc />
    public partial class PopularPrecoJogos : Migration
    {
        /// <inheritdoc />

        // Método responsável por aplicar as alterações no banco de dados, atualizando os preços dos jogos
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            UPDATE Jogos
            SET JogoPreco = 199.90
            WHERE JogoNome = 'God Of War';
        ");

            migrationBuilder.Sql(@"
            UPDATE Jogos
            SET JogoPreco = 119.90
            WHERE JogoNome = 'GTA V';
        ");

            migrationBuilder.Sql(@"
            UPDATE Jogos
            SET JogoPreco = 99.90
            WHERE JogoNome = 'Minecraft';
        ");

            migrationBuilder.Sql(@"
            UPDATE Jogos
            SET JogoPreco = 249.90
            WHERE JogoNome = 'The Last Of Us';
        ");

            migrationBuilder.Sql(@"
            UPDATE Jogos
            SET JogoPreco = 24.99
            WHERE JogoNome = 'Stardew Valley';
        ");

            migrationBuilder.Sql(@"
            UPDATE Jogos
            SET JogoPreco = 149.90
            WHERE JogoNome = 'Cyberpunk 2077';
        ");
        }
        /// <inheritdoc />
        // Método responsável por reverter as alterações no banco de dados, definindo os preços dos jogos como zero
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            UPDATE Jogos
            SET Preco = 0;
        ");
        }
    }
}
