#pragma checksum "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8e640956925e81631dfc14e9067ec292d8d074810f202efbad858fe6f262837b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal_Core

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal_Core.Areas.Member.Models

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal_Core.Areas.Admin.Models

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal_Core.CQRS.Results.DestinationResults

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal_Core.CQRS.Results.GuideResults

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal_Core.CQRS.Command.DestinationCommands

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal_Core.CQRS.Command.GuideCommands

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8e640956925e81631dfc14e9067ec292d8d074810f202efbad858fe6f262837b", @"/Areas/Admin/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"793c45b74d4c3bf37da6bbb1a85c9606c0ab7695d67355eb5d33939a7ab4ae86", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
       List<Destination>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<h1>Tur Rotaları</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Şehir</th>
        <th>Fiyat</th>
        <th>Kapasite</th>
        <th>Sitede Gör</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 19 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
     foreach(var item in Model){

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>");
            Write(
#nullable restore
#line 21 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
                 item.DestinationID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 22 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
                 item.City

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 23 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
                 item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 24 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
                 item.Capacity

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 617, "\"", 675, 2);
            WriteAttributeValue("", 624, "/Destination/DestinationDetails/", 624, 32, true);
            WriteAttributeValue("", 656, 
#nullable restore
#line 25 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
                                                          item.DestinationID

#line default
#line hidden
#nullable disable
            , 656, 19, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Sitede Gör</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 745, "\"", 808, 2);
            WriteAttributeValue("", 752, "/Admin/Destination/DeleteDestination/", 752, 37, true);
            WriteAttributeValue("", 789, 
#nullable restore
#line 26 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
                                                               item.DestinationID

#line default
#line hidden
#nullable disable
            , 789, 19, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 873, "\"", 936, 2);
            WriteAttributeValue("", 880, "/Admin/Destination/UpdateDestination/", 880, 37, true);
            WriteAttributeValue("", 917, 
#nullable restore
#line 27 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
                                                               item.DestinationID

#line default
#line hidden
#nullable disable
            , 917, 19, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\Destination\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n<a href=\"/Admin/Destination/AddDestination/\" class=\"btn btn-outline-primary\">Yeni Tur Rotası</a>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
