using System.ComponentModel.DataAnnotations;

namespace LrCursosAPI.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(8, ErrorMessage ="A senha deve ter oito dígitos")]
        public string Password { get; set; }



    }
}
