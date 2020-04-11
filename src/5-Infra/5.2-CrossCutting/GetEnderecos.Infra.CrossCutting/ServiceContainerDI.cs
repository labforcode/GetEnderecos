using GetEnderecos.Application.Interfaces.Enderecos;
using GetEnderecos.Application.Services.Enderecos;
using Microsoft.Extensions.DependencyInjection;

namespace GetEnderecos.Infra.CrossCutting
{
    public class ServiceContainerDI
    {
        public static void ServicesInject(IServiceCollection services)
        {
            services.AddTransient<IEnderecoService, EnderecoService>();
        }
    }
}
