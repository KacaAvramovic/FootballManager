using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace FootballManager.Service.Extensions
{
    public static class ConfigureServicesContainer
    {

        public static void AddMediatorCQRS(this IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.Load("FootballManager.Service");
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

    }
}
