#pragma checksum "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\PhanLoaiThuoc\lisdata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb669814cf2f0a53f202cb9529c7a51b4065a784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PhanLoaiThuoc_lisdata), @"mvc.1.0.view", @"/Areas/Admin/Views/PhanLoaiThuoc/lisdata.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb669814cf2f0a53f202cb9529c7a51b4065a784", @"/Areas/Admin/Views/PhanLoaiThuoc/lisdata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb67e6db47e1fd3b42e62e4ee643c74fea8ca8d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_PhanLoaiThuoc_lisdata : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBanThuoc.DTOs.PhanLoaiThuoc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\PhanLoaiThuoc\lisdata.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 6 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\PhanLoaiThuoc\lisdata.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 9 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\PhanLoaiThuoc\lisdata.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoaiThuoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\t\t\t<td>\r\n\t\t\t\t<button class=\"btn btn-secondary btn-edit\" data-id=\"");
#nullable restore
#line 12 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\PhanLoaiThuoc\lisdata.cshtml"
                                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#exampleModal\">\r\n\t\t\t\t\t<i class=\"fa-solid fa-pen-to-square\"></i>\r\n\t\t\t\t\tSửa\r\n\t\t\t\t</button>\r\n\t\t\t\t<button id=\"delete\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 16 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\PhanLoaiThuoc\lisdata.cshtml"
                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\t\t\t\t\t<i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n\t\t\t\t</button>\r\n\t\t\t</td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Admin\Downloads\phuc\WebBanThuoc\WebBanThuoc.Web\Areas\Admin\Views\PhanLoaiThuoc\lisdata.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBanThuoc.DTOs.PhanLoaiThuoc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
