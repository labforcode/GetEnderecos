namespace GetEnderecos.Domain.Entities.Enderecos
{
    public class Endereco
    {
        /// <summary>
        /// CEP do Endereço
        /// </summary>
        public string Cep { get; private set; }

        /// <summary>
        /// Logradouro do Endereço
        /// </summary>
        public string Logradouro { get; private set; }

        /// <summary>
        /// Complemento do Endereço
        /// </summary>
        public string Complemento { get; private set; }

        /// <summary>
        /// Bairro do Endereço
        /// </summary>
        public string Bairro { get; private set; }

        /// <summary>
        /// Município do Endereço
        /// </summary>
        public string Municipio { get; private set; }

        /// <summary>
        /// Código do IBGE do Endereço
        /// </summary>
        public string IbgeMunicipio { get; private set; }

        /// <summary>
        /// UF do Endereço
        /// </summary>
        public string Uf { get; private set; }

        /// <summary>
        /// Código do IBGE do Endereço
        /// </summary>
        public string IbgeUf { get; private set; }
    }
}
