using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GenerateViewFromModel.Models;
namespace GenerateViewFromModel.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> listProduct = new List<Product>();
        public IActionResult Index()
        {
            listProduct.Add(new Product { Id=1,Name="Product1",Price=1000});
            listProduct.Add(new Product { Id = 2, Name = "Product2", Price = 2000 });
            listProduct.Add(new Product { Id=3,Name="Product3",Price=3000});
            return View("ShowAll",listProduct);
        }
        public IActionResult ShowAll()
        {
            return View(listProduct);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            
            if (ModelState.IsValid == false) return View();
            int preCount = listProduct.Count();
            listProduct.Add(product);
            int afterCount = listProduct.Count();
            if (preCount < afterCount)
            {
                ViewData["InsertResult"] = "Thêm mới thành công một sản phẩm có ID = " + product.Id;
            }
            else
            {
                ViewData["InsertResult"] = "Thêm mới thất bại";
            }
            return View("ShowAll", listProduct);
        }
        public IActionResult Delete(int iD)
        {
            Product product = listProduct.SingleOrDefault(s => s.Id == iD);
            int PreCount = listProduct.Count();
            listProduct.Remove(product);
            int afterCount = listProduct.Count();
            if (afterCount < PreCount)
            {
                ViewData["DeleteResult"] = "Xóa thành công sản phẩm có ID = " + iD;

            }
            else
            {
                ViewData["DeleteResult"] = "Xóa không thành công ! Kiểm tra sản phẩm có ID = " + iD;
            }
            return View("ShowAll", listProduct);
        }
        [HttpGet]
        public IActionResult Update(int iD)
        {
            Product productUpdate = listProduct.SingleOrDefault(s => s.Id ==iD);
            if(productUpdate == null)
            {
                return View("ShowAll", listProduct);
            }
            return View(productUpdate);

        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            Product productUpdate = listProduct.SingleOrDefault(s => s.Id == product.Id);
            productUpdate.Name = product.Name;
            productUpdate.Price = product.Price;
            ViewData["UpdateResult"] = "Cập nhật thành công sản phẩm có ID = "+product.Id;
            return View("ShowAll",listProduct);
        }
        public IActionResult Detail(int iD)
        {
            Product productDetail = listProduct.SingleOrDefault(s => s.Id == iD);
            if (productDetail == null)
            {
                return View("ShowAll", listProduct);
            }
            return View(productDetail);
        }
    }
}