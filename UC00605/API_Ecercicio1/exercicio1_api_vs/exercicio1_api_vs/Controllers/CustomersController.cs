using Microsoft.AspNetCore.Mvc;

namespace exercicio1_api_vs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new object[] { });

        [HttpPost]
        public IActionResult Post() =>
            Created("", new { mensagem = "Cliente criado" });

        [HttpGet("{id}/pedidos")]
        public IActionResult GetPedidos(int id) => Ok(new object[] { });
    }
}
