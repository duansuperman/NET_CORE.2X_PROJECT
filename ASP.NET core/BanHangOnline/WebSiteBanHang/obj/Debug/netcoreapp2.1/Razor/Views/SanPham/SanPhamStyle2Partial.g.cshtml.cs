#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3a976149622e08fe84e2fe0ad2b49de641ce9dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_SanPhamStyle2Partial), @"mvc.1.0.view", @"/Views/SanPham/SanPhamStyle2Partial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPham/SanPhamStyle2Partial.cshtml", typeof(AspNetCore.Views_SanPham_SanPhamStyle2Partial))]
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
#line 1 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
using WebSiteBanHang.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3a976149622e08fe84e2fe0ad2b49de641ce9dc", @"/Views/SanPham/SanPhamStyle2Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_SanPhamStyle2Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
   
    List<SanPham> list = Model.ToList();


#line default
#line hidden
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(192, 44, true);
            WriteLiteral("\r\n<div class=\"content-top-bottom\">\r\n    <h2>");
            EndContext();
            BeginContext(237, 27, false);
#line 11 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
   Write(list[0].LoaiSanPham.TenLoai);

#line default
#line hidden
            EndContext();
            BeginContext(264, 58, true);
            WriteLiteral(" mới nhất</h2>\r\n    <div class=\"col-md-6 men\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 322, "\"", 391, 1);
#line 13 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
WriteAttributeValue("", 329, Url.Action("ChiTietSanPham","SanPham",new { id=list[0].MaSP}), 329, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(392, 108, true);
            WriteLiteral(" class=\"b-link-stripe b-animate-go  thickbox\">\r\n            <img style=\"height:350px\" class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 500, "\"", 559, 1);
#line 14 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
WriteAttributeValue("", 506, Url.Content("~/Content/HinhAnhSP/"+ list[0].HinhAnh), 506, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(560, 179, true);
            WriteLiteral(" alt=\"\">\r\n            <div class=\"b-wrapper\">\r\n                <h3 class=\"b-animate b-from-top top-in   b-delay03 \" style=\"text-align: left;font-size:15pt;\">\r\n                    ");
            EndContext();
            BeginContext(740, 25, false);
#line 17 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
               Write(Html.Raw(list[0].CauHinh));

#line default
#line hidden
            EndContext();
            BeginContext(765, 69, true);
            WriteLiteral("\r\n                    <span style=\"text-align:center;font-size:25pt\">");
            EndContext();
            BeginContext(835, 37, false);
#line 18 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
                                                              Write(list[0].DonGia.Value.ToString("#,##"));

#line default
#line hidden
            EndContext();
            BeginContext(872, 160, true);
            WriteLiteral(" VNĐ</span>\r\n                </h3>\r\n            </div>\r\n        </a>\r\n\r\n\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div class=\"col-md1 \">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1032, "\"", 1101, 1);
#line 27 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
WriteAttributeValue("", 1039, Url.Action("ChiTietSanPham","SanPham",new { id=list[1].MaSP}), 1039, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1102, 112, true);
            WriteLiteral(" class=\"b-link-stripe b-animate-go  thickbox\">\r\n                <img style=\"height:150px\" class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1214, "\"", 1272, 1);
#line 28 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
WriteAttributeValue("", 1220, Url.Content("~/Content/HinhAnhSP/"+list[1].HinhAnh), 1220, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1273, 191, true);
            WriteLiteral(" alt=\"\">\r\n                <div class=\"b-wrapper\">\r\n                    <h3 style=\"text-align: left;font-size:15pt\" class=\"b-animate b-from-top top-in1   b-delay03 \">\r\n                        ");
            EndContext();
            BeginContext(1465, 25, false);
#line 31 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
                   Write(Html.Raw(list[1].CauHinh));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 181, true);
            WriteLiteral("\r\n\r\n                    </h3>\r\n                </div>\r\n            </a>\r\n\r\n        </div>\r\n        <div class=\"col-md2\">\r\n            <div class=\"col-md-6 men1\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1671, "\"", 1740, 1);
#line 40 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
WriteAttributeValue("", 1678, Url.Action("ChiTietSanPham","SanPham",new { id=list[2].MaSP}), 1678, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1741, 117, true);
            WriteLiteral(" class=\"b-link-stripe b-animate-go  thickbox\">\r\n                    <img  style=\"height:150px\" class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1858, "\"", 1916, 1);
#line 41 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
WriteAttributeValue("", 1864, Url.Content("~/Content/HinhAnhSP/"+list[2].HinhAnh), 1864, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1917, 163, true);
            WriteLiteral(" alt=\"\">\r\n                    <div class=\"b-wrapper\">\r\n                        <h3  class=\"b-animate b-from-top top-in2   b-delay03 \">\r\n                           ");
            EndContext();
            BeginContext(2081, 25, false);
#line 44 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
                      Write(Html.Raw(list[2].CauHinh));

#line default
#line hidden
            EndContext();
            BeginContext(2106, 164, true);
            WriteLiteral("\r\n                        </h3>\r\n                    </div>\r\n                </a>\r\n\r\n            </div>\r\n            <div class=\"col-md-6 men2\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2270, "\"", 2339, 1);
#line 51 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
WriteAttributeValue("", 2277, Url.Action("ChiTietSanPham","SanPham",new { id=list[3].MaSP}), 2277, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2340, 116, true);
            WriteLiteral(" class=\"b-link-stripe b-animate-go  thickbox\">\r\n                    <img style=\"height:150px\" class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2456, "\"", 2514, 1);
#line 52 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
WriteAttributeValue("", 2462, Url.Content("~/Content/HinhAnhSP/"+list[3].HinhAnh), 2462, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2515, 166, true);
            WriteLiteral(" alt=\"\">\r\n                    <div class=\"b-wrapper\">\r\n                        <h3    class=\"b-animate b-from-top top-in2   b-delay03 \">\r\n                            ");
            EndContext();
            BeginContext(2682, 25, false);
#line 55 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamStyle2Partial.cshtml"
                       Write(Html.Raw(list[3].CauHinh));

#line default
#line hidden
            EndContext();
            BeginContext(2707, 219, true);
            WriteLiteral("\r\n                        </h3>\r\n                    </div>\r\n                </a>\r\n\r\n            </div>\r\n            <div class=\"clearfix\"> </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"clearfix\"> </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
