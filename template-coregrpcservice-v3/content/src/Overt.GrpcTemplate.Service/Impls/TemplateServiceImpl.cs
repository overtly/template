using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using static Overt.GrpcTemplate.Service.Grpc.TemplateService;

namespace Overt.GrpcTemplate.Service.Impls
{
    public partial class TemplateServiceImpl : TemplateServiceBase
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;
        public TemplateServiceImpl(ILogger<TemplateServiceImpl> logger, IMapper mapper, IServiceProvider provider)
        {
            _logger = logger;
            _mapper = mapper;
            _serviceProvider = provider;
        }

        /// <summary>
        /// Scope执行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public T ExecuteInScope<T>(Func<IServiceProvider, T> func)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var provider = scope.ServiceProvider;
                return func(provider);
            }
        }
    }
}