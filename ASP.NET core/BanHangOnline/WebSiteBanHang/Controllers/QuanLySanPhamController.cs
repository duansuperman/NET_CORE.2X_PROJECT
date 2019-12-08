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
    public class QuanLySanPhamController : Controller
    {
        QuanLyBanHangContext db = new QuanLyBanHangContext();
        // GET: QuanLySanPham
        
        public ActionResult Index(int? page, string key)
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

            ViewBag.tv = tv;
            List<SanPham> ListSP = new List<SanPham>();
            if (key==null)
            {
                ListSP = db.SanPham.OrderByDescending(o => o.MaSp).ToList();
            }
            else
            {
                ListSP = db.SanPham.Where(w => w.DaXoa == false && w.TenSp.ToUpper().Contains(key.ToUpper())).OrderByDescending(o => o.MaSp).ToList();
            }
            int pagenum = (page ?? 1);
            int pagesize = 12;
            return View(ListSP.ToPagedList(pagenum,pagesize));
        }
        
        [HttpGet]
        public ActionResult ThemMoi()
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

            ViewBag.MaNCC = new SelectList(db.NhaCungCap.OrderBy(o => o.TenNcc), "MaNCC", "TenNcc");
            ViewBag.MaNSX = new SelectList(db.NhaSanXuat.OrderBy(o => o.TenNsx), "MaNSX", "TenNSX");
            ViewBag.MaLoaiSP = new SelectList(db.LoaiSanPham.OrderBy(o => o.TenLoai), "MaLoaiSP", "TenLoai");
            return View();
        }
        
        [HttpPost]
        //public ActionResult ThemMoi(SanPham sp, HttpPostedFileBase HinhAnh, HttpPostedFileBase HinhAnh1, HttpPostedFileBase HinhAnh2, HttpPostedFileBase HinhAnh3, HttpPostedFileBase HinhAnh4)
        //{
        //    if (HttpContext.Session.Get("TaiKhoan") == null)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //    ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
        //    if (tv.MaLoaiTv != 1 && tv.MaLoaiTv != 2)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }

        //    ViewBag.MaNCC = new SelectList(db.NhaCungCap.OrderBy(o => o.TenNcc), "MaNCC", "TenNcc");
        //    ViewBag.MaNSX = new SelectList(db.NhaSanXuats.OrderBy(o => o.TenNSX), "MaNSX", "TenNSX");
        //    ViewBag.MaLoaiSP = new SelectList(db.LoaiSanPham.OrderBy(o => o.TenLoai), "MaLoaiSP", "TenLoai");
        //    if (HinhAnh !=null && HinhAnh1.ContentLength>0 && HinhAnh2 !=null&& HinhAnh3 !=null && HinhAnh4 !=null)
        //    {
        //        var fileName = Path.GetFileName(HinhAnh.FileName);
        //        var fileName1 = Path.GetFileName(HinhAnh1.FileName);
        //        var fileName2 = Path.GetFileName(HinhAnh2.FileName);
        //        var fileName3 = Path.GetFileName(HinhAnh3.FileName);
        //        var fileName4 = Path.GetFileName(HinhAnh4.FileName);
        //        var path = Path.Combine(Server.MapPath("~/Content/HinhAnhSP"), fileName);
        //        var path1 = Path.Combine(Server.MapPath("~/Content/HinhAnhSP"), fileName1);
        //        var path2 = Path.Combine(Server.MapPath("~/Content/HinhAnhSP"), fileName2);
        //        var path3 = Path.Combine(Server.MapPath("~/Content/HinhAnhSP"), fileName3);
        //        var path4 = Path.Combine(Server.MapPath("~/Content/HinhAnhSP"), fileName4);
        //        if (System.IO.File.Exists(path)==true|| System.IO.File.Exists(path1) == true|| System.IO.File.Exists(path2) == true|| System.IO.File.Exists(path3) == true|| System.IO.File.Exists(path4) == true)
        //        {
        //            ViewBag.upload = "Một trong các hình đã tồn tại. Vui lòng kiểm tra lại";
        //        }
        //        else
        //        {
        //            HinhAnh.SaveAs(path);
        //            HinhAnh1.SaveAs(path1);
        //            HinhAnh2.SaveAs(path2);
        //            HinhAnh3.SaveAs(path3);
        //            HinhAnh4.SaveAs(path4);

        //            sp.HinhAnh = fileName;
        //            sp.HinhAnh1 = fileName1;
        //            sp.HinhAnh2 = fileName2;
        //            sp.HinhAnh3 = fileName3;
        //            sp.HinhAnh4 = fileName4;
        //            sp.NgayCapNhap = DateTime.Now;
        //            sp.Moi = 1;
        //            sp.DaXoa = false;
        //            db.SanPham.Add(sp);
        //            db.SaveChanges();
        //        }
        //    }

        //    return View();
        //}
        public ActionResult Xoa(int? MaSp)
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
            else
            {
                if (tv.MaLoaiTv == 2)
                {
                    return RedirectToAction("Index");
                }
            }
            SanPham sp = db.SanPham.SingleOrDefault(s => s.MaSp == MaSp);
            db.SanPham.Remove(sp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult VoHieuHoa(int? MaSp) {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            if (tv.MaLoaiTv != 1 && tv.MaLoaiTv != 2)
            {
                return RedirectToAction("Index", "Home");
            }

            SanPham sp = db.SanPham.SingleOrDefault(s => s.MaSp == MaSp);
            sp.DaXoa = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KichHoat(int? MaSp)
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
            SanPham sp = db.SanPham.SingleOrDefault(s => s.MaSp == MaSp);
            sp.DaXoa = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Sua(int? MaSp)
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

            ViewBag.MaNCC = new SelectList(db.NhaCungCap.OrderBy(o => o.TenNcc), "MaNCC", "TenNcc");
            ViewBag.MaNSX = new SelectList(db.NhaSanXuat.OrderBy(o => o.TenNsx), "MaNSX", "TenNSX");
            ViewBag.MaLoaiSP = new SelectList(db.LoaiSanPham.OrderBy(o => o.TenLoai), "MaLoaiSP", "TenLoai");
            SanPham sp = db.SanPham.SingleOrDefault(s => s.MaSp == MaSp);
            return View(sp);
        }
        //[ValidateInput(false)]
        [HttpPost]
        //public ActionResult Sua(SanPham sp, HttpPostedFileBase HinhAnh, HttpPostedFileBase HinhAnh1, HttpPostedFileBase HinhAnh2, HttpPostedFileBase HinhAnh3, HttpPostedFileBase HinhAnh4,FormCollection f)
        //{
        //    if (HttpContext.Session.Get("TaiKhoan") == null)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //    ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
        //    if (tv.MaLoaiTv != 1 && tv.MaLoaiTv != 2)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }

        //    SanPham update = db.SanPham.SingleOrDefault(s => s.MaSp == sp.MaSp);

        //    ViewBag.MaNCC = new SelectList(db.NhaCungCap.OrderBy(o => o.TenNcc), "MaNCC", "TenNcc");
        //    ViewBag.MaNSX = new SelectList(db.NhaSanXuats.OrderBy(o => o.TenNSX), "MaNSX", "TenNSX");
        //    ViewBag.MaLoaiSP = new SelectList(db.LoaiSanPham.OrderBy(o => o.TenLoai), "MaLoaiSP", "TenLoai");
        //    if (HinhAnh!=null )
        //    {
        //        var fileName = Path.GetFileName(HinhAnh.FileName);
        //        var path = Path.Combine(Server.MapPath("~/Content/HinhAnhSP"), fileName);
        //        if (System.IO.File.Exists(path) == false)
        //        {

        //            HinhAnh.SaveAs(path);
                    
        //            update.HinhAnh = fileName;
        //        }
        //    }
        //    if (HinhAnh1 !=null)
        //    {
        //        var fileName1 = Path.GetFileName(HinhAnh1.FileName);
        //        var path = Path.Combine(Server.MapPath("~/Content/HinhAnhSP"), fileName1);
        //        if (System.IO.File.Exists(path) == false)
        //        {
        //            HinhAnh1.SaveAs(path);
        //            update.HinhAnh1 = fileName1;
        //        }
                
        //    }
        //    if (HinhAnh2 !=null)
        //    {
        //        var fileName2 = Path.GetFileName(HinhAnh2.FileName);
        //        var path = Path.Combine(Server.MapPath("~/Content/HinhAnhSP"), fileName2);
        //        if (System.IO.File.Exists(path) == false)
        //        {
        //            HinhAnh2.SaveAs(path);
        //            update.HinhAnh2 = fileName2;
        //        }
        //    }
        //    if (HinhAnh3 !=null)
        //    {
        //        var fileName3 = Path.GetFileName(HinhAnh3.FileName);
        //        var path = Path.Combine(Server.MapPath("~/Content/HinhAnhSP"), fileName3);
        //        if (System.IO.File.Exists(path) == false)
        //        {
        //            HinhAnh3.SaveAs(path);
        //            update.HinhAnh3 = fileName3;
        //        }
        //    }
        //    if (HinhAnh4 !=null)
        //    {
        //        var fileName4 = Path.GetFileName(HinhAnh4.FileName);
        //        var path = Path.Combine(Server.MapPath("~/Content/HinhAnhSP"), fileName4);
        //        if (System.IO.File.Exists(path) == false)
        //        {
        //            HinhAnh4.SaveAs(path);
        //            update.HinhAnh4 = fileName4;
        //        }
        //    }
           
        //    update.TenSp = sp.TenSp;
        //    update.DonGia = sp.DonGia;
        //    update.CauHinh = sp.CauHinh;
        //    update.MoTa = sp.MoTa;
        //    update.NgayCapNhap = DateTime.Now;
        //    update.MaLoaiSP = sp.MaLoaiSP;
        //    update.MaNCC = sp.MaNCC;
        //    update.MaNSX = sp.MaNSX;
        //    update.SoLuongTon = sp.SoLuongTon;
        //    db.SaveChanges();
        //    string check = "1";
        //    Session["update"] = check;
        //    return RedirectToAction("Index");
        //}
        //San pham het hang
        public ActionResult SanPhamHetHang(int?page)
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

            ViewBag.tv = tv;
            List<SanPham> ListSP = new List<SanPham>();
            ListSP = db.SanPham.Where(w=>w.SoLuongTon==0).OrderByDescending(o => o.MaSp).ToList();
            int pagenum = (page ?? 1);
            int pagesize = 12;
            return View(ListSP.ToPagedList(pagenum, pagesize));
           
        }
        //San pham gan het hang
        public ActionResult SanPhamGanHetHang(int? page)
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

            ViewBag.tv = tv;
            List<SanPham> ListSP = new List<SanPham>();
            ListSP = db.SanPham.Where(w => w.SoLuongTon <=10).OrderByDescending(o => o.MaSp).ToList();
            int pagenum = (page ?? 1);
            int pagesize = 12;
            return View(ListSP.ToPagedList(pagenum, pagesize));

        }

    }
}