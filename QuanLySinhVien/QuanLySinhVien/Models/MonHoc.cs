using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySinhVien.Models
{
    public class MonHoc
    {
        [Key]
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public List<LopHocPhan> LopHocPhans { get; set; }
    }
}
