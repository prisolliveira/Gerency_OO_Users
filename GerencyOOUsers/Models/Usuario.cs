using GerencyOOUsers.Models.Enums;

namespace GerencyOOUsers.Models
{
    public class Usuario
    {
        // Registrados manualmente
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Nacionalidade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Cargos Cargo { get; set; }
        public PermissaoAcesso Acesso { get; set; }
        
        // Adicionados automaticamente no sistema
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }


    }
}
