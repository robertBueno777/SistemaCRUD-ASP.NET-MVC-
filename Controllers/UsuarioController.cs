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
            var usu = this._usuarioService.AcharUsuarioPorId(id);
            return View(usu.Id);
        }
        [HttpPost]
        public IActionResult EditarUsuario(UsuarioModel novoUsuario, int id)
        {

            var usuarioOriginal = _usuarioService.ListarUsuarios().FirstOrDefault(u => u.Id == novoUsuario.Id);
                                                     
            if (usuarioOriginal == null)
            {
                TempData["MensagemErro"] = "Erro ao tentar editar o usuario";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["MensagemSucesso"] = "Usuario editado com sucesso";
            }
            _usuarioService.EditarUsuario(usuarioOriginal, novoUsuario);
            return RedirectToAction("Home", "Index");
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
