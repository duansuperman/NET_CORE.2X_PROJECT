#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a135cdfc49baa18bdc4546be830401085be8497"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_SanPhamPageAjax), @"mvc.1.0.view", @"/Views/SanPham/SanPhamPageAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPham/SanPhamPageAjax.cshtml", typeof(AspNetCore.Views_SanPham_SanPhamPageAjax))]
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
#line 1 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml"
using WebSiteBanHang.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a135cdfc49baa18bdc4546be830401085be8497", @"/Views/SanPham/SanPhamPageAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_SanPhamPageAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(99, 171, true);
            WriteLiteral("    <div style=\"margin-bottom:2em\" class=\"col-md-4 bottom-cd simpleCart_shelfItem\">\r\n        <script>\r\n            $(document).ready(function (c) {\r\n\r\n                $(\'#");
            EndContext();
            BeginContext(271, 9, false);
#line 12 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml"
               Write(item.MaSP);

#line default
#line hidden
            EndContext();
            BeginContext(280, 146, true);
            WriteLiteral("\').on(\'click\', function (c) {\r\n                    $.ajax({\r\n                            type: \'POST\',\r\n                            data: { MaSP: ");
            EndContext();
            BeginContext(427, 9, false);
#line 15 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml"
                                     Write(item.MaSP);

#line default
#line hidden
            EndContext();
            BeginContext(436, 39, true);
            WriteLiteral(" },\r\n                            url: \'");
            EndContext();
            BeginContext(476, 35, false);
#line 16 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml"
                             Write(Url.Action("ThemGioHang","GioHang"));

#line default
#line hidden
            EndContext();
            BeginContext(511, 295, true);
            WriteLiteral(@"',
                            success: function (ketqua) {

                                $('#GioHang').html(ketqua);
                            }
                        });
                });


            });
        </script>
        <div class=""product-at "">
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 806, "\"", 875, 1);
#line 28 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml"
WriteAttributeValue("", 813, Url.Action("ChiTietSanPham","SanPham",new { id = item.MaSP }), 813, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(876, 80, true);
            WriteLiteral(">\r\n                <img style=\"width:250px; height:200px\" class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 956, "\"", 1011, 1);
#line 29 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml"
WriteAttributeValue("", 962, Url.Content("~/Content/HinhAnhSP/"+item.HinhAnh), 962, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1012, 223, true);
            WriteLiteral(" alt=\"\">\r\n                <div class=\"pro-grid\">\r\n                    <span class=\"buy-in\">Xem chi tiết</span>\r\n                </div>\r\n            </a>\r\n        </div>\r\n        <p class=\"tun\"></p>\r\n        <a type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1235, "\"", 1250, 1);
#line 36 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml"
WriteAttributeValue("", 1240, item.MaSP, 1240, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1251, 64, true);
            WriteLiteral(" href=\"#\" class=\"item_add\"><p class=\"number item_price\"><i> </i>");
            EndContext();
            BeginContext(1316, 34, false);
#line 36 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml"
                                                                                                   Write(item.DonGia.Value.ToString("#,##"));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 43, true);
            WriteLiteral(" VNĐ</p></a>\r\n        <p></p>\r\n    </div>\r\n");
            EndContext();
#line 39 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\SanPham\SanPhamPageAjax.cshtml"
}

#line default
#line hidden
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
