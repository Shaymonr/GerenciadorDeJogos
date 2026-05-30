using GerenciadorDeJogos.Models;
using GerenciadorDeJogos.Repositories.Interfaces;
using GerenciadorDeJogos.Context;

namespace GerenciadorDeJogos.Repositories
{
    // Implementação do repositório de categorias, responsável por acessar os dados de categorias no banco de dados
    public class CategoriaRepository : ICategoriaRepository
    {
        // Campo privado para armazenar a instância do contexto do banco de dados
        private readonly AppDbContext _context;
        // Construtor que recebe o contexto do banco de dados por meio de injeção de dependência
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        // Propriedade para obter todas as categorias disponíveis, implementando a interface ICategoriaRepository
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
