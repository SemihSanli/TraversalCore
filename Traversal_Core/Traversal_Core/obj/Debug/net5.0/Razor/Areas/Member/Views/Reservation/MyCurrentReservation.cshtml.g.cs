#pragma checksum "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6d83cf4d2bf28670026ffe636774a0b19814f00c15e3e734881092405d1c20c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Member_Views_Reservation_MyCurrentReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyCurrentReservation.cshtml")]
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
#line 1 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\_ViewImports.cshtml"
using Traversal_Core

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\_ViewImports.cshtml"
using Traversal_Core.Areas.Member.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6d83cf4d2bf28670026ffe636774a0b19814f00c15e3e734881092405d1c20c1", @"/Areas/Member/Views/Reservation/MyCurrentReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d09816bfdc3e2ffa0cd37963d8f3fbb0552c4f9a2a13c13f7f88319fc27ab421", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Member_Views_Reservation_MyCurrentReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
       List<Reservation>

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
#line 3 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
  
    ViewData["Title"] = "MyCurrentReservation";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n\r\n<h1>Aktif Rezervasyonlar</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Lokasyon</th>\r\n        <th>Kişi Sayısı</th>\r\n        <th>Rezervasyon Tarihi</th>\r\n        <th>Durum</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>");
            Write(
#nullable restore
#line 23 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                 item.ReservationID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 24 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                 item.Destination.City

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 25 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                 item.PersonCount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 26 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                 item.ReservationDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 27 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                 item.Status

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
