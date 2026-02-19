using GerencyOOUsers.Models;
using Microsoft.EntityFrameworkCore;

namespace GerencyOOUsers.Data
{
    public class UsuariosDb : DbContext
    {
        public UsuariosDb(DbContextOptions<UsuariosDb> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
