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

    public class QuanLyPhieuNhapController : Controller
    {
        QuanLyBanHangContext db = new QuanLyBanHangContext();
        // GET: QuanLyPhieuNhap
        public ActionResult Index(int? page)
        {

            ViewBag.MaNCCA = new SelectList(db.NhaCungCap.OrderBy(o => o.TenNcc), "MaNcc", "TenNcc");
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            if (tv.MaLoaiTv != 1 && tv.MaLoaiTv != 2)
            {
                return RedirectToAction("Index", "Home");
            }
            int pagenum = (page ?? 1);
            int pagesize = 20;
            var result = db.PhieuNhap.OrderByDescending(o => o.NgayNhap);
            if (result == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(result.ToPagedList(pagenum,pagesize));
        }
        [HttpGet]
        public ActionResult ThemPhieuNhap()
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

            ViewBag.MaNcc = new SelectList(db.NhaCungCap.OrderBy(o => o.TenNcc), "MaNcc", "TenNcc");
            ViewBag.MaSp= new SelectList(db.SanPham.OrderBy(o => o.TenSp), "MaSp", "TenSp");
            return View();
        }
        [HttpPost]
        public ActionResult ThemPhieuNhap(PhieuNhap a, IEnumerable<ChiTietPhieuNhap> b)
        {
            if (a == null)
            {
                return Content("<script> alert('Phiếu nhập không được rỗng')</script>");
            }
            if (b == null)
            {
                return Content("<script> alert('Phiếu nhập không được rỗng')</script>");
            }
            ViewBag.MaNcc = new SelectList(db.NhaCungCap.OrderBy(o => o.TenNcc), "MaNcc", "TenNcc");
            ViewBag.MaSp= new SelectList(db.SanPham.OrderBy(o => o.TenSp), "MaSp", "TenSp");
            a.NgayNhap = DateTime.Now;
            a.DaXoa = false;
            db.PhieuNhap.Add(a);
            db.SaveChanges();
            SanPham sp;
            foreach (var item in b)
            {
                sp = db.SanPham.SingleOrDefault(s => s.MaSp== item.MaSp);
                sp.SoLuongTon += item.SoLuongNhap;
                db.SaveChanges();
                item.MaPn = a.MaPn;
            }
            db.ChiTietPhieuNhap.AddRange(b);
            db.SaveChanges();
            return View();
        }
        public ActionResult Xoa(int? MaPn)
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
            PhieuNhap pn = db.PhieuNhap.SingleOrDefault(s => s.MaPn == MaPn);

            db.PhieuNhap.Remove(pn);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult VoHieuHoa(int? MaPn)
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
            var update = db.PhieuNhap.SingleOrDefault(s => s.MaPn == MaPn);
            if (update == null)
            {
                return RedirectToAction("Index");
            }
            update.DaXoa = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KichHoat(int? MaPn)
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
            var update = db.PhieuNhap.SingleOrDefault(s => s.MaPn == MaPn);
            if (update == null)
            {
                return RedirectToAction("Index");
            }
            update.DaXoa = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public ActionResult Sua(PhieuNhap pn)
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
            var update = db.PhieuNhap.SingleOrDefault(s => s.MaPn == pn.MaPn);
            if (update == null)
            {
                return RedirectToAction("Index");
            }
            update.MaNcc = pn.MaNcc;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult XemChiTietPhieuNhap(int? page, int? MaPn)
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
            int pagenum = (page ?? 1);
            int pagesize = 20;
            if (MaPn != null)
            {
                var List = db.ChiTietPhieuNhap.Where(w=>w.MaPn==MaPn).OrderBy(o=>o.MaChiTietPn);
                if (List == null)
                {
                    return RedirectToAction("Index");
                }

                ViewBag.MaPn = MaPn;
                return View(List.ToPagedList(pagenum, pagesize));
            }
            return RedirectToAction("Index");
        }
        public ActionResult XoaCT(int? MaCT)
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
            ChiTietPhieuNhap del = db.ChiTietPhieuNhap.SingleOrDefault(s => s.MaChiTietPn == MaCT);
            if (del == null)
            {
                return Content("<script> alert(/'Chi tiết phiếu nhập không thể xóa/')</script>");
            }
            db.ChiTietPhieuNhap.Remove(del);
            db.SaveChanges();
            return RedirectToAction("XemChiTietPhieuNhap",new {@MaPn =  del.MaPn});
        }
        public ActionResult VoHieuHoaCT(int? MaCT)
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
            ChiTietPhieuNhap del = db.ChiTietPhieuNhap.SingleOrDefault(s => s.MaChiTietPn == MaCT);
            if (del == null)
            {
                return Content("<script> alert(/'Chi tiết phiếu nhập không thể cập nhật/')</script>");
            }
            del.DaXoa = true;
            db.SaveChanges();
            return RedirectToAction("XemChiTietPhieuNhap", new { @MaPn = del.MaPn });
        }
        public ActionResult KichHoatCT(int? MaCT)
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
            ChiTietPhieuNhap del = db.ChiTietPhieuNhap.SingleOrDefault(s => s.MaChiTietPn == MaCT);
            if (del == null)
            {
                return Content("<script> alert(/'Chi tiết phiếu nhập không thể kích hoạt/')</script>");
            }
            del.DaXoa = false;
            db.SaveChanges();
            return RedirectToAction("XemChiTietPhieuNhap", new { @MaPn = del.MaPn });
        }

        [HttpGet]
        public ActionResult CapNhatCT(int? MaCT)
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
            var result = db.ChiTietPhieuNhap.SingleOrDefault(s => s.MaChiTietPn == MaCT);
            if (result == null)
            {
                return Content("<script> alert(/'Mã chi tiết phiếu nhập không tồn tại/')</script>");
               
            }
            ViewBag.MaSp= new SelectList(db.SanPham.OrderBy(o=>o.TenSp),"MaSp","TenSp",result.MaSp);
            return View(result);
        }
        [HttpPost]
        public ActionResult CapNhatCT(ChiTietPhieuNhap ct)
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
            ChiTietPhieuNhap up = db.ChiTietPhieuNhap.SingleOrDefault(s => s.MaChiTietPn == ct.MaChiTietPn);
            if (up == null)
            {
                return Content("<script> alert(/'Chi tiết phiếu nhập không cập nhật/')</script>");
            }
            var sp = db.SanPham.SingleOrDefault(s => s.MaSp== up.MaSp);
            sp.SoLuongTon -= up.SoLuongNhap;
            sp.SoLuongTon += ct.SoLuongNhap;
            db.SaveChanges();
            up.MaSp= ct.MaSp;
            up.DonGiaNhap = ct.DonGiaNhap;
            up.SoLuongNhap = ct.SoLuongNhap;
            db.SaveChanges();
            return Content("Cập nhật chi tiết phiếu nhập thành công <a href=\"/QuanLyPhieuNhap/XemChiTietPhieuNhap?MaPn="+up.MaPn+"\"><u>Quay về chi tiết phiếu nhập</u></a>");
        }
        
    }

}