using System;
using System.Collections.Generic;

namespace WebSiteBanHang.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DonDatHang = new HashSet<DonDatHang>();
        }

        public int MaKh { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public int? MaThanhVien { get; set; }
        public bool? Xoa { get; set; }

        public ICollection<DonDatHang> DonDatHang { get; set; }
    }
}
