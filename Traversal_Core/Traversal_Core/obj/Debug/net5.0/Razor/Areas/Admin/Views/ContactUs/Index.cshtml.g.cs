#pragma checksum "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\ContactUs\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bb58de814252838aaa83eb5f2d9ddc38f7a4d58a14075466df3e3f1d5f1bdf4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_ContactUs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
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
#line 3 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete

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

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bb58de814252838aaa83eb5f2d9ddc38f7a4d58a14075466df3e3f1d5f1bdf4a", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"793c45b74d4c3bf37da6bbb1a85c9606c0ab7695d67355eb5d33939a7ab4ae86", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\ContactUs\Index.cshtml"
       List<ContactUs>

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
#line 2 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Bize Ulaşın Mesajları</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Gönderen</th>\r\n        <th>Konu</th>\r\n        <th>Tarih</th>\r\n        <th>Sil</th>\r\n        <th>Mesajı Aç</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\ContactUs\Index.cshtml"
     foreach(var item in Model){

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 21 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\ContactUs\Index.cshtml"
              
                count++;
            

#line default
#line hidden
#nullable disable

            WriteLiteral("            <td>");
            Write(
#nullable restore
#line 24 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\ContactUs\Index.cshtml"
                 count

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 25 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\ContactUs\Index.cshtml"
                 item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 26 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\ContactUs\Index.cshtml"
                 item.Subject

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 27 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\ContactUs\Index.cshtml"
                 item.MessageDate.ToString("dd.MMM.yyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-primary\">Mesajı Aç</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Admin\Views\ContactUs\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactUs>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
