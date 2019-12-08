using System;
using System.Collections.Generic;

namespace WebSiteBanHang.Models
{
    public partial class ThanhVienTb
    {
        public ThanhVienTb()
        {
            BinhLuan = new HashSet<BinhLuan>();
        }

        public int MaThanhVien { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string CauHoi { get; set; }
        public string CauTraLoi { get; set; }
        public int? MaLoaiTv { get; set; }
        public bool? DaXoa { get; set; }

        public LoaiThanhVien MaLoaiTvNavigation { get; set; }
        public ICollection<BinhLuan> BinhLuan { get; set; }
    }
}
