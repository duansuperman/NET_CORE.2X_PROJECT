#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c8e436f0c3a7268c238285e1f7239b5c1236db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLyDonHang_Index), @"mvc.1.0.view", @"/Views/QuanLyDonHang/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QuanLyDonHang/Index.cshtml", typeof(AspNetCore.Views_QuanLyDonHang_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\_ViewImports.cshtml"
using WebSiteBanHang;

#line default
#line hidden
#line 1 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
using WebSiteBanHang.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c8e436f0c3a7268c238285e1f7239b5c1236db", @"/Views/QuanLyDonHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLyDonHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<DonDatHang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
  
    /**/

    ViewBag.Title = "Index";
    Layout = "~/Views/Layout/AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(195, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
  
    QuanLyBanHangEntities db = new QuanLyBanHangEntities();
    ThanhVienTB check = Session["TaiKhoan"] as ThanhVienTB;
    int checkmail = 0;
    if (Session["SendMail"] != null)
    {
        string t = Session["SendMail"] as string;
        checkmail = int.Parse(t);
        Session["SendMail"] = null;
    }
    int maddh = 0;
    if (Session["MaDDH"] != null)
    {
        string t = Session["MaDDH"] as string;
        maddh = int.Parse(t);
        Session["MaDDH"] = null;
    }

