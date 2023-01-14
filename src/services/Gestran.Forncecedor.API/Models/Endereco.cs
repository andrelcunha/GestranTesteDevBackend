using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;

namespace Gestran.Forncecedor.API.Models
{
    public class Endereco:Entity
    {
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string? Complemento { get; set; } = null;
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public Guid FornecedorId { get; private set; }

        [SwaggerSchema(ReadOnly = true)]
        [JsonIgnore]
        public virtual Fornecedor? Fornecedor { get; private set; }
#pragma warning disable CS8618
        public Endereco() { } //Necessário para o EF
#pragma warning restore CS8618

        public Endereco(string cep, string rua, string numero, string complemento, string cidade, string estado, string pais, Guid fornecedorId)
        {
            //Id = Guid.NewGuid();
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            FornecedorId = fornecedorId;
        }
    }


}
