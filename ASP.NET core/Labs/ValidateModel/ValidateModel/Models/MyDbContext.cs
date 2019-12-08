using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidateModel.Models
{
    public class MyDbContext: DbContext
    {
        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=DbQLSV;Integrated Security=True;");
        }
    }
}
