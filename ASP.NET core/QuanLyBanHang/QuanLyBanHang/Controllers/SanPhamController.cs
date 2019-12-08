using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Controllers
{
    public class SanPhamController : Controller
    {
        QuanLyBanHangContext db = new QuanLyBanHangContext();
        public IActionResult Index()
        {
            var result = db.SanPham;
            
            return View(result);
        }
    }
}