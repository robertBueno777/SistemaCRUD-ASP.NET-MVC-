using CRUDDoMVC.Models;

namespace CRUDDoMVC.Services
{
    public class UsuarioService
    {
        private readonly List<UsuarioModel> _listaUsuario = new List<UsuarioModel>();
        public void CadastrarUsuario(UsuarioModel usuario)
        {
            usuario.Id = 1;
            _listaUsuario.Add(usuario);

            foreach(var u in _listaUsuario)
            {
                u.Id = +1;
                Console.WriteLine(u.NomeUsuario);
            }
        }
        public void EditarUsuario()
        {

        }
        
    }
}
