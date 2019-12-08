using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSiteBanHang.Models
{
    
    public partial class ThanhVien
    {
        internal sealed class ThanhVienMetadata
        {
            public int MaThanhVien { get; set; }

            [Display(Name = "Tài khoản")]
            [Required(ErrorMessage = "{0} không được để trống")]
            public string TaiKhoan { get; set; }

            [Display(Name = "Mật khẩu")]
            [Required(ErrorMessage = "{0} không được để trống")]
            public string MatKhau { get; set; }

            [Display(Name = "Họ tên")]
            [Required(ErrorMessage = "{0} không được để trống")]
            public string HoTen { get; set; }

            [Display(Name = "Đại chỉ")]
            [Required(ErrorMessage = "{0} không được để trống")]
            public string DiaChi { get; set; }

            [Display(Name = "Email")]
            [Required(ErrorMessage = "{0} không được để trống")]
            [EmailAddress(ErrorMessage = "{0} không hợp lệ")]
            public string Email { get; set; }

            [Display(Name = "Số điện thoại")]
            [Required(ErrorMessage = "{0} không được để trống")]
            public string SoDienThoai { get; set; }

            public string CauHoi { get; set; }

            [Display(Name = "Câu trả lời")]
            [Required(ErrorMessage = "{0} không được để trống")]
            public string CauTraLoi { get; set; }
            public Nullable<int> MaLoaiTV { get; set; }
            //public Nullable<bool> Xoa { get; set; }
        }
    }
}