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
        [HttpGet]
        public IActionResult EditarUsuario(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditarUsuario(UsuarioModel novoUsuario)
        {
            //var usuarioASerEditado = _usuarioService.AcharUsuarioPorNome(nome);
            //_usuarioService.EditarUsuario(usuarioASerEditado, novoNome, novaIdade);
            return RedirectToAction("Index", "Home");
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
