using System;
using System.Collections.Generic;

namespace WebSiteBanHang.Models
{
    public partial class BinhLuan
    {
        public int MaBl { get; set; }
        public string NoiDungBl { get; set; }
        public int? MaThanhVien { get; set; }
        public int? MaSp { get; set; }

        public SanPham MaSpNavigation { get; set; }
        public ThanhVienTb MaThanhVienNavigation { get; set; }
    }
}
