#pragma checksum "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbbf61947d48fd1d33737e9960a32a7144b307a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_XemGioHang), @"mvc.1.0.view", @"/Views/GioHang/XemGioHang.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GioHang/XemGioHang.cshtml", typeof(AspNetCore.Views_GioHang_XemGioHang))]
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
#line 1 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
using WebSiteBanHang.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbbf61947d48fd1d33737e9960a32a7144b307a8", @"/Views/GioHang/XemGioHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880cb40bb3d50c49c215fa331228a75220b66e41", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_XemGioHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItemGioHang>>
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
#line 3 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
  
    ViewBag.Title = "XemGioHang";
    Layout = "~/Views/Layout/ProductLayout.cshtml";

#line default
#line hidden
            BeginContext(152, 75, true);
            WriteLiteral("<script>\r\n      var listID = [];\r\n</script>\r\n<div id=\"ContentRealtime\">\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
     if (Model == null || Model.ToList().Count == 0)
    {

#line default
#line hidden
            BeginContext(288, 32, true);
            WriteLiteral("        <h2>giỏ hàng rỗng</h2>\r\n");
            EndContext();
#line 15 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
     
    }
    else
    {

#line default
#line hidden
            BeginContext(351, 74, true);
            WriteLiteral("        <div class=\"check\" id=\"ketqua\">\r\n            <h2>My Shopping Bag (");
            EndContext();
            BeginContext(426, 25, false);
#line 20 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                            Write(Model.Sum(s => s.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(451, 57, true);
            WriteLiteral(")</h2>\r\n            <div class=\"col-md-6 cart-items\">\r\n\r\n");
            EndContext();
#line 23 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                 foreach (ItemGioHang item in Model)
                {



#line default
#line hidden
            BeginContext(585, 130, true);
            WriteLiteral("                    <script>\r\n                        $(document).ready(function (c) {\r\n                            listID.push(\'#");
            EndContext();
            BeginContext(716, 9, false);
#line 29 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                                     Write(item.MaSP);

#line default
#line hidden
            EndContext();
            BeginContext(725, 41, true);
            WriteLiteral("\');\r\n                                $(\'#");
            EndContext();
            BeginContext(767, 9, false);
#line 30 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                               Write(item.MaSP);

#line default
#line hidden
            EndContext();
            BeginContext(776, 231, true);
            WriteLiteral("\').on(\'click\', function (c) {\r\n                                   \r\n                                    $.ajax({\r\n                                            type: \'POST\',\r\n                                            data: { MaSP: ");
            EndContext();
            BeginContext(1008, 9, false);
#line 34 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                                                     Write(item.MaSP);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 55, true);
            WriteLiteral(" },\r\n                                            url: \'");
            EndContext();
            BeginContext(1073, 38, false);
#line 35 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                                             Write(Url.Action("XoaItemGioHang","GioHang"));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 467, true);
            WriteLiteral(@"',
                                            success: function (ketqua) {

                                                $('.check').html(ketqua);


                                            }
                                    });
                   

                                });


                            });
                    </script>
                    <div class=""cart-header"">

                        <div class=""close1""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1578, "\"", 1593, 1);
#line 52 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 1583, item.MaSP, 1583, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1594, 52, true);
            WriteLiteral("> </div>\r\n\r\n                        <a class=\"edit1\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1646, "\"", 1714, 1);
#line 54 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 1653, Url.Action("SuaGioHang","GioHang",new { @MaSP = item.MaSP }), 1653, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1715, 170, true);
            WriteLiteral("> </a>\r\n                        <div class=\"cart-sec simpleCart_shelfItem\">\r\n                            <div class=\"cart-item cyc\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1885, "\"", 1942, 1);
#line 57 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 1891, Url.Content("~/Content/HinhAnhSP/" + item.HinhAnh), 1891, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1943, 177, true);
            WriteLiteral(" class=\"img-responsive\" alt=\"\" />\r\n                            </div>\r\n                            <div class=\"cart-item-info\">\r\n                                <h3><a href=\"#\">");
            EndContext();
            BeginContext(2121, 10, false);
#line 60 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                                           Write(item.TenSP);

#line default
#line hidden
            EndContext();
            BeginContext(2131, 61, true);
            WriteLiteral("</a></h3>\r\n                                <ul class=\"qty\">\r\n");
            EndContext();
            BeginContext(2258, 54, true);
            WriteLiteral("                                    <li><p>Số lượng : ");
            EndContext();
            BeginContext(2313, 12, false);
#line 63 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                                                 Write(item.SoLuong);

#line default
#line hidden
            EndContext();
            BeginContext(2325, 156, true);
            WriteLiteral("</p></li>\r\n                                </ul>\r\n\r\n                                <div class=\"delivery\">\r\n                                    <p>Đơn giá :");
            EndContext();
            BeginContext(2482, 28, false);
#line 67 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                                           Write(item.DonGia.ToString("#,##"));

