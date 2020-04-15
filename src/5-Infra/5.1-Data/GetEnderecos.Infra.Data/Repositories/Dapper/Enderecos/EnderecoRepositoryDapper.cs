using Dapper;
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
        /// Obtém um endereço por cep
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public async Task<Endereco> ObterEnderecoPorCep(string cep)
        {
            try
            {
                using var connection = Connection;

                _query += "WHERE e.cep = @cep;";

                var endereco = await connection.QueryFirstOrDefaultAsync<Endereco>(_query, new { cep });

                return endereco;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logradouro"></param>
        /// <param name="municipio"></param>
        /// <param name="uf"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Endereco>> ObterEnderecos(string logradouro, string municipio, string uf)
        {
            try
            {
                using var connection = Connection;

                _query += "WHERE e.uf = @uf " +
                          "AND e.municipio = @municipio " +
                          "AND e.logradouro LIKE @logradouro;";

                var enderecos = await connection.QueryAsync<Endereco>(_query, new { uf, municipio, logradouro = "%" + logradouro + "%" });

                return enderecos;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Obtém todos os endereços
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Endereco>> ObterTodosEnderecos()
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
