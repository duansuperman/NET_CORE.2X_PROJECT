#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35ab65d5f8114e44290692c6ddde7817a87731d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_SanPhamPartial), @"mvc.1.0.view", @"/Views/SanPham/SanPhamPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPham/SanPhamPartial.cshtml", typeof(AspNetCore.Views_SanPham_SanPhamPartial))]
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
#line 2 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPartial.cshtml"
using WebSiteBanHang.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ab65d5f8114e44290692c6ddde7817a87731d2", @"/Views/SanPham/SanPhamPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_SanPhamPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 21, true);
            WriteLiteral(" // khai bao cach 1\r\n");
            EndContext();
            BeginContext(135, 97, true);
            WriteLiteral("\r\n\r\n    <div class=\"content-top\">\r\n        <h1>NEW RELEASED</h1>\r\n        <div class=\"grid-in\">\r\n");
            EndContext();
#line 9 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPartial.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(289, 189, true);
            WriteLiteral("                <div class=\"col-md-4 grid-top\">\r\n                    <a href=\"single.html\" class=\"b-link-stripe b-animate-go  thickbox\">\r\n                        <img class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 478, "\"", 533, 1);
#line 13 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPartial.cshtml"
WriteAttributeValue("", 484, Url.Content("~/Content/HinhAnhSP/"+item.HinhAnh), 484, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(534, 176, true);
            WriteLiteral(" alt=\"#\">\r\n                        <div class=\"b-wrapper\">\r\n                            <h3 class=\"b-animate b-from-left    b-delay03 \">\r\n                                <span>");
            EndContext();
            BeginContext(711, 10, false);
#line 16 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPartial.cshtml"
                                 Write(item.TenSP);

#line default
#line hidden
            EndContext();
            BeginContext(721, 151, true);
            WriteLiteral("</span>\r\n                            </h3>\r\n                        </div>\r\n                    </a>\r\n\r\n\r\n                    <p><a href=\"single.html\">");
            EndContext();
            BeginContext(873, 12, false);
#line 22 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPartial.cshtml"
                                        Write(item.CauHinh);

#line default
#line hidden
            EndContext();
            BeginContext(885, 34, true);
            WriteLiteral("</a></p>\r\n                </div>\r\n");
            EndContext();
#line 24 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(934, 100, true);
            WriteLiteral("\r\n            <div class=\"clearfix\"> </div>\r\n        </div>\r\n      \r\n    </div>\r\n    <!----->\r\n\r\n   ");
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
