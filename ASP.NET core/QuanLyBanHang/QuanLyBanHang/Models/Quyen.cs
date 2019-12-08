using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models
{
    public partial class Quyen
    {
        public Quyen()
        {
            LoaiThanhVienQuyen = new HashSet<LoaiThanhVienQuyen>();
        }

        public string MaQuyen { get; set; }
        public string TenQuyen { get; set; }

        public ICollection<LoaiThanhVienQuyen> LoaiThanhVienQuyen { get; set; }
    }
}
