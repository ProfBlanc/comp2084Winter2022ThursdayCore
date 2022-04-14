using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comp2084Winter2022ThursdayCore.Models
{
    public class RoleManagement
    {
        /*
         * Role
         * Members
         * NonMembers
         */

        public IdentityRole Role {get;set;}
        public ICollection<IdentityUser> Members {get;set;} //Users. What is object referrings to Users?
        public IEnumerable<IdentityUser> NonMembers { get; set; }


    }
}
