namespace CRUDDoMVC.Models
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Cep { get; set; }
        public string NumeroCasa { get; set; }
        public string NomeRua { get; set; }
    }
}
