#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0e458691ad515f1b8b2efd854668654ecf3b9ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e458691ad515f1b8b2efd854668654ecf3b9ce", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 262, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e7bb8e2f3f343df83d517c4caa05373", async() => {
                BeginContext(31, 119, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
                EndContext();
                BeginContext(151, 13, false);
#line 6 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(164, 39, true);
                WriteLiteral(" - My ASP.NET Application</title>\r\n    ");
                EndContext();
                BeginContext(204, 30, false);
#line 7 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
Write(Styles.Render("~/Content/css"));

#line default
#line hidden
                EndContext();
                BeginContext(234, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(241, 37, false);
#line 8 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/modernizr"));

#line default
#line hidden
                EndContext();
                BeginContext(278, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(287, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(289, 1316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24268e9cb4644e84933d08740af4c936", async() => {
                BeginContext(295, 449, true);
                WriteLiteral(@"
    <div class=""navbar navbar-inverse navbar-fixed-top"">
        <div class=""container"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                ");
                EndContext();
                BeginContext(745, 104, false);
#line 19 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
           Write(Html.ActionLink("Application name", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" }));

#line default
#line hidden
                EndContext();
                BeginContext(849, 143, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"nav navbar-nav\">\r\n                    <li>");
                EndContext();
                BeginContext(993, 40, false);
#line 23 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1033, 31, true);
                WriteLiteral("</li>\r\n                    <li>");
                EndContext();
                BeginContext(1065, 41, false);
#line 24 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("About", "About", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1106, 31, true);
                WriteLiteral("</li>\r\n                    <li>");
                EndContext();
                BeginContext(1138, 45, false);
#line 25 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Contact", "Contact", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1183, 128, true);
                WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"container body-content\">\r\n        ");
                EndContext();
                BeginContext(1312, 12, false);
#line 31 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1324, 58, true);
                WriteLiteral("\r\n        <hr />\r\n        <footer>\r\n            <p>&copy; ");
                EndContext();
                BeginContext(1383, 17, false);
#line 34 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(1400, 69, true);
                WriteLiteral(" - My ASP.NET Application</p>\r\n        </footer>\r\n    </div>\r\n\r\n     ");
                EndContext();
                BeginContext(1470, 34, false);
#line 38 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/jquery"));

#line default
#line hidden
                EndContext();
                BeginContext(1504, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1511, 37, false);
#line 39 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/bootstrap"));

#line default
#line hidden
                EndContext();
                BeginContext(1548, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1555, 41, false);
#line 40 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1596, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1605, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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