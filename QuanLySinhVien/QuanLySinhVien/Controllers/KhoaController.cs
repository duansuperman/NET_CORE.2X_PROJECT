using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Controllers
{
    public class KhoaController : Controller
    {
        private readonly QLSVContext db;
        public KhoaController(QLSVContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Khoa);
        }
        [HttpGet]
        public IActionResult Edit(string maKhoa)
        {
            var result = db.Khoa.SingleOrDefault(s => s.MaKhoa == maKhoa);
            if (result == null)
            {
                return Content("Không tồn tại Khoa để update !");
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Khoa khoa)
        {
            if (khoa == null)
            {
                return Content("Cập nhật bị ngừng do bị tác động bên ngoài");
            }
            db.Khoa.Update(khoa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(string maKhoa)
        {
            var result = db.Khoa.SingleOrDefault(s => s.MaKhoa == maKhoa);
            if (result == null)
            {
                return Content("Không tòn tại Khoa có Mã : " + maKhoa);
            }
            return View(result);
        }
        public IActionResult Delete(string maKhoa)
        {
            var result = db.Khoa.SingleOrDefault(s => s.MaKhoa == maKhoa);
            if (result == null)
            {
                return Content("Không tòn tại Khoa có Mã : " + maKhoa);
            }
            db.Khoa.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}