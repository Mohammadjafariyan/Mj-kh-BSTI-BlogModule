#pragma checksum "D:\mohammad\workplace\1400\shared\BlogModule\Views\Article\Save.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "871ecfa94e5a9466bc88e081c7e61a34697db66a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Save), @"mvc.1.0.view", @"/Views/Article/Save.cshtml")]
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
#line 1 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Article\Save.cshtml"
using AbstractLibrary.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"871ecfa94e5a9466bc88e081c7e61a34697db66a", @"/Views/Article/Save.cshtml")]
    public class Views_Article_Save : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalRMVCChat.Models.HelpDesk.Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Article\Save.cshtml"
  
    ViewBag.Title = "ثبت مقاله جدید";
    Layout = "_Layout_Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>ثبت مقاله جدید</h2>\r\n\r\n\r\n\r\n<form action=\"/Article/Save\" method=\"post\" >\r\n\r\n    ");
#nullable restore
#line 15 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Article\Save.cshtml"
Write(await Component.InvokeAsync<FormBuilderViewComponent>(Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        <button class=\"btn btn-primary\" type=\"submit\">ارسال</button>\r\n    </div>\r\n\r\n</form>\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalRMVCChat.Models.HelpDesk.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
