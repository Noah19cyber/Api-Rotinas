using ApiRotina.Models;
using Microsoft.AspNetCore.Mvc;
using ApiRotina.Data;
using Microsoft.EntityFrameworkCore;


namespace ApiRotina.Controllers
{
    

    [Route("[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly DataContext _context;

        public TarefasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Tarefass
        [HttpGet]
        public async Task<IActionResult> GetTarefas()
        {
            var tarefas = await _context.Tarefas.ToListAsync();
            return Ok(tarefas);
        }

        // GET: api/Tarefas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTarefa(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);

            if (tarefa == null)
            {
                return NotFound();
            }

            return Ok(tarefa);
        }

        // POST: api/Tarefas
        [HttpPost]
        public async Task<IActionResult> PostTarefa([FromBody] Tarefa tarefa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tarefas.Add(tarefa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTarefa), new { id = tarefa.Id }, tarefa);
        }

        // PUT: api/Tarefas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarefa(int id, [FromBody] Tarefa tarefa)
        {
            if (id != tarefa.Id)
            {
                return BadRequest();
            }

            _context.Entry(tarefa).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarefaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // PATCH: api/Tarefas/5/concluir
        [HttpPatch("{id}/concluir")]
        public async Task<IActionResult> ConcluirTarefa(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);

            if (tarefa == null)
            {
                return NotFound();
            }

            tarefa.Concluida = true;
            _context.Entry(tarefa).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(tarefa);
        }

        // DELETE: api/Tarefas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarefa(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);
            if (tarefa == null)
            {
                return NotFound();
            }

            _context.Tarefas.Remove(tarefa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TarefaExists(int id)
        {
            return _context.Tarefas.Any(e => e.Id == id);
        }
    }
    }
