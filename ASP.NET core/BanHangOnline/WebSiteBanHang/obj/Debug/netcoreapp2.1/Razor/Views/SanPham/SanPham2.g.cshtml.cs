#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPham2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a25f51032f4942b5341e6ef5f9f1d0849d017819"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_SanPham2), @"mvc.1.0.view", @"/Views/SanPham/SanPham2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPham/SanPham2.cshtml", typeof(AspNetCore.Views_SanPham_SanPham2))]
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
#line 1 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPham2.cshtml"
using WebSiteBanHang.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a25f51032f4942b5341e6ef5f9f1d0849d017819", @"/Views/SanPham/SanPham2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_SanPham2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPham2.cshtml"
   
    IEnumerable<SanPham> ListSP = (IEnumerable<SanPham>)ViewBag.ListSP;
    IEnumerable<SanPham> ListSPNew = (IEnumerable<SanPham>)ViewBag.ListSPNew;

#line default
#line hidden
#line 6 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPham2.cshtml"
  
    ViewBag.Title = "SanPham2";
    Layout = "~/Views/Layout/HomeLayout.cshtml";

#line default
#line hidden
            BeginContext(281, 21, true);
            WriteLiteral("\r\n<h2>SanPham2</h2>\r\n");
            EndContext();
            BeginContext(314, 29, true);
            WriteLiteral("<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(344, 38, false);
#line 14 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPham2.cshtml"
Write(Html.Partial("SanPhamPartial", ListSP));

#line default
#line hidden
            EndContext();
            BeginContext(382, 9, true);
            WriteLiteral(";\r\n\r\n    ");
            EndContext();
            BeginContext(392, 44, false);
#line 16 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPham2.cshtml"
Write(Html.Partial("SanPhamPartialAll", ListSPNew));

#line default
#line hidden
            EndContext();
            BeginContext(436, 5, true);
            WriteLiteral(";\r\n\r\n");
            EndContext();
            BeginContext(498, 14, true);
            WriteLiteral("    \r\n</div>\r\n");
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