using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            BinhLuan = new HashSet<BinhLuan>();
            ChiTietDonDatHang = new HashSet<ChiTietDonDatHang>();
            ChiTietPhieuNhap = new HashSet<ChiTietPhieuNhap>();
        }

        public int MaSp { get; set; }
        public string TenSp { get; set; }
        public decimal? DonGia { get; set; }
        public DateTime? NgayCapNhap { get; set; }
        public string CauHinh { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public int? SoLuongTon { get; set; }
        public int? LuotXem { get; set; }
        public int? LuotBinhChon { get; set; }
        public int? LuotBinhLuan { get; set; }
        public int? SoLanMua { get; set; }
        public int? Moi { get; set; }
        public int? MaNcc { get; set; }
        public int? MaNsx { get; set; }
        public int? MaLoaiSp { get; set; }
        public bool? DaXoa { get; set; }
        public string HinhAnh1 { get; set; }
        public string HinhAnh2 { get; set; }
        public string HinhAnh3 { get; set; }
        public string HinhAnh4 { get; set; }

        public LoaiSanPham MaLoaiSpNavigation { get; set; }
        public NhaCungCap MaNccNavigation { get; set; }
        public NhaSanXuat MaNsxNavigation { get; set; }
        public ICollection<BinhLuan> BinhLuan { get; set; }
        public ICollection<ChiTietDonDatHang> ChiTietDonDatHang { get; set; }
        public ICollection<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }
    }
}
