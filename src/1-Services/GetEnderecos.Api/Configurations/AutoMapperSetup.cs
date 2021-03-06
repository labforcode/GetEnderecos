﻿using AutoMapper;
using GetEnderecos.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GetEnderecos.Api.Configurations
{
    public static class AutoMapperSetup
    {

        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddAutoMapper(typeof(Startup));

            // Registering Mappings automatically only works if the 
            // Automapper Profile classes are in ASP.NET project
            services.AddSingleton<IConfigurationProvider>(AutoMapperConfig.RegisterMappings());
        }
    }
}
