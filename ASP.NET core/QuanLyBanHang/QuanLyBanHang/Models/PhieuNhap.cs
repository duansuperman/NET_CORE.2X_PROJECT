using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models
{
    public partial class PhieuNhap
    {
        public PhieuNhap()
        {
            ChiTietPhieuNhap = new HashSet<ChiTietPhieuNhap>();
        }

        public int MaPn { get; set; }
        public int? MaNcc { get; set; }
        public DateTime? NgayNhap { get; set; }
        public bool? DaXoa { get; set; }

        public NhaCungCap MaNccNavigation { get; set; }
        public ICollection<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }
    }
}
