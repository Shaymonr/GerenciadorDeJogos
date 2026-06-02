// Esse arquivo define o ViewModel para a exibição dos jogos na loja, contendo uma coleção de jogos e a categoria atual.
// O ViewModel é uma classe que serve como um modelo de dados para a view, permitindo que a view acesse os dados necessários
// para exibir as informações corretamente. Neste caso, o ViewModel inclui uma propriedade para a coleção de jogos a ser exibida
// na loja e outra propriedade para a categoria atual dos jogos exibidos.

using GerenciadorDeJogos.Models;

namespace GerenciadorDeJogos.ViewModels
    
{
    // ViewModel para a exibição dos jogos na loja, contendo uma coleção de jogos e a categoria atual
    public class JogosViewModel
    {
        // Propriedade que representa a coleção de jogos a ser exibida na loja
        public IEnumerable<Jogo> Jogos { get; set; }
        // Propriedade que representa a categoria atual dos jogos exibidos
        public string CategoriaAtual {get; set; }

    }
}
