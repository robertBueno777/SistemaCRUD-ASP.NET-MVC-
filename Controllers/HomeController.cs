using CRUDDoMVC.Models;
using CRUDDoMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUDDoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsuarioService _usuarioService;
        public HomeController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public IActionResult Index()
        {
            var lista = _usuarioService.ListarUsuarios();

            return View(lista);
        }
        public IActionResult MostrarUsuario(int id)
        {
            var usuario = _usuarioService.AcharUsuarioPorId(id);
            return PartialView("_MostrarUsuarios", usuario);
        }

        public IActionResult Privacy()
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
