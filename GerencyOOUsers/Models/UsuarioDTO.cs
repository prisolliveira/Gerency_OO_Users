using GerencyOOUsers.Models.Enums;

namespace GerencyOOUsers.Models
{
    public class UsuarioDTO
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Nacionalidade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Cargos Cargo { get; set; }
    }
}
