using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace Overt.GrpcTemplate.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDomainDI(this IServiceCollection services)
        {
            var assembly = Assembly.GetAssembly(typeof(Constants));
            var types = assembly.GetTypes();
            var interfaceTypes = types.Where(oo => oo.IsInterface).Where(oo => oo.Name.EndsWith("Repository"));
            foreach (var interfaceType in interfaceTypes)
            {
                var implType = types.FirstOrDefault(oo => oo.Name == interfaceType.Name.Substring(1));
                if (implType != null)
                    services.AddTransient(interfaceType, implType);
            }
        }
    }
}
