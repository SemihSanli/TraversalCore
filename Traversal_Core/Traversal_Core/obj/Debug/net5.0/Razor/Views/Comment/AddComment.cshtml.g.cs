#pragma checksum "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Views\Comment\AddComment.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18247dec94bce89c8140e06b0c242eb2b0ac502771f83e5922bc6e4c63f91508"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Comment_AddComment), @"mvc.1.0.view", @"/Views/Comment/AddComment.cshtml")]
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
#line 1 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Views\_ViewImports.cshtml"
using Traversal_Core

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Views\_ViewImports.cshtml"
using Traversal_Core.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Views\_ViewImports.cshtml"
using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"18247dec94bce89c8140e06b0c242eb2b0ac502771f83e5922bc6e4c63f91508", @"/Views/Comment/AddComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ffdc6b5248d6fd0f0d7a940aecac4d8b73185aa5819bea777052d421df6b1e98", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Comment_AddComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Views\Comment\AddComment.cshtml"
 if(User.Identity.IsAuthenticated){



#line default
#line hidden
#nullable disable

            WriteLiteral("<div class=\"leave-comment-form mt-5\" id=\"reply\">\r\n    <h4 class=\"side-title mb-2\">Yorum Bırakın</h4>\r\n    <p class=\"mb-4\">\r\n        İşaretli Alanları Boş Bırakmamalısınız\r\n    </p>\r\n   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18247dec94bce89c8140e06b0c242eb2b0ac502771f83e5922bc6e4c63f915084972", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"DestinationID\"");
                BeginWriteAttribute("value", " value=\"", 352, "\"", 375, 1);
                WriteAttributeValue("", 360, 
#nullable restore
#line 11 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Views\Comment\AddComment.cshtml"
                                                          ViewBag.destID

#line default
#line hidden
#nullable disable
                , 360, 15, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"AppUserID\"");
                BeginWriteAttribute("value", " value=\"", 426, "\"", 449, 1);
                WriteAttributeValue("", 434, 
#nullable restore
#line 12 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Views\Comment\AddComment.cshtml"
                                                      ViewBag.userID

#line default
#line hidden
#nullable disable
                , 434, 15, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n      \n       \n        <div class=\"form-group\">\r\n            <textarea name=\"CommentContent\" class=\"form-control\" placeholder=\"Yorumunuz\"");
                BeginWriteAttribute("required", " required=\"", 592, "\"", 603, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                      spellcheck=\"false\"></textarea>\r\n        </div>\r\n\r\n        <div class=\"submit text-right\">\r\n            <button class=\"btn btn-style btn-primary\">Yorum Yap </button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<script src=\"https://code.jquery.com/jquery-3.5.1.min.js\" type=\"text/javascript\"></script>\r\n");
#nullable restore
#line 26 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Views\Comment\AddComment.cshtml"
}
else{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h2> Yorum İçin Üye Olmanız Gereklidir </h2>\r\n");
#nullable restore
#line 29 "C:\Users\Semih\source\repos\Traversal_Core\Traversal_Core\Views\Comment\AddComment.cshtml"
}

#line default
#line hidden
#nullable disable

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
