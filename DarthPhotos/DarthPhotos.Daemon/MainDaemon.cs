using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Daemon
{
    public class MainDaemon : BackgroundService
    {
        private readonly ILogger _logger;
        private readonly AppSettings _options;

        public MainDaemon(ILogger<MainDaemon> logger,
            IOptions<AppSettings> options)
        {
            _logger = logger;
            _options = options.Value;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation($"Worker running at: {DateTimeOffset.Now}; {_options.ScannedPhotosPath}");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
