using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySinhVien.Models
{
    public class QLSVContext:DbContext
    {
        public QLSVContext()
        {

        }
        public QLSVContext(DbContextOptions<QLSVContext> options)
    : base(options)
        {

        }
        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<LopHocPhan> LopHocPhan { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=QuanLySinhVien;Trusted_Connection=True;");
        }
    }
}
