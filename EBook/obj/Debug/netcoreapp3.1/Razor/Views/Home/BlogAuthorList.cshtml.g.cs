#pragma checksum "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0f64e800fc7811a96765d5c8e3718419e1a0909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BlogAuthorList), @"mvc.1.0.view", @"/Views/Home/BlogAuthorList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0f64e800fc7811a96765d5c8e3718419e1a0909", @"/Views/Home/BlogAuthorList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c73c2a034334d9f0ae4dad9f60bdd7324f1a1f68", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BlogAuthorList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogAuthorListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorList.cshtml"
 foreach (var item in Model.BAuthor)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorList.cshtml"
Write(await Html.PartialAsync("_BlogAuthorList", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BlogAuthorList.cshtml"
                                                     

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogAuthorListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
