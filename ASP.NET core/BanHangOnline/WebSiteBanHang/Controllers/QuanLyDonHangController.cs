using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebSiteBanHang.Models;
using X.PagedList;
using Rotativa.AspNetCore;
using MailKit.Net.Smtp;
using MimeKit;

namespace WebSiteBanHang.Controllers
{
    public class QuanLyDonHangController : Controller
    {
        // GET: QuanLyDonHang
        QuanLyBanHangContext db = new QuanLyBanHangContext();
        
        public IActionResult Index(int? page)
        {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb kt = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            if (kt.MaLoaiTv != 1 && kt.MaLoaiTv != 2)
            {
                return RedirectToAction("Index", "Home");
            }
            var result = db.DonDatHang.OrderByDescending(o => o.NgayDat);

            if (page == 1 || page == null)
            {
                foreach (var item in result)
                {
                    int KM = 0;
                    var kh = db.KhachHang.SingleOrDefault(s => s.MaKh == item.MaKh);
                    var tv = db.ThanhVienTb.SingleOrDefault(s => s.MaThanhVien == kh.MaThanhVien);

                    if (tv != null)
                    {
                        LoaiThanhVien ltv = db.LoaiThanhVien.SingleOrDefault(s => s.MaLoaiTv == tv.MaLoaiTv);
                        KM = (int)ltv.UuDai;
                    }
                    DonDatHang ddh = db.DonDatHang.SingleOrDefault(s => s.MaDdh == item.MaDdh);
                    ddh.UuDai = KM;
                    
                }
                db.SaveChanges();
            }
            int pagenum = (page ?? 1);
            int pagesize = 20;
            return View(result.ToPagedList(pagenum,pagesize));
        }

      
        public IActionResult KichHoatDH(int? MaDDH)
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
            var dh = db.DonDatHang.SingleOrDefault(s => s.MaDdh == MaDDH);
            if (dh == null)
            {
                return Content("<script> alert('Không thể kích hoạt mã đơn hàng :" + MaDDH + "')</script>");
            }
            dh.DaHuy = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult VoHieuHoaDH(int? MaDDH)
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
            var dh = db.DonDatHang.SingleOrDefault(s => s.MaDdh == MaDDH);
            if (dh == null)
            {
                return Content("<script> alert('Không thể vô hiệu hóa mã đơn hàng :" + MaDDH + "')</script>");
            }
            dh.DaHuy = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult XoaDH(int? MaDDH)
        {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            if (tv.MaLoaiTv != 1 )
            {
                return RedirectToAction("Index", "Home");
            }
            DonDatHang dh = db.DonDatHang.SingleOrDefault(s => s.MaDdh == MaDDH);
            if (dh == null)
            {
                return Content("<script> alert('Không thể xóa mã đơn hàng :"+MaDDH+"')</script>");
            }
            db.DonDatHang.Remove(dh);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DuyetDH(int? MaDDH)
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
            DonDatHang dh = db.DonDatHang.SingleOrDefault(s => s.MaDdh == MaDDH);
            
            if (dh == null)
            {
                return Content("<script> alert('Không thể duyệt mã đơn hàng : " + MaDDH + "')</script>");
            }
            if (dh.DaHuy == true)
            {
                return Content("<script> alert('Mã đơn hàng :" + MaDDH + " đã bị vô hiệu hóa. Nên không thể duyệt')</script>");
            }
            var ctddh = db.ChiTietDonDatHang.Where(w => w.MaDdh == dh.MaDdh);
            //Cập nhật só lượng tồn của sp khi duyệt đơn hàng
            foreach (var item in ctddh)
            {
                var sp = db.SanPham.SingleOrDefault(w => w.MaSp == item.MaSp);
                sp.SoLuongTon -= item.SoLuong;
                if (sp.SoLuongTon < 0)
                {
                    return Content("<script> alert('Sản phẩm mã : " + item.MaSp + "đã hết hàng. Yêu cầu nhập đơn hàng để tiếp tục')</script>");
                }

            }
            db.SaveChanges();
            dh.TinhTrangGiaoHang = true;
            dh.NgayGiao = DateTime.Now;
            db.SaveChanges();
            bool check = false;
            KhachHang kh = db.KhachHang.SingleOrDefault(s => s.MaKh == dh.MaKh);
            
            string emailBody = "<p>Chao Duan! Chuc mung ban da dat hang thanh cong tai shop</p><p>Cảm ơn quý khách đã đặt hàng tại shop. Mọi chi tiết mong quý khách liên hệ sdt: 123456</p>";
            check = SendEmail(kh.Email, "PhanAnh LapTop",emailBody );
            //Session["MaDDH"] = MaDDH.ToString();
            HttpContext.Session.Set("MaDDH", MaDDH.ToString());
            if (check == true)
            {
                //Session["SendMail"] = "1";
                HttpContext.Session.Set("SendMail", "1");

            }
            else
            {
                //Session["SendMail"] = "-1";
                HttpContext.Session.Set("SendMail", "-1");

            }
            return RedirectToAction("Index");
        }
        public IActionResult HuyDuyetDH(int? MaDDH)
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
            DonDatHang dh = db.DonDatHang.SingleOrDefault(s => s.MaDdh == MaDDH);
            
