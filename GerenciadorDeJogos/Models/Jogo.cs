namespace GerenciadorDeJogos.Models
{
    public class Jogo
    {
        // Propriedades do modelo Jogo
        public int JogoId { get; set; }

        public string JogoNome { get; set; }

        public string JogoDescricao { get; set; }

        public string JogoImagem { get; set; }

        public string JogoMiniatura { get; set; }
        
        public bool JogoConcluido { get; set; }

        // Chave estrangeira para Categoria
        public int CategoriaId { get; set; }
        // Propriedade de navegação para Categoria
        public virtual Categoria Categoria { get; set; }

    }
}
