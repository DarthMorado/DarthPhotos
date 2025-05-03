using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Core.Services
{
    public interface IPhotosService
    {
        public Task ScanPhotos();
    }


    public class PhotosService : IPhotosService
    {
        public async Task ScanPhotos()
        {

        }
    }
}
