namespace GetEnderecos.Application.ViewModels.Enderecos
{
    public class EnderecoViewModel
    {
        /// <summary>
        /// CEP do Endereço
        /// </summary>
        public string Cep { get; set; }

        /// <summary>
        /// Logradouro do Endereço
        /// </summary>
        public string Logradouro { get; set; }

        /// <summary>
        /// Complemento do Endereço
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// Bairro do Endereço
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Município do Endereço
        /// </summary>
        public string Municipio { get; set; }

        /// <summary>
        /// Código do IBGE do Endereço
        /// </summary>
        public string IbgeMunicipio { get; set; }

        /// <summary>
        /// UF do Endereço
        /// </summary>
        public string Uf { get; set; }

        /// <summary>
        /// Código do IBGE do Endereço
        /// </summary>
        public string IbgeUf { get; set; }
    }
}
