using GetEnderecos.Domain.Entities.Enderecos;
using GetEnderecos.Domain.Interfaces.Dapper.Enderecos;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace GetEnderecos.Infra.Data.Repositories.Dapper.Enderecos
{
    public class EnderecoRepositoryDapper : RepositoryBaseDapper, IEnderecoRepositoryDapper
    {
        private string _query = "SELECT c.contato_id AS ContatoId," +
                                        "c.nome AS Nome, " +
                                        "c.telefone_fixo AS TelefoneFixo, " +
                                        "c.telefone_celular AS TelefoneCelular, " +
                                        "c.email AS Email, " +
                                        "c.situacao AS Situacao, " +
                                        "c.cadastro AS Cadastro " +
                                "FROM contatos AS c ";

        public EnderecoRepositoryDapper(IConfiguration configuration) : base(configuration) { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<Endereco> ObterTodos()
        {
            try
            {
                using var connection = Connection;
                _query += "WHERE contato_id = @id;";

                //var contato = await connection.QueryFirstOrDefaultAsync<Contato>(_query, new { contatoId });

                return null ;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
