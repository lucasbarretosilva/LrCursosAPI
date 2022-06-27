
namespace LrCursosAPI.Models
{
    public class ConteudoVisto
    {
        public int Id { get; set; }

        public int AutenticacaoId { get; set; }

        public int ConteudoId { get; set; }



        public Autenticacao? Autenticacao { get; set; }

        public Conteudo? Conteudo { get; set; }

    }
}