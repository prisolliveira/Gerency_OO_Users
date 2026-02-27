using GerencyOOUsers.Models;
using Microsoft.EntityFrameworkCore;

namespace GerencyOOUsers.Data
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext(DbContextOptions<UsuariosContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
