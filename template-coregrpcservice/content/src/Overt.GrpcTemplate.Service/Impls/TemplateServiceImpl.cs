using AutoMapper;
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
    }
}