#pragma checksum "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b18788b44dd2c2c4ce358bb91d6ce0ca08aa174"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Search), @"mvc.1.0.view", @"/Views/Blog/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Search.cshtml", typeof(AspNetCore.Views_Blog_Search))]
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
#line 1 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes;

#line default
#line hidden
#line 2 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models;

#line default
#line hidden
#line 3 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Views.Manage;

#line default
#line hidden
#line 5 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.ManageViewModel;

#line default
#line hidden
#line 6 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.CategoryViewModels;

#line default
#line hidden
#line 7 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.PostsViewModel;

#line default
#line hidden
#line 8 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.PhotosViewModels;

#line default
#line hidden
#line 9 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.ViewComponentsViewModels;

#line default
#line hidden
#line 10 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.AdminViewModels;

#line default
#line hidden
#line 11 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.UserManagementViewModels;

#line default
#line hidden
#line 12 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b18788b44dd2c2c4ce358bb91d6ce0ca08aa174", @"/Views/Blog/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72619efaeb64bdc0d0475c2b92c508c3d7da4a67", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search For All The Blog Posts...."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("categoryFind"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/anime3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar img-raised"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
  
    ViewData["Title"] = "Search for: " + Model.Search;
    ViewBag.Description = "Search Results for the search query: " + Model.Search;

#line default
#line hidden
            BeginContext(172, 253, true);
            WriteLiteral("\r\n<div class=\"wrapper\">\r\n    <div class=\"page-header page-header-mini\">\r\n        <div class=\"page-header-image\" data-parallax=\"true\"></div>\r\n        <div class=\"content-center\">\r\n            <div class=\"container\">\r\n                <h2 class=\"category\">");
            EndContext();
            BeginContext(426, 19, false);
#line 12 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                                Write(ViewBag.Description);

#line default
#line hidden
            EndContext();
            BeginContext(445, 230, true);
            WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"main\">\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-center my-5\">\r\n            <div class=\"col-md-10 mx-auto\">\r\n                ");
            EndContext();
            BeginContext(675, 630, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a4dde6b9bf549cbade7f6e7b404933d", async() => {
                BeginContext(782, 73, true);
                WriteLiteral("\r\n                    <div class=\"input-group\">\r\n                        ");
                EndContext();
                BeginContext(855, 114, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7e2b2d84147c442cb8c09519e19f7d2e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 24 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Search);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(969, 329, true);
                WriteLiteral(@"
                        <div class=""input-group-append"">
                            <button type=""submit"" class=""input-group-text"">
                                <i class=""now-ui-icons ui-1_zoom-bold""></i>
                            </button>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Search", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                                                               WriteLiteral(Model.Search);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Search"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Search", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Search"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1305, 70, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row mb-3\">\r\n");
            EndContext();
#line 35 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
             if (!Model.PostsIndexViewModels.Any())
            {

#line default
#line hidden
            BeginContext(1443, 534, true);
            WriteLiteral(@"                <div class=""col-md-10 mx-auto"">
                    <div class=""alert alert-danger"" role=""alert"">
                        <div class=""container"">
                            <div class=""alert-icon"">
                                <i class=""now-ui-icons objects_support-17""></i>
                            </div>
                            <strong>Arrggh Sorry</strong> We couldn't find the blog post you were looking for...
                        </div>
                    </div>
                </div>
");
            EndContext();
#line 47 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
            }
            else
            {
                

#line default
#line hidden
#line 50 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                 foreach (var post in Model.PostsIndexViewModels)
                {

                    var src = $"/api/Images/{post.ImageUrl}";

#line default
#line hidden
            BeginContext(2176, 218, true);
            WriteLiteral("                    <div class=\"col-md-4 col-lg-4\">\r\n                        <div class=\"card card-plain card-raised card-blog\">\r\n                            <div class=\"card-image\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2394, "\"", 2411, 1);
#line 57 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
WriteAttributeValue("", 2401, post.Link, 2401, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2412, 74, true);
            WriteLiteral(">\r\n                                    <img class=\"img rounded img-raised\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2486, "\"", 2496, 1);
#line 58 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
WriteAttributeValue("", 2492, src, 2492, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2497, 246, true);
            WriteLiteral(" />\r\n                                </a>\r\n                            </div>\r\n                            <div class=\"card-body\">\r\n                                <h6 class=\"category text-primary pull-left\">\r\n                                    ");
            EndContext();
            BeginContext(2743, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29daa7425596485490481ec048d62b17", async() => {
                BeginContext(2889, 13, false);
#line 63 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                                                                                                                                                                                Write(post.Category);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                                                                                                                                                         WriteLiteral(post.Category);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2906, 226, true);
            WriteLiteral("\r\n                                </h6>\r\n                                <h6 class=\"category text-info pull-right\">\r\n                                    <div class=\"stats stats-right\">\r\n                                        ");
            EndContext();
            BeginContext(3133, 37, false);
#line 67 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                                   Write(post.DatePublished.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3170, 220, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </h6>\r\n                                <br />\r\n                                <h4 class=\"card-title\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3390, "\"", 3407, 1);
#line 72 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
WriteAttributeValue("", 3397, post.Link, 3397, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3408, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3410, 10, false);
#line 72 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                                                    Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3420, 143, true);
            WriteLiteral("</a>\r\n                                </h4>\r\n                                <p class=\"card-description\">\r\n                                    ");
            EndContext();
            BeginContext(3564, 16, false);
#line 75 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                               Write(post.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3580, 4, true);
            WriteLiteral(" .<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3584, "\"", 3601, 1);
#line 75 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
WriteAttributeValue("", 3591, post.Link, 3591, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3602, 109, true);
            WriteLiteral(">Read More...</a>\r\n                                </p>\r\n                                <p class=\"author\">\r\n");
            EndContext();
#line 78 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                                     if (!String.IsNullOrWhiteSpace(post.AuthorImage))
                                    {
                                        var avator = $"/api/Images/{post.AuthorImage}";

#line default
#line hidden
            BeginContext(3927, 44, true);
            WriteLiteral("                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3971, "\"", 3984, 1);
#line 81 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
WriteAttributeValue("", 3977, avator, 3977, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3985, 50, true);
            WriteLiteral(" alt=\"Author Image\" class=\"avatar img-raised\" />\r\n");
            EndContext();
#line 82 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4155, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(4195, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3a4634fb8e24968b94698c185556dba", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4254, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 86 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4295, 42, true);
            WriteLiteral("                                    <span>");
            EndContext();
            BeginContext(4338, 11, false);
#line 87 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                                     Write(post.Author);

#line default
#line hidden
            EndContext();
            BeginContext(4349, 143, true);
            WriteLiteral("</span>\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 92 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                }

#line default
#line hidden
#line 92 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(4526, 90, true);
            WriteLiteral("        </div>\r\n        <div class=\"row d-flex justify-content-center my-4\">\r\n            ");
            EndContext();
            BeginContext(4616, 242, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c248b8cd7444c6cb0268098830f2f4c", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Search", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
                         WriteLiteral(Model.Search);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["Search"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Search", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["Search"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 98 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model.PostsIndexViewModels;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 99 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Blog\Search.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedListRenderOptions.TwitterBootstrapPager4;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4858, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
