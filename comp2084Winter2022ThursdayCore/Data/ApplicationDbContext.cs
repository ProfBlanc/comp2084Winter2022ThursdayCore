using comp2084Winter2022ThursdayCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace comp2084Winter2022ThursdayCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        //add a DbSet<TableName> TableName {get; set}
        //db.Semesters

        DbSet<Employee> employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
