using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models
{
    public partial class ChiTietDonDatHang
    {
        public int MaChiTietDdh { get; set; }
        public int? MaDdh { get; set; }
        public int? MaSp { get; set; }
        public string TenSp { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public bool? DaXoa { get; set; }

        public DonDatHang MaDdhNavigation { get; set; }
        public SanPham MaSpNavigation { get; set; }
    }
}
