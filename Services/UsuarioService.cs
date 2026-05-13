using CRUDDoMVC.Models;

namespace CRUDDoMVC.Services
{
    public class UsuarioService
    {
        private readonly MensagemErroService _mensagemErroService;
        public UsuarioService(MensagemErroService mensagemErroService)
        {
            _mensagemErroService = mensagemErroService;
        }
        private readonly List<UsuarioModel> _listaUsuario = new List<UsuarioModel>();
        public List<UsuarioModel> ListarUsuarios()
        {
            return _listaUsuario;
        }
        public bool VerificarSeUsuarioTemErro(UsuarioModel usuario)//polish
        {
            _mensagemErroService.AdicionarNovaNotificacao(usuario, _listaUsuario);
            if (_mensagemErroService.TemNotificacao(usuario) == true)
            {
                _mensagemErroService.ObterNotificacoes(usuario);
                return false;
            }
            return true;
        }
        public void CadastrarUsuario(UsuarioModel usuario)
        {
            if(VerificarSeUsuarioTemErro(usuario) == true)
            {
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
