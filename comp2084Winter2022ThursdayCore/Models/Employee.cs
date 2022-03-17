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
        [Required]
        [Column(Order = 3, TypeName = "int")]
        public int EmployeeAge { get; set; }

        /*
        [Required(ErrorMessage = "Custom Error Message")]
        [Range(1000000, 9999999)]
        */
        [Column(Order = 0, TypeName = "int")]
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        public string EmployeeName { get; set; }

        [Required]
        [Column(Order = 2, TypeName = "nvarchar(10)")]
        public string EmployeePosition { get; set; }

    }
}
