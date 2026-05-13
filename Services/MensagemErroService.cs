
using CRUDDoMVC.Models;

namespace CRUDDoMVC.Services
{
    public class MensagemErroService
    {
        public void AdicionarNovaNotificacao(UsuarioModel usuario, List<UsuarioModel>lista)
        {
            //temos um usuario
            //temos uma lista de mensagem de erros pra cada usuario
            //dependendo dos erros dele, acrescentaremos mais itens à lista
            if (usuario.NomeUsuario == string.Empty)
                usuario.MensagemErro.Add(new MensagemErroModel { IdErro = 1, MensagemDeErro = "campo nome vazio, tente novamente" });
            else if (usuario.IdadeUsuario <= 0 || usuario.IdadeUsuario > 120)
                usuario.MensagemErro.Add(new MensagemErroModel { IdErro = 2, MensagemDeErro = "campo idade fora do padrão, insira uma idade válida!" });
            else if (lista.Any(u => u.NomeUsuario == usuario.NomeUsuario) == true)
                usuario.MensagemErro.Add(new MensagemErroModel { IdErro = 3, MensagemDeErro = "usuario ja cadastrado" });
        }
        public bool TemNotificacao(UsuarioModel usuario)
            {
            if (usuario.MensagemErro.Count == 0)
            {
                Console.WriteLine("testepraverseentrou");
                return false;
            }
            return true;
      
        }
        //gsilva
        public string ObterNotificacoes(UsuarioModel usuario)
        {
            if (TemNotificacao(usuario) == true)
            {
                foreach (var e in usuario.MensagemErro)
                {
                    string mensagemErro = $"erro {e.IdErro}: {e.MensagemDeErro}";
                    return mensagemErro;
                }
            }
            return "";
        }
    }
}
