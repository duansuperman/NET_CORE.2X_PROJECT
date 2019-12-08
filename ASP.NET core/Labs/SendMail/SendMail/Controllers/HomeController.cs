using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SendMail.Models;
using MailKit.Net.Smtp;
using MimeKit;

namespace SendMail.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("shop dien thoai", "duansupper@gmail.com"));
                message.To.Add(new MailboxAddress("Khách hàng", "duansupper@gmail.com"));
                message.Subject = "Thông báo đạthàng thành công";
                message.Body = new TextPart("plain")
                {
                    Text = "Đặt hàng thành công "
                };
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("duansupper@gmail.com", "nguyenduan111111");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch
            {

            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
