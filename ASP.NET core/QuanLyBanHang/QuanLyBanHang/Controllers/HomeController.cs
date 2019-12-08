using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Controllers
{
    public class HomeController : Controller
    {
        QuanLyBanHangContext db = new QuanLyBanHangContext();
        public IActionResult Index()
        {
            var listDTM = db.SanPham.Where(w => w.MaLoaiSp == 1 && w.Moi == 1 && w.DaXoa == false);
            var listLTM = db.SanPham.Where(w => w.MaLoaiSp == 2 && w.DaXoa == false);
            var listMTM = db.SanPham.Where(w => w.MaLoaiSp == 3 && w.Moi == 1 && w.DaXoa == false);
            ViewBag.ListDTM = listDTM;
            ViewBag.ListLTM = listLTM;
            ViewBag.ListMTM = listMTM;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
