using System.ComponentModel.DataAnnotations;

namespace LrCursosAPI.Models
{
    public class Carrinho
    {
        [Key]
        public int CarrinhoId { get; set; }

        public int CursoId { get; set; }

        public string TipoPagamento { get; set; }
    }
}
