using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GetEnderecos.Infra.CrossCutting
{
    public class BootstraperContainerDI
    {
        public static void Injector(IServiceCollection services, IConfiguration configuration)
        {
            ContextContainerDI.ContextInject(services, configuration);

            RepositoryEFContainerDI.RepositoryInject(services);

            RepositoryDapperContainerDI.RepositoryInject(services);

            ServiceContainerDI.ServicesInject(services);
        }
    }
}
