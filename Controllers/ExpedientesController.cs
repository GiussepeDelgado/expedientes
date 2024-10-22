using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestionExpedientesAPI.Data;
using GestionExpedientesAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionExpedientesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpedientesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExpedientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/expedientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expediente>>> GetExpedientes()
        {
            return await _context.Expedientes.ToListAsync();
        }

        // GET: api/expedientes/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Expediente>> GetExpediente(int id)
        {
            var expediente = await _context.Expedientes.FindAsync(id);

            if (expediente == null)
            {
                return NotFound();
            }

            return expediente;
        }

        // POST: api/expedientes
        [HttpPost]
        public async Task<ActionResult<Expediente>> PostExpediente(Expediente expediente)
        {
            _context.Expedientes.Add(expediente);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetExpediente), new { id = expediente.Indice }, expediente);
        }

        // PUT: api/expedientes/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpediente(int id, Expediente expediente)
        {
            if (id != expediente.Indice)
            {
                return BadRequest();
            }

            _context.Entry(expediente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpedienteExists(id))
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

        // DELETE: api/expedientes/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpediente(int id)
        {
            var expediente = await _context.Expedientes.FindAsync(id);
            if (expediente == null)
            {
                return NotFound();
            }

            _context.Expedientes.Remove(expediente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExpedienteExists(int id)
        {
            return _context.Expedientes.Any(e => e.Indice == id);
        }
    }
}
