using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace comp2084Winter2022ThursdayCore.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Custom Error Message")]
        [Column(Order = 0, TypeName = "int")]
        [Range(1000000, 9999999)]
        public int EmployeeID { get; set; }
        [Required]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        public string EmployeeName { get; set; }

        [Required]
        [Column(Order = 0, TypeName = "nvarchar(10)")]
        public string EmployeePosition { get; set; }

        [Required]
        [Column(Order = 0, TypeName = "int")]
        public int EmployeeAge { get; set; }
    }
}
