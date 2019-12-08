using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteBanHang.Models
{
    public class ItemGioHang
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string HinhAnh { get; set; }
        public ItemGioHang(int masp, int sl)
        {
            using (QuanLyBanHangContext db = new QuanLyBanHangContext())
            {
                MaSP = masp;
                SanPham sp = db.SanPham.SingleOrDefault(s => s.MaSp == masp);
                TenSP = sp.TenSp;
                SoLuong = sl;
                DonGia = sp.DonGia.Value;
                ThanhTien = DonGia * sl;
                HinhAnh = sp.HinhAnh;
            }
        }
        public ItemGioHang(int masp)
        {
            using (QuanLyBanHangContext db = new QuanLyBanHangContext())
            {
                MaSP = masp;
                SanPham sp = db.SanPham.SingleOrDefault(s => s.MaSp == masp);
                TenSP = sp.TenSp;
                DonGia = sp.DonGia.Value;
                HinhAnh = sp.HinhAnh;
                SoLuong = 1;
                ThanhTien = SoLuong * DonGia;
            }
        }
        public ItemGioHang()
        {
            SoLuong = 0;
            ThanhTien = 0;
            DonGia = 0;
        }
        public void SetThanhTien()
        {
            ThanhTien = SoLuong * DonGia;
        }
    }
}