            if (dh == null)
            {
                return Content("<script> alert('Không thể hủy duyệt mã đơn hàng : " + MaDDH + "')</script>");
            }
            if (dh.DaHuy == true)
            {
                return Content("<script> alert('Mã đơn hàng :" + MaDDH + " đã bị vô hiệu hóa. Nên không thể duyệt')</script>");
            }
            var ctddh = db.ChiTietDonDatHang.Where(w => w.MaDdh == dh.MaDdh);
            foreach (var item in ctddh)
            {
                var sp = db.SanPham.SingleOrDefault(w => w.MaSp == item.MaSp);
                sp.SoLuongTon += item.SoLuong;
                
            }
            db.SaveChanges();
            dh.TinhTrangGiaoHang = false;
            dh.NgayGiao = null;
            db.SaveChanges();
            bool check = false;
            KhachHang kh = db.KhachHang.SingleOrDefault(s => s.MaKh == dh.MaKh);

            string emailBody = "<p>Chao Duan! Chuc mung ban da dat hang thanh cong tai shop</p><p>Cảm ơn quý khách đã đặt hàng tại shop. Mọi chi tiết mong quý khách liên hệ sdt: 123456</p>";
            check = SendEmail(kh.Email, "PhanAnh LapTop", emailBody);
            //Session["MaDDH"] = MaDDH.ToString();
            HttpContext.Session.Set("MaDDH", MaDDH.ToString());
            return RedirectToAction("Index");
        }

