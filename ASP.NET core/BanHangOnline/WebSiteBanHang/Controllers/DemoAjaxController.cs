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
    public class DemoAjaxController : Controller
    {
        // GET: DemoAjax
        QuanLyBanHangContext db = new QuanLyBanHangContext();
        public ActionResult DemoAjax()
        {
            return View();
        }
        //Load Ajax theo link
        public ActionResult LoadAjaxActionLink()
        {
            System.Threading.Thread.Sleep(2000);
            return Content("Ajax Demo");
        }
        //Load Ajax theo BeginForm
        public ActionResult LoadAjaxBeginForm(FormCollection f)
        {
            System.Threading.Thread.Sleep(2000);
            string kq = f["txt1"].ToString();
            return Content(kq);
        }
        //Load Ajax theo Jquery
        public ActionResult LoadAjaxJquery(int a, int b)
        {
            System.Threading.Thread.Sleep(2000);
            return RedirectToAction("Index","Home");
        }
        public ActionResult SanPhamPartial()
        {
            var listSP = db.SanPham;
            return PartialView(listSP);
        }
    }
}