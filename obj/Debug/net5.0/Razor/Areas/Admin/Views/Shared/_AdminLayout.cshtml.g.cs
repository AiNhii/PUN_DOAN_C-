#pragma checksum "N:\Framework\WEBAPP\comestic_csharp\Areas\Admin\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9969ccae5590a4c6bf8da303d57b4dddc92c3530"
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
#line 1 "N:\Framework\WEBAPP\comestic_csharp\Areas\Admin\Views\_ViewImports.cshtml"
using comestic_csharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "N:\Framework\WEBAPP\comestic_csharp\Areas\Admin\Views\_ViewImports.cshtml"
using comestic_csharp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "N:\Framework\WEBAPP\comestic_csharp\Areas\Admin\Views\_ViewImports.cshtml"
using comestic_csharp.Areas.Admin.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "N:\Framework\WEBAPP\comestic_csharp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "N:\Framework\WEBAPP\comestic_csharp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
using comestic_csharp.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9969ccae5590a4c6bf8da303d57b4dddc92c3530", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98274e6ec761f60c0efa226c28371157596c351f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("px-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9969ccae5590a4c6bf8da303d57b4dddc92c35307758", async() => {
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
    <link rel=""icon"" href=""./backend/dashboard/asset/images/favicon.svg"" type=""image/x-icon"">

    <!-- font css -->
    <link rel=""stylesheet"" href=""/backend/dashboard/fonts/feather.css"">
    <link rel=""stylesheet"" href=""/backend/dashboard/fonts/fontawesome.css"">
    <link rel=""stylesheet"" href=""/backend/dashboard/fonts/material.css"">

    <!-- vendor css -->
