using GetEnderecos.Domain.Interfaces.Dapper.Enderecos;
using GetEnderecos.Infra.Data.Repositories.Dapper.Enderecos;
using Microsoft.Extensions.DependencyInjection;

namespace GetEnderecos.Infra.CrossCutting
{
    public class RepositoryDapperContainerDI
    {
        public static void RepositoryInject(IServiceCollection services)
        {
            services.AddTransient<IEnderecoRepositoryDapper, EnderecoRepositoryDapper>();
        }
    }
}
