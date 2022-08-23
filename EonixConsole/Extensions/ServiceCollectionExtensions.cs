using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EonixConsole.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private const string domainAssembly = @"Eonix.Domain.Model";

        public static IServiceCollection RegisterServices(this IServiceCollection service)
        {
            var types = GetServices(domainAssembly);

            foreach (var currService in types)
            {
                var serviceInterface = currService.GetInterfaces().Where(p => p.Namespace.Contains(domainAssembly)).FirstOrDefault();
                if (serviceInterface == null) continue;
                service.AddScoped(serviceInterface, currService);
            }

            return service;
        }

        private static List<Type> GetServices(string assemblyName)
        {
            var infraAssembly = Assembly.Load(assemblyName);
            return infraAssembly == null ? new List<Type>() : infraAssembly
                .GetTypes()
                .Where(t => t.Namespace != null && t.Namespace.Contains("Services"))
                .Where(t => !t.IsAbstract && t.IsClass)
                .ToList();
        }
    }
}
