#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9375c3a462aada14abd23f619e3a1a2ed7cd90c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLySanPham_SanPhamGanHetHang), @"mvc.1.0.view", @"/Views/QuanLySanPham/SanPhamGanHetHang.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QuanLySanPham/SanPhamGanHetHang.cshtml", typeof(AspNetCore.Views_QuanLySanPham_SanPhamGanHetHang))]
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
#line 1 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
using WebSiteBanHang.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
using PagedList.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9375c3a462aada14abd23f619e3a1a2ed7cd90c", @"/Views/QuanLySanPham/SanPhamGanHetHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLySanPham_SanPhamGanHetHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<SanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
  
    ViewBag.Title = "SanPhamGanHetHang";
    Layout = "~/Views/Layout/AdminLayout.cshtml";

#line default
#line hidden
#line 9 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
  
    ThanhVienTB check = ViewBag.tv as ThanhVienTB;
    string kt = Session["update"] as string;
    if (kt == "1")
    {

        Session["update"] = "0";
    }

#line default
#line hidden
            BeginContext(369, 468, true);
            WriteLiteral(@"<div class=""w3l_agileits_breadcrumbs"">
    <div class=""w3l_agileits_breadcrumbs_inner"">
        <ul>
            <li><a href=""main-page.html"">Home</a><span>«</span></li>

            <li>Quản lý sản phẩm</li>
        </ul>
    </div>
</div>
<div class=""inner_content_w3_agile_info two_in"">
    <h2 class=""w3_inner_tittle"">Quản lý sản phẩm</h2>
    <!-- tables -->

    <div class=""agile-tables"">

        <div class=""w3l-table-info agile_info_shadow"">
");
            EndContext();
#line 34 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
             if (kt == "1")
            {

#line default
#line hidden
            BeginContext(881, 84, true);
            WriteLiteral("                <h3 class=\"w3_inner_tittle two\">Cập nhật sản phẩm thành công </h3>\r\n");
            EndContext();
#line 37 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1013, 83, true);
            WriteLiteral("                <h3 class=\"w3_inner_tittle two\">Cập nhật thông tin sản phẩm </h3>\r\n");
            EndContext();
#line 41 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
            }

#line default
#line hidden
            BeginContext(1111, 48, true);
            WriteLiteral("\r\n            <h3 class=\"w3_inner_tittle two\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1159, "\"", 1204, 1);
#line 43 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
WriteAttributeValue("", 1166, Url.Action("ThemMoi","QuanLySanPham"), 1166, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1205, 616, true);
            WriteLiteral(@"><u>Thêm sản phẩm mới</u></a> </h3>
            <table id=""table-no-resize"">
                <thead>
                    <tr>
                        <th>Mã SP</th>
                        <th>Tên sản phẩm</th>
                        <th>Hình ảnh</th>
                        <th>Loại sản phẩm</th>
                        <th>Nhà sản xuất</th>
                        <th>Nhà cung cấp </th>
                        <th>Số lượng tồn</th>
                        <th>Trạng thái</th>
                        <th>Thao tác</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 59 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1894, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1957, 9, false);
#line 62 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                           Write(item.MaSP);

#line default
#line hidden
            EndContext();
            BeginContext(1966, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2006, 10, false);
#line 63 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                           Write(item.TenSP);

#line default
#line hidden
            EndContext();
            BeginContext(2016, 43, true);
            WriteLiteral("</td>\r\n                            <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2059, "\"", 2114, 1);
#line 64 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
WriteAttributeValue("", 2065, Url.Content("~/Content/HinhAnhSP/"+item.HinhAnh), 2065, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2115, 75, true);
            WriteLiteral(" style=\"width:100px;height:100px\" /></td>\r\n                            <td>");
            EndContext();
            BeginContext(2191, 54, false);
#line 65 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                           Write(Html.DisplayFor(modelitem => item.LoaiSanPham.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(2245, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2285, 52, false);
#line 66 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                           Write(Html.DisplayFor(modelitem => item.NhaSanXuat.TenNSX));

#line default
#line hidden
            EndContext();
            BeginContext(2337, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2377, 52, false);
#line 67 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                           Write(Html.DisplayFor(modelitem => item.NhaCungCap.TenNCC));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2469, 15, false);
#line 68 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                           Write(item.SoLuongTon);

#line default
#line hidden
            EndContext();
            BeginContext(2484, 9, true);
            WriteLiteral(" <br /><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2493, "\"", 2546, 1);
#line 68 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
WriteAttributeValue("", 2500, Url.Action("ThemPhieuNhap","QuanLyPhieuNhap"), 2500, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2547, 28, true);
            WriteLiteral("><u>Nhập hàng</u></a></td>\r\n");
            EndContext();
#line 69 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                             if (item.DaXoa == false)
                            {

#line default
#line hidden
            BeginContext(2661, 55, true);
            WriteLiteral("                                <td>Đã kích hoạt</td>\r\n");
            EndContext();
#line 72 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2812, 57, true);
            WriteLiteral("                                <td>Chưa kích hoạt</td>\r\n");
            EndContext();
#line 76 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                            }

#line default
#line hidden
            BeginContext(2900, 34, true);
            WriteLiteral("                            <td>\r\n");
            EndContext();
#line 78 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                                 if (check.MaLoaiTV == 1)
                                {

#line default
#line hidden
            BeginContext(3028, 81, true);
            WriteLiteral("                                    <a title=\"Xoá vĩnh viễn\" onclick=\"Xoa(event)\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3109, "\"", 3173, 1);
#line 80 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
WriteAttributeValue("", 3116, Url.Action("Xoa","QuanLySanPham",new { @MaSP=item.MaSP}), 3116, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3174, 140, true);
            WriteLiteral(" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-remove\" style=\"background-color:orangered\">\r\n\r\n                                    </a>\r\n");
            EndContext();
#line 83 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                                }

#line default
#line hidden
            BeginContext(3349, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 84 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                                 if (item.DaXoa == false)
                                {

#line default
#line hidden
            BeginContext(3443, 58, true);
            WriteLiteral("                                    <a title=\"Vô hiệu hóa\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3501, "\"", 3571, 1);
#line 86 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
WriteAttributeValue("", 3508, Url.Action("VoHieuHoa","QuanLySanPham",new { @MaSP=item.MaSP}), 3508, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3572, "\"", 3587, 1);
#line 86 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
WriteAttributeValue("", 3577, item.MaSP, 3577, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3588, 155, true);
            WriteLiteral(" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-unlock\">\r\n\r\n                                    </a>\r\n                                    <a title=\"Sửa\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3743, "\"", 3807, 1);
#line 89 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
WriteAttributeValue("", 3750, Url.Action("Sua","QuanLySanPham",new { @MaSP=item.MaSP}), 3750, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3808, 103, true);
            WriteLiteral(" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-edit\">\r\n\r\n                                    </a>\r\n");
            EndContext();
            BeginContext(3913, 55, true);
            WriteLiteral("                                    <a title=\"Chi tiết\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3968, "\"", 4034, 1);
#line 93 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
WriteAttributeValue("", 3975, Url.Action("ChiTietSanPham","SanPham",new { id=item.MaSP}), 3975, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4035, 127, true);
            WriteLiteral(" target=\"_blank\" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-product-hunt\">\r\n\r\n                                    </a>\r\n");
            EndContext();
#line 96 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4270, 66, true);
            WriteLiteral("                                    <a title=\"Kích hoạt tài khoản\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4336, "\"", 4405, 1);
#line 99 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
WriteAttributeValue("", 4343, Url.Action("KichHoat","QuanLySanPham",new { @MaSP=item.MaSP}), 4343, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4406, "\"", 4421, 1);
#line 99 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
WriteAttributeValue("", 4411, item.MaSP, 4411, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4422, 103, true);
            WriteLiteral(" class=\"btn btn-info btn-flat btn-pri btn-sm fa fa-lock\">\r\n\r\n                                    </a>\r\n");
            EndContext();
#line 102 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                                }

#line default
#line hidden
            BeginContext(4560, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 106 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                    }

#line default
#line hidden
            BeginContext(4651, 157, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"pagination col-md-9\" style=\"float:right\">\r\n        Trang ");
            EndContext();
            BeginContext(4810, 57, false);
#line 116 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
          Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4868, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(4870, 15, false);
#line 116 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
                                                                      Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(4885, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(4896, 76, false);
#line 117 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLySanPham\SanPhamGanHetHang.cshtml"
   Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page = page })));

#line default
#line hidden
            EndContext();
            BeginContext(4972, 370, true);
            WriteLiteral(@"
    </div>
    <div class=""clearfix""></div>

    <!-- //tables -->
    <!-- /social_media-->
    <!-- //social_media-->
</div>
<script type=""text/javascript"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
