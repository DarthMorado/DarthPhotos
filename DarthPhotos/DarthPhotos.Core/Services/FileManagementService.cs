using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Core.Services
{
    public interface IFileManagementService
    {

    }
    public class FileManagementService
    {
        private readonly CoreOptions _coreOptions;

        public FileManagementService(IOptions<CoreOptions> options)
        {
            _coreOptions = options.Value;
        }

        private string FilePath(int fileId, int? userId, bool ensure = false)
        {
            if (ensure && !Path.Exists(_coreOptions.BaseStorePhotosPath))
            {
                Directory.CreateDirectory(_coreOptions.BaseStorePhotosPath);
            }

            var userFolder = $"{_coreOptions.BaseStorePhotosPath}/{userId}";
            if (ensure && userId.HasValue && !Path.Exists(userFolder))
            {
                Directory.CreateDirectory(userFolder);
            }

            return $"{userFolder}/{fileId}"; //todo image file format /extension
        }

        public void SavePhoto(int fileId, int userId, byte[] fileContents)
        { 

        }

        public byte[] GetPhoto(int fileId, int userId)
        {
            //todo
            return null;
        }
    }
}
