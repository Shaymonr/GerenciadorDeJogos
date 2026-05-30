using GerenciadorDeJogos.Models;

namespace GerenciadorDeJogos.Repositories.Interfaces
{
    //Interface para o repositório de categorias, definindo os métodos que serão implementados para manipulação dos dados de categorias
    public interface ICategoriaRepository
    {
        // Método para obter todas as categorias disponíveis
        IEnumerable<Categoria> Categorias { get; }
    }
}
