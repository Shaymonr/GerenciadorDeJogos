using GerenciadorDeJogos.Repositories.Interfaces;
using GerenciadorDeJogos.Context;
using GerenciadorDeJogos.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeJogos.Repositories
{
    // Implementação do repositório de jogos, responsável por acessar os dados de jogos no banco de dados
    public class JogosRepository : IJogosRepository
    {
        private readonly AppDbContext _context;
        public JogosRepository(AppDbContext context)
        {
              _context = context;
        }
        // Campo privado para armazenar a instância do contexto do banco de dados
        public IEnumerable<Jogo> Jogos => _context.Jogos.Include(c=> c.Categoria);

        // Construtor que recebe o contexto do banco de dados como dependência
        public Jogo GetJogoById(int jogoId)
        {
            return _context.Jogos.FirstOrDefault(l => l.JogoId == jogoId);
        }
    }
}
