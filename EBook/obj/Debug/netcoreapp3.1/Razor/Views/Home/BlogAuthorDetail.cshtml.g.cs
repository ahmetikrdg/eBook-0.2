#pragma checksum "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc5e167e0ac0022dfa959e7f24f87631d5aeefd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BlogAuthorDetail), @"mvc.1.0.view", @"/Views/Home/BlogAuthorDetail.cshtml")]
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
#line 1 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\_ViewImports.cshtml"
using EBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\_ViewImports.cshtml"
using EBook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\_ViewImports.cshtml"
using EBook.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc5e167e0ac0022dfa959e7f24f87631d5aeefd0", @"/Views/Home/BlogAuthorDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c73c2a034334d9f0ae4dad9f60bdd7324f1a1f68", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BlogAuthorDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BauthorDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card mb-3\" style=\"max-width: 540px;\">\r\n    <div class=\"row no-gutters\">\r\n        <div class=\"col-md-4\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 162, "\"", 187, 1);
#nullable restore
#line 6 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorDetail.cshtml"
WriteAttributeValue("", 168, Model.Author.Image, 168, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\" alt=\"...\">\r\n        </div>\r\n        <div class=\"col-md-8\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorDetail.cshtml"
                                  Write(Model.Author.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorDetail.cshtml"
                                Write(Model.Author.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n/--\r\n");
#nullable restore
#line 18 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorDetail.cshtml"
     foreach (var blogs in Model.Blog)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-group\">\r\n            <div class=\"card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 634, "\"", 652, 1);
#nullable restore
#line 22 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorDetail.cshtml"
WriteAttributeValue("", 640, blogs.Image, 640, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 24 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorDetail.cshtml"
                                      Write(blogs.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorDetail.cshtml"
                                    Write(blogs.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 26 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorDetail.cshtml"
                                                              Write(blogs.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorDetail.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BauthorDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
