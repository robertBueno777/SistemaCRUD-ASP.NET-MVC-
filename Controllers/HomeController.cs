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
        public IActionResult MostrarUsuario()
        {
             var listaUsuarios = _usuarioService.ListarUsuarios();
            return PartialView("_MostrarUsuarios", listaUsuarios);
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
