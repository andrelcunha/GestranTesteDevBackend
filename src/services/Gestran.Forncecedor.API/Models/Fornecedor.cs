namespace Gestran.Forncecedor.API.Models
{
    public class Fornecedor: Entity
    {
        public string Nome { get; private set; }
        public string Cnpj { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public IEnumerable<Endereco> Enderecos { get; private set; }
    }
}
