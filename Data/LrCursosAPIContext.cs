using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LrCursosAPI.Models;

namespace LrCursosAPI.Data
{
    public class LrCursosAPIContext : DbContext
    {
        public LrCursosAPIContext (DbContextOptions<LrCursosAPIContext> options)
            : base(options)
        {
        }

        public DbSet<LrCursosAPI.Models.Curso>? Curso { get; set; }

        public DbSet<LrCursosAPI.Models.Conteudo>? Conteudo { get; set; }

        public DbSet<LrCursosAPI.Models.Autenticacao>? Autenticacao { get; set; }

        public DbSet<LrCursosAPI.Models.ConteudoVisto>? ConteudoVisto { get; set; }
    }
}
