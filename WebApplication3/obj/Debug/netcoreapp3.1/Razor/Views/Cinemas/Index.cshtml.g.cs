#pragma checksum "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e714906da251c7b2bbcc1acae5930408bb91583c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cinemas_Index), @"mvc.1.0.view", @"/Views/Cinemas/Index.cshtml")]
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
#line 1 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e714906da251c7b2bbcc1acae5930408bb91583c", @"/Views/Cinemas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f8fb492687d67e370226924ce18737b3684a28", @"/Views/_ViewImports.cshtml")]
    public class Views_Cinemas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cinema>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
  
    ViewData["Title"] = "List of Cinemas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 12 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 13 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 15 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>Actions</th>\r\n");
#nullable restore
#line 18 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">\r\n                        <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 861, "\"", 877, 1);
#nullable restore
#line 26 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
WriteAttributeValue("", 867, item.Logo, 867, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 878, "\"", 894, 1);
#nullable restore
#line 26 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
WriteAttributeValue("", 884, item.Name, 884, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:150px\" />\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 34 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td class=""align-middle"">
                            <a class=""btn btn-outline-primary""><i class=""bi bi-pencil-square""></i>Edit</a>
                            <a class=""btn btn-outline-info""><i class=""bi bi-eye""></i>Details</a>
                            <a class=""btn btn-outline-danger""><i class=""bi bi-trash""></i>Delete</a>
                        </td>
");
#nullable restore
#line 41 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 49 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Cinemas\Index.cshtml"
Write(await Html.PartialAsync("_CreateItem", "Cinemas"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cinema>> Html { get; private set; }
    }
}
#pragma warning restore 1591
