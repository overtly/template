using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Overt.Template.Service
{
    public class HostedService : IHostedService
    {
        readonly ILogger _logger;
        public HostedService(
            ILogger<HostedService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew(() =>
            {
                _logger.LogError("TemplateService开启");
            }, cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew(() =>
            {
                _logger.LogError("TemplateService停止");
            }, cancellationToken);
        }
    }
}
