using GerencyOOUsers.Data;
using GerencyOOUsers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GerencyOOUsers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministradorController : ControllerBase
    {
        private readonly UsuariosContext _contextUsersDb;

        public AdministradorController(UsuariosContext usuariosDb)
        {
            _contextUsersDb = usuariosDb;
        }      

        [HttpGet("Resgistros")]
        public async Task<IActionResult> ListarRegistros()
        { 
            return Ok(await _contextUsersDb.Usuarios.ToListAsync());
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

        [HttpPatch("NovoRegistro/{id}")]
        
        public async Task<IActionResult> AtualizarUsuario(int id, UsuarioDTO usuarioDTO)
        {
            Usuario usuario = await _contextUsersDb.Usuarios.FindAsync(id);

            if(usuario == null)
            {
                return NotFound();
            }

            usuario.Nome = usuarioDTO.Nome;
            usuario.Sobrenome = usuarioDTO.Sobrenome;
            usuario.DataNascimento = usuarioDTO.DataNascimento;
            usuario.Nacionalidade = usuarioDTO.Nacionalidade;
            usuario.Email = usuarioDTO.Email;
            usuario.Telefone = usuarioDTO.Telefone;
            usuario.Cargo = usuarioDTO.Cargo;

            await _contextUsersDb.SaveChangesAsync();
            return Ok();
        }

        // criar metodo de atualização * (sucesso)
        // criar outras propriedades para usuario * (sucesso)
        // criar formulário que preenche os valores e adiciona no bd
    }
}