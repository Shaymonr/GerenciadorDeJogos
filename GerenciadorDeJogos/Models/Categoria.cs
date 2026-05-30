using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorDeJogos.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        // Propriedades do modelo Categoria

        // Atributos de validação para o ID da categoria
        [Key]
        [Required]
        public int CategoriaId { get; set; }

        // Atributos de validação para o nome da categoria
        [Required(ErrorMessage = "O nome da Categoria deve ser informado!")]
        [Display(Name = "Nome da Categoria")]
        [StringLength(100, ErrorMessage = "O nome da Categoria deve ter no máximo 100 caracteres!")]

        public string CategoriaNome { get; set; }

        // Propriedade de navegação para os jogos relacionados a esta categoria
        public List<Jogo> Jogos { get; set; }


    }
}

