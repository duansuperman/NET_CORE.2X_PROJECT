#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80ba984c20438496cec8dce1207c49526c750f91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_TimKiemSanPham), @"mvc.1.0.view", @"/Views/SanPham/TimKiemSanPham.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPham/TimKiemSanPham.cshtml", typeof(AspNetCore.Views_SanPham_TimKiemSanPham))]
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
#line 1 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
using WebSiteBanHang.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
using X.PagedList;

#line default
#line hidden
#line 3 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ba984c20438496cec8dce1207c49526c750f91", @"/Views/SanPham/TimKiemSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_TimKiemSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SanPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.signalR-2.4.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/signalr/hubs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(118, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
  

    int sumpage = ViewBag.sumpage;

#line default
#line hidden
            BeginContext(165, 86, true);
            WriteLiteral("\r\n\r\n<div class=\"col-md-9 product1\">\r\n    <div class=\" bottom-product\" id=\"LinkPage\">\r\n");
            EndContext();
#line 15 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(300, 187, true);
            WriteLiteral("            <div style=\"margin-bottom:2em\" class=\"col-md-4 bottom-cd simpleCart_shelfItem\">\r\n                <script>\r\n            $(document).ready(function (c) {\r\n\r\n                $(\'#");
            EndContext();
            BeginContext(488, 9, false);
#line 21 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
               Write(item.MaSp);

#line default
#line hidden
            EndContext();
            BeginContext(497, 146, true);
            WriteLiteral("\').on(\'click\', function (c) {\r\n                    $.ajax({\r\n                            type: \'POST\',\r\n                            data: { MaSp: ");
            EndContext();
            BeginContext(644, 9, false);
#line 24 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                     Write(item.MaSp);

#line default
#line hidden
            EndContext();
            BeginContext(653, 39, true);
            WriteLiteral(" },\r\n                            url: \'");
            EndContext();
            BeginContext(693, 35, false);
#line 25 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                             Write(Url.Action("ThemGioHang","GioHang"));

#line default
#line hidden
            EndContext();
            BeginContext(728, 371, true);
            WriteLiteral(@"',
                            success: function (ketqua) {

                                $('#GioHang').html(ketqua);
                                location.reload();
                            }
                        });
                });


            });
                </script>
                <div class=""product-at "">
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1099, "\"", 1168, 1);
#line 38 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
WriteAttributeValue("", 1106, Url.Action("ChiTietSanPham","SanPham",new { id = item.MaSp }), 1106, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1169, 88, true);
            WriteLiteral(">\r\n                        <img style=\"width:250px; height:200px\" class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1257, "\"", 1312, 1);
