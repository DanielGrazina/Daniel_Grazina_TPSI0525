using Microsoft.AspNetCore.Mvc;

namespace exercicio1_api_vs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() =>
            Ok(new[] { new { id = 1, nome = "Parafuso", preco = 0.5, quantidade = 100 } });

        [HttpPost]
        public IActionResult Post([FromBody] dynamic p)
        {
            int quantidade = (int)(p?.quantidade ?? 0);
            if (quantidade <= 0)
                return BadRequest(new { erro = "Quantidade inválida" });
            return Created("/api/produtos/2", new { id = 2, mensagem = "Produto criado" });
        }

        [HttpPut("{id}/stock")]
        public IActionResult AtualizarStock(int id) =>
            Ok(new { mensagem = "Stock atualizado" });

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            StatusCode(409, new { erro = "Stock não é zero" });
    }
}
