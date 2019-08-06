using Grpc.Core;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Overt.Core.Grpc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static Overt.GrpcTemplate.Service.Grpc.TemplateService;

namespace Overt.GrpcTemplate.Service
{
    public class HostedService : IHostedService
    {
        readonly ILogger _logger;
        readonly TemplateServiceBase _grpcServImpl;
        public HostedService(
            ILogger<HostedService> logger,
            TemplateServiceBase grpcService)
        {
            _logger = logger;
            _grpcServImpl = grpcService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew(() =>
            {
                var channelOptions = new List<ChannelOption>()
                {
                     new ChannelOption(ChannelOptions.MaxReceiveMessageLength, int.MaxValue),
                     new ChannelOption(ChannelOptions.MaxSendMessageLength, int.MaxValue),
                };
                GrpcServiceManager.Start(BindService(_grpcServImpl), channelOptions: channelOptions, whenException: (ex) =>
                {
                    _logger.LogError($"{nameof(Overt.GrpcTemplate.Service).Replace(".", "")}服务器开启失败");
                    throw ex;
                });

                _logger.LogError($"{nameof(Overt.GrpcTemplate.Service).Replace(".", "")}开启");
            }, cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew(() =>
            {
                GrpcServiceManager.Stop();

                _logger.LogError($"{nameof(Overt.GrpcTemplate.Service).Replace(".", "")}停止");
            }, cancellationToken);
        }
    }
}
