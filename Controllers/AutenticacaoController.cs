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
    public class AutenticacaoController : ControllerBase
    {
        private readonly LrCursosAPIContext _context;

        public AutenticacaoController(LrCursosAPIContext context)
        {
            _context = context;
        }

        // GET: api/Autenticacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autenticacao>>> GetAutenticacao()
        {
          if (_context.Autenticacao == null)
          {
              return NotFound();
          }
            return await _context.Autenticacao.ToListAsync();
        }

        // GET: api/Autenticacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Autenticacao>> GetAutenticacao(int id)
        {
          if (_context.Autenticacao == null)
          {
              return NotFound();
          }
            var autenticacao = await _context.Autenticacao.FindAsync(id);

            if (autenticacao == null)
            {
                return NotFound();
            }

            return autenticacao;
        }

        // PUT: api/Autenticacao/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutenticacao(int id, Autenticacao autenticacao)
        {
            if (id != autenticacao.Id)
            {
                return BadRequest();
            }

            _context.Entry(autenticacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutenticacaoExists(id))
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

        // POST: api/Autenticacao
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Autenticacao>> PostAutenticacao(Autenticacao autenticacao)
        {
          if (_context.Autenticacao == null)
          {
              return Problem("Entity set 'LrCursosAPIContext.Autenticacao'  is null.");
          }
            _context.Autenticacao.Add(autenticacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutenticacao", new { id = autenticacao.Id }, autenticacao);
        }

        // DELETE: api/Autenticacao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutenticacao(int id)
        {
            if (_context.Autenticacao == null)
            {
                return NotFound();
            }
            var autenticacao = await _context.Autenticacao.FindAsync(id);
            if (autenticacao == null)
            {
                return NotFound();
            }

            _context.Autenticacao.Remove(autenticacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AutenticacaoExists(int id)
        {
            return (_context.Autenticacao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
