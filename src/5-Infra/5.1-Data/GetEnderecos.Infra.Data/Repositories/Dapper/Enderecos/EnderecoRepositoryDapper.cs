﻿using Dapper;
using GetEnderecos.Domain.Entities.Enderecos;
using GetEnderecos.Domain.Interfaces.Dapper.Enderecos;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetEnderecos.Infra.Data.Repositories.Dapper.Enderecos
{
    public class EnderecoRepositoryDapper : RepositoryBaseDapper, IEnderecoRepositoryDapper
    {
        private string _query = "SELECT e.cep AS Cep, " +
		                               "e.logradouro AS Logradouro, " +
                                       "e.complemento AS Complemento, " +
                                       "e.bairro AS Bairro, " +
                                       "e.municipio AS Municipio, " +
                                       "e.ibge_municipio AS IbgeMunicipio, " +
                                       "e.uf AS Uf, " +
                                       "e.ibge_uf AS IbgeUf " +
                                "FROM enderecos AS e ";

        public EnderecoRepositoryDapper(IConfiguration configuration) : base(configuration) { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Endereco>> ObterTodos()
        {
            try
            {
                using var connection = Connection;
                var enderecos = await connection.QueryAsync<Endereco>(_query);

                return enderecos;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
