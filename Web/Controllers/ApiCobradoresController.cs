﻿using System;
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
    public class ApiCobradoresController : ControllerBase
    {
        private readonly CosmopolitaContext _context;

        public ApiCobradoresController(CosmopolitaContext context)
        {
            _context = context;
        }

        // GET: api/ApiCobradores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cobrador>>> GetCobradores()
        {
            return await _context.Cobradores.ToListAsync();
        }

        // GET: api/ApiCobradores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cobrador>> GetCobrador(int id)
        {
            var cobrador = await _context.Cobradores.FindAsync(id);

            if (cobrador == null)
            {
                return NotFound();
            }

            return cobrador;
        }

        // PUT: api/ApiCobradores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCobrador(int id, Cobrador cobrador)
        {
            if (id != cobrador.Id)
            {
                return BadRequest();
            }

            _context.Entry(cobrador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CobradorExists(id))
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

        // POST: api/ApiCobradores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cobrador>> PostCobrador(Cobrador cobrador)
        {
            _context.Cobradores.Add(cobrador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCobrador", new { id = cobrador.Id }, cobrador);
        }

        // DELETE: api/ApiCobradores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCobrador(int id)
        {
            var cobrador = await _context.Cobradores.FindAsync(id);
            if (cobrador == null)
            {
                return NotFound();
            }

            _context.Cobradores.Remove(cobrador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CobradorExists(int id)
        {
            return _context.Cobradores.Any(e => e.Id == id);
        }
    }
}
