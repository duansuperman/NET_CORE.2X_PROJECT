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
    public class QuanLyThanhVienController : Controller
    {
        // GET: QuanLyThanhVien
        QuanLyBanHangContext db = new QuanLyBanHangContext();

        public ActionResult Index(int? page, string key)
        {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            
            if (tv.MaLoaiTv == 1)
            {
                key = "Ad";
            }
            else if (tv.MaLoaiTv == 2)
            {
                key = null;
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            List<ThanhVienTb> result = new List<ThanhVienTb>();
            if (key != "Ad")
            {
                result = db.ThanhVienTb.Where(w => (w.MaLoaiTv == 3 || w.MaLoaiTv == 4)).OrderBy(o => o.HoTen).ToList();
            }
            else
            {
                result = db.ThanhVienTb.Where(w => w.MaLoaiTv == 2|| w.MaLoaiTv == 3 || w.MaLoaiTv == 4).OrderBy(o => o.HoTen).ToList();
            }
            int pagenum = (page ?? 1);
            int pagesize = 20;
            return View(result.ToPagedList(pagenum,pagesize));
        }
        public ActionResult Xoa(int? MaThanhVien, string key)
        {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            
            if (tv.MaLoaiTv == 1)
            {
                key = "Ad";
            }
            else if (tv.MaLoaiTv == 2)
            {
                key = null;
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            ThanhVienTb rm = db.ThanhVienTb.SingleOrDefault(s => s.MaThanhVien == MaThanhVien);
            db.ThanhVienTb.Remove(rm);
            db.SaveChanges();
            if (key != "Ad")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", new { @key = "Ad" });
            }
        }
        
        public ActionResult VoHieuHoa(int? MaThanhVien, string key)
        {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            
            if (tv.MaLoaiTv == 1)
            {
                key = "Ad";
            }
            else if (tv.MaLoaiTv == 2)
            {
                key = null;
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            ThanhVienTb del = db.ThanhVienTb.SingleOrDefault(s => s.MaThanhVien == MaThanhVien);
            del.DaXoa = true;
            db.SaveChanges();
            if (key != "Ad")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", new { @key = "Ad" });
            }
        }
        public ActionResult KichHoat(int? MaThanhVien, string key)
        {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
           
            if (tv.MaLoaiTv == 1)
            {
                key = "Ad";
            }
            else if (tv.MaLoaiTv == 2)
            {
                key = null;
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb kh = db.ThanhVienTb.SingleOrDefault(s => s.MaThanhVien == MaThanhVien);
            kh.DaXoa = false;
            db.SaveChanges();
            if (key != "Ad")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", new { @key = "Ad" });
            }
        }
        public ActionResult ChuyenLoaiThanhVien(int? MaThanhVien,string key)
        {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb check = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            
            if (check.MaLoaiTv == 1)
            {
                key = "Ad";
            }
            else if (check.MaLoaiTv == 2)
            {
                key = null;
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = db.ThanhVienTb.SingleOrDefault(s => s.MaThanhVien == MaThanhVien);
            if (tv.MaLoaiTv == 3)
            {
                tv.MaLoaiTv = 4;
            }
            else if(tv.MaLoaiTv==4)
            {
                tv.MaLoaiTv = 3;
            }
            else
            {
                tv.MaLoaiTv = 1;
            }
            db.SaveChanges();
            if (key != "Ad")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index",new {@key="Ad" });
            }
        }
        public ActionResult ResetPass(int? MaThanhVien, string key)
        {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb check = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
           
            if (check.MaLoaiTv == 1)
            {
                key = "Ad";
            }
            else if (check.MaLoaiTv == 2)
            {
                key = null;
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = db.ThanhVienTb.SingleOrDefault(s => s.MaThanhVien == MaThanhVien);
            tv.MatKhau = "123456";
            db.SaveChanges();
            if (key != "Ad")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", new { @key = "Ad" });
            }
        }
        
    }
}