using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Controllers
{
    public class LopHocPhanController : Controller
    {
        private readonly QLSVContext db;
        public LopHocPhanController(QLSVContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var result = db.LopHocPhan;
            if (result == null)
            {
                return Content("Không có danh sách học phần để hiển thị !");
            }
            return View(result);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = db.LopHocPhan.SingleOrDefault(s => s.ID == id);
            if (result == null)
            {
                return Content("Không có lớp học phần để Edit");
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(LopHocPhan lhp)
        {
            if (lhp == null)
            {
                return Content("Không thể cập nhật do tác động bên ngoài !");
            }
            db.LopHocPhan.Update(lhp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var result = db.LopHocPhan.SingleOrDefault(s => s.ID == id);
            if (result == null)
            {
                return Content("Không có lớp học phần để hiển thị chi tiết");
            }
            return View(result);
        }
    }
}