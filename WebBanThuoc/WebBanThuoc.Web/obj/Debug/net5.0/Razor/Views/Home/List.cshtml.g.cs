#pragma checksum "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e133598089929cc974022f97a789acc52416add"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\_ViewImports.cshtml"
using WebBanThuoc.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\_ViewImports.cshtml"
using WebBanThuoc.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e133598089929cc974022f97a789acc52416add", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"548648716cd31890e514f7925a27803d209d467e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBanThuoc.DTOs.Thuoc>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fa fa-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "XemThuoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\Home\List.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"col-md-4 col-sm-6 \">\r\n\t\t<div class=\"team-thumb wow fadeInUp\" data-wow-delay=\"0.2s\">\r\n\t\t\t<img src=\"/img/thuoc110-05-2022-22-41-44-001.jpg\" class=\"img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 254, "\"", 260, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\t\t\t<div class=\"team-info\" >\r\n\t\t\t\t<div style=\"width: 230px; height: 50px;overflow: hidden\"; text-overflow: ellipsis >\r\n\t\t\t\t\t<h3 >");
#nullable restore
#line 12 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\Home\List.cshtml"
                    Write(item.TenThuoc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"team-contact-info\">\r\n\t\t\t\t\t<p><i class=\"fa fa-money\" aria-hidden=\"true\"></i> Đã bán: ");
#nullable restore
#line 15 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\Home\List.cshtml"
                                                                         Write(item.DaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\t\t\t\t\t<p><i class=\"fa fa-money\" aria-hidden=\"true\"></i> <a href=\"#\" >");
#nullable restore
#line 16 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\Home\List.cshtml"
                                                                              Write(item.GiaTien.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</a></p>\r\n\t\t\t\t</div>\r\n\t\t\t\t<ul class=\"social-icon\">\r\n\t\t\t\t\t<li><a href=\"#\" class=\"fa fa-cart-arrow-down add-cart\" data-id=");
#nullable restore
#line 19 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\Home\List.cshtml"
                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("></a></li>\r\n\t\t\t\t\t<li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e133598089929cc974022f97a789acc52416add6513", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\Home\List.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 26 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Views\Home\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBanThuoc.DTOs.Thuoc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
