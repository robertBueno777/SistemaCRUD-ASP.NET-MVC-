using CRUDDoMVC.Models;
using CRUDDoMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUDDoMVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _usuarioService;
        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public IActionResult CadastrarUsuario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarUsuario(UsuarioModel usuario)
        {
            _usuarioService.CadastrarUsuario(usuario);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult EditarUsuario()
        {
            return View();
        }
        public IActionResult ExcluirUsuario()
        {
            return View();
        }
        public IActionResult MostrarUsuario()
        {
            return View();
        }
        public IActionResult MostrarTodosUsuarios()
        {
            return View();
        }
    }
}
