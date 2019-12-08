using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models
{
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            SanPham = new HashSet<SanPham>();
        }

        public int MaLoaiSp { get; set; }
        public string TenLoai { get; set; }
        public string Icon { get; set; }
        public string BiDanh { get; set; }

        public ICollection<SanPham> SanPham { get; set; }
    }
}
