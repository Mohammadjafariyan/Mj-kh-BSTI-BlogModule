#pragma checksum "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89808e41144aa0277e6be0d2d358d22a9886069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 2 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Index.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Index.cshtml"
using AbstractLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Index.cshtml"
using AbstractLibrary.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Index.cshtml"
using BigPardakht.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Index.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Index.cshtml"
using SignalRMVCChat.Models.HelpDesk;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89808e41144aa0277e6be0d2d358d22a9886069", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyDataTableResponse<SignalRMVCChat.Models.HelpDesk.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Index.cshtml"
  
    ViewBag.Title = "لیست دسته بندی های صفحات ";
    Layout = "_Layout_Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 20 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Category\Index.cshtml"
Write(await Component.InvokeAsync<TableViewComponent>(new 
    TableVCModel{ 
        table = Model,
        entity = new Category()
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyDataTableResponse<SignalRMVCChat.Models.HelpDesk.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591