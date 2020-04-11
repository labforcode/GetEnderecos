using GetEnderecos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GetEnderecos.Infra.CrossCutting
{
    public class ContextContainerDI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void ContextInject(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApiDataContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("dbenderecos")));
            services.AddScoped<ApiDataContext, ApiDataContext>();
        }
    }
}
