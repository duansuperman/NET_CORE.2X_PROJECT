using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebSiteBanHang.Models;


using System.Security.Cryptography;

namespace WebSiteBanHang.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        QuanLyBanHangContext db = new QuanLyBanHangContext();

       

        public IActionResult Index()
        {
            var listDTM = db.SanPham.Where(w=>w.MaLoaiSp ==1 && w.Moi==1 && w.DaXoa==false);
            var listLTM = db.SanPham.Where(w => w.MaLoaiSp == 2  && w.DaXoa == false);
            var listMTM = db.SanPham.Where(w => w.MaLoaiSp == 3 && w.Moi == 1 && w.DaXoa == false);
            ViewBag.ListDTM = listDTM;
            ViewBag.ListLTM = listLTM;
            ViewBag.ListMTM = listMTM;
            return View();
        }
        public  bool timGioHang(int maTV)
        {
            var result = db.GioHangTam.Where(w=>w.MaTv==maTV);
            if (result.ToList().Count() ==0)
            {
                return false;
            }
            return true;
           
        }
        
        public IActionResult MenuPartial()
        {
            var listSP = db.SanPham;
            return PartialView(listSP);
        }
        [HttpGet]
        public IActionResult DangKy()
        {
            ViewBag.CauHoi = new SelectList(LoadCauHoi());
            return View();
        }
        [HttpPost]
        public IActionResult DangKy(ThanhVienTb t,FormCollection f)
        {
            ViewBag.CauHoi = new SelectList(LoadCauHoi());
            if (true)
            {

                if (ModelState.IsValid)
                {
                    var check = db.ThanhVienTb.SingleOrDefault(s => s.Email.ToLower() == t.Email.ToLower());
                    if (check == null)
                    {
                        db.ThanhVienTb.Add(t);
                        db.SaveChanges();
                        ViewBag.ThongBao = "Chúc mừng bạn đã đăng ký thành công!";
                    }
                    else
                    {
                        ViewBag.ThongBao = "Email đã được dùng đăng ký tài khoản. Vui lòng kiểm tra lại!";
                    }
                }
                else
                {
                    ViewBag.ThongBao = "Đăng ký không Không thành công !";
                }
                return View();
            }
            ViewBag.ThongBao = "Sai mã captcha";
            
            return View();
        }
        [HttpPost]
        public IActionResult DangNhap(FormCollection f)
        {
           
            //Session["GioHang"] = null;
            HttpContext.Session.Set("GioHang", null);
            string username = f["userName"].ToString();
            string password = f["password"].ToString();
            ThanhVienTb tv = db.ThanhVienTb.SingleOrDefault(s => s.TaiKhoan == username && s.MatKhau == password);
            if (tv != null)
            {
                // Session["TaiKhoan"] = tv;
                HttpContext.Session.Set("TaiKhoan", tv);
                if (timGioHang(tv.MaThanhVien))
                {
                    return RedirectToAction("XemGioHang", "GioHang");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
            if (tv.MaLoaiTv == 1 || tv.MaLoaiTv == 2)
            {
                return RedirectToAction("Index","QuanLy");
            }
            return RedirectToAction("Index");
        }
        
        public IActionResult DangXuat()
        {
            //Session["TaiKhoan"] = null;
            //Session["GioHang"] = null;
            HttpContext.Session.Set("TaiKhoan", null);
            HttpContext.Session.Set("GioHang", null);
            return RedirectToAction("Index");
        }
        public List<string> LoadCauHoi()
        {
            List<string> list = new List<string>() {
                "Người bạn thân nhất của bạn là gì?",
                "Con chó của bạn tên gì ?",
                "Chiếc đồng hồ mà bạn đang đeo màu gì?"
            };
            
            return list;
        }
        [HttpGet]
        public IActionResult QuenMatKhau()
        {
            return View();
        }
        [HttpPost]
        public IActionResult QuenMatKhau(ThanhVienTb tv)
        {
            var result = db.ThanhVienTb.SingleOrDefault(s => s.Email == tv.Email);
            if (result == null)
            {
                return Content("<script> alert('Email: " + tv.Email + " chưa được đăng ký thành viên. Vui lòng kiểm tra lại!')</script>");
            }
            Random rd = new Random();
            int mk = rd.Next(111, 9999);
            result.MatKhau = mk.ToString();
            db.SaveChanges();
            string pass = "Mật khẩu mới của bạn là: " + mk.ToString();
           // bool check = new QuanLyDonHangController().SendEmail(tv.Email, "Shop PhanAnh Laptop", pass);
            return Content("<script> alert('Kiểm tra email: " + tv.Email + " và thử đăng nhập lại')</script>");
        }
        public IActionResult DatHang(FormCollection f)
        {
            ThanhVienTb tv = null;
            if (HttpContext.Session.Get("GioHangg") == null)
            {
                return PartialView("ThongBao");
            }
            DonDatHang ddh = new DonDatHang();
            KhachHang kh = new KhachHang();
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                
                kh.TenKh = f["userName"].ToString();
                kh.Email = f["Email"].ToString();
                kh.SoDienThoai = f["phoneNumber"].ToString();
                kh.DiaChi = f["Dress"].ToString();
                db.KhachHang.Add(kh);
                
                
            }
            else
            {
                tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");

                KhachHang check = db.KhachHang.SingleOrDefault(s=>s.MaThanhVien==tv.MaThanhVien);
                if(check == null)
                {
                    kh.TenKh = tv.HoTen;
                    kh.DiaChi = tv.DiaChi;
                    kh.Email = tv.Email;
                    kh.SoDienThoai = tv.SoDienThoai;
                    kh.MaThanhVien = tv.MaThanhVien;
                    db.KhachHang.Add(kh);
                }
                else
                {
                    kh = check;
                }

            }
            

            ddh.NgayDat = DateTime.Now;
            ddh.TinhTrangGiaoHang = false;
            ddh.DaHuy = false;
            ddh.DaXoa = false;
            ddh.DaThanhToan = false;
            ddh.MaKh = kh.MaKh;
            db.DonDatHang.Add(ddh);

            List<ItemGioHang> listGH = HttpContext.Session.Get<List<ItemGioHang>>("GioHang") ;
            ChiTietDonDatHang ct = new ChiTietDonDatHang();

            if (tv != null)
            {
                
                List<GioHangTam> listGHT = db.GioHangTam.Where(w => w.MaTv == tv.MaThanhVien).ToList();
                db.GioHangTam.RemoveRange(listGHT);
                foreach (GioHangTam item in listGHT)
                {
                    ct.MaDdh = ddh.MaDdh;
                    ct.MaSp = item.MaSp;
                    SanPham sanPham = db.SanPham.SingleOrDefault(s => s.MaSp == item.MaSp);
                    ct.TenSp = sanPham.TenSp;
                    ct.SoLuong = item.SoLuong;
                    ct.DonGia = item.DonGia;
                    db.ChiTietDonDatHang.Add(ct);
                    db.SaveChanges();
                }
            }
            else
            {
                foreach (ItemGioHang it in listGH)
                {
                    ct.MaDdh = ddh.MaDdh;
                    ct.MaSp = it.MaSP;
                    ct.TenSp = it.TenSP;
                    ct.SoLuong = it.SoLuong;
                    ct.DonGia = it.DonGia;
                    db.ChiTietDonDatHang.Add(ct);
                    db.SaveChanges();
                }
            }
            db.SaveChanges();
            listGH.Clear();
            return RedirectToAction("LoadViewGioHangAjax", "GioHang");

        }
        //Left Menu partial 
        
        public IActionResult LeftMenu()
        {
            var listSP = db.SanPham;
           
            return PartialView(listSP);
        }

        //Ma hoa pass sang MD5
        public static string GetMD5_1(string pass)
        {
            string str_md5_out = string.Empty;
            using (MD5 md5 = MD5.Create())
            {
                byte[] bytes_md5_in = System.Text.Encoding.UTF8.GetBytes(pass);
                byte[] bytes_md5_out = md5.ComputeHash(bytes_md5_in);

                str_md5_out = BitConverter.ToString(bytes_md5_out);
                str_md5_out = str_md5_out.Replace("-", "");
            }
            return str_md5_out;
        }
        public IActionResult DeMo()
        {
            return View();
        }
    }
}