using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Core.Dto
{
    public class UserDto : BaseDto
    {
        public string Gmail { get; set; }

        public bool IsAdmin { get; set; }
    }
}
