using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<Student> Student { get; set; } 
        public DbSet<Department> Department { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=.;Database=EFCoreCodeFirst-ManagerStudent;Integrated Security=True;");

        }
    }
}

