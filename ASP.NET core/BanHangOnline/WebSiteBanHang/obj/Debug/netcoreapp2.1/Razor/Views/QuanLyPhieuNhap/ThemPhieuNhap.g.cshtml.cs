#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyPhieuNhap\ThemPhieuNhap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7963f577329a8c55ebaebc30ac6ede80fcc7e53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLyPhieuNhap_ThemPhieuNhap), @"mvc.1.0.view", @"/Views/QuanLyPhieuNhap/ThemPhieuNhap.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QuanLyPhieuNhap/ThemPhieuNhap.cshtml", typeof(AspNetCore.Views_QuanLyPhieuNhap_ThemPhieuNhap))]
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
#line 2 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\_ViewImports.cshtml"
using WebSiteBanHang.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7963f577329a8c55ebaebc30ac6ede80fcc7e53", @"/Views/QuanLyPhieuNhap/ThemPhieuNhap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLyPhieuNhap_ThemPhieuNhap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyPhieuNhap\ThemPhieuNhap.cshtml"
  
    ViewBag.Title = "ThemPhiepNhap";
    Layout = "~/Views/Layout/AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(98, 781, true);
            WriteLiteral(@"

<div class=""w3l_agileits_breadcrumbs"">
    <div class=""w3l_agileits_breadcrumbs_inner"">
        <ul>
            <li><a href=""main-page.html"">Trang chủ</a><span>«</span></li>

            <li>Quản lý Phiếu Nhập</li>
        </ul>
    </div>
</div>

<div class=""inner_content_w3_agile_info two_in"">
    <h2 class=""w3_inner_tittle"">Phiếu nhập</h2>

    <!--/forms-->
    <div class=""forms-main_agileits"">


        <!--/forms-inner-->
        <div class=""forms-inner"">
            <div class=""set-1_w3ls"">

                <div class=""col-md-12 button_set_one agile_info_shadow graph-form"">
                    <h3 class=""w3_inner_tittle two"">Nhập phiếu nhập </h3>
                    <div class=""grid-1"">
                        <div class=""form-body"">
");
            EndContext();
#line 33 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyPhieuNhap\ThemPhieuNhap.cshtml"
                             using (Html.BeginForm("ThemPhieuNhap","QuanLyPhieuNhap",new { @class = "form-horizontal" }))
                            {

#line default
#line hidden
            BeginContext(1033, 265, true);
            WriteLiteral(@"                                <div class=""form-group"">
                                    <label for=""inputEmail3"" class=""col-sm-2 "">Chọn nhà cung cấp</label>
                                    <div class=""col-sm-10"">
                                        ");
            EndContext();
            BeginContext(1299, 61, false);
#line 38 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyPhieuNhap\ThemPhieuNhap.cshtml"
                                   Write(Html.DropDownList("MaNCC", null, new { @class = "col-sm-6" }));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 903, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""form-group"" style=""padding-top:50px"">
                                    <table class=""table"" id=""TableChiTiet"">
                                        <tr>
                                            <th style=""text-align:center"">Tên sản phẩm</th>
                                            <th style=""text-align:center"">Số lượng </th>
                                            <th style=""text-align:center"">Đơn giá</th>
                                            <th style=""text-align:center"">Thao tác</th>
                                        </tr>
                                        <tr style=""display:none"" id=""RowMau"" >
                                            <td style=""text-align:center"">
                                                ");
            EndContext();
            BeginContext(2264, 51, false);
#line 51 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyPhieuNhap\ThemPhieuNhap.cshtml"
                                           Write(Html.DropDownList("MaSP",null,new { @class="MaSP"}));

#line default
#line hidden
            EndContext();
            BeginContext(2315, 1022, true);
            WriteLiteral(@"
                                            </td>
                                            <td style=""text-align:center"" >
                                                <input type=""number"" class=""SoLuong"" min=""0"" value=""0"" />
                                            </td>

                                            <td style=""text-align:center"" >
                                                <input type=""number"" class=""DonGia"" min=""0"" value=""0""/>
                                            </td>
                                            <td style=""text-align:center"">
                                                <button title=""Xóa""   class=""btn btn-info btn-flat btn-pri btn-sm fa fa-remove "" id=""btnXoa"" style=""background-color:orangered"">

                                                </button>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
");
            EndContext();
            BeginContext(3339, 446, true);
            WriteLiteral(@"                                <div class=""col-md-10"" style=""padding-top:10px"">
                                    <button type=""button""  class=""btn btn-success btn-flat btn-pri btn-md "" id=""btnThem"" style=""width:100px"">
                                        <i class=""fa fa-plus"" aria-hidden=""true"">
                                        </i> Thêm
                                    </button>
                                </div>
");
            EndContext();
            BeginContext(3787, 223, true);
            WriteLiteral("                                <div class=\" col-md-2\" style=\"padding-top:10px\">\r\n                                    <button type=\"submit\" class=\"btn btn-default\">Nhập vào</button>\r\n                                </div>\r\n");
            EndContext();
#line 79 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\QuanLyPhieuNhap\ThemPhieuNhap.cshtml"

                            }

#line default
#line hidden
            BeginContext(4043, 1831, true);
            WriteLiteral(@"                        </div>

                    </div>
                </div>

                <div class=""clearfix""> </div>
            </div>
        </div>
        <!--//forms-inner-->
    </div>

</div>

<script type=""text/javascript"">
    var id = 0;
    $(""#btnThem"").click(function () {
        
        Them();
        id = id + 1;
    });
    
    $(""body"").delegate(""#btnXoa"", ""click"", function () {
        $(this).closest(""tr"").remove();
        CapNhatLai();
    });
    //thêm 1 row chi tiết phiếu nhập
    function Them() {
        
        var noidung = $(""#TableChiTiet"").find(""#RowMau"").html();
        noidung=""<tr class=\""trRow\"">""+noidung+""</tr>""
        $(""#TableChiTiet"").append(noidung);
        //$(""#TableChiTiet"").find(""tr:last"");
      
        CapNhatName();
        
    };
    //cập nhật name cho thẻ input
    function CapNhatName() {
        var masp = ""["" + id + ""].MaSP"";
        var dongia = ""["" + id + ""].DonGiaNhap"";
        var soluong = ""[""");
            WriteLiteral(@" + id + ""].SoLuongNhap"";
        $(""#TableChiTiet"").find(""tr:last-child"").find("".MaSP"").attr(""name"", masp);
        $(""#TableChiTiet"").find(""tr:last-child"").find("".SoLuong"").attr(""name"", soluong);
        $(""#TableChiTiet"").find(""tr:last-child"").find("".DonGia"").attr(""name"", dongia);
        
    }
    //cập nhật thuộc tính sau khi xóa
    function CapNhatLai() {
        id = 0;
        $("".trRow"").each(function (){
            var masp = ""["" + id + ""].MaSP"";
            var dongia = ""["" + id + ""].DonGiaNhap"";
            var soluong = ""["" + id + ""].SoLuongNhap"";
            $(this).find("".MaSP"").attr(""name"", masp);
            $(this).find("".SoLuong"").attr(""name"", soluong);
            $(this).find("".DonGia"").attr(""name"", dongia);
            id++;
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
