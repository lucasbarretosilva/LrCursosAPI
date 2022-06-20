using System.ComponentModel.DataAnnotations;

namespace LrCursosAPI.Models
{
    public class Conteudo
    {
        [Key]
        public int ConteudoId { get; set; }

        [StringLength(100)]
        public string TituloAula { get; set; }

        public string UrlAula { get; set; }

        public int CursoId { get; set; }

        public Curso Curso { get; set; }
    }
}
