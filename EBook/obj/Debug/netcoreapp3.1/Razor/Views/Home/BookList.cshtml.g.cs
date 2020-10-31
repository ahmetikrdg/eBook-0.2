#pragma checksum "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc5b4927b18d2218cf98d484891ccf795bdf5922"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BookList), @"mvc.1.0.view", @"/Views/Home/BookList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5b4927b18d2218cf98d484891ccf795bdf5922", @"/Views/Home/BookList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c73c2a034334d9f0ae4dad9f60bdd7324f1a1f68", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BookList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 6 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    ");
#nullable restore
#line 8 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
Write(await Component.InvokeAsync("BookMiddle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"col-md-9\">\r\n");
#nullable restore
#line 11 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
         foreach (var item in Model.Books)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
       Write(await Html.PartialAsync("_BookList", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
                                                       
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>


                    <div class=""row"">
                        <div class=""col"">
                            <nav aria-label=""Page navigation example"">
                                <ul class=""pagination"">
                                    <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 633, "\"", 656, 2);
            WriteAttributeValue("", 640, "/kitap?page=", 640, 12, true);
#nullable restore
#line 23 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
WriteAttributeValue("", 652, 1, 652, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ana Sayfa</a>\r\n");
#nullable restore
#line 24 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
                                     for (int i = 0; i < Model.pageInfo.TotalPages(); i++)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
                                         if(string.IsNullOrEmpty(Model.pageInfo.CurrentCategory))//kategori dolumu boşmu
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li");
            BeginWriteAttribute("class", " class=\"", 1016, "\"", 1080, 2);
            WriteAttributeValue("", 1024, "page-item", 1024, 9, true);
#nullable restore
#line 28 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
WriteAttributeValue(" ", 1033, Model.pageInfo.CurrentPage==i+1?"active":"", 1034, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            WriteLiteral("\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1239, "\"", 1264, 2);
            WriteAttributeValue("", 1246, "/kitap?page=", 1246, 12, true);
#nullable restore
#line 29 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
WriteAttributeValue("", 1258, i+1, 1258, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            WriteLiteral("\r\n                                                ");
#nullable restore
#line 30 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n                                                </a>\r\n                                           </li>\r\n");
#nullable restore
#line 33 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <li");
            BeginWriteAttribute("class", " class=\"", 1731, "\"", 1795, 2);
            WriteAttributeValue("", 1739, "page-item", 1739, 9, true);
#nullable restore
#line 36 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
WriteAttributeValue(" ", 1748, Model.pageInfo.CurrentPage==i+1?"active":"", 1749, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1867, "\"", 1924, 4);
            WriteAttributeValue("", 1874, "/kitap/", 1874, 7, true);
#nullable restore
#line 37 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
WriteAttributeValue("", 1881, Model.pageInfo.CurrentCategory, 1881, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1912, "?page=", 1912, 6, true);
#nullable restore
#line 37 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
WriteAttributeValue("", 1918, i+1, 1918, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 38 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                           </li>\r\n");
#nullable restore
#line 41 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Ahmet\source\repos\EBookApps\EBook\Views\Home\BookList.cshtml"
                                         
                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \r\n                                </ul>\r\n                            </nav>\r\n                        </div>\r\n                    </div>\r\n        </div>      \r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591