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
    public class SanPhamController : Controller
    {
        // GET: SanPham
        QuanLyBanHangContext db = new QuanLyBanHangContext();
        //[ChildActionOnly]
        public ActionResult SanPhamtyle1Partial()
        {
            return PartialView();
        }
        //[ChildActionOnly ]
        public ActionResult SanPhamtyle2Partial()
        {
            return PartialView();
        }
        public ActionResult ChiTietSanPham(int? id)
        {
            if (id == null)
            {
                return Content("Sản phẩm không tồn tại");
                
            }
            var sp = db.SanPham.SingleOrDefault(s => s.MaSp == id && s.DaXoa == false);
            if (sp == null)
            {
                return Content("<script> alert('Mã đơn hàng :" + id + " chưa được kích hoạt. Nên không thể xem chi tiết')</script>");
            }

            return View(sp);
        }
        public ActionResult SanPham(int? LSP,int? NSX,int? page)
        {
            if (LSP == null || NSX == null)
            {
                return Content("Sản phẩm không tồn tại");
            }
            var query = db.SanPham.Where(w=>w.MaLoaiSp==LSP&&w.MaNsx ==NSX);
            if (query.Count() == 0)
            {
                return Content("Không có sản phảm");
            }
            int pagesize = 12;
            int pagenumber = (page ?? 1);
            ViewBag.LoaiSP = LSP;
            ViewBag.NhaSX = NSX;
            return View(query.OrderBy(o=>o.MaSp).ToPagedList(pagenumber,pagesize));
        }
        public ActionResult SanPhamByLSP(int? LSP, int? page )
        {
            if (LSP == null)
            {
                return Content("Sản phẩm không tồn tại");
            }
            var query = db.SanPham.Where(w => w.MaLoaiSp == LSP);
            if (query.Count() == 0)
            {
                return Content("Không có sản phảm");
            }
            int size = 12;
            int pagenum = (page ?? 1);
            ViewBag.LSP = LSP;
            return View(query.OrderBy(o=>o.MaSp).ToPagedList(pagenum,size));
        }

        //Tìm kiếm sản phẩm
        public ActionResult TimKiemSanPham(string tukhoa,int page)
        {
            int sl = 12;
            var ketqua = db.SanPham.Where(w => w.TenSp.ToUpper().Contains(tukhoa.ToUpper()));
            int sumpage;
            int du = ketqua.Count() % 12;
            if (du == 0)
            {
                sumpage = ketqua.Count()/12;
            }
            else
            {
                sumpage = ketqua.Count() / 12+1;
            }
            ViewBag.sumpage = sumpage;
            ViewBag.tukhoa = tukhoa;
            ViewBag.tv = HttpContext.Session.Get<ThanhVienTb>("TaiKhoan");
            ketqua = ketqua.OrderBy(o => o.TenSp).Skip((page - 1) * sl).Take(sl);
            return View(ketqua);
        }

        public ActionResult SanPhamPageAjax(string tukhoa, int page)
        {
            int sl = 12;
            var ketqua = db.SanPham.Where(w => w.TenSp.ToUpper().Contains(tukhoa.ToUpper()));
            int sumpage;
            int du = ketqua.Count() % 12;
            if (du == 0)
            {
                sumpage = ketqua.Count() / 12;
            }
            else
            {
                sumpage = ketqua.Count() / 12 + 1;
            }
            ViewBag.sumpage = sumpage;
            ViewBag.TuKhoa = tukhoa as string;
            ViewBag.Page = page;
            ketqua = ketqua.OrderBy(o => o.TenSp).Skip((page - 1) * sl).Take(sl);
           
            return View(ketqua);
        }
        
    }
}