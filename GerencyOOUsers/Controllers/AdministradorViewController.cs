using Microsoft.AspNetCore.Mvc;

namespace GerencyOOUsers.Controllers
{
    [Route("api/[controller]")]
    public class AdministradorViewController : Controller
    {
        [HttpGet("Registros")]
        public IActionResult Registros()
        {
            return View("\\Views\\Administrador\\Registros.cshtml");
        }

        [HttpGet("NovoRegistro")]
        public IActionResult NovoRegistro()
        {
            return View("\\Views\\Administrador\\NovoRegistro.cshtml");
        }
    }
}
