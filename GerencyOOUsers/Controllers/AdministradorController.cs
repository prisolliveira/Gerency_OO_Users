using GerencyOOUsers.Data;
using GerencyOOUsers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("Resgistros")]
        public async Task<IActionResult> ListarRegistros()
        { 
            return Ok(await _contextUsersDb.Usuarios.ToListAsync());
        }

        [HttpGet("NovoRegistro")]
        public IActionResult NovoRegistro()
        {
            return View("NovoRegistro");
        }

        [HttpPost("NovoRegistro")]
        public async Task<IActionResult> CriarRegistro(Usuario usuario)
        {
            _contextUsersDb.Usuarios.Add(usuario);
            await _contextUsersDb.SaveChangesAsync();
            return Ok(usuario);
        }

        [HttpDelete("NovoRegistro/{id}")]
        public async Task<IActionResult> RemoverRegistro(int id)
        {
            var u = await _contextUsersDb.Usuarios.FindAsync(id);
            _contextUsersDb.Usuarios.Remove(u);
            await _contextUsersDb.SaveChangesAsync();
            return Ok();
        }
    }
}
// criação de listagem e deleção de registros