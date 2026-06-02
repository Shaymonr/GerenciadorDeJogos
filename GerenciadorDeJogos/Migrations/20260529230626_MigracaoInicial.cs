// Esse código é uma migração do Entity Framework Core, que é usada para criar as tabelas "Categorias" e "Jogos" no banco de dados.
// A migração define as colunas, chaves primárias e relacionamentos entre as tabelas. O método "Up" é responsável por aplicar as
// alterações no banco de dados, enquanto o método "Down" reverte essas alterações, removendo as tabelas criadas.

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeJogos.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
       // Método responsável por aplicar as alterações no banco de dados, criando as tabelas Categorias e Jogos, definindo suas colunas,
       // chaves primárias e relacionamentos
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    JogoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JogoNome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    JogoDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JogoImagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JogoMiniatura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusJogo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.JogoId);
                    table.ForeignKey(
                        name: "FK_Jogos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_CategoriaId",
                table: "Jogos",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        // Método responsável por reverter as alterações no banco de dados, removendo as tabelas Jogos e Categorias
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
