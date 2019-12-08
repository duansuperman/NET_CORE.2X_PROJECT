using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebSiteBanHang.Models;
namespace WebSiteBanHang.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        QuanLyBanHangContext db = new QuanLyBanHangContext();

             
        public ActionResult Index()
        {
            //c1 : query syntax
            var listKH = from KH in db.KhachHang select KH;
            //c2 : Method syntax
            //var listKH = db.KhachHang;
            return View(listKH);
        }
        public ActionResult Index1()
        {
            //c1: Sử dụng đối tượng trả về là List
            List<KhachHang> listKH = (from KH in db.KhachHang select KH).ToList();
            //c2: Sử dụng đối tượng trả về var
            //var listKH = from KH in db.KhachHang select KH;
            return View(listKH);
        }
        public ActionResult TruyVan1DoiTuong()
        {
            //cash 1: Truy vấn đối tượng bằng cú pháp truy vấn(query syntax)

            //b1: Lấy danh sách dữ liệu :
            var listKH = from kh in db.KhachHang where kh.MaKh == 1 select kh;

            //b2: Lấy đối tượng đầu tiên trong bảng
            var khang = listKH.FirstOrDefault();

            //cách 2: sử dụng method syntax để truy vấn 
            // var khang = db.KhachHang.SingleOrDefault(s=>s.MaKH==1); hoặc var khang = db.KhachHang.FirstOrDefault()

            return View(khang);
        }
        public ActionResult SortDuLieu()
        {
            var listKH = db.KhachHang.OrderByDescending(o => o.TenKh);
            return View(listKH);
        }
        public ActionResult GroupByDuLieu()
        {
            var listTV = db.ThanhVienTb;
            return View(listTV);
        }
        

    }
    
}