        public IActionResult ThanhToanDH(int? MaDDH)
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
            DonDatHang dh = db.DonDatHang.SingleOrDefault(s => s.MaDdh == MaDDH);
            if (dh == null)
            {
                return Content("<script> alert('Không thể hủy thanh toán đơn hàng : " + MaDDH + "')</script>");
            }
            if (dh.DaHuy == true)
            {
                return Content("<script> alert('Mã đơn hàng :" + MaDDH + " đã bị vô hiệu hóa. Nên không thể duyệt')</script>");
            }
            dh.DaThanhToan = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult HuyThanhToanDH(int? MaDDH)
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
            DonDatHang dh = db.DonDatHang.SingleOrDefault(s => s.MaDdh == MaDDH);
            if (dh == null)
            {
                return Content("<script> alert('Không thể hủy thanh toán đơn hàng : " + MaDDH + "')</script>");
            }
            if (dh.DaHuy == true)
            {
                return Content("<script> alert('Mã đơn hàng :" + MaDDH + " đã bị vô hiệu hóa. Nên không thể duyệt')</script>");
            }
            dh.DaThanhToan = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChiTietDH(int? page,int? MaDDH)
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
            var dh = db.ChiTietDonDatHang.Where(w => w.MaDdh == MaDDH).OrderBy(o=>o.MaChiTietDdh);
            if (dh == null)
            {
                return Content("<script> alert('Không tồn tại mã đơn hàng :" + MaDDH + "')</script>");
            }
            ViewBag.MaDDH = MaDDH;
            int pagenum = (page ?? 1);
            int pagesize = 20;
            return View(dh.ToPagedList(pagenum, pagesize));
        }

        public IActionResult VoHieuHoaCTDH(int? MaCTDH,int? MaDDH)
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
            var dh = db.ChiTietDonDatHang.SingleOrDefault(s =>s.MaChiTietDdh==MaCTDH);
            if (dh == null)
            {
                return Content("<script> alert('Không tồn tại mã chi tiết đơn hàng :" + MaCTDH + "')</script>");
            }
            dh.DaXoa = true;
            db.SaveChanges();
            if (MaDDH == null)
            {
                return View("Index");
            }
            return RedirectToAction("ChiTietDH", new { @MaDDH = MaDDH });
            
        }

        public IActionResult KichHoatCTDH(int? MaCTDH, int? MaDDH)
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
            var dh = db.ChiTietDonDatHang.SingleOrDefault(s => s.MaChiTietDdh == MaCTDH);
            if (dh == null)
            {
                return Content("<script> alert('Không tồn tại mã chi tiết đơn hàng :" + MaCTDH + "')</script>");
            }
            dh.DaXoa = false;
            db.SaveChanges();
            if (MaDDH == null)
            {
                return View("Index");
            }
            return RedirectToAction("ChiTietDH", new { @MaDDH = MaDDH });

        }

        public IActionResult XoaCTDH(int? MaCTDH, int? MaDDH)
        {
            if (HttpContext.Session.Get("TaiKhoan") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            ThanhVienTb tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            if (tv.MaLoaiTv != 1 )
            {
                return RedirectToAction("Index", "Home");
            }
            var dh = db.ChiTietDonDatHang.SingleOrDefault(s => s.MaChiTietDdh == MaCTDH);
            if (dh == null)
            {
                return Content("<script> alert('Không tồn tại mã chi tiết đơn hàng :" + MaCTDH + "')</script>");
            }
            db.ChiTietDonDatHang.Remove(dh);
            db.SaveChanges();
            if (MaDDH == null)
            {
                return View("Index");
            }
            return RedirectToAction("ChiTietDH", new { @MaDDH = MaDDH });

        }
        public IActionResult XuatHDDH(int? page,int? MaDDH)
        {

            var dh = db.ChiTietDonDatHang.Where(w => w.MaDdh == MaDDH&&w.DaXoa==false).OrderBy(o=>o.MaChiTietDdh);
            if (dh == null)
            {
                return Content("<script> alert('Không tồn tại mã chi đơn đặt hàng :" + MaDDH + "')</script>");
            }
            ViewBag.MaDDH = MaDDH;
            int pagenum = (page ?? 1);
            int pagesize = 20;
            return View(dh.ToPagedList(pagenum, pagesize));
        }
        public IActionResult Print(int? MaDDH)
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

            var p = new ViewAsPdf("XuatHDDH",new { @MaDDH=MaDDH});
            return p;
        }
        //Ham gui email
        public bool SendEmail(string toEmail, string subJect, string emailBody)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("shop dien thoai", "duansupper@gmail.com"));
                message.To.Add(new MailboxAddress("Khách hàng", "duansupper@gmail.com"));
                message.Subject = "Thông báo đạthàng thành công";
                message.Body = new TextPart("plain")
                {
                    Text = "Đặt hàng thành công "
                };
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("duansupper@gmail.com", "nguyenduan111111");
                    client.Send(message);
                    client.Disconnect(true);
                }
                return true;
            }
            catch
            {
                return false;
            }
            
            
        }
       
    }
}