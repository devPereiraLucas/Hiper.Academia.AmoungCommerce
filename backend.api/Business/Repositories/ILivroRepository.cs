using backend.api.Business.Entities;
using System.Collections.Generic;

namespace backend.api.Business.Repositories
{
    public interface ILivroRepository
    {
        void Adicionar(Livro livro);
        void Commit();
        IList<Livro> BuscarBuscarTodosLivros();
    }
}
