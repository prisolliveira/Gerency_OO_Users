using GerencyOOUsers.Data;
using GerencyOOUsers.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerencyOOUsers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministradorController : Controller
    {
        private readonly UsuariosContext _contextUsersDb;

        public AdministradorController(UsuariosContext usuariosDb)
        {
            _contextUsersDb = usuariosDb;
        }

        [HttpGet("Registros")]
        public IActionResult Registros()
        {
            return View("Registros"); 
        }

        [HttpGet("NovoRegistro")]
        public IActionResult NovoRegistro()
        {
            return View("NovoRegistro");
        }

        [HttpPost("NovoRegistro")]
        public async Task<IActionResult> NovoRegistro(Usuario usuario)
        {
            _contextUsersDb.Usuarios.Add(usuario);
            await _contextUsersDb.SaveChangesAsync(); // erro de conexão
            return Ok(usuario);
        }
    }
}
