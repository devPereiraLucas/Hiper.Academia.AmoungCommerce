using backend.api.Business.Entities;
using backend.api.Business.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace backend.api.Infrastructure.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly LivroDbContext _contexto;

        public LivroRepository(LivroDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Livro livro)
        {
            _contexto.Livro.Add(livro);
        }

        public IList<Livro> BuscarBuscarTodosLivros()
        {
            return _contexto.Livro.ToList();
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }
    }
}
