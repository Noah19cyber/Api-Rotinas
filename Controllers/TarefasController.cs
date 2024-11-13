using ApiRotina.Models;
using Microsoft.AspNetCore.Mvc;


public class Atividade {
    private int Id;
    private  String nome;
    private String horario;
    private String descricao;}// Certifique-se de que este namespace está correto

namespace ApiRotina.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        // Exemplos de métodos de ação
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Tudo certo!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Tarefa tarefa)
        {
            if (tarefa == null)
            {
                return BadRequest();
            }

            // Lógica para adicionar a tarefa
            return CreatedAtAction(nameof(Get), new { Id = tarefa.Id }, tarefa);
        }
    }
}

