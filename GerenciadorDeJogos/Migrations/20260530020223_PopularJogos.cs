using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeJogos.Migrations
{
    /// <inheritdoc />
    public partial class PopularJogos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Jogos (JogoNome, JogoDescricao,StatusJogo, CategoriaId) VALUES ('God Of War', 'Um jogo de ação e aventura.', 'Completo', 2)");
            migrationBuilder.Sql("INSERT INTO Jogos (JogoNome, JogoDescricao,StatusJogo, CategoriaId) VALUES ('GTA V', 'Um jogo de Mundo aberto desenvolvido pela Rockstar.', 'Completo', 3)");
            migrationBuilder.Sql("INSERT INTO Jogos (JogoNome, JogoDescricao,StatusJogo, CategoriaId) VALUES ('Minecraft', 'Um jogo de construção e sobrevivência em um mundo aberto. Estilo Sandbox', 'Completo', 5)");
            migrationBuilder.Sql("INSERT INTO Jogos (JogoNome, JogoDescricao,StatusJogo, CategoriaId) VALUES ('The Last Of Us', 'Um jogo de sobrevivência.', 'Completo', 7)");
            migrationBuilder.Sql("INSERT INTO Jogos (JogoNome, JogoDescricao,StatusJogo, CategoriaId) VALUES ('Stardeew Valley', 'Um jogo Simulação com uma ótima história', 'Completo', 6)");
//            migrationBuilder.Sql("INSERT INTO Jogos (JogoNome, JogoDescricao,StatusJogo, CategoriaId) VALUES ('The Witcher 3', 'Um jogo de RPG com uma história envolvente', 'Completo', 4)");
            migrationBuilder.Sql("INSERT INTO Jogos (JogoNome, JogoDescricao,StatusJogo, CategoriaId) VALUES ('Cyberpunk 2077', 'Um jogo de RPG com uma história envolvente.', 'Completo', 4)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
