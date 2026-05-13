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
            var mensagemErro = new MensagemErro();

            if (usuario.IdadeUsuario < 0 || usuario.IdadeUsuario > 120)
            {
                mensagemErro.Id = 
                throw new Exception("Idade de usuario não permitido.");
            }
                
            else if (VerificarSeExisteNaListaPorNome(usuario.NomeUsuario) == false)
                throw new Exception("Usuario ja existe no banco");
            _listaUsuario.Add(usuario);
            var ultimoUsua = _listaUsuario.LastOrDefault();
            if (ultimoUsua.Id == 0)
            {
                usuario.Id = _listaUsuario.Max(u => u.Id) + 1;
            }
            else
            {
                usuario.Id = _listaUsuario.Max(u => u.Id) + 1;
            }
        }
        public bool VerificarSeExisteNaListaPorNome(string nome)
        {
            var usuario = _listaUsuario.FirstOrDefault(u => u.NomeUsuario == nome);
            if(usuario.NomeUsuario != null)
                return true;
            return false;
        }
        public UsuarioModel AcharUsuarioPorId(int id)
        {
            var usuario = _listaUsuario.FirstOrDefault(u => u.Id == id);
            return usuario;
        }
        public UsuarioModel AcharUsuarioPorNome(string nome)
        {
            var usuario = _listaUsuario.FirstOrDefault(u => u.NomeUsuario == nome);
            return usuario;
        }
        public void EditarUsuario(UsuarioModel usuario)
        {
            var usu = AcharUsuarioPorId(usuario.Id);
            usu.IdadeUsuario = usuario.IdadeUsuario;
            usu.NomeUsuario = usuario.NomeUsuario;                
        }
        public void ExcluirUsuario(int id)
        {
            var usuario = AcharUsuarioPorId(id);
            _listaUsuario.Remove(usuario);
        }
        public UsuarioModel PesquisarPorUsuario(int id, string nome)
        {
            var usuario = AcharUsuarioPorId(id);
            if (usuario == null)
                usuario = AcharUsuarioPorNome(nome);
            return usuario;
        }
    }
}
