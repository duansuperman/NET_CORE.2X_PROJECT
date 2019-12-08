using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaveAndReadFile.Models;

namespace SaveAndReadFile.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Manage(StudentInfo student, string command)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/FileSave", "Student.txt");
            if(command == "Lưu")
            {
                if (ModelState.IsValid == false)
                {
                    ViewBag.Message = "Lưu thất bại";
                    return View("Index");
                }
                string[] line = { student.Id, student.Name, student.Marks.ToString() };
                System.IO.File.WriteAllLines(path, line);
                ViewBag.Message = "Lưu thành công";
               
            }
            if (command == "Mở")
            {
                string []line = System.IO.File.ReadAllLines(path);
                ViewBag.Id = line[0];
                ViewBag.Name = line[1];
                ViewBag.Marks = line[2];
                ViewBag.Message = "Mở thành công";
            }
            return View("Index");
        }
    }
}