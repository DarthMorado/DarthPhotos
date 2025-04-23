using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarthPhotos.Db.Entities
{
    [Table("PHT_Photos")]
    public class PhotoEntity : BaseEntity
    {
        [Column("PHT_Path")]
        public string Path { get; set; }
        public UserEntity Creator { get; set; }
        [Column("PHT_Creator_USR_ID")]
        public int CreatorId { get; set; }
        [Column("PHT_Is_Scanned")]
        public bool IsScanned { get; set; }
        [Column("PHT_Size")]
        public int Size { get; set; }
        [Column("PHT_Hash")]
        public byte[] Hash { get; set; }
    }
}
