using CRUDDoMVC.Models;

namespace CRUDDoMVC.Services
{
    public class UsuarioService
    {
        private readonly List<UsuarioModel> _listaUsuario = new List<UsuarioModel>();
        public List<UsuarioModel> ListarUsuarios()
        {
            return _listaUsuario;
        }
        public void CadastrarUsuario(UsuarioModel usuario)
        {
          
            _listaUsuario.Add(usuario);
            var ultimoUsua = _listaUsuario.LastOrDefault();
            if (ultimoUsua.Id == 0)
            {
                usuario.Id = 1;
            }
            else
            {
                usuario.Id = _listaUsuario.Max(u => u.Id) + 1;
            }
        }
        public UsuarioModel AcharUsuarioPorNome(string nome)
        {
            var usuarioASerEditado = _listaUsuario.FirstOrDefault(u => u.NomeUsuario == nome);
            return usuarioASerEditado;
        }
        public void EditarUsuario(UsuarioModel usuario)
        {
            usuario.NomeUsuario = usuario.NomeUsuario;
            usuario.IdadeUsuario = usuario.IdadeUsuario;
        }
        
    }
}
