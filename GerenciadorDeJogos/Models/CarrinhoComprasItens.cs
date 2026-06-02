//Aqui está o código completo para a classe CarrinhoComprasItens, que representa os itens do carrinho de compras
//em um sistema de gerenciamento de jogos. Esta classe inclui propriedades para o ID do item do carrinho,
//o jogo associado, a quantidade, o preço e o ID do carrinho de compras ao qual o item pertence.
//A propriedade CarrinhoComprasId é decorada com o atributo StringLength para limitar seu comprimento a 200 caracteres.

using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeJogos.Models
{
    public class CarrinhoComprasItens
    {
        // Propriedades do modelo CarrinhoComprasItens

        // Chave primária para o item do carrinho de compras
        public int CarrinhoComprasItensId { get; set; }
        // Chave estrangeira para o carrinho de compras       
        public Jogo Jogo { get; set; }
        // Propriedade que representa a quantidade de itens do jogo no carrinho de compras
        public int Quantidade { get; set; }
        // Propriedade que representa o preço do jogo no carrinho de compras
        public decimal Preco { get; set; }
        // Propriedade que representa o ID do carrinho de compras ao qual o item pertence
        [StringLength(200)]
        public string CarrinhoComprasId { get; set; }
    }
}
