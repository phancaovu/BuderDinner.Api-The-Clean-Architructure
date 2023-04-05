﻿using BuberDinner.Application.Common.Interface.Persistence;
using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Services;
using BuberDinner.Application.Services.Authentiaction;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Infrastructure.Persistence;
using BuberDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {

            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddScoped<IUserReponsitory, UserRepository>();
            return services;   
        }
    }

   
  
}
