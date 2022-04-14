using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace comp2084Winter2022ThursdayCore.Models
{
    public class Folder
    {
        [Key]
        [Column(TypeName = "int", Order = 0)]
        public int FolderID { get; set; }

        [Column(TypeName="nvarchar(255)", Order =1)]
        public string FolderLocation { get; set; }

        [Column(TypeName = "int", Order = 2)]
        public int OwnerID { get; set; }

        [ForeignKey("OwnerID")]
        public Owner Owner { get; set; }
    }
}
