using Microsoft.AspNetCore.Mvc;

namespace exercicio1_api_vs.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] dynamic p)
        {
            int quantidade = (int)(p?.quantidade ?? 0);
            if (quantidade <= 0)
                return BadRequest(new { erro = "Quantidade inválida" });

            int clienteId = (int)(p?.clienteId ?? 0);
            if (clienteId == 0)
                return NotFound(new { erro = "Cliente inexistente" });

            return Created("", new { mensagem = "Pedido criado" });
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id) =>
            Ok(new { mensagem = "Estado atualizado" });

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            StatusCode(403, new { erro = "Só enquanto 'Em processamento'" });
    }
}
