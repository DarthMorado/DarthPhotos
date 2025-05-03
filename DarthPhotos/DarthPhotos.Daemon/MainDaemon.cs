using DarthPhotos.Core.Services;
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
        private readonly IPhotosService _photosService;

        public MainDaemon(ILogger<MainDaemon> logger,
            IOptions<AppSettings> options,
            IPhotosService photosService)
        {
            _logger = logger;
            _options = options.Value;
            _photosService = photosService;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                if (_options?.ScanDaemon?.Enabled ?? false)
                {
                    _options.ScanDaemon.Enabled = await _photosService.ScanPhotos(_options.ScanDaemon.ScannedPhotosPath, cancellationToken);
                    _logger.LogInformation($"Worker running at: {DateTimeOffset.Now}; {_options.ScanDaemon.ScannedPhotosPath}");
                }
                
                await Task.Delay(1000, cancellationToken);
            }
        }
    }
}
