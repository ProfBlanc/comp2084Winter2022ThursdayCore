using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace comp2084Winter2022ThursdayCore.Models
{
    public class Country
    {
        /*
         * 
         * CountryID
         * CountryName
         * CountryInitials
         * HeadOfState
         * 
         */ 
        [Key]
        [Column(Order = 0, TypeName = "int")]
        public int CountryID { get; set; }

        [Column(Order = 1, TypeName = "nvarchar(50)")]
        [Display(Name = "Country Name")]
        [Required]
        public string CountryName { get; set; }

        [Column(Order = 2, TypeName = "nvarchar(5)")]
        [Display(Name = "Country Initials")]
        [Required]
        public string CountryInitials { get; set; }

        [Column(Order = 3, TypeName = "nvarchar(50)")]
        [Display(Name = "Head of State")]
        [Required]
        public string HeadOfState { get; set; }
    }
}
