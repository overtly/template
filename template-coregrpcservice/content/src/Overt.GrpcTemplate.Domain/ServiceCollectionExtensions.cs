using Microsoft.Extensions.DependencyInjection;
using Overt.GrpcTemplate.Domain.Contracts;
using Overt.GrpcTemplate.Domain.Repositories;

namespace Overt.GrpcTemplate.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDomainDI(this IServiceCollection services)
        {
            services.AddTransient<IAccountRepository, AccountRepository>();
        }
    }
}
