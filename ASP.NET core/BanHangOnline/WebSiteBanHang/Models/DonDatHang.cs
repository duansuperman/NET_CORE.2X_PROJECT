using System;
using System.Collections.Generic;

namespace WebSiteBanHang.Models
{
    public partial class DonDatHang
    {
        public DonDatHang()
        {
            ChiTietDonDatHang = new HashSet<ChiTietDonDatHang>();
        }

        public int MaDdh { get; set; }
        public DateTime? NgayDat { get; set; }
        public bool? TinhTrangGiaoHang { get; set; }
        public DateTime? NgayGiao { get; set; }
        public bool? DaThanhToan { get; set; }
        public int? MaKh { get; set; }
        public int? UuDai { get; set; }
        public bool? DaHuy { get; set; }
        public bool? DaXoa { get; set; }

        public KhachHang MaKhNavigation { get; set; }
        public ICollection<ChiTietDonDatHang> ChiTietDonDatHang { get; set; }
    }
}
