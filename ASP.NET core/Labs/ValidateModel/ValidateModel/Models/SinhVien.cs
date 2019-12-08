using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ValidateModel.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string Email { get; set; }
        public string CreditCard { get; set; }
        public string Hinh { get; set; }
        public double Diem { get; set; }
        public double HeSo { get; set; }
        public string MaBaoMat { get; set; }
        public string GhiChu { get; set; }
        public string MaKhoa { get; set; }
        [ForeignKey("MaKhoa")]
        public Khoa khoa { get; set; }
    }
}
