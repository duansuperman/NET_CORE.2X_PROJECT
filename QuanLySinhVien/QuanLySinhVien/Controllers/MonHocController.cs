using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Controllers
{
    public class MonHocController : Controller
    {
        private readonly QLSVContext db;
        public MonHocController(QLSVContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var result = db.MonHoc;
            if (result == null)
            {
                return Content("Không có danh sách Môn Học để hiển thị !");
            }
            return View(result);
        }
        [HttpGet]
        public IActionResult Edit(string maMon)
        {
            var result = db.MonHoc.SingleOrDefault(s => s.MaMon == maMon);
            if (result == null)
            {
                return Content("Không tồn tại Môn Học để Edit");
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(MonHoc monHoc)
        {
            if (monHoc == null)
            {
                return Content("Không thể cập nhập Môn Học !");
            }
            db.MonHoc.Update(monHoc);
            return RedirectToAction("Index");
        }
        public IActionResult Details(string maMon)
        {
            var result = db.MonHoc.SingleOrDefault(s => s.MaMon == maMon);
            if (result == null)
            {
                return Content("Xem chi tiết Môn Học !");
            }
            return View(result);
        }
        public IActionResult Delete(string maMon)
        {
            var result = db.MonHoc.SingleOrDefault(s => s.MaMon == maMon);
            if (result == null)
            {
                return Content("Không thể Delete do tác động bên ngoài !");
            }
            db.MonHoc.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}