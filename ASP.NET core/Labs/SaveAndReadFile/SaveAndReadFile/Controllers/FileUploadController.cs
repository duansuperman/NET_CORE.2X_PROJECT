using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using SaveAndReadFile.Models;

namespace SaveAndReadFile.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly IFileProvider fileProvider;
        public FileUploadController(IFileProvider fileProvider)
        {
            this.fileProvider = fileProvider;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UploadFiles", file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return RedirectToAction("ListModel");
        }
        [HttpPost]
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            if (files == null || files.Count() == 0) return Content("file not selected");
            foreach(IFormFile item in files)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UploadFiles", item.FileName);
                using(var stream = new FileStream(path, FileMode.Create))
                {
                    await item.CopyToAsync(stream);
                }
            }
            return RedirectToAction("ListModel");

        }
        [HttpPost] 
        public async Task<IActionResult> UploadFileByModel(FileInputModel model)
        {
            if(model.UploadToFile ==null||model.UploadToFile.Length == 0)
            {
                return Content("Not selected file");
            }
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UploadFiles", model.UploadToFile.FileName);
            using(var stream =new  FileStream(path, FileMode.Create))
            {
                await model.UploadToFile.CopyToAsync(stream);
            }
            return RedirectToAction("ListModel");
        }
       
        public IActionResult ListModel()
        {
            var listFiles = new List<FileDetail>();
            foreach(var item in this.fileProvider.GetDirectoryContents("UploadFiles"))
            {
                listFiles.Add(new FileDetail { Name = item.Name, Path = item.PhysicalPath });
            }
            return View(listFiles);
        }
    }
}