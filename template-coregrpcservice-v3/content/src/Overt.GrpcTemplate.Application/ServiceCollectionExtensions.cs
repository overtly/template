using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Overt.GrpcTemplate.Application.Constracts;
using Overt.GrpcTemplate.Application.Services;
using Overt.GrpcTemplate.Domain;

namespace Overt.GrpcTemplate.Application
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationDI(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();

            services.AddDomainDI();
            services.AddAutoMapper();
        }
    }
}