#line 39 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
WriteAttributeValue("", 1263, Url.Content("~/Content/HinhAnhSP/"+item.HinhAnh), 1263, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1313, 279, true);
            WriteLiteral(@" alt="""">
                        <div class=""pro-grid"">
                            <span class=""buy-in"">Xem chi tiết</span>
                        </div>
                    </a>
                </div>
                <p class=""tun""></p>
                <a type=""submit""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1592, "\"", 1607, 1);
#line 46 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
WriteAttributeValue("", 1597, item.MaSp, 1597, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1608, 64, true);
            WriteLiteral(" href=\"#\" class=\"item_add\"><p class=\"number item_price\"><i> </i>");
            EndContext();
            BeginContext(1673, 34, false);
#line 46 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                                                                                           Write(item.DonGia.Value.ToString("#,##"));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 59, true);
            WriteLiteral(" VNĐ</p></a>\r\n                <p></p>\r\n            </div>\r\n");
            EndContext();
#line 49 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
        }

#line default
#line hidden
            BeginContext(1777, 294, true);
            WriteLiteral(@"

        <div class=""clearfix""> </div>
    </div>


</div>
<div class=""clearfix""> </div>
<nav class=""in"">
    <ul id=""numberPage""></ul>
    <ul class=""pagination"">
        <li><a href=""#"" type=""submit"" id=""Previous"" aria-label=""Previous""><span aria-hidden=""true"">«</span></a></li>
");
            EndContext();
#line 63 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
         for (int i = 1; i <= sumpage; i++)
        {

            string page_num = "Page" + i;



#line default
#line hidden
            BeginContext(2270, 124, true);
            WriteLiteral("            <li>\r\n                <script>\r\n\r\n                $(document).ready(function (c) {\r\n\r\n\r\n                    $(\'#");
            EndContext();
            BeginContext(2395, 8, false);
#line 75 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                   Write(page_num);

#line default
#line hidden
            EndContext();
            BeginContext(2403, 84, true);
            WriteLiteral("\').on(\'click\', function (c) {\r\n                        $(\"#numberPage\").text(\"Trang ");
            EndContext();
            BeginContext(2488, 1, false);
#line 76 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                                Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2489, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(2491, 7, false);
#line 76 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                                   Write(sumpage);

#line default
#line hidden
            EndContext();
            BeginContext(2498, 34, true);
            WriteLiteral("\");\r\n                        tu = ");
            EndContext();
            BeginContext(2533, 1, false);
#line 77 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                        Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2534, 156, true);
            WriteLiteral(";\r\n                        $.ajax({\r\n                                type: \'GET\',\r\n                                data: { tukhoa:$(\"#tukhoa\").val() , page:");
            EndContext();
            BeginContext(2691, 1, false);
#line 80 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                                                    Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2692, 43, true);
            WriteLiteral(" },\r\n                                url: \'");
            EndContext();
            BeginContext(2736, 39, false);
#line 81 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                 Write(Url.Action("SanPhamPageAjax","SanPham"));

#line default
#line hidden
            EndContext();
            BeginContext(2775, 320, true);
            WriteLiteral(@"',
                                success: function (ketqua) {

                                    $('#LinkPage').html(ketqua);
                                }
                            });
                    });


                });
                </script>
                <a href=""#"" type=""submit""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3095, "\"", 3109, 1);
#line 92 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
WriteAttributeValue("", 3100, page_num, 3100, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3110, "\"", 3120, 1);
#line 92 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
WriteAttributeValue("", 3118, i, 3118, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3121, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3123, 1, false);
#line 92 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3124, 55, true);
            WriteLiteral(" <span class=\"sr-only\"></span></a>\r\n            </li>\r\n");
            EndContext();
#line 94 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"

        }

#line default
#line hidden
            BeginContext(3192, 177, true);
            WriteLiteral("        <li> <a href=\"#\" id=\"Next\" aria-label=\"Next\"><span aria-hidden=\"true\">»</span> </a> </li>\r\n    </ul>\r\n</nav>\r\n</div>\r\n\r\n\r\n\r\n<script>\r\n    $(\"#numberPage\").text(\"Trang 1/");
            EndContext();
            BeginContext(3370, 7, false);
#line 104 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                              Write(sumpage);

#line default
#line hidden
            EndContext();
            BeginContext(3377, 325, true);
            WriteLiteral(@""");
    var tu = 1;
    $(document).ready(function (c) {


                    $('#Previous').on('click', function (c) {
                        if (tu <= 1) {
                            return false;
                        }
                        tu = tu - 1;
                        var t = ""Trang "" + tu + ""/");
            EndContext();
            BeginContext(3703, 7, false);
#line 114 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                             Write(sumpage);

#line default
#line hidden
            EndContext();
            BeginContext(3710, 253, true);
            WriteLiteral("\";\r\n                        $(\"#numberPage\").text(t);\r\n                        $.ajax({\r\n                                type: \'GET\',\r\n                                data: { tukhoa:$(\"#tukhoa\").val() , page:tu },\r\n                                url: \'");
            EndContext();
            BeginContext(3964, 39, false);
#line 119 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                 Write(Url.Action("SanPhamPageAjax","SanPham"));

#line default
#line hidden
            EndContext();
            BeginContext(4003, 488, true);
            WriteLiteral(@"',
                                success: function (ketqua) {

                                    $('#LinkPage').html(ketqua);
                                }
                            });
                    });


                    $('#Next').on('click', function (c) {
                        if (tu >= 3) {
                            return false;
                        }
                        tu = tu + 1;
                        var t = ""Trang "" + tu + ""/");
            EndContext();
            BeginContext(4492, 7, false);
#line 133 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                             Write(sumpage);

#line default
#line hidden
            EndContext();
            BeginContext(4499, 253, true);
            WriteLiteral("\";\r\n                        $(\"#numberPage\").text(t);\r\n                        $.ajax({\r\n                                type: \'GET\',\r\n                                data: { tukhoa:$(\"#tukhoa\").val() , page:tu },\r\n                                url: \'");
            EndContext();
            BeginContext(4753, 39, false);
#line 138 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
                                 Write(Url.Action("SanPhamPageAjax","SanPham"));

#line default
#line hidden
            EndContext();
            BeginContext(4792, 263, true);
            WriteLiteral(@"',
                                success: function (ketqua) {

                                    $('#LinkPage').html(ketqua);
                                }
                            });
                    });


                });
</script>
");
            EndContext();
#line 149 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
  

    ThanhVienTb tv = ViewBag.tv as ThanhVienTb;
    int status = 0;
    if (tv != null)
    {
        status = 1;
    }

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(5208, 182, true);
                WriteLiteral("\r\n    \r\n    <!--Script references. -->\r\n    <!--The jQuery library is required and is referenced by default in _Layout.cshtml. -->\r\n    <!--Reference the SignalR library. -->\r\n\r\n    ");
                EndContext();
                BeginContext(5390, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20ad30fdc0348778120257a5e1dc40e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5451, 67, true);
                WriteLiteral("\r\n    <!--Reference the autogenerated SignalR hub script. -->\r\n    ");
                EndContext();
                BeginContext(5518, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf370c3848c24467976d2b770a3cc3d6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5556, 103, true);
                WriteLiteral("\r\n    <!--SignalR script to update the chat page and send messages.-->\r\n    <script>\r\n        var kt = ");
                EndContext();
                BeginContext(5660, 6, false);
#line 169 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\TimKiemSanPham.cshtml"
            Write(status);

#line default
#line hidden
                EndContext();
                BeginContext(5666, 1281, true);
                WriteLiteral(@";
        $(function () {

            // Reference the auto-generated proxy for the hub.
            var chat = $.connection.chatHub;
            // Create a function that the hub can call back to display messages.
            chat.client.addNewMessageToPage = function (name, message) {
                // Add the message to the page.


                window.location.href = name;

            };
            // Get the user name and store it to prepend to messages.
            // $('#displayname').val(prompt('Enter your name:', ''));
            // Set initial focus to message input box.

            // Start the connection.
            $.connection.hub.start().done(function () {


                // Call the Send method on the hub.
                if (kt) {

                    $('#XemGioHang').click(function () {
                        
                        chat.server.send('/GioHang/XemGioHang', '');
                    });

                }

            });


       ");
                WriteLiteral(@" });

        // This optional function html-encodes messages for display in the page.
        function htmlEncode(value) {
            var encodedValue = $('<div />').text(value).html();
            return encodedValue;
        }


    </script>
");
                EndContext();
            }
            );
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
