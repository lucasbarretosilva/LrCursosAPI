namespace LrCursosAPI.Models
{
    public class Autenticacao
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public  string Senha { get; set; } = string.Empty;

        public bool IsManager { get; set; }

        public bool Liberado { get; set; }
    }
}
