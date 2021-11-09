using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using backend.api.Filters;
using backend.api.Business.Entities;
using backend.api.Business.Repositories;
using System.Linq;
using backend.api.Models;
using Microsoft.AspNetCore.Cors;

namespace backend.api.Controllers
{
    [EnableCors("mypolicy")]
    [Route("api/livro")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;

        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [SwaggerResponse(statusCode: 200, description: "Sucesso ao criar livro", Type = typeof(LivroModel))]
        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios", Type = typeof(ValidaCampoModel))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoModel))]
        [HttpPost]
        [Route("registrar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult RegistrarLivro(Livro livro)
        {

            Livro Novolivro = new Livro();
            Novolivro.ImageUrl = livro.ImageUrl;
            Novolivro.Titulo = livro.Titulo;
            Novolivro.Autor = livro.Autor;
            Novolivro.Nivel = livro.Nivel;
            Novolivro.Preco = livro.Preco;

            _livroRepository.Adicionar(livro);
            _livroRepository.Commit();

            return Created("", livro);
        }

        [SwaggerResponse(statusCode: 200, description: "Sucesso ao buscar livros", Type = typeof(LivroModel))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoModel))]
        [HttpGet]
        [Route("listarTodos")]
        public IActionResult BuscarTodosLivros()
        {
            var livros = _livroRepository.BuscarBuscarTodosLivros()
                .Select(s => new LivroModel()
                {
                    ImageUrl = s.ImageUrl,
                    Titulo = s.Titulo,
                    Autor = s.Autor,
                    Nivel = s.Nivel,
                    Preco = s.Preco
                });
            
            return Ok(livros);
        }
    }
}
