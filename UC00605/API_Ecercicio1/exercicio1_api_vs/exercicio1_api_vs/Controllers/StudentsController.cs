using exercicio1_api_vs.Models;
using exercicio1_api_vs.Data;
using Microsoft.AspNetCore.Mvc;
using System;

namespace exercicio1_api_vs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ApiContext _context;

        public StudentsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() =>
            Ok(new[] { new { id = 1, nome = "Ana", idade = 15, curso = "TI" } });

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id == 1)
                return Ok(new { id = 1, nome = "Ana", idade = 15, curso = "TI" });
            return NotFound(new { erro = "Aluno não encontrado" });
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student s)
        {
            if (s.Idade < 15)
                return BadRequest(new { erro = "Idade mínima não atingida" });
            return Created("/api/alunos/2", new { id = 2, mensagem = "Aluno criado" });
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id) =>
            Ok(new { mensagem = "Aluno atualizado" });

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            StatusCode(403, new { erro = "Sem permissão para apagar" });
    }
}
