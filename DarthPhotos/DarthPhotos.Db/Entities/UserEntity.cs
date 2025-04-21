using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Db.Entities
{
    [Table("ADM_Users")]
    public class UserEntity : BaseEntity
    {
        [Column("USR_Gmail")]
        public string Gmail { get; set; }

        [Column("USR_Is_Admin")]
        public bool IsAdmin { get; set; }
    }
}
