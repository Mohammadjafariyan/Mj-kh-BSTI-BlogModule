#pragma checksum "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Save.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "909f0328fbbc3d203c30e49ba9c62532e79fb41e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Save), @"mvc.1.0.view", @"/Views/Category/Save.cshtml")]
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
#line 2 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Save.cshtml"
using AbstractLibrary.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Save.cshtml"
using BigPardakht.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Save.cshtml"
using SignalRMVCChat.Models.weblog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"909f0328fbbc3d203c30e49ba9c62532e79fb41e", @"/Views/Category/Save.cshtml")]
    public class Views_Category_Save : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalRMVCChat.Models.HelpDesk.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Save.cshtml"
  
    ViewBag.Title = "ویرایشگر صفحات سایت";

    Layout = "_Layout_Blog";




#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""/_content/BlogModule/Quill/Quill.css"" rel=""stylesheet""/>
<link href=""/_content/BlogModule/Quill/Highlight.css"" rel=""stylesheet""/>


<a style=""float:left;margin-left:50px"" href=""/Editor/index"">بازگشت به لیست</a>
<form style=""padding: 50px"" method=""post"">
    ");
#nullable restore
#line 25 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Save.cshtml"
Write(await Component.InvokeAsync<FormBuilderViewComponent>(Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n\r\n        <button class=\"btn btn-info\">ذخیره</button>\r\n    </div>\r\n\r\n\r\n</form>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BigPardakht.Data.ApplicationDbContext ApplicationDbContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalRMVCChat.Models.HelpDesk.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
