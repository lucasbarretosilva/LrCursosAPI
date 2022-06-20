using System.ComponentModel.DataAnnotations;

namespace LrCursosAPI.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório!")]
        [StringLength(100, ErrorMessage ="O nome deve ter até 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string CPF { get; set; }

        public int LoginId { get; set; }
        public Login Login { get; set; }


    }
}
