using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySinhVien.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string Makhoa { get; set; }
        public Khoa khoa { get; set; }
        public List<LopHocPhan> LopHocPhans { get; set; }
    }
}
