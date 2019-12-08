using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models
{
    public partial class NhaSanXuat
    {
        public NhaSanXuat()
        {
            SanPham = new HashSet<SanPham>();
        }

        public int MaNsx { get; set; }
        public string TenNsx { get; set; }
        public string ThongTin { get; set; }
        public string Logo { get; set; }

        public ICollection<SanPham> SanPham { get; set; }
    }
}