#line default
#line hidden
            EndContext();
            BeginContext(2510, 52, true);
            WriteLiteral(" vnđ</p>\r\n                                    <span>");
            EndContext();
            BeginContext(2563, 31, false);
#line 68 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                                     Write(item.ThanhTien.ToString("#,##"));

#line default
#line hidden
            EndContext();
            BeginContext(2594, 275, true);
            WriteLiteral(@" vnđ</span>
                                    <div class=""clearfix""></div>
                                </div>
                            </div>
                            <div class=""clearfix""></div>

                        </div>
                    </div>
");
            EndContext();
#line 76 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                }

#line default
#line hidden
            BeginContext(2888, 104, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-3 cart-total\">\r\n                <a class=\"continue\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2992, "\"", 3026, 1);
#line 80 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 2999, Url.Action("Index","Home"), 2999, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3027, 202, true);
            WriteLiteral(">Tiếp tục mua hàng</a>\r\n                <div class=\"price-details\">\r\n                    <h3>Thông tin hóa đơn</h3>\r\n                    <span>Tổng tiền</span>\r\n                    <span class=\"total1\">");
            EndContext();
            BeginContext(3230, 44, false);
#line 84 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                                    Write(Model.Sum(s => s.ThanhTien).ToString("#,##"));

#line default
#line hidden
            EndContext();
            BeginContext(3274, 501, true);
            WriteLiteral(@" vnđ</span>
                    <span>Discount</span>
                    <span class=""total1"">---</span>
                    <span>Miễn phí ship tại TP.HCM</span>
                    <hr />
                    <span>Phí ship các tỉnh khác: 30.000 vnđ</span>

                    <div class=""clearfix""></div>
                </div>
                <ul class=""total_price"">
                    <li class=""last_price""> <h4>Tổng tiền</h4></li>
                    <li class=""last_price""><span>");
            EndContext();
            BeginContext(3776, 44, false);
#line 95 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                                            Write(Model.Sum(s => s.ThanhTien).ToString("#,##"));

#line default
#line hidden
            EndContext();
            BeginContext(3820, 363, true);
            WriteLiteral(@" vnđ</span></li>
                    <li><span>( chưa cộng phí ship )</span></li>
                    <div class=""clearfix""> </div>
                </ul>


                <div class=""clearfix""></div>
                <a class=""order"" id=""btnDatHang"" href=""#"">Đặt hàng</a>

            </div>

            <div class=""clearfix""> </div>
        </div>
");
            EndContext();
#line 108 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
    }

#line default
#line hidden
            BeginContext(4190, 292, true);
            WriteLiteral(@"
</div>


<div id=""popup-order"">
    <div class="" w3l-login-form"">
        <div style=""clear:both;text-align:right;margin-bottom:0"">
            <span id=""close-form-order"" class=""btn btn-danger"">X</span>
        </div>
        <h3 style=""color:red;text-align:center"">Đặt hàng</h3>
");
            EndContext();
#line 119 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
         using (Ajax.BeginForm("DatHang", "Home", new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "ketqua", InsertionMode = InsertionMode.Replace }))
        {


#line default
#line hidden
            BeginContext(4654, 1408, true);
            WriteLiteral(@"            <div class="" w3l-form-group"">
                <label>Tài khoản:</label>
                <div class=""group"">
                    <i class=""fas fa-user""></i>
                    <input type=""text"" class=""form-control"" placeholder=""Họ tên"" required=""required"" name=""userName"">
                </div>
            </div>
            <div class="" w3l-form-group"">
                <label>Email:</label>
                <div class=""group"">
                    <i class=""fas fa-envelope""></i>
                    <input id=""email"" type=""email"" class=""form-control"" placeholder=""Email"" required=""required"" name=""Email"">
                </div>
            </div>
            <div class="" w3l-form-group"">
                <label>Số điện thoại:</label>
                <div class=""group"">
                    <i class=""fas fa-phone""></i>
                    <input id=""numberphone"" type=""number"" class=""form-control"" placeholder=""Số điện thoại"" required=""required"" name=""phoneNumber"">
                </div");
            WriteLiteral(@">
            </div>
            <div class="" w3l-form-group"">
                <label>Địa chỉ:</label>
                <div class=""group"">
                    <i class=""fas fa-home""></i>
                    <input style=""width:100%"" id=""dress"" type=""text"" class=""form-control"" placeholder=""Địa chỉ"" required=""required"" name=""Dress"">
                </div>
            </div>
");
            EndContext();
            BeginContext(6064, 77, true);
            WriteLiteral("            <button type=\"submit\" id=\"btnOrder\">Tiến hành đặt hàng</button>\r\n");
            EndContext();
#line 152 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
        }

#line default
#line hidden
            BeginContext(6152, 284, true);
            WriteLiteral(@"
    </div>
</div>

<div id=""popup-order-tv"">
    <div class="" w3l-login-form"">
        <div style=""clear:both;text-align:right;margin-bottom:0"">
            <span id=""close-form-order-tv"" class=""btn btn-danger"">X</span>
        </div>
        <div style=""padding-top:10%"">
");
            EndContext();
#line 163 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
             using (Ajax.BeginForm("DatHang", "Home", new AjaxOptions { HttpMethod = "Post", UpdateTargetId = "ketqua", InsertionMode = InsertionMode.Replace }))
            {



#line default
#line hidden
            BeginContext(6618, 84, true);
            WriteLiteral("                <button type=\"submit\" id=\"btnOrder-tv\">Tiến hành đặt hàng</button>\r\n");
            EndContext();
#line 168 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
            }

#line default
#line hidden
            BeginContext(6717, 575, true);
            WriteLiteral(@"        </div>

    </div>
</div>

<style>


    #close-form-order {
        color: white;
    }

    #popup-order {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        background-color: rgba(0,0,0,0);
        z-index: 3;
        display: none;
    }

    #popup-order-tv {
        position: absolute;
        top: 10%;
        left: 0;
        width: 100%;
        height: 100%;
        background-color: rgba(0,0,0,0);
        z-index: 3;
        display: none;
    }
</style>

");
            EndContext();
#line 204 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
  

    ThanhVienTB tv = Session["TaiKhoan"] as ThanhVienTB;
    int status = 0;
    if (tv != null)
    {
        status = 1;
    }

#line default
#line hidden
            BeginContext(7436, 46, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n    var kt = ");
            EndContext();
            BeginContext(7483, 6, false);
#line 214 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
        Write(status);

#line default
#line hidden
            EndContext();
            BeginContext(7489, 983, true);
            WriteLiteral(@";
    $(""#btnDatHang"").click(function () {

        
        if (kt) {
            $(""#popup-order-tv"").fadeIn(500);

        }
        else {
            $(""#popup-order"").fadeIn(500);
        }
    });

    //Bắt sựu kiện ẩn form
    $(""#close-form-order"").click(CloseForm);

    //Định nghĩa ẩn form
    function CloseForm() {
        $(""#popup-order"").hide();
    }
    $(""#close-form-order-tv"").click(CloseFormTV);

    //Định nghĩa ẩn form
    function CloseFormTV() {
        $(""#popup-order-tv"").hide();
    }
    $(""#btnOrder"").click(function () {

        alert(""Quý khách đã đặt hàng thành công ! Cảm ơn quý khách. Nhân viên tư vấn sẽ gọi lại xác nhận đơn hàng này"");
        $(""#popup-order"").hide();
    });
    $(""#btnOrder-tv"").click(function () {

        alert(""Quý khách đã đặt hàng thành công ! Cảm ơn quý khách. Nhân viên tư vấn sẽ gọi lại xác nhận đơn hàng này"");
        $(""#popup-order-tv"").hide();
    });


</script>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(8490, 179, true);
                WriteLiteral("\r\n \r\n    <!--Script references. -->\r\n    <!--The jQuery library is required and is referenced by default in _Layout.cshtml. -->\r\n    <!--Reference the SignalR library. -->\r\n\r\n    ");
                EndContext();
                BeginContext(8669, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b769f614532247a593e8fbf5dcdaf5be", async() => {
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
                BeginContext(8730, 67, true);
                WriteLiteral("\r\n    <!--Reference the autogenerated SignalR hub script. -->\r\n    ");
                EndContext();
                BeginContext(8797, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "181f7609190742a788a6d0457bf8b4b3", async() => {
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
                BeginContext(8835, 197, true);
                WriteLiteral("\r\n    <!--SignalR script to update the chat page and send messages.-->\r\n    <script>\r\n      \r\n        $(function () {\r\n            \r\n            var contentHtml = \'\';\r\n            var contenUrl = \'");
                EndContext();
                BeginContext(9033, 14, false);
#line 269 "C:\Users\Admin\Desktop\ASP.NET core\BanHangOnline\WebSiteBanHang\Views\GioHang\XemGioHang.cshtml"
                        Write(Request.RawUrl);

#line default
#line hidden
                EndContext();
                BeginContext(9047, 1772, true);
                WriteLiteral(@"';
            
            // Reference the auto-generated proxy for the hub.
            var chat = $.connection.chatHub;
            // Create a function that the hub can call back to display messages.
            chat.client.addNewMessageToPage = function (name, message) {
                // Add the message to the page.

                $('#KQTimKiem').html(message);
                window.location.href = name;

            };
            // Get the user name and store it to prepend to messages.
            // $('#displayname').val(prompt('Enter your name:', ''));
            // Set initial focus to message input box.

            // Start the connection.
            $.connection.hub.start().done(function () {


                // Call the Send method on the hub.
                if (kt) {
                    
                    for (var i = 0; i < listID.length; i++) {
                        $(listID[i]).click(function () {
                            listID.splice(i, 1);
     ");
                WriteLiteral(@"                       chat.server.send(contenUrl, $('#KQTimKiem').html());
                             
                            
                        });
                       
                    }
                    $('#XemGioHang').click(function () {
                        chat.server.send(contenUrl, $('#KQTimKiem').html());
                    });
                    
                }
                 
            });
            

        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItemGioHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
