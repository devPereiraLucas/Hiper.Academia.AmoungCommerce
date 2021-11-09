namespace backend.api.Business.Entities
{
    public class Livro
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Nivel { get; set; }

        public decimal Preco { get; set; }

    }
}
