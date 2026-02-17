using System.Diagnostics;
using GerencyOOUsers.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerencyOOUsers.Controllers
{
    public class AcessoController : Controller
    {
        private readonly ILogger<AcessoController> _logger;

        public AcessoController(ILogger<AcessoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Empresa()
        {
            return View();
        }

        public IActionResult Administrador()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
