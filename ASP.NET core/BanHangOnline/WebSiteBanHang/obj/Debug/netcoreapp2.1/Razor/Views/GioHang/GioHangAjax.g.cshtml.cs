#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\GioHangAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "510467fa49677eaef99490915cbbfb90c49c75b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_GioHangAjax), @"mvc.1.0.view", @"/Views/GioHang/GioHangAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GioHang/GioHangAjax.cshtml", typeof(AspNetCore.Views_GioHang_GioHangAjax))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"510467fa49677eaef99490915cbbfb90c49c75b0", @"/Views/GioHang/GioHangAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_GioHangAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/cart.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2, "\"", 44, 1);
#line 1 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\GioHangAjax.cshtml"
WriteAttributeValue("", 9, Url.Action("XemGioHang","GioHang"), 9, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(45, 74, true);
            WriteLiteral(">\r\n    <h3>\r\n        <div class=\"total\">\r\n            <span id=\"TongTien\">");
            EndContext();
            BeginContext(120, 16, false);
#line 4 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\GioHangAjax.cshtml"
                           Write(ViewBag.TongTien);

#line default
#line hidden
            EndContext();
            BeginContext(136, 44, true);
            WriteLiteral(" vnđ</span> (<span id=\"simpleCart_quantity\">");
            EndContext();
            BeginContext(181, 19, false);
#line 4 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\GioHangAjax.cshtml"
                                                                                        Write(ViewBag.TongSoLuong);

#line default
#line hidden
            EndContext();
            BeginContext(200, 37, true);
            WriteLiteral("</span> sp)\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(237, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1e230a85ab4946b7bd73f1a8e13ad965", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(281, 24, true);
            WriteLiteral("\r\n    </h3>\r\n</a>\r\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 305, "\"", 347, 1);
#line 9 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\GioHangAjax.cshtml"
WriteAttributeValue("", 312, Url.Action("XemGioHang","GioHang"), 312, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(348, 53, true);
            WriteLiteral(" class=\"simpleCart_empty\">Chi tiết giỏ hàng</a></p>\r\n");
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
