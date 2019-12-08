using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Models
{
    public partial class LoaiThanhVien
    {
        public LoaiThanhVien()
        {
            LoaiThanhVienQuyen = new HashSet<LoaiThanhVienQuyen>();
            ThanhVienTb = new HashSet<ThanhVienTb>();
        }

        public int MaLoaiTv { get; set; }
        public string TenLoai { get; set; }
        public int? UuDai { get; set; }

        public ICollection<LoaiThanhVienQuyen> LoaiThanhVienQuyen { get; set; }
        public ICollection<ThanhVienTb> ThanhVienTb { get; set; }
    }
}
