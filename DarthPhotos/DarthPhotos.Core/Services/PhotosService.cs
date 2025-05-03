using DarthPhotos.Db.Repositories;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Core.Services
{
    public interface IPhotosService
    {
        public Task<bool> ScanPhotos(string basePath, CancellationToken cancellationToken);
    }


    public class PhotosService : IPhotosService
    {
        private readonly ILogger _logger;
        private readonly IScanRepository _scanRepository;

        public PhotosService(ILogger<PhotosService> logger,
            IScanRepository scanRepository)
        {
            _logger = logger;
            _scanRepository = scanRepository;
        }

        public async Task<bool> ScanPhotos(string basePath, CancellationToken cancellationToken)
        {
            List<string> paths = new();

            if (!Directory.Exists(basePath))
            {
                _logger.LogError($"ScanPhotos: Base path does not exist ({basePath})");
                return false;
            }

            //Get All Folders
            paths.Add(basePath);
            
            for (int i = 0; i < paths.Count; i++)
            {
                var newDirectories = Directory.GetDirectories(paths[i]);
                if (newDirectories != null && newDirectories.Any())
                {
                    paths.AddRange(newDirectories);
                }
            }

            //Get all files in each folder
            foreach(var folder in paths)
            {
                var files = Directory.GetFiles(folder);

                // Process each file
                foreach(var file in files)
                {
                    // Check if image
                    // todo: use options or DB?

                    // Get base data
                    using var sha256 = SHA256.Create();
                    using var stream = File.OpenRead(file);
                    var hash = sha256.ComputeHash(stream);
                    var hashString = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    var fileInfo = new FileInfo(file);

                    var dbItem = await _scanRepository.GetByHashAsync(hashString, cancellationToken);
                    if (dbItem is not null)
                    {
                        continue;
                    }
                }
            }

            return true;
        }
    }
}
