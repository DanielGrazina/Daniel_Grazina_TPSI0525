using exercicio1_api_vs.Data;
using exercicio1_api_vs.Models;
using Microsoft.AspNetCore.Mvc;

namespace exercicio1_api_vs.Controllers
{
    [ApiController]
    [Route("api/emprestimos")]
    public class LoansController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] dynamic e)
        {
            string? livro = e?.livro;
            if (livro == null)
                return NotFound(new { erro = "Livro não encontrado" });
            return Created("", new { mensagem = "Empréstimo registado" });
        }

        [HttpPut("{id}/devolucao")]
        public IActionResult Devolver(int id) =>
            Ok(new { mensagem = "Livro devolvido" });
    }
}