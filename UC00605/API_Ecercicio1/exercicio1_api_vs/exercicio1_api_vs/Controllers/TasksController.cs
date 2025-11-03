using Microsoft.AspNetCore.Mvc;

namespace exercicio1_api_vs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new object[] { });

        [HttpPost]
        public IActionResult Post([FromBody] dynamic t)
        {
            string titulo = t?.titulo;
            if (string.IsNullOrWhiteSpace(titulo))
                return BadRequest(new { erro = "Título vazio" });
            return Created("", new { mensagem = "Tarefa criada" });
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id) =>
            Ok(new { mensagem = "Tarefa atualizada" });

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            StatusCode(403, new { erro = "Só pode apagar tarefa concluída" });
    }
}
