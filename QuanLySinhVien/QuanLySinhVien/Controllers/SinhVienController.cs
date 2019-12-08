using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly QLSVContext db;
        public SinhVienController(QLSVContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var result = db.SinhVien;
            if (result == null)
            {
                return Content("Không có danh sách sinh viên để hiển thị !");
            }
            return View(result);
        }
        [HttpGet]
        public IActionResult Edit(string maSV)
        {
            var result = db.SinhVien.SingleOrDefault(s => s.MaSV == maSV);
            if (result == null)
            {
                return Content("Không tồn tại Sinh Viên để Edit !");
            }
            return View(result);
        }
        [HttpPost]
        public  IActionResult Edit(SinhVien sinhVien)
        {
            if (sinhVien == null)
            {
                return Content("Không thể update do tác động bên ngoài !");
            }
            db.SinhVien.Update(sinhVien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string maSV)
        {
            var result = db.SinhVien.SingleOrDefault(s => s.MaSV == maSV);
            if (result == null)
            {
                return Content("Không thể Delete Sinh vien có Mã : " + maSV);
            }
            db.SinhVien.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(string maSV)
        {
            var result = db.SinhVien.SingleOrDefault(s => s.MaSV == maSV);
            if (result == null)
            {
                return Content("Không tồn tại Sinh vien có Mã : " + maSV);
            }
            return View(result);
        }
    }
}