using Microsoft.EntityFrameworkCore;


namespace GerenciadorDeJogos.Context
{
    // Classe de contexto do Entity Framework para o aplicativo
    public class AppDbContext : DbContext
    {
        // Construtor que recebe as opções de configuração do contexto
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Propriedades DbSet para as entidades do modelo
        public DbSet<Models.Categoria> Categorias { get; set; }
        public DbSet<Models.Jogo> Jogos { get; set; }
    
    }
}
