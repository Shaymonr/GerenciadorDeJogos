using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorDeJogos.Models
{
    // Modelo de dados para a entidade Jogo, representando um jogo no sistema
    [Table("Jogos")]
    public class Jogo
    {
        // Propriedades do modelo Jogo

        // Atributos de validação para o ID do jogo
        [Required]
        [Key]
        public int JogoId { get; set; }
      
        // Atributos de validação para o nome do jogo
        [Required(ErrorMessage ="O nome do Jogo deve ser informado!")]
        [Display(Name ="Nome do Jogo")]
        [StringLength(80,MinimumLength = 3, ErrorMessage = "O nome do Jogo deve ter entre 3 e 80 caracteres!")]
        public string JogoNome { get; set; }

        // Atributos de validação para a descrição do jogo
        [Required(ErrorMessage = "A descrição do Jogo deve ser informada!")]
        [Display(Name = "Descrição do Jogo")]
        public string JogoDescricao { get; set; }

        // Atributos de validação para a imagem do jogo
        [Display(Name = "Url da Imagem do Jogo")]
        public string JogoImagem { get; set; }

        // Atributos de validação para a miniatura do jogo
        [Display(Name = "Url da Miniatura do Jogo")]
        public string JogoMiniatura { get; set; }

        // Atributos de validação para o status do jogo
        [Display(Name = "Status do Jogo")]
        [StringLength(20)]
        public string StatusJogo{ get; set; }

        // Chave estrangeira para Categoria

        [Required(ErrorMessage = "A categoria do Jogo deve ser informada!")]
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        // Propriedade de navegação para Categoria
        public virtual Categoria Categoria { get; set; }

    }
}
