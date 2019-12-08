using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models
{
    public partial class LoaiThanhVienQuyen
    {
        public int MaLoaiTv { get; set; }
        public string MaQuyen { get; set; }
        public string GhiChu { get; set; }

        public LoaiThanhVien MaLoaiTvNavigation { get; set; }
        public Quyen MaQuyenNavigation { get; set; }
    }
}
