#pragma checksum "D:\Năm3_hk1\DoAn\C#\WEB_C#\PUN_DOAN_C\Areas\Admin\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db2959509959eb56180230b57867234bfaeded03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
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
#line 1 "D:\Năm3_hk1\DoAn\C#\WEB_C#\PUN_DOAN_C\Areas\Admin\Views\_ViewImports.cshtml"
using comestic_csharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Năm3_hk1\DoAn\C#\WEB_C#\PUN_DOAN_C\Areas\Admin\Views\_ViewImports.cshtml"
using comestic_csharp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Năm3_hk1\DoAn\C#\WEB_C#\PUN_DOAN_C\Areas\Admin\Views\_ViewImports.cshtml"
using comestic_csharp.Areas.Admin.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Năm3_hk1\DoAn\C#\WEB_C#\PUN_DOAN_C\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Năm3_hk1\DoAn\C#\WEB_C#\PUN_DOAN_C\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
using comestic_csharp.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db2959509959eb56180230b57867234bfaeded03", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98274e6ec761f60c0efa226c28371157596c351f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavLayout.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db2959509959eb56180230b57867234bfaeded034784", async() => {
                WriteLiteral(@"
    <title>Dashboard</title>
    <!-- Meta -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""description"" content=""DashboardKit is made using Bootstrap 5 design framework. Download the free admin template & use it for your project."">
    <meta name=""keywords"" content=""DashboardKit, Dashboard Kit, Dashboard UI Kit, Bootstrap 5, Admin Template, Admin Dashboard, CRM, CMS, Free Bootstrap Admin Template"">
    <meta name=""author"" content=""DashboardKit "">

    <!-- Favicon icon -->
    <link rel=""icon"" href=""./backend/dashboard/asset/asset/images/favicon.svg"" type=""image/x-icon"">

    <!-- font css -->
    <link rel=""stylesheet"" href=""/backend/dashboard/asset/fonts/feather.css"">
    <link rel=""stylesheet"" href=""/backend/dashboard/asset/fonts/fontawesome.css"">
    <link rel=""stylesheet"" href=""/backend/dashboard/asset/fonts/material.css"">

 ");
                WriteLiteral("   <!-- vendor css -->\r\n    <link rel=\"stylesheet\" href=\"/backend/dashboard/asset/css/style_Admin.css\" id=\"main-style-link\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db2959509959eb56180230b57867234bfaeded036986", async() => {
                WriteLiteral("\r\n\t<!-- [ Pre-loader ] start -->\r\n");
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db2959509959eb56180230b57867234bfaeded037320", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\r\n\t<!-- [ Header ] end -->\r\n    <div class=\"pc-container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 264 "D:\Năm3_hk1\DoAn\C#\WEB_C#\PUN_DOAN_C\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n");
                WriteLiteral(@"
<!-- custom-chart js -->
    <script src=""/backend/dashboard/asset/js/pages/dashboard-sale.js""></script>
	<script>
		var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle=""tooltip""]'))
		var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
  		return new bootstrap.Tooltip(tooltipTriggerEl)
		})
	</script>
    ");
#nullable restore
#line 282 "D:\Năm3_hk1\DoAn\C#\WEB_C#\PUN_DOAN_C\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ShopUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ShopUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
