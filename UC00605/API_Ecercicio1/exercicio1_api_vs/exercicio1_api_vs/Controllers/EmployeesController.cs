using Microsoft.AspNetCore.Mvc;

namespace exercicio1_api_vs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new object[] { });

        [HttpPost]
        public IActionResult Post([FromBody] dynamic e)
        {
            double salario = (double)(e?.salario ?? 0);
            if (salario < 760)
                return BadRequest(new { erro = "Salário abaixo do mínimo" });

            return Created("", new { mensagem = "Funcionário criado" });
        }

        [HttpPut("{id}/salario")]
        public IActionResult AtualizarSalario(int id) =>
            Ok(new { mensagem = "Salário atualizado" });

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            BadRequest(new { erro = "Funcionário tem tarefas pendentes" });
    }
}