");
                WriteLiteral("    <link rel=\"stylesheet\" href=\"/backend/dashboard/css/style.css\" id=\"main-style-link\">\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9969ccae5590a4c6bf8da303d57b4dddc92c35309926", async() => {
                WriteLiteral(@"
	<!-- [ Pre-loader ] start -->
	<div class=""loader-bg"">
		<div class=""loader-track"">
			<div class=""loader-fill""></div>
		</div>
	</div>
	<!-- [ Pre-loader ] End -->
	<!-- [ Mobile header ] start -->
	<div class=""pc-mob-header pc-header"">
		<div class=""pcm-logo"">
			<img src=""/backend/dashboard/images/logo.svg""");
                BeginWriteAttribute("alt", " alt=\"", 1686, "\"", 1692, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""logo logo-lg"">
		</div>
		<div class=""pcm-toolbar"">
			<a href=""#!"" class=""pc-head-link"" id=""mobile-collapse"">
				<div class=""hamburger hamburger--arrowturn"">
					<div class=""hamburger-box"">
						<div class=""hamburger-inner""></div>
					</div>
				</div>
			</a>
			<a href=""#!"" class=""pc-head-link"" id=""headerdrp-collapse"">
				<i data-feather=""align-right""></i>
			</a>
			<a href=""#!"" class=""pc-head-link"" id=""header-collapse"">
				<i data-feather=""more-vertical""></i>
			</a>
		</div>
	</div>
	<!-- [ Mobile header ] End -->

	<!-- [ navigation menu ] start -->
	<nav class=""pc-sidebar "">
		<div class=""navbar-wrapper"">
			<div class=""m-header"">
				<a href=./Admin/Dashboard"" class=""b-brand"">
					<!-- ========   change your logo hear   ============ -->
					<img src=""./backend/dashboard/images/logo.svg""");
                BeginWriteAttribute("alt", " alt=\"", 2541, "\"", 2547, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"logo logo-lg\">\r\n\t\t\t\t\t<img src=\"./backend/dashboard/images/logo-sm.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 2626, "\"", 2632, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""logo logo-sm"">
				</a>
			</div>
			<div class=""navbar-content"">
				<ul class=""pc-navbar"">
					<li class=""pc-item pc-caption"">
						<label>NAVIGATION</label>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Dashboard</span></a>
					</li>
					<li class=""pc-item pc-caption"">
						<label>SHOP</label>
						<span>things to manage</span>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Banners</span><span class=""pc-arrow""><i data-feather=""chevron-right""></i></span></a>
						<ul class=""pc-submenu"">
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Add banner</a></li>
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Banner</a></li>
						</ul>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a hr");
                WriteLiteral(@"ef=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Category</span><span class=""pc-arrow""><i data-feather=""chevron-right""></i></span></a>
						<ul class=""pc-submenu"">
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Add Category</a></li>
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Category</a></li>
						</ul>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Brands</span><span class=""pc-arrow""><i data-feather=""chevron-right""></i></span></a>
						<ul class=""pc-submenu"">
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Add brand</a></li>
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Brands</a></li>
						</ul>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt<");
                WriteLiteral(@"/i></span><span class=""pc-mtext"">Products</span><span class=""pc-arrow""><i data-feather=""chevron-right""></i></span></a>
						<ul class=""pc-submenu"">
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Add product</a></li>
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Products</a></li>
						</ul>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Orders</span></a>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Reviews</span></a>
					</li>
					<li class=""pc-item pc-caption"">
						<label>BLOG</label>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Posts</span></a>
						<ul class=""p");
                WriteLiteral(@"c-submenu"">
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Add post</a></li>
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Posts</a></li>
						</ul>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Category</span></a>
						<ul class=""pc-submenu"">
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Add Category</a></li>
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Category</a></li>
						</ul>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Tags</span></a>
						<ul class=""pc-submenu"">
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Add tags</a></li>
							<li class=""pc-item""><a class=""pc-link"" href=""#!"">Tags</a></li>
						</ul>
					</li>
					<li class=""pc-item pc-hasmenu"">
					");
                WriteLiteral(@"	<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Comments</span></a>
					</li>
					<li class=""pc-item pc-caption"">
						<label>GENERAL SETTINGS</label>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Coupon</span></a>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Users</span></a>
					</li>
					<li class=""pc-item pc-hasmenu"">
						<a href=""#!"" class=""pc-link""><span class=""pc-micon""><i class=""material-icons-two-tone"">list_alt</i></span><span class=""pc-mtext"">Settings</span></a>
					</li>
				</ul>
			</div>
		</div>
	</nav>
	<!-- [ navigation menu ] end -->
	<!-- [ Header ] start -->
	<header class=""pc-header "">
		<div class=""header-wrap");
                WriteLiteral(@"per"">
			<div class=""mr-auto pc-mob-drp"">
				<ul class=""list-unstyled"">
					<li class=""dropdown pc-h-item"">
						<a class=""pc-head-link active dropdown-toggle arrow-none mr-0"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""false"" aria-expanded=""false"">
							Level
						</a>
						<div class=""dropdown-menu pc-h-dropdown"">
							<a href=""#!"" class=""dropdown-item"">
								<i class=""material-icons-two-tone"">account_circle</i>
								<span>My Account</span>
							</a>
							<div class=""pc-level-menu"">
								<a href=""#!"" class=""dropdown-item"">
									<i class=""material-icons-two-tone"">list_alt</i>
									<span class=""float-right""><i data-feather=""chevron-right"" class=""mr-0""></i></span>
									<span>Level2.1</span>
								</a>
								<div class=""dropdown-menu pc-h-dropdown"">
									<a href=""#!"" class=""dropdown-item"">
										<i class=""fas fa-circle""></i>
										<span>My Account</span>
									</a>
									<a href=""#!"" class=""dropdown-item"">
									");
                WriteLiteral(@"	<i class=""fas fa-circle""></i>
										<span>Settings</span>
									</a>
									<a href=""#!"" class=""dropdown-item"">
										<i class=""fas fa-circle""></i>
										<span>Support</span>
									</a>
									<a href=""#!"" class=""dropdown-item"">
										<i class=""fas fa-circle""></i>
										<span>Lock Screen</span>
									</a>
									<a href=""#!"" class=""dropdown-item"">
										<i class=""fas fa-circle""></i>
										<span>Logout</span>
									</a>
								</div>
							</div>
							<a href=""#!"" class=""dropdown-item"">
								<i class=""material-icons-two-tone"">settings</i>
								<span>Settings</span>
							</a>
							<a href=""#!"" class=""dropdown-item"">
								<i class=""material-icons-two-tone"">support</i>
								<span>Support</span>
							</a>
							<a href=""#!"" class=""dropdown-item"">
								<i class=""material-icons-two-tone"">https</i>
								<span>Lock Screen</span>
							</a>
							<a href=""#!"" class=""dropdown-item"">
								<i class=""material-icon");
                WriteLiteral("s-two-tone\">chrome_reader_mode</i>\r\n\t\t\t\t\t\t\t\t<span>Logout</span>\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\r\n");
                WriteLiteral(@"				<div class=""ml-auto"">
					<ul class=""list-unstyled"">
						<li class=""dropdown pc-h-item"">
							<a class=""pc-head-link dropdown-toggle arrow-none mr-0"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""false"" aria-expanded=""false"">
								<i class=""material-icons-two-tone"">search</i>
							</a>
							<div class=""dropdown-menu dropdown-menu-right pc-h-dropdown drp-search"">
								");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9969ccae5590a4c6bf8da303d57b4dddc92c353020399", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group mb-0 d-flex align-items-center\">\r\n\t\t\t\t\t\t\t\t\t\t<i data-feather=\"search\"></i>\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"search\" class=\"form-control border-0 shadow-none\" placeholder=\"Search here. . .\">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t<li class=\"dropdown-item\">\r\n        \t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9969ccae5590a4c6bf8da303d57b4dddc92c353022191", async() => {
                    WriteLiteral("Hello ");
#nullable restore
#line 245 "N:\Framework\WEBAPP\comestic_csharp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
                                                                                                                                           Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
                    WriteLiteral("!");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</span>\r\n    \t\t\t\t\t</li>\r\n\t\t\t\t\t\t<li class=\"dropdown-item\">\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9969ccae5590a4c6bf8da303d57b4dddc92c353024409", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t<button id=\"logout\" type=\"submit\" class=\"nav-link btn btn-link text-dark\">Logout</button>\r\n\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 251 "N:\Framework\WEBAPP\comestic_csharp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
                                                                                                                              WriteLiteral(Url.Action("Index", "Home", new { area = "" }));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t}\r\n\t\t</div>\r\n\t</header>\r\n\t<!-- [ Header ] end -->\r\n    <div class=\"pc-container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 263 "N:\Framework\WEBAPP\comestic_csharp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <script src=""/backend/dashboard/js/vendor-all.min.js""></script>
    <script src=""/backend/dashboard/js/plugins/bootstrap.min.js""></script>
    <script src=""/backend/dashboard/js/plugins/feather.min.js""></script>
    <script src=""/backend/dashboard/js/pcoded.min.js""></script>
    <script src=""/backend/dashboard/asset/js/plugins/apexcharts.min.js""></script>

<!-- custom-chart js -->
    <script src=""/backend/dashboard/js/pages/dashboard-sale.js""></script>
    ");
#nullable restore
#line 275 "N:\Framework\WEBAPP\comestic_csharp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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
