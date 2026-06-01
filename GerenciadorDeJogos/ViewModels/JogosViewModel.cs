using GerenciadorDeJogos.Models;

namespace GerenciadorDeJogos.ViewModels
    
{
    public class JogosViewModel
    {
        public IEnumerable<Jogo> Jogos { get; set; }
        public string CategoriaAtual {get; set; }

    }
}
