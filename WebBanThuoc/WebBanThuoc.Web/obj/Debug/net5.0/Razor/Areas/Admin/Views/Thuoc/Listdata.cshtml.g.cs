#pragma checksum "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95052fbe048c2ca73fdfc04077ff9252e343d9dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Thuoc_Listdata), @"mvc.1.0.view", @"/Areas/Admin/Views/Thuoc/Listdata.cshtml")]
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
#line 1 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanThuoc.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanThuoc.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95052fbe048c2ca73fdfc04077ff9252e343d9dd", @"/Areas/Admin/Views/Thuoc/Listdata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb67e6db47e1fd3b42e62e4ee643c74fea8ca8d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Thuoc_Listdata : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBanThuoc.Data.ViewModels.Thuoc.ListThuocVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditThuoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Thuoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<tr>\r\n\t\t<td>\r\n\t\t\t");
#nullable restore
#line 9 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml"
       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n\t\t<td>\r\n\t\t\t");
#nullable restore
#line 12 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml"
       Write(Html.DisplayFor(modelItem => item.TenThuoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n\t\t<td>\r\n\t\t\t");
#nullable restore
#line 15 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml"
       Write(Html.DisplayFor(modelItem => item.DVT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n\t\t<td>\r\n\t\t\t");
#nullable restore
#line 18 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml"
       Write(Html.DisplayFor(modelItem => item.GiaTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n\t\t<td>\r\n\t\t\t");
#nullable restore
#line 21 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml"
       Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n\t\t<td>\r\n\t\t\t");
#nullable restore
#line 24 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml"
       Write(Html.DisplayFor(modelItem => item.LoaiThuoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n\t\t<td>\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95052fbe048c2ca73fdfc04077ff9252e343d9dd6526", async() => {
                WriteLiteral("\r\n\t\t\t\t<i class=\"fa-solid fa-pen-to-square\"></i>\r\n\t\t\t\tSửa\r\n\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml"
                                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t<button id=\"delete\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 31 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml"
                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\t\t\t\t<i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n\t\t\t</button>\r\n\t\t</td>\r\n\t</tr>\r\n");
#nullable restore
#line 36 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\Thuoc\Listdata.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBanThuoc.Data.ViewModels.Thuoc.ListThuocVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591