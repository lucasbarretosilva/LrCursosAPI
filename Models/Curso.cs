using System.ComponentModel.DataAnnotations;

namespace LrCursosAPI.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }

        [StringLength(100)]
      
        public string CursoNome { get; set; } = string.Empty;

      
        public string ImagemUrl { get; set; } = string.Empty;

        [StringLength(200)]
        public string Descricao { get; set; } = string.Empty ;

        public string Duracao { get; set; } = string.Empty ;

        public IEnumerable<Conteudo> Conteudos { get; set; } = new List<Conteudo>();
    }
}
