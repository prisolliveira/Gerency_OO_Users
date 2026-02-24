using GerencyOOUsers.Data;
using GerencyOOUsers.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerencyOOUsers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministradorController : Controller
    {
        private readonly UsuariosDb _contextUsersDb;

        public AdministradorController(UsuariosDb usuariosDb)
        {
            _contextUsersDb = usuariosDb;
        }

        public IActionResult Index()
        {
            return View();
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

        [HttpPost]
        public async Task<IActionResult> NovoRegistro(Usuario usuario)
        {
            _contextUsersDb.Usuarios.Add(usuario);
            await _contextUsersDb.SaveChangesAsync();
            return Ok(usuario);
        }
    }
}
