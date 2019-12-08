using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models
{
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            PhieuNhap = new HashSet<PhieuNhap>();
            SanPham = new HashSet<SanPham>();
        }

        public int MaNcc { get; set; }
        public string TenNcc { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string Fax { get; set; }

        public ICollection<PhieuNhap> PhieuNhap { get; set; }
        public ICollection<SanPham> SanPham { get; set; }
    }
}
