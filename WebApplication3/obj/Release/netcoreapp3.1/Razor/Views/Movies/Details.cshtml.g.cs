#pragma checksum "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55d035d96e35f2d1fa6e43869482643e02b4a749"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d035d96e35f2d1fa6e43869482643e02b4a749", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f8fb492687d67e370226924ce18737b3684a28", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cinemas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Actors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
   ViewData["Title"] = "Movie details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <div class=""card mb-12"">
            <div class=""row g-0"">
                <div class=""col-md-12"">
                    <div class=""card-header text-white bg-info"">
                        <p class=""card-text"">
                            <h5 class=""card-title"">
                                ");
#nullable restore
#line 13 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </h5>\n                        </p>\n                    </div>\n                </div>\n                <div class=\"col-md-4\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 601, "\"", 622, 1);
#nullable restore
#line 19 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
WriteAttributeValue("", 607, Model.ImageUrl, 607, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 636, "\"", 653, 1);
#nullable restore
#line 19 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
WriteAttributeValue("", 642, Model.Name, 642, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                </div>\n                <div class=\"col-md-8\">\n                    <div class=\"card-body\">\n                        <p class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text\">\n                            <b>Cinema: </b>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d035d96e35f2d1fa6e43869482643e02b4a7498232", async() => {
                WriteLiteral("\n                                ");
#nullable restore
#line 27 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                           Write(Model.Cinema.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                                               WriteLiteral(Model.CinemaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </p>\n                        <p class=\"card-text\">\n                            <b>Producer: </b>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d035d96e35f2d1fa6e43869482643e02b4a74911122", async() => {
                WriteLiteral("\n                                ");
#nullable restore
#line 33 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                           Write(Model.Producer.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                                                 WriteLiteral(Model.ProducerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </p>\n                        <p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 36 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                         Write(Model.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text\"><b>Start Date: </b>");
#nullable restore
#line 37 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                           Write(Model.StartDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text\"><b>End Date: </b>");
#nullable restore
#line 38 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                         Write(Model.EndDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text \">\n                            <b>Status: </b>\n");
#nullable restore
#line 41 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                             if (DateTime.Now >= Model.StartDate && DateTime.Now <= Model.EndDate)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge bg-success text-white\">AVAILABLE</span> ");
#nullable restore
#line 43 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                                               }
                else if (DateTime.Now > Model.EndDate)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge bg-danger text-white\">EXPIRED</span> ");
#nullable restore
#line 46 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                                            }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge bg-primary text-white\">UPCOMING</span>");
#nullable restore
#line 49 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </p>\n                        <p class=\"card-text\">\n                            <b>Actors: </b>\n                            <hr />\n                            <div class=\"row\">\n");
#nullable restore
#line 55 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                 foreach (var actor in Model.Actors_Movies)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"column text-center\">\n                        <img class=\"border-info rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 2759, "\"", 2795, 1);
#nullable restore
#line 58 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2765, actor.Actor.ProfilePictureURL, 2765, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\n                        <br />\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d035d96e35f2d1fa6e43869482643e02b4a74917786", async() => {
#nullable restore
#line 60 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                                                                 Write(actor.Actor.FullName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                                          WriteLiteral(actor.ActorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>");
#nullable restore
#line 61 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </p>

                    </div>
                </div>
                <div class=""col-md-12"">
                    <div class=""card-footer"">
                        <p class=""card-text"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d035d96e35f2d1fa6e43869482643e02b4a74920998", async() => {
                WriteLiteral("\n                                Back to List\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d035d96e35f2d1fa6e43869482643e02b4a74922333", async() => {
                WriteLiteral("<i class=\"bi bi-cart-plus\"></i> Add to Cart (Price ");
#nullable restore
#line 76 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                                                                                      Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3470, "btn", 3470, 3, true);
            AddHtmlAttributeValue(" ", 3473, "btn-success", 3474, 12, true);
            AddHtmlAttributeValue(" ", 3485, "text-white", 3486, 11, true);
#nullable restore
#line 73 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
AddHtmlAttributeValue("  ", 3496, (DateTime.Now > Model.EndDate) ? "disabled" : "", 3498, 51, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\lushe\OneDrive\Desktop\E-commerce-System\WebApplication3\Views\Movies\Details.cshtml"
                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </p>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591