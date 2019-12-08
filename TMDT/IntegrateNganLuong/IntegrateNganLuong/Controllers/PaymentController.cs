using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrateNganLuong.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegrateNganLuong.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExecutePayment(string buyer_fullname,string buyer_email,
            string buyer_mobile,string option_payment,string bankcode)
        {
            string payment_method = option_payment;
            string str_bankcode = bankcode;


            RequestInfo info = new RequestInfo();
            info.Merchant_id = "48246";
            info.Merchant_password = "f50caee66338f38d87988530fbb85a79";
            info.Receiver_email = "duansupper@gmail.com";



            info.cur_code = "vnd";
            info.bank_code = str_bankcode;

            info.Order_code = "ma_don_hang01";
            info.Total_amount = "10000";
            info.fee_shipping = "0";
            info.Discount_amount = "0";
            info.order_description = "Thanh toan test thu dong hang";
            info.return_url = "http://localhost";
            info.cancel_url = "http://localhost";

            info.Buyer_fullname = buyer_fullname;
            info.Buyer_email = buyer_email;
            info.Buyer_mobile = buyer_mobile;

            APICheckoutV3 objNLChecout = new APICheckoutV3();
            ResponseInfo result = objNLChecout.GetUrlCheckout(info, payment_method);

            if (result.Error_code == "00")
            {
                return Redirect(result.Checkout_url);
                //Response.Redirect(result.Checkout_url);
            }
            else
                return View();
               // txtserverkt.InnerHtml = result.Description;
            
        }
    }
}