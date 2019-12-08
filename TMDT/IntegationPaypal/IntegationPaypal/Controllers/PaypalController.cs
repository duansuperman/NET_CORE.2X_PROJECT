﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BraintreeHttp;
using Microsoft.AspNetCore.Mvc;
using PayPal.Core;
using PayPal.v1.Payments;

namespace IntegationPaypal.Controllers
{
    public class PaypalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Checkout()
        {
            //SandboxEnvironment(clientId, clientSerect)
            var environment = new SandboxEnvironment("AQ4CrSrqt4JgVnf2MGGIaOC0dlzOSG_jPoSzsdsGLDJkx_PLmHBtFr3cmoG49VMMY5nz69C9aZHluh1F",
                "EJ32c1nN2pFrPdoUs3hQiEIuBepmt2ir5PFcIY7wuQiz2KnCLpp6lXZmAm3VuaD-8gnG2ziZurqyNtoB");
            var client = new PayPalHttpClient(environment);

            //Đọc thông tin đơn hàng từ Session
            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };

            var tongTien = 11;
            //foreach (var item in Cart)
            //{
            //    itemList.Items.Add(new Item()
            //    {
            //        Name = item.HangHoa.TenHh,
            //        Currency = "USD",
            //        Price = item.HangHoa.GiaBan.ToString(),
            //        Quantity = item.SoLuong.ToString(),
            //        Sku = "sku",
            //        Tax = "0"
            //    });
            //}

            itemList.Items.Add(new Item()
            {
                Name = "Coca",
                Currency = "USD",
                Price = "5",
                Quantity = "1",
                Sku = "sku",
                Tax = "0"
            });
            itemList.Items.Add(new Item()
            {
                Name = "Pepsi",
                Currency = "USD",
                Price = "2",
                Quantity = "3",
                Sku = "sku",
                Tax = "0"
            });

            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = tongTien.ToString(),
                            Currency = "USD",
                            Details = new AmountDetails
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = tongTien.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = "Don hang 001",
                        InvoiceNumber = DateTime.Now.Ticks.ToString()
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "http://localhost:44366/Paypal/Fail",
                    ReturnUrl = "http://localhost:44366/Paypal/Success"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }

                return Redirect(paypalRedirectUrl);

            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                return RedirectToAction("Fail");
            }
        }

        public IActionResult Success()
        {
            //Tạo đơn hàng trong CSDL với trạng thái : Đã thanh toán, phương thức: Paypal
            return Content("Thanh toán thành công");
        }

        public IActionResult Fail()
        {
            //Tạo đơn hàng trong CSDL với trạng thái : Chưa thanh toán, phương thức: 
            return Content("Thanh toán thất bại");
        }
    }
    
}