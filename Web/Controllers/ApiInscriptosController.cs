using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Modelos;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiInscriptosController : ControllerBase
    {
        private readonly CosmopolitaContext _context;

        public ApiInscriptosController(CosmopolitaContext context)
        {
            _context = context;
        }

        // GET: api/ApiInscriptos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inscripto>>> GetInscriptos()
        {
            return await _context.Inscriptos.ToListAsync();
        }

        // GET: api/ApiInscriptos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inscripto>> GetInscripto(int id)
        {
            var inscripto = await _context.Inscriptos.FindAsync(id);

            if (inscripto == null)
            {
                return NotFound();
            }

            return inscripto;
        }

        // PUT: api/ApiInscriptos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInscripto(int id, Inscripto inscripto)
        {
            if (id != inscripto.Id)
            {
                return BadRequest();
            }

            _context.Entry(inscripto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InscriptoExists(id))
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

        // POST: api/ApiInscriptos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Inscripto>> PostInscripto(Inscripto inscripto)
        {
            _context.Inscriptos.Add(inscripto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInscripto", new { id = inscripto.Id }, inscripto);
        }

        // DELETE: api/ApiInscriptos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInscripto(int id)
        {
            var inscripto = await _context.Inscriptos.FindAsync(id);
            if (inscripto == null)
            {
                return NotFound();
            }

            _context.Inscriptos.Remove(inscripto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InscriptoExists(int id)
        {
            return _context.Inscriptos.Any(e => e.Id == id);
        }
    }
}
