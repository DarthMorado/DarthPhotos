using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Db.Entities
{
    [Table("PHT_Scanned")]
    public class ScannedEntity : BaseEntity
    {
        [Column("SCN_Path")]
        public string Path { get; set; }
        [Column("SCN_Name")]
        public string Name { get; set; }
        [Column("SCN_USR_Id")]
        public int? UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
