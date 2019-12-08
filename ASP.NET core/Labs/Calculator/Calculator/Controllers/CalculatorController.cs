using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calculate(double a = 0, double b=0, char op='+')
        {
            switch (op)
            {
                case '+':
                    ViewBag.KetQua = a + b;
                    break;
                case '-':
                    ViewBag.KetQua = a - b;
                    break;
                case '*':
                    ViewBag.KetQua = a * b;
                    break;
                case '/':
                    ViewBag.KetQua = a / b;
                    break;
                default:
                    ViewBag.KetQua = "ERROR";
                    break;
            }
            return View("Index");
        }
    }
}