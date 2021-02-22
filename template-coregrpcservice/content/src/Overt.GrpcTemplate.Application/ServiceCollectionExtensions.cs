using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Overt.GrpcTemplate.Domain;
using System.Linq;
using System.Reflection;

namespace Overt.GrpcTemplate.Application
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationDI(this IServiceCollection services)
        {
            services.AddDomainDI();
            services.AddAutoMapper();

            // 注入服务
            var assembly = Assembly.GetAssembly(typeof(ServiceCollectionExtensions));
            var types = assembly.GetTypes();
            var interfaceTypes = types.Where(oo => oo.IsInterface).Where(oo => oo.Name.EndsWith("Service"));
            foreach (var interfaceType in interfaceTypes)
            {
                var implType = types.FirstOrDefault(oo => oo.Name == interfaceType.Name.Substring(1));
                if (implType != null)
                    services.AddTransient(interfaceType, implType);
            }
        }
    }
}
