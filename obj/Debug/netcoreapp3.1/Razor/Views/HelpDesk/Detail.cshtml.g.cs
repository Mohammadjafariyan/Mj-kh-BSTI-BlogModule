#pragma checksum "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec6ef978977f2a991f2c774ef7e5009ee2d1d4b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelpDesk_Detail), @"mvc.1.0.view", @"/Views/HelpDesk/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec6ef978977f2a991f2c774ef7e5009ee2d1d4b4", @"/Views/HelpDesk/Detail.cshtml")]
    public class Views_HelpDesk_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalRMVCChat.Service.HelpDesk.CategoryArticlesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
  
    ViewBag.Title = "مرکز پشتیبانی";
    Layout = "_HelpDesk_Layout";

 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
.card-text{
color: black;

}

.card-text:hover{
color: black;
text-decoration: none;
}

.cat a {
font-size: 13px !important;
}

.card-text h5{
font-size: 18px !important;

}

.card-text p{
font-size: 13px !important;

}
.cat li {
    font-size: 13.5px;
    line-height: 18px;
    letter-spacing: .4px;
    padding: 5px 0;
    

}

.cat a{
color: #141414;

}

.popularity-text{
padding: 5px;
}
.popularity{
border-left: 1px solid #dddfe2;

}
.popularity-bulbs{
display: flex;
padding: 5px;

}

.text{
    display: flex;
    line-height: 1.5em;
    height: 3em;
    overflow: hidden;
    
    padding-left: 10px;
}
    .popularity-bulb-single{
    background-color: blue;
    width: 3px;
    height: 20px;
    margin: 2px;
    
    }
    
    .card{
   margin-bottom: 30px;
   }
</style>

<div class=""row "" style="" background-color: white;padding: 20px"">


    <div class=""container"">

        <div class=""row"">
        
              ");
            WriteLiteral("      \r\n                    <div class=\"col\">\r\n        \r\n        \r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1271, "\"", 1359, 4);
            WriteAttributeValue("", 1278, "/HelpDesk/Index?websiteBaseUrl=", 1278, 31, true);
#nullable restore
#line 95 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 1309, TempData["websiteBaseUrl"], 1309, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1336, "&lang=", 1336, 6, true);
#nullable restore
#line 95 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 1342, TempData["lang"], 1342, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-light"">
                            <i class=""fas fa-arrow-left"" aria-hidden=""true""></i>
                            بازگشت
                        </a>
        
                    </div>
        
                    <div class=""col"" style=""border-right: 2px solid #d3d7dd;padding-top: 7px"">
        
                        
                    </div><div class=""col-md-4"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 1789, "\"", 1913, 6);
            WriteAttributeValue("", 1796, "/HelpDesk/Detail?categoryTitle=", 1796, 31, true);
#nullable restore
#line 106 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 1827, Model.Category.Name, 1827, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1847, "&websiteBaseUrl=", 1847, 16, true);
#nullable restore
#line 106 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 1863, TempData["websiteBaseUrl"], 1863, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1890, "&lang=", 1890, 6, true);
#nullable restore
#line 106 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 1896, TempData["lang"], 1896, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" >");
#nullable restore
#line 106 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
                                                                                                                                                                            Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        <b>مقالات مربوط به</b>
        
                    </div>
        
                    
                    
        
                </div>

    </div>

</div>


<div class=""container"" style=""padding-right: 10%;
                                  padding-left: 10%;"">

        
    <div class=""row"" style=""margin-top: 50px"">
        
        <div class=""col-md-9"">
                  
");
#nullable restore
#line 129 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
             for (int i = 0; i < Model.Articles.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\" style=\"color: black;text-align: center\">\r\n                    <div class=\"card-body\">\r\n                        <a  class=\"card-text\"");
            BeginWriteAttribute("style", " style=\"", 2639, "\"", 2647, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", "  href=\"", 2648, "\"", 2770, 6);
            WriteAttributeValue("", 2656, "/HelpDesk/Article?title=", 2656, 24, true);
#nullable restore
#line 133 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 2680, Model.Articles[i].Title, 2680, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2704, "&websiteBaseUrl=", 2704, 16, true);
#nullable restore
#line 133 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 2720, TempData["websiteBaseUrl"], 2720, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2747, "&lang=", 2747, 6, true);
#nullable restore
#line 133 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 2753, TempData["lang"], 2753, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h5 >\r\n                                    \r\n                                <b>");
#nullable restore
#line 136 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
                              Write(Model.Articles[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                            </h5>
                                
                              
                            <div style=""display: flex;"">
                                <div class=""text"" style=""width: 80%;"">
                                    <p>");
#nullable restore
#line 142 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
                                  Write(Html.Raw(Model.Articles[i].Summary));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                                <div class=""popularity"" style=""/* padding-left: 20px; *//* padding-left: 10px; */"">
                                                              
                                                              
                                    <div class=""popularity-text"">
                                        very popular
                                    </div>
                                    <div class=""popularity-bulbs"">
                                                                  
                                        <div class=""popularity-bulb-single""></div>
                                        <div class=""popularity-bulb-single""></div>
                                        <div class=""popularity-bulb-single""></div>
                                        <div class=""popularity-bulb-single""></div></div>
                                                              
                          ");
            WriteLiteral("      </div>\r\n                            </div>\r\n        \r\n                        </a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 163 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        
        
        </div>
        <div class=""col-md-3"" style=""text-align: right;
        border-left: 2px solid #dddfe2"">
        
            <h5 style=""padding-bottom: 10px"">
                <b>دسته بندی ها</b>
            </h5>
            <ul class=""cat"" style=""text-decoration: none;list-style-type: none;"">
        
");
#nullable restore
#line 175 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
                 foreach (var rel in Model.Cateogies)
                {
                                          

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4910, "\"", 5023, 6);
            WriteAttributeValue("", 4917, "/HelpDesk/Detail?categoryTitle=", 4917, 31, true);
#nullable restore
#line 179 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 4948, rel.Name, 4948, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4957, "&websiteBaseUrl=", 4957, 16, true);
#nullable restore
#line 179 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 4973, TempData["websiteBaseUrl"], 4973, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5000, "&lang=", 5000, 6, true);
#nullable restore
#line 179 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
WriteAttributeValue("", 5006, TempData["lang"], 5006, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">\r\n                            <b>");
#nullable restore
#line 180 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
                          Write(rel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 183 "D:\mohammad\workplace\1400\shared\BlogModule\Views\HelpDesk\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n            </ul>\r\n        \r\n        </div>\r\n        \r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalRMVCChat.Service.HelpDesk.CategoryArticlesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591