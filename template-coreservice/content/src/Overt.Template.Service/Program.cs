using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Overt.Template.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new HostBuilder()
               .UseConsoleLifetime() //使用控制台生命周期
               .ConfigureAppConfiguration((context, configuration) =>
               {
                   configuration
                   .AddJsonFile("appsettings.json", optional: true)
                   .AddEnvironmentVariables();
               })
               .ConfigureLogging(logger =>
               {

               })
               .ConfigureServices(ConfigureServices)
               .Build();

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                var logFactory = host.Services.GetService<ILoggerFactory>();
                var logger = logFactory.CreateLogger<Program>();
                logger.LogError(e.ExceptionObject as Exception, $"UnhandledException");
            };

            host.Run();
        }

        /// <summary>
        /// 通用DI注入
        /// </summary>
        /// <param name="context"></param>
        /// <param name="services"></param>
        private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            services.AddSingleton<IHostedService, HostedService>();
        }
    }
}
