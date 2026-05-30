using GerenciadorDeJogos.Models;

namespace GerenciadorDeJogos.Repositories.Interfaces
{
    // Interface para o repositório de jogos, definindo os métodos que serão implementados para manipulação dos dados de jogos
    public interface IJogosRepository
    {
        // Propriedade para obter todos os jogos disponíveis, implementando a interface IJogosRepository
        IEnumerable<Jogo> Jogos { get; }

        // Método para obter um jogo específico pelo seu ID, implementando a interface IJogosRepository
        Jogo GetJogoById(int jogoId);
    }
}
