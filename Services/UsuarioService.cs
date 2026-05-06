using CRUDDoMVC.Models;

namespace CRUDDoMVC.Services
{
    public class UsuarioService
    {
        public void CadastrarUsuario(UsuarioModel usuario)
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            usuarios.Add(usuario);
            foreach(var u in usuarios)
            {
                Console.WriteLine(u.NomeUsuario);
            }
        }
        public void EditarUsuario()
        {

        }
        
    }
}
