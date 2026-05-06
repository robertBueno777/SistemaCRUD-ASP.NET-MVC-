using Microsoft.AspNetCore.Mvc;

namespace CRUDDoMVC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult CadastrarUsuario()
        {
            return View();
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
