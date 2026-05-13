namespace CRUDDoMVC.Models
{
    public class UsuarioModel
    {
        public UsuarioModel()
        {
            MensagemErro = new List<MensagemErroModel>();
        }
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public int IdadeUsuario { get; set; }
        public List<MensagemErroModel> MensagemErro { get; set; }
        //public EnderecoModel Endereco { get; set; }
    }
}