#line default
#line hidden
            BeginContext(707, 1319, true);
            WriteLiteral(@"<!-- /inner_content_w3_agile_info-->
<!-- breadcrumbs -->
<div class=""w3l_agileits_breadcrumbs"">
    <div class=""w3l_agileits_breadcrumbs_inner"">
        <ul>
            <li><a href=""main-page.html"">Home</a><span>«</span></li>

            <li>Đơn đặt hàng</li>
        </ul>
    </div>
</div>
<!-- //breadcrumbs -->

<div class=""inner_content_w3_agile_info two_in"">
    <h2 class=""w3_inner_tittle"">Đơn đặt hàng</h2>
    <!-- tables -->

    <div class=""agile-tables"">
        <div class=""w3l-table-info agile_info_shadow"">
            <h3 class=""w3_inner_tittle two"">Thống kê</h3>
            <table id=""table"">
                <thead>
                    <tr>
                        <th>Mã DDH</th>
                        <th>Tên khách hàng</th>
                        <th>Loại khách hàng</th>
                        <th>Ngày đặt</th>
                        <th>Trình trạng giao</th>
                        <th>Ngày giao</th>

                        <th>Đã thanh toán</th>
          ");
            WriteLiteral(@"              <th>Trạng thái</th>
                        <th>Giá trị DH</th>
                        <th>KM(%)</th>
                        <th>Tổng tiền (VNĐ)</th>
                        <th>Thao tác</th>

                    </tr>
                </thead>
                <tbody>

");
            EndContext();
#line 70 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                     foreach (var item in Model)
                    {

                        var kh = db.KhachHangs.SingleOrDefault(s => s.MaKH == item.MaKH);
                        var tv = db.ThanhVienTBs.SingleOrDefault(s => s.MaThanhVien == kh.MaThanhVien);
                        int GiaTri = (int)db.ChiTietDonDatHangs.Where(w => w.MaDDH == item.MaDDH).Sum(s => s.SoLuong * s.DonGia);

                        double TongTien = (double)(1 - item.UuDai * 1.0 / 100) * GiaTri;


#line default
#line hidden
            BeginContext(2522, 64, true);
            WriteLiteral("                        <tr>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(2587, 10, false);
#line 81 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                           Write(item.MaDDH);

#line default
#line hidden
            EndContext();
            BeginContext(2597, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2637, 8, false);
#line 82 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                           Write(kh.TenKH);

#line default
#line hidden
            EndContext();
            BeginContext(2645, 45, true);
            WriteLiteral("\r\n                                <br />sđt: ");
            EndContext();
            BeginContext(2691, 14, false);
#line 83 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                                      Write(kh.SoDienThoai);

#line default
#line hidden
            EndContext();
            BeginContext(2705, 39, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n");
            EndContext();
#line 86 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                             if (tv == null)
                            {

#line default
#line hidden
            BeginContext(2821, 51, true);
            WriteLiteral("                                <td>Vãng lai</td>\r\n");
            EndContext();
#line 89 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2968, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(3005, 50, false);
#line 92 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                               Write(Html.DisplayFor(model => tv.LoaiThanhVien.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(3055, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 93 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3093, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3126, 12, false);
#line 94 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                           Write(item.NgayDat);

#line default
#line hidden
            EndContext();
            BeginContext(3138, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 95 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                             if (item.TinhTrangGiaoHang == false)
                            {

#line default
#line hidden
            BeginContext(3243, 52, true);
            WriteLiteral("                                <td>Chưa giao</td>\r\n");
            EndContext();
#line 98 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3391, 50, true);
            WriteLiteral("                                <td>Đã giao</td>\r\n");
            EndContext();
#line 102 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3472, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3505, 13, false);
#line 103 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                           Write(item.NgayGiao);

#line default
#line hidden
            EndContext();
            BeginContext(3518, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 104 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                             if (item.DaThanhToan == false)
                            {

#line default
#line hidden
            BeginContext(3617, 136, true);
            WriteLiteral("                                <td>\r\n                                    <p>Chưa thanh toán</p>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3753, "\"", 3832, 1);
#line 108 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
WriteAttributeValue("", 3760, Url.Action("ThanhToanDH", "QuanLyDonHang", new { @MaDDH = item.MaDDH }), 3760, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3833, 74, true);
            WriteLiteral("><u>Kích hoạt thanh toán </u></a>\r\n                                </td>\r\n");
            EndContext();
#line 110 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4005, 134, true);
            WriteLiteral("                                <td>\r\n                                    <p>Đã thanh toán</p>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4139, "\"", 4221, 1);
#line 116 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
WriteAttributeValue("", 4146, Url.Action("HuyThanhToanDH", "QuanLyDonHang", new { @MaDDH = item.MaDDH }), 4146, 75, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4222, 77, true);
            WriteLiteral("><u>Hủy kích hoạt thanh toán</u></a>\r\n                                </td>\r\n");
            EndContext();
#line 118 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4330, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 119 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                             if (item.DaHuy == false)
                            {

#line default
#line hidden
            BeginContext(4416, 52, true);
            WriteLiteral("                                <td>Kích hoạt</td>\r\n");
            EndContext();
#line 122 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4564, 54, true);
            WriteLiteral("                                <td>Vô hiệu hóa</td>\r\n");
            EndContext();
#line 126 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4649, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(4682, 23, false);
#line 127 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                           Write(GiaTri.ToString("#,##"));

#line default
#line hidden
            EndContext();
            BeginContext(4705, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4745, 10, false);
#line 128 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                           Write(item.UuDai);

#line default
#line hidden
            EndContext();
            BeginContext(4755, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4795, 25, false);
#line 129 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                           Write(TongTien.ToString("#,##"));

#line default
#line hidden
            EndContext();
            BeginContext(4820, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 131 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                                 if (check.MaLoaiTV == 1)
                                {

#line default
#line hidden
            BeginContext(4955, 81, true);
            WriteLiteral("                                    <a title=\"Xoá vĩnh viễn\" onclick=\"Xoa(event)\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5036, "\"", 5104, 1);
#line 133 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
WriteAttributeValue("", 5043, Url.Action("XoaDH","QuanLyDonHang",new { @MaDDH=item.MaDDH}), 5043, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5105, 140, true);
            WriteLiteral(" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-remove\" style=\"background-color:orangered\">\r\n\r\n                                    </a>\r\n");
            EndContext();
#line 136 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5280, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 137 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                                 if (item.DaHuy == false)
                                {

#line default
#line hidden
            BeginContext(5374, 58, true);
            WriteLiteral("                                    <a title=\"Vô hiệu hóa\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5432, "\"", 5511, 1);
#line 139 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
WriteAttributeValue("", 5439, Url.Action("VoHieuHoaDH", "QuanLyDonHang", new { @MaDDH = item.MaDDH }), 5439, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5512, 105, true);
            WriteLiteral(" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-unlock\">\r\n\r\n                                    </a>\r\n");
            EndContext();
#line 142 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                                    if (item.TinhTrangGiaoHang == false)
                                    {

#line default
#line hidden
            BeginContext(5730, 65, true);
            WriteLiteral("                                        <a title=\"Duyệt đơn hàng\"");
            EndContext();
            BeginWriteAttribute("href", "  href=\"", 5795, "\"", 5871, 1);
#line 144 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
WriteAttributeValue("", 5803, Url.Action("DuyetDH", "QuanLyDonHang", new { @MaDDH = item.MaDDH }), 5803, 68, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5872, 147, true);
            WriteLiteral(" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-check-circle-o\" style=\"background-color:gold\">\r\n\r\n                                        </a>\r\n");
            EndContext();
#line 147 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(6139, 69, true);
            WriteLiteral("                                        <a title=\"Hủy duyệt đơn hàng\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6208, "\"", 6286, 1);
#line 150 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
WriteAttributeValue("", 6215, Url.Action("HuyDuyetDH", "QuanLyDonHang", new { @MaDDH = item.MaDDH }), 6215, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6287, 152, true);
            WriteLiteral(" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-check-circle-o\" style=\"background-color:lawngreen\">\r\n\r\n                                        </a>\r\n");
            EndContext();
#line 153 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(6478, 63, true);
            WriteLiteral("                                    <a title=\"Xem chi tiết DH \"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6541, "\"", 6618, 1);
#line 154 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
WriteAttributeValue("", 6548, Url.Action("ChiTietDH", "QuanLyDonHang", new { @MaDDH = item.MaDDH }), 6548, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6619, 99, true);
            WriteLiteral(" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-book\">\r\n\r\n                                </a>\r\n");
            EndContext();
#line 157 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(6826, 56, true);
            WriteLiteral("                                    <a title=\"Kích hoạt\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6882, "\"", 6960, 1);
#line 160 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
WriteAttributeValue("", 6889, Url.Action("KichHoatDH", "QuanLyDonHang", new { @MaDDH = item.MaDDH }), 6889, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6961, 103, true);
            WriteLiteral(" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-lock\">\r\n\r\n                                    </a>\r\n");
            EndContext();
#line 163 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(7099, 104, true);
            WriteLiteral("                                \r\n\r\n                            </td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 169 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(7226, 159, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"pagination col-md-9\" style=\"float:right\">\r\n        Trang ");
            EndContext();
            BeginContext(7387, 57, false);
#line 180 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
          Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(7445, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(7447, 15, false);
#line 180 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                                                                      Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(7462, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(7473, 76, false);
#line 181 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
   Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page = page })));

#line default
#line hidden
            EndContext();
            BeginContext(7549, 163, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"clearfix\"></div>\r\n</div>\r\n<!-- //inner_content_w3_agile_info-->\r\n<script type=\"text/javascript\">\r\n    var dem = 0;\r\n    var ktmail = ");
            EndContext();
            BeginContext(7713, 9, false);
#line 188 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
            Write(checkmail);

#line default
#line hidden
            EndContext();
            BeginContext(7722, 44, true);
            WriteLiteral(";\r\n    \r\n    var thongbao = \'Mã đơn hàng: \'+");
            EndContext();
            BeginContext(7767, 5, false);
#line 190 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyDonHang\Index.cshtml"
                              Write(maddh);

#line default
#line hidden
            EndContext();
            BeginContext(7772, 395, true);
            WriteLiteral(@";
    if (ktmail == 1) {
        alert(thongbao + ' gửi mail đặt hàng thành công')
    }
    if (ktmail == -1) {
        alert(thongbao + ' gửi mail đặt hàng không thành công')
    }
    function Xoa(event) {
        if (confirm('Bạn chắc chắn xóa sản phẩm?') == false) {
            event.preventDefault();
            event.stopPropagation();
        }

    }
    
</script>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<DonDatHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
