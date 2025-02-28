#pragma checksum "F:\MacSlopes\MacSlopes\Views\Manage\ShowRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e91a3bb50adaff60206ea0e72fb0b5c263f89d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ShowRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ShowRecoveryCodes.cshtml", typeof(AspNetCore.Views_Manage_ShowRecoveryCodes))]
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
#line 1 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes;

#line default
#line hidden
#line 2 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models;

#line default
#line hidden
#line 3 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.AccountViewModels;

#line default
#line hidden
#line 4 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Views.Manage;

#line default
#line hidden
#line 5 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.ManageViewModel;

#line default
#line hidden
#line 6 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.CategoryViewModels;

#line default
#line hidden
#line 7 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.PostsViewModel;

#line default
#line hidden
#line 8 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.PhotosViewModels;

#line default
#line hidden
#line 9 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.ViewComponentsViewModels;

#line default
#line hidden
#line 10 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.AdminViewModels;

#line default
#line hidden
#line 11 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using MacSlopes.Models.UserManagementViewModels;

#line default
#line hidden
#line 12 "F:\MacSlopes\MacSlopes\Views\_ViewImports.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e91a3bb50adaff60206ea0e72fb0b5c263f89d2", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72619efaeb64bdc0d0475c2b92c508c3d7da4a67", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShowRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\MacSlopes\MacSlopes\Views\Manage\ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Show Recovery Codes";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
            BeginContext(159, 538, true);
            WriteLiteral(@"
<div class=""col-lg-6 col-md-6 ml-auto mr-auto"">
    <div class=""alert alert-warning"" role=""alert"">
        <div class=""container"">
            <div class=""alert-icon"">
                <i class=""now-ui-icons ui-1_simple-remove""></i>
            </div>
            <strong>Put these codes in a safe place.</strong>
            If you lose your device and don't have the recovery codes you will lose access to your account.
        </div>
    </div>
    <div class=""row justify-content-center"">
        <div class=""col-md-12"">
");
            EndContext();
#line 19 "F:\MacSlopes\MacSlopes\Views\Manage\ShowRecoveryCodes.cshtml"
             for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
            {

#line default
#line hidden
            BeginContext(788, 22, true);
            WriteLiteral("                <code>");
            EndContext();
            BeginContext(811, 24, false);
#line 21 "F:\MacSlopes\MacSlopes\Views\Manage\ShowRecoveryCodes.cshtml"
                 Write(Model.RecoveryCodes[row]);

#line default
#line hidden
            EndContext();
            BeginContext(835, 7, true);
            WriteLiteral("</code>");
            EndContext();
            BeginContext(848, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(861, 6, true);
            WriteLiteral("<code>");
            EndContext();
            BeginContext(868, 28, false);
#line 21 "F:\MacSlopes\MacSlopes\Views\Manage\ShowRecoveryCodes.cshtml"
                                                                          Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
            EndContext();
            BeginContext(896, 15, true);
            WriteLiteral("</code><br />\r\n");
            EndContext();
#line 22 "F:\MacSlopes\MacSlopes\Views\Manage\ShowRecoveryCodes.cshtml"
            }

#line default
#line hidden
            BeginContext(926, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
