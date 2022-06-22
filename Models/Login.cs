using System.ComponentModel.DataAnnotations;

namespace LrCursosAPI.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }

       
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

       
        [StringLength(8, ErrorMessage ="A senha deve ter oito dígitos")]
        public string Password { get; set; }



    }
}
