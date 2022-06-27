using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LrCursosAPI.Data;
using LrCursosAPI.Models;

namespace LrCursosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConteudosVistosController : ControllerBase
    {
        private readonly LrCursosAPIContext _context;

        public ConteudosVistosController(LrCursosAPIContext context)
        {
            _context = context;
        }

        // GET: api/ConteudosVistos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConteudoVisto>>> GetConteudoVisto()
        {
          if (_context.ConteudoVisto == null)
          {
              return NotFound();
          }
            return await _context.ConteudoVisto.Include(x=> x.Conteudo).Include(y=> y.Autenticacao)
                .Include(z=> z.Conteudo.Curso)
                .ToListAsync();
        }

        // GET: api/ConteudosVistos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConteudoVisto>> GetConteudoVisto(int id)
        {
          if (_context.ConteudoVisto == null)
          {
              return NotFound();
          }
            var conteudoVisto = await _context.ConteudoVisto.FindAsync(id);

            if (conteudoVisto == null)
            {
                return NotFound();
            }

            return conteudoVisto;
        }

        // PUT: api/ConteudosVistos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConteudoVisto(int id, ConteudoVisto conteudoVisto)
        {
            if (id != conteudoVisto.Id)
            {
                return BadRequest();
            }

            _context.Entry(conteudoVisto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConteudoVistoExists(id))
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

        // POST: api/ConteudosVistos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConteudoVisto>> PostConteudoVisto(ConteudoVisto conteudoVisto)
        {
          if (_context.ConteudoVisto == null)
          {
              return Problem("Entity set 'LrCursosAPIContext.ConteudoVisto'  is null.");
          }
            _context.ConteudoVisto.Add(conteudoVisto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConteudoVisto", new { id = conteudoVisto.Id }, conteudoVisto);
        }

        // DELETE: api/ConteudosVistos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConteudoVisto(int id)
        {
            if (_context.ConteudoVisto == null)
            {
                return NotFound();
            }
            var conteudoVisto = await _context.ConteudoVisto.FindAsync(id);
            if (conteudoVisto == null)
            {
                return NotFound();
            }

            _context.ConteudoVisto.Remove(conteudoVisto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConteudoVistoExists(int id)
        {
            return (_context.ConteudoVisto?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
