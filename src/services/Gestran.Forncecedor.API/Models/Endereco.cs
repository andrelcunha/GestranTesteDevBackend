﻿namespace Gestran.Forncecedor.API.Models
{
    public class Endereco:Entity
    {
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public Guid FornecedorId { get; set; }

    }
}