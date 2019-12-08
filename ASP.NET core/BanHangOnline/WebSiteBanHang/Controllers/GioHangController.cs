
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSiteBanHang.Models;
namespace WebSiteBanHang.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        QuanLyBanHangContext db = new QuanLyBanHangContext();
        public ActionResult XemGioHang()
        {
            List<ItemGioHang> listGH = null;
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            if (tv != null)
            {
                if(new HomeController().timGioHang(tv.MaThanhVien))
                {
                    var result = db.GioHangTam.Where(w => w.MaTv == tv.MaThanhVien);
                    listGH = new List<ItemGioHang>();
                    foreach (var item in result)
                    {
                        ItemGioHang itemGH = new ItemGioHang((int)item.MaSp, item.SoLuong);
                        listGH.Add(itemGH);
                    }
                    //Session["GioHang"] = listGH;
                    HttpContext.Session.Set("GioHang", listGH);

                }
            }
            else
            {
                //listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
                listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
            }

            return View(listGH);
        }
        public ActionResult GioHangPartial()
        {
            ViewBag.TongSoLuong = TinhTongSoLuong();
            if (TinhTongTien() == 0)
            {
                ViewBag.TongTien = 0;
            }
            else
            {
                ViewBag.TongTien = TinhTongTien().ToString("#,##");
            }
            return PartialView();
        }

        public ActionResult GioHangAjax()
        {
            ViewBag.TongSoLuong = TinhTongSoLuong();
            if (TinhTongTien() == 0)
            {
                ViewBag.TongTien = 0;
            }
            else
            {
                ViewBag.TongTien = TinhTongTien().ToString("#,##");
            }
            return PartialView();
        }
        public List<ItemGioHang> LayGioHang()
        {

            //List<ItemGioHang> listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
            List<ItemGioHang> listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
            if (listGH == null)
            {
                //Nếu session giỏ hàng chưa tồn tại thì khởi tạo giỏ hàng
                listGH = new List<ItemGioHang>();
                //Session["GioHang"] = listGH;
                HttpContext.Session.Set("GioHang", listGH);
            }
            return listGH;
        }
        public ActionResult ThemGioHang(int MaSP,string strURL )
        {
            List<ItemGioHang> listGH = LayGioHang();
            SanPham sp = db.SanPham.SingleOrDefault(s => s.MaSp == MaSP);
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ItemGioHang check = listGH.SingleOrDefault(s => s.MaSP == MaSP);
            if(check == null)
            {
                ItemGioHang item = new ItemGioHang(MaSP);
                if (sp.SoLuongTon < item.SoLuong)
                {
                    return View("ThongBao");
                }
                listGH.Add(item);
                if (tv != null)
                {
                    capNhatVaoGioHangTam(tv.MaThanhVien,item.MaSP, 1);
                }
                
                return RedirectToAction("GioHangPartial","GioHang");
            }
            if (sp.SoLuongTon < check.SoLuong+1)
            {
                return View("ThongBao");
            }
            check.SoLuong++;
            check.SetThanhTien();
            if (tv != null)
            {
                capNhatVaoGioHangTam(tv.MaThanhVien ,check.MaSP, check.SoLuong);
            }
            return RedirectToAction("GioHangPartial", "GioHang");
        }
        public int TinhTongSoLuong()
        {
            List<ItemGioHang> listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
            if (listGH == null)
            {
                return 0;
            }
            return listGH.Sum(s => s.SoLuong);
        }
        public decimal TinhTongTien()
        {
            List<ItemGioHang> listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
            if (listGH == null)
            {
                return 0;
            }
            return listGH.Sum(s => s.ThanhTien);
        }
        public ActionResult SuaGioHang(int? MaSP)
        {
            if (HttpContext.Session.Get("GioHang") == null)
            {
                return RedirectToAction("Index","Home");
            }
            List<ItemGioHang> list = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
            ItemGioHang item = list.Find(f => f.MaSP == MaSP);
            ViewBag.ListGH = list;
            return View(item);
        }
       
        public ActionResult CapNhatGioHang(int MaSP, int Sl)
        {
            if (HttpContext.Session.Get("GioHang") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<ItemGioHang> listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
            ItemGioHang it = listGH.Find(f => f.MaSP == MaSP);
            SanPham sp = db.SanPham.SingleOrDefault(s=>s.MaSp==MaSP);
            if (Sl > sp.SoLuongTon)
            {
                return View("ThongBao");
            }

            it.SoLuong = Sl;
            it.SetThanhTien();
            ThanhVienTb tv =  HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            if (tv != null)
            {
                capNhatVaoGioHangTam(tv.MaThanhVien,MaSP, Sl);
            }
            return RedirectToAction("LoadGioHangAjaxUpdate", new { @MaSP = MaSP });

        }
        public ActionResult LoadGioHangAjaxUpdate(int? MaSP)
        {
            List<ItemGioHang> listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
            ItemGioHang it = listGH.Find(f => f.MaSP == MaSP);
            ViewBag.ListGH = listGH;
            return PartialView(it);
        }
        [HttpPost]
        public ActionResult XoaItemGioHang(int? MaSP, int? MaEdit)
        {
            if (HttpContext.Session.Get("GioHang") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<ItemGioHang> listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
            ItemGioHang it = listGH.SingleOrDefault(f => f.MaSP == MaSP);
            listGH.Remove(it);
            ThanhVienTb tv =  HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            if (tv != null)
            {
                GioHangTam itemGHT = db.GioHangTam.SingleOrDefault(s => s.MaSp == MaSP && s.MaTv == tv.MaThanhVien);
                if (itemGHT != null)
                {
                    db.GioHangTam.Remove(itemGHT);
                    db.SaveChanges();
                }
            }
            if(MaEdit !=null )
            {
                return RedirectToAction("LoadGioHangAjaxUpdate", new { @MaSP = MaEdit });
            }
            return RedirectToAction("LoadViewGioHangAjax");
        }

        //public ActionResult LoadViewEditGioHang( )
        //{
        //    if (Session["GioHang"] == null)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //    List<ItemGioHang> listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
        //    return PartialView(listGH);
        //}
     
        public ActionResult LoadViewGioHangAjax()
        {
            
            List<ItemGioHang> listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang");
            return PartialView(listGH);
        }
        public void capNhatVaoGioHangTam(int maTV,int maSP, int sl)
        {
            var result = db.GioHangTam.SingleOrDefault(s => s.MaSp == maSP&&s.MaTv == maTV);
           
            if (result == null)
            {
                //Nếu sản phẩm không có trong giỏ hàng tạm thì sẽ thêm mới
                GioHangTam item = new GioHangTam();
                ThanhVienTb tv =  HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
                var sanPham = db.SanPham.SingleOrDefault(s => s.MaSp == maSP);
                if (tv != null && sanPham!=null)
                {
                    item.MaTv = tv.MaThanhVien;
                    item.MaSp = maSP;
                    item.DonGia = sanPham.DonGia;
                    item.SoLuong = sl;
                }
                db.GioHangTam.Add(item);
                db.SaveChanges();
            }
            else
            {
                result.SoLuong = sl;
                db.SaveChanges();
            }
        }
        
    }
}