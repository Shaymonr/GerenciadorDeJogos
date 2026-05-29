namespace GerenciadorDeJogos.Models
{
    public class Categoria
    {
        // Propriedades do modelo Categoria
        public int CategoriaId { get; set; }
    
        public string CategoriaNome { get; set; }

        // Propriedade de navegação para os jogos relacionados a esta categoria
        public List<Jogo> Jogos { get; set; }


    }
}

