using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Modelos;

namespace Web.Controllers
{
    public class InscriptosController : Controller
    {
        private readonly CosmopolitaContext _context;

        public InscriptosController(CosmopolitaContext context)
        {
            _context = context;
        }

        // GET: Inscriptos
        public async Task<IActionResult> Index()
        {
            var cosmopolitaContext = _context.Inscriptos.Include(i => i.Actividad).Include(i => i.Socio);
            return View(await cosmopolitaContext.ToListAsync());
        }

        // GET: Inscriptos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Inscriptos == null)
            {
                return NotFound();
            }

            var inscripto = await _context.Inscriptos
                .Include(i => i.Actividad)
                .Include(i => i.Socio)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inscripto == null)
            {
                return NotFound();
            }

            return View(inscripto);
        }

        // GET: Inscriptos/Create
        public IActionResult Create()
        {
            ViewData["ActividadId"] = new SelectList(_context.Actividades, "Id", "Horarios");
            ViewData["SocioId"] = new SelectList(_context.Socios, "Id", "Apellido_Nombre");
            return View();
        }

        // POST: Inscriptos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SocioId,ActividadId")] Inscripto inscripto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inscripto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActividadId"] = new SelectList(_context.Actividades, "Id", "Horarios", inscripto.ActividadId);
            ViewData["SocioId"] = new SelectList(_context.Socios, "Id", "Apellido_Nombre", inscripto.SocioId);
            return View(inscripto);
        }

        // GET: Inscriptos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Inscriptos == null)
            {
                return NotFound();
            }

            var inscripto = await _context.Inscriptos.FindAsync(id);
            if (inscripto == null)
            {
                return NotFound();
            }
            ViewData["ActividadId"] = new SelectList(_context.Actividades, "Id", "Horarios", inscripto.ActividadId);
            ViewData["SocioId"] = new SelectList(_context.Socios, "Id", "Apellido_Nombre", inscripto.SocioId);
            return View(inscripto);
        }

        // POST: Inscriptos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SocioId,ActividadId")] Inscripto inscripto)
        {
            if (id != inscripto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inscripto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InscriptoExists(inscripto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActividadId"] = new SelectList(_context.Actividades, "Id", "Horarios", inscripto.ActividadId);
            ViewData["SocioId"] = new SelectList(_context.Socios, "Id", "Apellido_Nombre", inscripto.SocioId);
            return View(inscripto);
        }

        // GET: Inscriptos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Inscriptos == null)
            {
                return NotFound();
            }

            var inscripto = await _context.Inscriptos
                .Include(i => i.Actividad)
                .Include(i => i.Socio)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inscripto == null)
            {
                return NotFound();
            }

            return View(inscripto);
        }

        // POST: Inscriptos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Inscriptos == null)
            {
                return Problem("Entity set 'CosmopolitaContext.Inscriptos'  is null.");
            }
            var inscripto = await _context.Inscriptos.FindAsync(id);
            if (inscripto != null)
            {
                _context.Inscriptos.Remove(inscripto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InscriptoExists(int id)
        {
          return _context.Inscriptos.Any(e => e.Id == id);
        }
    }
}
