using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models
{
    public partial class ChiTietPhieuNhap
    {
        public int MaChiTietPn { get; set; }
        public int? MaPn { get; set; }
        public int? MaSp { get; set; }
        public decimal? DonGiaNhap { get; set; }
        public int? SoLuongNhap { get; set; }
        public bool? DaXoa { get; set; }

        public PhieuNhap MaPnNavigation { get; set; }
        public SanPham MaSpNavigation { get; set; }
    }
}
