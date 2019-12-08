using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using General.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace General.Controllers
{
    public class ProductController : Controller
    {
        private readonly WebAppContext db;
        public ProductController(WebAppContext context)
        {
            db = context;
        }
        public IActionResult Index(int ? page)
        {
            var products = db.Product;
            int pageNumber = page ?? 1;//If page = null, so default page = 1
            var productsOfOnePage = products.ToPagedList(pageNumber, 15); //Only contain 15 product per each page
            
            return View(productsOfOnePage);
        }
        
    }
}