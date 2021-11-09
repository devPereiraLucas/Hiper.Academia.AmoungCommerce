using System.ComponentModel.DataAnnotations;

namespace backend.api.Models
{
    public class LivroModel
    {
        public string ImageUrl { get;  set; }

        [Required(ErrorMessage = "O nome do livro é obrigatorio")]
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Nivel { get; set; }

        public decimal Preco { get; set; }

    }
}
