using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeJogos.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        // Método responsável por aplicar as alterações no banco de dados, inserindo registros de categorias na tabela Categorias
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome) VALUES ('Ação')");
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome) VALUES ('Mundo Aberto')");
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome) VALUES ('RPG')");
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome) VALUES ('Sandbox')");
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome) VALUES ('Simulação')");
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome) VALUES ('Sobrevivência')");
        }

        /// <inheritdoc />
       // Método responsável por reverter as alterações no banco de dados, removendo os registros de categorias inseridos na tabela Categorias
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
