using GetEnderecos.Domain.Interfaces.EF.Enderecos;
using GetEnderecos.Infra.Data.Repositories.EF.Enderecos;
using Microsoft.Extensions.DependencyInjection;

namespace GetEnderecos.Infra.CrossCutting
{
    public class RepositoryEFContainerDI
    {
        public static void RepositoryInject(IServiceCollection services)
        {
            services.AddTransient<IEnderecoRepositoryEF, EnderecoRepositoryEF>();
        }
    }
}
