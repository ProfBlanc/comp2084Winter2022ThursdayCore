using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace comp2084Winter2022ThursdayCore.Models
{
    public class Job
    {
        [Key]
        [Column(TypeName = "int")]
        public int JobID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string JobTitle { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public IEnumerable<Employee> EmployeID { get; set; }
    }
}
