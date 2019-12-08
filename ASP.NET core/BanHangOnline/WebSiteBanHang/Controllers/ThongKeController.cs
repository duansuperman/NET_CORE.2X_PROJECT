using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebSiteBanHang.Models;
using X.PagedList;


namespace WebSiteBanHang.Controllers
{
    public class ThongKeController : Controller
    {
        // GET: ThongKe
        QuanLyBanHangContext db = new QuanLyBanHangContext();
        public ActionResult Index(int? Nam)
        {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            if (tv.MaLoaiTv != 1 && tv.MaLoaiTv != 2)
            {
                return RedirectToAction("Index", "Home");
            }

            if (Nam == null)
            {
                Nam = DateTime.Now.Year;
            }

            List<ThongKeDoanhThu> list = new List<ThongKeDoanhThu>();
            list = ThongKeDoanhThu(Nam);
            ViewBag.Nam = Nam.ToString();
            return View(list);
        }
        //Tinh Tong Doanh Thu Trong 1 Nam
        public double TongDoanhThuNam(int? Nam)
        {

            if (Nam == null)
            {
                Nam = DateTime.Now.Year;
            }
            var result = db.DonDatHang.Where(w => w.NgayDat.Value.Year == Nam);
            double TongThu = 0;
            foreach(var item in result)
            {
                TongThu += (double)db.ChiTietDonDatHang.Where(w => w.MaDdh == item.MaDdh).Sum(s => s.SoLuong * s.DonGia);
            }
            return TongThu;
        }
        //Thong ke Doanh Thu Theo Thang
        public List<ThongKeDoanhThu> ThongKeDoanhThu(int? Nam)
        {
            
            List<DonDatHang> result = db.DonDatHang.Where(w => w.NgayDat.Value.Year == Nam&&w.DaThanhToan==true).ToList();
            List<ThongKeDoanhThu> list = new List<ThongKeDoanhThu>();
            if (result == null)
            {
                return new List<ThongKeDoanhThu>(12);
            }
            
            for(int i = 1; i <= 12; i++)
            {
                ThongKeDoanhThu tk = new ThongKeDoanhThu();
                List<DonDatHang> ct = result.Where(w => w.NgayDat.Value.Month == i).ToList();
                tk.Thang = i;
                double TongDT = 0;
                foreach (DonDatHang item in ct)
                {
                    TongDT += (double)db.ChiTietDonDatHang.Where(w => w.MaDdh == item.MaDdh).Sum(s => s.SoLuong * s.DonGia);
                }
                tk.DoanhThu = TongDT;
                list.Add(tk);
            }
            
            return list;
        }
        //Thong Ke SoLuong Thanh Vien
        public int SoLuongTV()
        {
            return (int)db.ThanhVienTb.Count();
        }
        public int SoLuongSP()
        {
            return (int)db.SanPham.Count();
        }
        public int SoLuongDDH()
        {
            return (int)db.DonDatHang.Count();
        }
        public ActionResult ThongKePartial()
        {
            //ViewBag.SoNguoiTruyCap = HttpContext.Application["SoNguoiTruyCap"].ToString();
            //ViewBag.SoNguoiOnline = HttpContext.Application["SoNguoiOnLine"].ToString();
            ViewBag.SoLuongSP = SoLuongSP().ToString();
            ViewBag.SoLuongTV = SoLuongTV().ToString();
            ViewBag.SoLuongDDH = SoLuongDDH().ToString();
            return PartialView();
        }
       
    }
}