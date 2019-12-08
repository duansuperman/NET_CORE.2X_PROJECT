using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySinhVien.Models
{
    public class LopHocPhan
    {
        [Key]
        public int ID { get; set; }
        public string MaHocPhan{get;set;}
        public int NamHoc { get; set; }
        public int HocKy { get; set; }
        public string MaMon { get; set; }
        public MonHoc MonHoc { get; set; }
        public string MaSV { get; set; }
        public SinhVien SinhVien { get; set; }
    }
}
