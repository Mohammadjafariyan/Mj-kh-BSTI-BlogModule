#pragma checksum "D:\mohammad\workplace\1400\shared\BlogModule\Views\Shared\HelpDeskSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a2c943c83025e2c6deef33b5cb29fbfdd257360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HelpDeskSearch), @"mvc.1.0.view", @"/Views/Shared/HelpDeskSearch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2c943c83025e2c6deef33b5cb29fbfdd257360", @"/Views/Shared/HelpDeskSearch.cshtml")]
    public class Views_Shared_HelpDeskSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""col-md-6 "">
    
    <form method=""get"" action=""/HelpDesk/Search"">
        <div class=""form-group"" style=""text-align: center"">
            <h4 style=""font-size: 23.4px;    margin-bottom: 20px;"" for=""exampleFormControlInput1"">چطور میتونیم کمکتون کنیم ؟</h4>
  
     
            <input type=""hidden"" name=""websiteBaseUrl""");
            BeginWriteAttribute("value", " value=\"", 361, "\"", 396, 1);
#nullable restore
#line 12 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Shared\HelpDeskSearch.cshtml"
WriteAttributeValue("", 369, TempData["websiteBaseUrl"], 369, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" name=\"lang\"");
            BeginWriteAttribute("value", " value=\"", 445, "\"", 470, 1);
#nullable restore
#line 13 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Shared\HelpDeskSearch.cshtml"
WriteAttributeValue("", 453, TempData["lang"], 453, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>

            <div class=""input-group mb-3"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" style=""background-color: white;border: none"" onclick=""$('form').submit()"">
                        <i class=""fas fa-search"" style=""font-size: 21px""></i>
                    </span>
          
                </div>

                <input name=""searchTerm"" style=""text-align: right;
                         height: 57px;border: none;""
                       dir=""rtl"" type=""text"" class=""form-control"" placeholder=""سوال تون رو اینجا جستجو کنید..."">
            </div>
        </div>

    </form>
    <ul class=""list-group""  style=""display: none;    position: absolute;
                                      width: 95%;
                                      z-index: 999;"">
      <li class=""list-group-item"">Cras justo odio</li>
      <li class=""list-group-item"">Dapibus ac facilisis in</li>
      <li class=""list-group-item"">Morbi leo risus</li>
      <");
            WriteLiteral("li class=\"list-group-item\">Porta ac consectetur ac</li>\r\n      <li class=\"list-group-item\">Vestibulum at eros</li>\r\n    </ul>\r\n</div>");
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
