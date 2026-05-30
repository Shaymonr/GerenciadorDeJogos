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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
