#pragma checksum "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cf42357441f591345e8a04132201f10dd98ec31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Search), @"mvc.1.0.view", @"/Views/Gallery/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gallery/Search.cshtml", typeof(AspNetCore.Views_Gallery_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cf42357441f591345e8a04132201f10dd98ec31", @"/Views/Gallery/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72619efaeb64bdc0d0475c2b92c508c3d7da4a67", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhotosListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search For Our Work...."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gallery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
  
    ViewData["Title"] = "Search for: " + Model.Search;
    ViewBag.Description = "Search Results for the search query: " + Model.Search;

#line default
#line hidden
            BeginContext(174, 253, true);
            WriteLiteral("\r\n<div class=\"wrapper\">\r\n    <div class=\"page-header page-header-mini\">\r\n        <div class=\"page-header-image\" data-parallax=\"true\"></div>\r\n        <div class=\"content-center\">\r\n            <div class=\"container\">\r\n                <h2 class=\"category\">");
            EndContext();
            BeginContext(428, 19, false);
#line 12 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
                                Write(ViewBag.Description);

#line default
#line hidden
            EndContext();
            BeginContext(447, 232, true);
            WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"main\">\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-center my-5\">\r\n            <div class=\"col-md-10 mx-auto\">\r\n                ");
            EndContext();
            BeginContext(679, 623, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "397afd9504e848749d8eed034ae288f1", async() => {
                BeginContext(789, 73, true);
                WriteLiteral("\r\n                    <div class=\"input-group\">\r\n                        ");
                EndContext();
                BeginContext(862, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "43134873069c4b5e91742092ab0e92c5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 25 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
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
                BeginContext(966, 329, true);
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
#line 23 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
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
            BeginContext(1302, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 35 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
         if (!Model.Photos.Any())
        {

#line default
#line hidden
            BeginContext(1386, 600, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-10 mx-auto"">
                    <div class=""alert alert-danger"" role=""alert"">
                        <div class=""container"">
                            <div class=""alert-icon"">
                                <i class=""now-ui-icons objects_support-17""></i>
                            </div>
                            <strong>Arrggh Sorry</strong> We Couldn't find what you are looking for. Try To be more specific...
                        </div>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 49 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"

        }
        else
        {

#line default
#line hidden
            BeginContext(2024, 80, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-10 mx-auto\">\r\n");
            EndContext();
#line 55 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
                     foreach (var photo in Model.Photos)
                    {
                        var src = $"/api/Images/{photo.PhotoUrl}";

#line default
#line hidden
            BeginContext(2253, 274, true);
            WriteLiteral(@"                        <div class=""card card-plain card-blog"">
                            <div class=""row"">
                                <div class=""col-md-5"">
                                    <div class=""card-image"">
                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2527, "\"", 2537, 1);
#line 62 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
WriteAttributeValue("", 2533, src, 2533, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2538, 251, true);
            WriteLiteral(" class=\"img img-raised rounded\" />\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-md-7\">\r\n                                    <h6 class=\"category text-primary mt-3\">");
            EndContext();
            BeginContext(2790, 14, false);
#line 66 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
                                                                      Write(photo.Category);

#line default
#line hidden
            EndContext();
            BeginContext(2804, 108, true);
            WriteLiteral("</h6>\r\n                                    <h3 class=\"card-title\">\r\n                                        ");
            EndContext();
            BeginContext(2913, 10, false);
#line 68 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
                                   Write(photo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2923, 151, true);
            WriteLiteral("\r\n                                    </h3>\r\n                                    <p class=\"card-description\">\r\n                                        ");
            EndContext();
            BeginContext(3075, 17, false);
#line 71 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
                                   Write(photo.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3092, 185, true);
            WriteLiteral("\r\n                                    </p>\r\n                                    <p class=\"author\">\r\n                                        <i class=\"now-ui-icons tech_watch-time\"></i> ");
            EndContext();
            BeginContext(3278, 17, false);
#line 74 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
                                                                                Write(photo.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(3295, 152, true);
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 79 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
                    }

#line default
#line hidden
            BeginContext(3470, 119, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"row justify-content-center my-4\">\r\n                ");
            EndContext();
            BeginContext(3589, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dcfe5320e264691a91307bfaf189789", async() => {
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
#line 84 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
                             WriteLiteral(Model.Search);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["Search"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Search", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["Search"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 85 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model.Photos;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 86 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
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
            BeginContext(3832, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 88 "C:\Users\daemo\Documents\MacSlopes\MacSlopes\Views\Gallery\Search.cshtml"
        }

#line default
#line hidden
            BeginContext(3865, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhotosListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
