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
        //tratar excecoes
        //fazer exibir somente um item ou varios dependendo da pesquisa na view
        //
        [HttpGet]
        public IActionResult EditarUsuario(int Id)
        {

            var usuarioOriginal = _usuarioService.ListarUsuarios().FirstOrDefault(u => u.Id == Id);
            return View(usuarioOriginal);
        }
        [HttpPost]
        public IActionResult EditarUsuario(UsuarioModel novoUsuario)
        {
            _usuarioService.EditarUsuario(novoUsuario);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ExcluirUsuario(int id)
        {
            _usuarioService.ExcluirUsuario(id);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult PesquisarPorUsuario(string nome, int id)
        {
            var usuario = _usuarioService.PesquisarPorUsuario(id, nome);
            return RedirectToAction("Index","Home");
        }
        public IActionResult MostrarTodosUsuarios()
        {
            return View();
        }
    }
}
//uma modal só tavlez vou utilizar o ajax
//colocar endereco com usuario
//

