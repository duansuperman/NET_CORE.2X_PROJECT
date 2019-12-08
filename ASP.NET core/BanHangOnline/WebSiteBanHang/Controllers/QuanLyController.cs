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
    public class QuanLyController : Controller
    {
        // GET: QuanLy
        public ActionResult Index()
        {
            return View();
        }
    }
}