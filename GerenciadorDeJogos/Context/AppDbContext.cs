// Esse arquivo define a classe de contexto do Entity Framework para o aplicativo de gerenciamento de jogos.
// Ele inclui as propriedades DbSet para as entidades do modelo, como Categoria, Jogo e CarrinhoComprasItens,
// permitindo que o Entity Framework gerencie as operações de banco de dados para essas entidades.
// O construtor da classe recebe as opções de configuração do contexto, que são passadas para a classe base DbContext.
using Microsoft.EntityFrameworkCore;
using GerenciadorDeJogos.Models;


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
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<CarrinhoComprasItens> carrinhoCompras { get; set; }
    }
}
