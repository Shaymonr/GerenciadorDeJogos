using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeJogos.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
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
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
