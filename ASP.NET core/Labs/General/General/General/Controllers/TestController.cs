using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using General.Models;
using Microsoft.AspNetCore.Mvc;

namespace General.Controllers
{
    public class TestController : Controller
    {
        private readonly WebAppContext db;
        public TestController(WebAppContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var listProduct = db.Product;
            return View(listProduct);
        }
        public IActionResult TestLoadView()
        {
            return View();
        }
    }
}