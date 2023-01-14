namespace Gestran.Forncecedor.API.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }

#pragma warning disable CS8618
        protected Fornecedor() { } //Necessário para o EF
#pragma warning restore CS8618

        public Fornecedor(string nome, string cnpj, string telefone, string email, ICollection<Endereco> enderecos)
        {
            //Id = Guid.NewGuid();
            Nome = nome;
            Cnpj = cnpj;
            Telefone = telefone;
            Email = email;
            Enderecos = enderecos;
        }
    }
}


