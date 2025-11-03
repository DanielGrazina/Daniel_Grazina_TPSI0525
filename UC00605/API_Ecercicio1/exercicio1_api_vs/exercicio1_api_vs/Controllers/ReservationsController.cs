using Microsoft.AspNetCore.Mvc;

namespace exercicio1_api_vs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new object[] { });

        [HttpPost]
        public IActionResult Post([FromBody] dynamic r)
        {
            DateTime checkin = r?.checkin ?? DateTime.Now;
            DateTime checkout = r?.checkout ?? DateTime.Now.AddDays(-1);

            if (checkout < checkin)
                return BadRequest(new { erro = "Checkout anterior ao checkin" });

            return Created("/api/reservas/10", new { id = 10, mensagem = "Reserva criada" });
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id) =>
            Ok(new { mensagem = "Reserva atualizada" });

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            StatusCode(403, new { erro = "Não é possível cancelar após checkin" });
    }
}
