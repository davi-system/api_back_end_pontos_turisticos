using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_pontos_turisticos.Data;
using api_pontos_turisticos.Models;

namespace api_pontos_turisticos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontosTuristicosController : ControllerBase
    {
        private readonly PontoTuristicoContext _context;

        public PontosTuristicosController(PontoTuristicoContext context)
        {
            _context = context;
        }

        // GET: api/PontosTuristicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PontoTuristico>>> GetPontoTuristico()
        {
          if (_context.PontoTuristico == null)
          {
              return NotFound();
          }
            return await _context.PontoTuristico.ToListAsync();
        }

        // GET: api/PontosTuristicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PontoTuristico>> GetPontoTuristico(int id)
        {
          if (_context.PontoTuristico == null)
          {
              return NotFound();
          }
            var pontoTuristico = await _context.PontoTuristico.FindAsync(id);

            if (pontoTuristico == null)
            {
                return NotFound();
            }

            return pontoTuristico;
        }

        // PUT: api/PontosTuristicos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPontoTuristico(int id, PontoTuristico pontoTuristico)
        {
            if (id != pontoTuristico.Id)
            {
                return BadRequest();
            }

            _context.Entry(pontoTuristico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PontoTuristicoExists(id))
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

        // POST: api/PontosTuristicos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PontoTuristico>> PostPontoTuristico(PontoTuristico pontoTuristico)
        {
          if (_context.PontoTuristico == null)
          {
              return Problem("Entity set 'PontoTuristicoContext.PontoTuristico'  is null.");
          }
            _context.PontoTuristico.Add(pontoTuristico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPontoTuristico", new { id = pontoTuristico.Id }, pontoTuristico);
        }

        // DELETE: api/PontosTuristicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePontoTuristico(int id)
        {
            if (_context.PontoTuristico == null)
            {
                return NotFound();
            }
            var pontoTuristico = await _context.PontoTuristico.FindAsync(id);
            if (pontoTuristico == null)
            {
                return NotFound();
            }

            _context.PontoTuristico.Remove(pontoTuristico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PontoTuristicoExists(int id)
        {
            return (_context.PontoTuristico?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
