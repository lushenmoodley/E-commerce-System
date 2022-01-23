#pragma checksum "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38bbb82c1b0a757ca5ce25f656aaced215da8e42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38bbb82c1b0a757ca5ce25f656aaced215da8e42", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml"
   ViewData["Title"] = "All orders"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <p>
            <h4>List of all your orders</h4>
        </p>

        <table class=""table"">
            <thead>
                <tr>
                    <th>Order ID</th>
                    <th>Items</th>
                    <th>Total</th>
                    <th>User</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml"
                 foreach (var order in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 24 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml"
                                        Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">\r\n                        <ul style=\"list-style-type:none\">\r\n");
#nullable restore
#line 27 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml"
                             foreach (var item in order.OrderItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <div class=\"alert alert-info\" role=\"alert\">\r\n                                        <span class=\"badge bg-success\">");
#nullable restore
#line 31 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml"
                                                                  Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> [");
#nullable restore
#line 31 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml"
                                                                                       Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("] - ");
#nullable restore
#line 31 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml"
                                                                                                                    Write(item.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 34 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml"
                   Write(order.OrderItems.Select(m => m.Movie.Price * m.Amount).Sum().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\"> - </td>}\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\lushe\OneDrive\Desktop\WebApplication3\WebApplication3\Views\Orders\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
