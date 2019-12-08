using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteBanHang.Models
{
    public class ThongKeDoanhThu
    {
        public int Thang { get; set; }
        public double DoanhThu { get; set; }
        public ThongKeDoanhThu()
        {
            Thang = 0;
            DoanhThu = 0;
        }

    }
}