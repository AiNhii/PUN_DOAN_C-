#pragma checksum "D:\Năm3_hk1\DoAn\C#\Web_db\Views\Shared\_UserLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32bb08c429bf0ec00fc16fe29a30a44fb829a781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserLayout), @"mvc.1.0.view", @"/Views/Shared/_UserLayout.cshtml")]
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
#line 1 "D:\Năm3_hk1\DoAn\C#\Web_db\Views\_ViewImports.cshtml"
using Web_db;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Năm3_hk1\DoAn\C#\Web_db\Views\_ViewImports.cshtml"
using Web_db.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32bb08c429bf0ec00fc16fe29a30a44fb829a781", @"/Views/Shared/_UserLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0fa31243d4561dbe10417b197458ac657a23be", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UserLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32bb08c429bf0ec00fc16fe29a30a44fb829a7813835", async() => {
                WriteLiteral(@"
    <title></title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" type=""text/css"" href=""./User/asset/css/StyleHome.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""./User/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""./User/font-awesome/css/fontawesome-all.css"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">

");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32bb08c429bf0ec00fc16fe29a30a44fb829a7815341", async() => {
                WriteLiteral("\r\n    <!-- menu -->\r\n    <nav class=\"navbar navbar-expand-lg navbar-light bg-light sticky-top\">\r\n\r\n        <a class=\"navbar-brand\" href=\"./index.html\"><img src=\"./User/asset/img/logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 748, "\"", 754, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""25%""></a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
	    <span class=""navbar-toggler-icon""></span>
	  </button>

        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">BEST SELLER</a>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" href=""#"" id=""navbarDropdown"">
	        MAKE UP
	        </a>
                    <div class=""dropdown-content"">
                        <a class=""dropdown-item"" href=""#"">Face</a>
                        <a class=""dropdown-item"" href=""#"">Eye</a>
                        <a class=""dropdown-item"" href=""#"">Lip</a>
                    </div>
                </li>
                <li class=""");
                WriteLiteral(@"nav-item"">
                    <a class=""nav-link"" href=""#"">SKINCARE</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">SPECIAL</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""./about.html"">EXPLORE</a>
                </li>

            </ul>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32bb08c429bf0ec00fc16fe29a30a44fb829a7817467", async() => {
                    WriteLiteral(@"
                <input class=""form-control mr-sm-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                <button class=""btn btn-outline-success my-2 my-sm-0"" type=""submit"">Search</button>
                <div class=""others"">
                    <li><i class=""fa fa-shopping-cart"" aria-hidden=""true""></i></li>
                    <li><i class=""fa fa-user"" aria-hidden=""true""></i></li>
                </div>
            ");
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
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </nav>\r\n    <!-- end menu -->\r\n     <div class=\"container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 65 "D:\Năm3_hk1\DoAn\C#\Web_db\Views\Shared\_UserLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

   
    <!--FOOTER-->
    <!-- Footer -->
    <footer class=""text-center text-lg-start bg-light text-muted"">
        <!-- Section: Social media -->
        <section class=""d-flex justify-content-center justify-content-lg-between p-4 border-bottom"">
            <!-- Left -->
            <div class=""me-5 d-none d-lg-block"">
                <span></span>
            </div>
            <!-- Left -->

            <!-- Right -->
            <div>
                <a");
                BeginWriteAttribute("href", " href=\"", 3324, "\"", 3331, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n                    <i class=\"fab fa-facebook-f\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 3454, "\"", 3461, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n                    <i class=\"fab fa-twitter\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 3581, "\"", 3588, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n                    <i class=\"fab fa-google\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 3707, "\"", 3714, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n                    <i class=\"fab fa-instagram\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 3836, "\"", 3843, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n                    <i class=\"fab fa-linkedin\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 3964, "\"", 3971, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""me-4 text-reset"">
                    <i class=""fab fa-github""></i>
                </a>
            </div>
            <!-- Right -->
        </section>
        <!-- Section: Social media -->

        <!-- Section: Links  -->
        <section");
                BeginWriteAttribute("class", " class=\"", 4232, "\"", 4240, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""container text-center text-md-start mt-5"">
                <!-- Grid row -->
                <div class=""row mt-3"">
                    <!-- Grid column -->
                    <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"">
                        <!-- Content -->
                        <h4 class=""text-uppercase fw-bold mb-4"">
                            <img src=""./User/asset/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 4676, "\"", 4682, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""30%"">Pun Cosmetic
                        </h4>
                        <p>
                            Here you can use rows and columns to organize your footer content. Lorem ipsum dolor sit amet, consectetur adipisicing elit.
                        </p>
                    </div>
                    <!-- Grid column -->

                    <!-- Grid column -->
                    <div class=""col-md-2 col-lg-2 col-xl-2 mx-auto mb-4"">
                        <!-- Links -->
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            Products
                        </h6>
                        <p>
                            <a href=""#!"" class=""text-reset"">Angular</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">React</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Vue</a>
                        </p>");
                WriteLiteral(@"
                        <p>
                            <a href=""#!"" class=""text-reset"">Laravel</a>
                        </p>
                    </div>
                    <!-- Grid column -->

                    <!-- Grid column -->
                    <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mb-4"">
                        <!-- Links -->
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            Useful links
                        </h6>
                        <p>
                            <a href=""#!"" class=""text-reset"">Pricing</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Settings</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Orders</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Help</a>
                        </p>");
                WriteLiteral(@"
                    </div>
                    <!-- Grid column -->

                    <!-- Grid column -->
                    <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4"">
                        <!-- Links -->
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            Contact
                        </h6>
                        <p><i class=""fas fa-home me-3""></i> New York, NY 10012, US</p>
                        <p>
                            <i class=""fas fa-envelope me-3""></i> info@example.com
                        </p>
                        <p><i class=""fas fa-phone me-3""></i> + 01 234 567 88</p>
                        <p><i class=""fas fa-print me-3""></i> + 01 234 567 89</p>
                    </div>
                    <!-- Grid column -->
                </div>
                <!-- Grid row -->
            </div>
        </section>
        <!-- Section: Links  -->

        <!-- Copyright -->
        <div class=""text");
                WriteLiteral(@"-center p-4 copy"" style=""background-color: #3C7363;"">
            © 2021 Copyright:
            <a class=""text-reset fw-bold copy"" href=""https://mdbootstrap.com/"">puncosmetic.com</a>
        </div>
        <!-- Copyright -->
    </footer>
    <!-- Footer -->




    <!-- Load jquery trước khi load bootstrap js -->
    <script src=""./User/asset/js/jquery-3.3.1.min.js""></script>
    <script src=""./User/bootstrap/js/bootstrap.min.js""></script>

    <script>
        $(document).ready(function() {
            $("".wish-icon i"").click(function() {
                $(this).toggleClass(""fa-heart fa-heart-o"");
            });
        });
    </script>
    <script>
        var countDownDate = new Date(Date.parse(new Date()) + 6 * 24 * 60 * 60 * 1000);

        // Update the count down every 1 second
        var x = setInterval(function() {

            // Get todays date and time
            var now = new Date().getTime();

            // Find the distance between now and the count down dat");
                WriteLiteral(@"e
            var distance = countDownDate - now;

            // Time calculations for days, hours, minutes and seconds
            var days = Math.floor(distance / (1000 * 60 * 60 * 24));
            var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
            var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
            var seconds = Math.floor((distance % (1000 * 60)) / 1000);


            // Display the result in the element with id=""demo""


            var dealday = document.getElementById('dealday');
            if (dealday != null) {
                document.getElementById(""dealdays"").innerHTML = days;
                document.getElementById(""dealhours"").innerHTML = hours;
                document.getElementById(""dealminutes"").innerHTML = minutes;
                document.getElementById(""dealseconds"").innerHTML = seconds;
                // If the count down is finished, write some text
                if (distance < 0) {
       ");
                WriteLiteral("             clearInterval(x);\r\n                    document.getElementById(\"dealday\").innerHTML = \"EXPIRED\";\r\n                }\r\n            }\r\n        }, 1000);\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
