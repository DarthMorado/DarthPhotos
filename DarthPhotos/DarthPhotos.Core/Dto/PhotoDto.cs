using DarthPhotos.Db.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Core.Dto
{
    public class PhotoDto : BaseDto
    {
        public string Path { get; set; }
        public UserDto Creator { get; set; }
        public int CreatorId { get; set; }
        public bool IsScanned { get; set; }
        public int Size { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Image { get; set; }
        public string ImageUrl { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public byte[] Preview { get; set; }
    }
}
