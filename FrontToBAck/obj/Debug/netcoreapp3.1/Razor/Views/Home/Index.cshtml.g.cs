#pragma checksum "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f88718ab1da293f9c01685e127c9faaefc8b4f2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\_ViewImports.cshtml"
using FrontToBAck.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\_ViewImports.cshtml"
using FrontToBAck.ViewsModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88718ab1da293f9c01685e127c9faaefc8b4f2b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04fa11b95f6c4c59b75e159a1305077a31094523", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- SLIDER START -->\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 10 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
         if (TempData["Success"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"successAlert\" class=\"alert alert-success\">");
#nullable restore
#line 12 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                                                          Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 13 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<section id=\"slider\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg\">\r\n                <div class=\"SliderItem position-absolute\">\r\n                    <h3>\r\n                        ");
#nullable restore
#line 24 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.SliderDesc.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                    <p>");
#nullable restore
#line 26 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                  Write(Model.SliderDesc.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f88718ab1da293f9c01685e127c9faaefc8b4f2b5917", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 683, "~/img/", 683, 6, true);
#nullable restore
#line 27 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 689, Model.SliderDesc.ImageUrl, 689, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"Slider\">\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n<!-- SLIDER END -->\r\n<!-- PRODUCTS_F START -->\r\n\r\n<input id=\"count\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 957, "\"", 986, 1);
#nullable restore
#line 40 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
WriteAttributeValue("", 965, ViewBag.ProductCount, 965, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
<section id=""products_main"">
    <div class=""container"">
        <div class=""row pt-5"">
            <div class=""col-12 d-flex justify-content-between"">
                <ul class=""category-mobile d-md-none list-unstyled"">
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1270, "\"", 1277, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                        <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1496, "\"", 1503, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 51 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                             foreach (var item in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1671, "\"", 1678, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 53 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                                                   Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 53 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 54 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </li>\r\n                </ul>\r\n                <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1942, "\"", 1949, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2005, "\"", 2012, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"popular\">Popular</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2076, "\"", 2083, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"winter\">Winter</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2145, "\"", 2152, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"various\">Various</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2216, "\"", 2223, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"exotic\">Exotic</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2285, "\"", 2292, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"green\">Greens</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2353, "\"", 2360, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cactuse\">Cactuses</a></li>\r\n                </ul>\r\n                <ul class=\"list-unstyled\">\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2518, "\"", 2525, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" id=\"productrow\">\r\n            ");
#nullable restore
#line 77 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>

        <div class=""row justify-content-center mt-3"">
            <button id=""loadMore"" class=""btn btn-success"">Load more..</button>
        </div>
    </div>
</section>

<!-- PRODUCTS_F END -->
<!-- ABOUT START -->
<section id=""about"">
    <div class=""container py-5"">
        <div class=""row py-5"">
            <div class=""col-lg-6"">
                <div class=""img"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 3219, "\"", 3247, 1);
#nullable restore
#line 94 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
WriteAttributeValue("", 3226, Model.About.VideoUrl, 3226, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f88718ab1da293f9c01685e127c9faaefc8b4f2b13246", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3259, "~/img/", 3259, 6, true);
#nullable restore
#line 94 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3265, Model.About.ImageUrl, 3265, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                    <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                        <i class=""fas fa-play fa-lg"" style=""color:#f34f3f;""></i>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                    ");
#nullable restore
#line 102 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
               Write(Html.Raw(Model.About.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p class=\"py-3\">\r\n                        ");
#nullable restore
#line 104 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                   Write(Model.About.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li class=\"mt-3\">\r\n                            <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 4025, "\"", 4031, 0);
            EndWriteAttribute();
            WriteLiteral("> Hand picked just\r\n                            for you.\r\n                        </li>\r\n                        <li class=\"mt-3\">\r\n                            <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 4238, "\"", 4244, 0);
            EndWriteAttribute();
            WriteLiteral("> Unique flower\r\n                            arrangements\r\n                        </li>\r\n                        <li class=\"mt-3\">\r\n                            <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 4452, "\"", 4458, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Best way to say
                            you care.
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- ABOUT END -->
<!-- Flower Experts START -->
<section id=""experts"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"" style=""text-align: center;"">
                    <h2 style=""font-size: 38px; font-family: playfair display,serif;"">Flower Experts</h2>
                    <p class=""text-black-50"" style=""font-size: 18px;"">
                        A perfect blend of creativity, energy, communication, happiness and
                        love. Let us arrange
                        a smile for you.
                    </p>
                </div>
            </div>
        </div>
        <div class=""row pb-5"">
");
#nullable restore
#line 142 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
             foreach (var item in Model.Experts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3\">\r\n                    <div class=\"item text-center\">\r\n                        <div class=\"img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f88718ab1da293f9c01685e127c9faaefc8b4f2b18248", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5641, "~/img/", 5641, 6, true);
#nullable restore
#line 147 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5647, item.ImageUrl, 5647, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"text mt-3\">\r\n                            <h6>");
#nullable restore
#line 150 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                           Write(item.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p class=\"text-black-50\">");
#nullable restore
#line 151 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                                                Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 155 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3\"></div>\r\n            <div class=\"col-lg-3\"></div>\r\n            <div class=\"col-lg-3\"></div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Flower Experts END -->\r\n<!-- SUBSCRIBE START -->\r\n\r\n<section id=\"subscribe\"");
            BeginWriteAttribute("style", " style=\"", 6257, "\"", 6342, 4);
            WriteAttributeValue("", 6265, "background:", 6265, 11, true);
            WriteAttributeValue(" ", 6276, "url(../img/", 6277, 12, true);
#nullable restore
#line 165 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
WriteAttributeValue("", 6288, Model.Subscribe.ImageUrl, 6288, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6313, ");background-attachment:fixed", 6313, 29, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container py-5\">\r\n        <div class=\"row py-5\">\r\n            <div class=\"col-12\">\r\n                <div class=\"content text-center py-5\">\r\n                    <h3>");
#nullable restore
#line 170 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                   Write(Model.Subscribe.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                        <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                        <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- SUBSCRIBE END -->
<!-- BLOG START -->
<section id=""blog"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"" style=""text-align: center;"">
                    <h1 style=""font-family: playfair display ,serif;"">From our Blog</h1>
                    <p style=""font-size: 18px;"" class=""text-black-50"">
                        A perfect blend of creativity, energy, communication, happiness and
                        love. Let us arrange
                        a smile for you.
   ");
            WriteLiteral("                 </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pb-5\">\r\n");
#nullable restore
#line 198 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
             foreach (var item in Model.Blogs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4\">\r\n                    <div class=\"item\">\r\n                        <div class=\"img position-relative\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f88718ab1da293f9c01685e127c9faaefc8b4f2b23741", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7938, "~/img/", 7938, 6, true);
#nullable restore
#line 203 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7944, item.ImageUrl, 7944, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                <span>");
#nullable restore
#line 205 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                                 Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"text mt-3 text-center px-5\">\r\n                            <h5>");
#nullable restore
#line 209 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"text-black-50\">\r\n                                ");
#nullable restore
#line 211 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                           Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 216 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<!-- BLOG END -->
<!-- SLIDER_2 START-->
<section id=""slider_2"">
    <div class=""container"">
        <div class=""row py-5 justify-content-center"">
            <div class=""col-md-8 col-xl-6"">
                <div class=""owl-carousel slider2"">
");
#nullable restore
#line 227 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                     foreach (var item in Model.BlogSliders)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <div class=\"item text-center\">\r\n                                <div class=\"img d-flex justify-content-center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f88718ab1da293f9c01685e127c9faaefc8b4f2b27541", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9145, "~/img/", 9145, 6, true);
#nullable restore
#line 232 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9151, item.ImageUrl, 9151, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"text text-muted pt-3 pb-5\">\r\n                                    <i>\r\n                                        ");
#nullable restore
#line 236 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                                   Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </i>\r\n                                </div>\r\n                                <div class=\"author\">\r\n                                    <h6>");
#nullable restore
#line 240 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <p class=\"text-black-50\">");
#nullable restore
#line 241 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                                                        Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 245 "B:\Asp.Net\FrontToBAck\FrontToBAck\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- SLIDER_2 END -->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n    let successAlert = document.getElementById(\"successAlert\");\r\n    setTimeout(() => {\r\n        successAlert.remove();\r\n    },3000)\r\n    </script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
