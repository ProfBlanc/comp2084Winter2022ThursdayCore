using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace comp2084Winter2022ThursdayCore.Models
{
    public class Owner
    {
        [Key]
        [Column(TypeName = "int", Order = 0)]
        public int OwnerID { get; set; }


        [Column(TypeName = "nvarchar(50)", Order = 1)]
        public string OwnerName { get; set; }

        public ICollection<Folder> Folders { get; set; }

    }
}
