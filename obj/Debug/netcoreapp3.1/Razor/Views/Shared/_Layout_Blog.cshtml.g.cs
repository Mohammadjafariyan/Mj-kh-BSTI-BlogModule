#pragma checksum "D:\mohammad\workplace\1400\shared\BlogModule\Views\Shared\_Layout_Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9700ee9bf9ba3d88a3606bab957308c3b0abf731"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout_Blog), @"mvc.1.0.view", @"/Views/Shared/_Layout_Blog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9700ee9bf9ba3d88a3606bab957308c3b0abf731", @"/Views/Shared/_Layout_Blog.cshtml")]
    public class Views_Shared__Layout_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9700ee9bf9ba3d88a3606bab957308c3b0abf7313102", async() => {
                WriteLiteral("\r\n\r\n    <title>");
#nullable restore
#line 6 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Shared\_Layout_Blog.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 293, "\"", 303, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 330, "\"", 340, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <link href=\"/css/site.css\" rel=\"stylesheet\"/>\r\n\r\n    <!-- Custom fonts for this template-->\r\n    <link href=\"/_content/ContentModule/adminTheme/vendor/fontawesome-free/css/all.min.css\" rel=\"stylesheet\" type=\"text/css\">\r\n");
                WriteLiteral("\r\n    <!-- Custom styles for this template-->\r\n    <link href=\"/_content/ContentModule/adminTheme/css/sb-admin-2.min.css\" rel=\"stylesheet\">\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9700ee9bf9ba3d88a3606bab957308c3b0abf7315333", async() => {
                WriteLiteral(@"

<!-- Page Wrapper -->
<div id=""wrapper"">

<!-- Sidebar -->
<ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

    <!-- Sidebar - Brand -->
    <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""/BlogHome"">
        <div class=""sidebar-brand-icon rotate-n-15"">
            <i class=""fas fa-laugh-wink""></i>
        </div>
        <div class=""sidebar-brand-text mx-3"">ماژول وبلاگ <sup>2</sup></div>
    </a>

    <!-- Divider -->
    <hr class=""sidebar-divider my-0"">

    <!-- Nav Item - Dashboard -->
    <li class=""nav-item active"">
        <a class=""nav-link"" href=""/BlogHome"">
            <i class=""fas fa-fw fa-tachometer-alt""></i>
            <span>داشبورد</span>
        </a>
    </li>

    <!-- Divider -->
    <hr class=""sidebar-divider"">

    <!-- Heading -->
    <div class=""sidebar-heading"">
        مرکز پشتیبانی (Help Desk)
    </div>

    <!-- Nav Item - Pages Collapse Menu -->
");
                WriteLiteral(@"    
      <li class=""nav-item"">
            <a class=""nav-link "" href=""/Language"" >
                <i class=""fas fa-fw fa-folder""></i>
                <span>زبان ها</span>
            </a>
        </li>
    <li class=""nav-item"">
            <a class=""nav-link "" href=""/HelpDeskManage"" >
                <i class=""fas fa-fw fa-folder""></i>
                <span>تعریف مرکز پشتیبانی (Help Desk)</span>
            </a>
        </li>
  
    <li class=""nav-item"">
        <a class=""nav-link "" href=""/Category"" >
            <i class=""fas fa-fw fa-folder""></i>
            <span>دسته بندی ها</span>
        </a>
    </li>
    
    <li class=""nav-item"">
        <a class=""nav-link "" href=""/Article"" >
            <i class=""fas fa-fw fa-folder""></i>
            <span>مقالات مرکز پشتیبانی</span>
        </a>
    </li>
    
    
     <hr class=""sidebar-divider"">
    
        <!-- Heading -->
        <div class=""sidebar-heading"">
            وبلاگ
        </div>
    
    <li class=""nav-item""");
                WriteLiteral(@">
        <a class=""nav-link "" href=""/editor"" >
            <i class=""fas fa-fw fa-folder""></i>
            <span>لیست صفحات سایت</span>
        </a>
    </li>
    
    <li class=""nav-item"">
        <a class=""nav-link "" href=""/Editor/Detail?blogId=0"" >
            <i class=""fas fa-fw fa-folder""></i>
            <span>ایجاد صفحه جدید</span>
        </a>
    </li>
    
    
");
                WriteLiteral("    \r\n    \r\n    <!-- Nav Item - Utilities Collapse Menu -->\r\n");
                WriteLiteral("\r\n");
                WriteLiteral(@"
    <!-- Divider -->
    <hr class=""sidebar-divider d-none d-md-block"">

    <!-- Sidebar Toggler (Sidebar) -->
    <div class=""text-center d-none d-md-inline"">
        <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
    </div>

    <!-- Sidebar Message -->
");
                WriteLiteral(@"
</ul>
<!-- End of Sidebar -->

<!-- Content Wrapper -->
<div id=""content-wrapper"" class=""d-flex flex-column"">

<!-- Main Content -->
<div id=""content"">

<!-- Topbar -->
<nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

");
                WriteLiteral("\r\n</nav>\r\n<!-- End of Topbar -->\r\n\r\n<!-- Begin Page Content -->\r\n<div class=\"container-fluid\">\r\n\r\n    <!-- Page Heading -->\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <h1 class=\"h3 mb-0 text-gray-800\">");
#nullable restore
#line 444 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Shared\_Layout_Blog.cshtml"
                                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n");
                WriteLiteral("    </div>\r\n\r\n    <!-- Content Row -->\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card border-left-primary shadow h-100 py-2\">\r\n                <div class=\"card-body\">\r\n                    ");
#nullable restore
#line 458 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Shared\_Layout_Blog.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
        </div>


    </div>

</div>
<!-- /.container-fluid -->

</div>
<!-- End of Main Content -->

<!-- Footer -->
<footer class=""sticky-footer bg-white"">
    <div class=""container my-auto"">
        <div class=""copyright text-center my-auto"">
            <span>Copyright &copy; Your Website 2020</span>
        </div>
    </div>
</footer>
<!-- End of Footer -->

</div>
<!-- End of Content Wrapper -->

</div>
<!-- End of Page Wrapper -->

<!-- Scroll to Top Button-->
<a class=""scroll-to-top rounded"" href=""#page-top"">
    <i class=""fas fa-angle-up""></i>
</a>

<!-- Logout Modal-->
<div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                <b");
                WriteLiteral(@"utton class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                <a class=""btn btn-primary"" href=""login.html"">Logout</a>
            </div>
        </div>
    </div>
</div>

<!-- Bootstrap core JavaScript-->
<script src=""/_content/ContentModule/adminTheme/vendor/jquery/jquery.min.js""></script>
<script src=""/_content/ContentModule/adminTheme/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

<!-- Core plugin JavaScript-->
<script src=""/_content/ContentModule/adminTheme/vendor/jquery-easing/jquery.easing.min.js""></script>

<!-- Custom scripts for all pages-->
<script src=""/_content/ContentModule/adminTheme/js/sb-admin");
                WriteLiteral(@"-2.min.js""></script>

<!-- Page level plugins -->
<script src=""/_content/ContentModule/adminTheme/vendor/chart.js/Chart.min.js""></script>

<!-- Page level custom scripts -->
<script src=""/_content/ContentModule/adminTheme/js/demo/chart-area-demo.js""></script>
<script src=""/_content/ContentModule/adminTheme/js/demo/chart-pie-demo.js""></script>


");
#nullable restore
#line 531 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Shared\_Layout_Blog.cshtml"
Write(RenderSection("scripts"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
