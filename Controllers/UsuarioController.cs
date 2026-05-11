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
        public IActionResult SalvarUsuarioEditado(UsuarioModel usuario)
        {
            var usuarioOg = _usuarioService.AcharUsuarioPorId(usuario.Id);
            _usuarioService.EditarUsuario(usuario, usuarioOg);
            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(UsuarioModel usuario)
        {
            _usuarioService.CadastrarUsuario(usuario);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult EditarUsuario(UsuarioModel novoUsuario, int id)
        {
            var usuarioOriginal = _usuarioService.ListarUsuarios().FirstOrDefault(u => u.Id == id);                                                     
            if (usuarioOriginal == null)
            {
                TempData["MensagemErro"] = "Erro ao tentar editar o usuario";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["MensagemSucesso"] = "Usuario editado com sucesso";
            }
            return View(usuarioOriginal);
        }
        public IActionResult ExcluirUsuario(int id)
        {
            _usuarioService.ExcluirUsuario(id);
            return RedirectToAction("Index", "Home");
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
