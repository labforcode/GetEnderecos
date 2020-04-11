using GetEnderecos.Domain.Interfaces.Dapper.Enderecos;
using Microsoft.Extensions.Configuration;

namespace GetEnderecos.Infra.Data.Repositories.Dapper.Enderecos
{
    public class EnderecoRepositoryDapper : RepositoryBaseDapper, IEnderecoRepositoryDapper
    {
        public EnderecoRepositoryDapper(IConfiguration configuration) : base(configuration) { }
    }
}
