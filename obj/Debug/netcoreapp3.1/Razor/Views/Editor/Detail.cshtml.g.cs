#pragma checksum "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "817f6da1662fcc9f573381fa694e0d38290a83f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Editor_Detail), @"mvc.1.0.view", @"/Views/Editor/Detail.cshtml")]
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
#line 2 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
using SignalRMVCChat.Models.weblog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"817f6da1662fcc9f573381fa694e0d38290a83f7", @"/Views/Editor/Detail.cshtml")]
    public class Views_Editor_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalRMVCChat.Models.weblog.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n       \r\n          \r\n");
            WriteLiteral("       \r\n");
#nullable restore
#line 8 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
            
           ViewBag.Title = "ویرایشگر صفحات سایت";
       
                Layout = "_Layout_Blog";
       
       

#line default
#line hidden
#nullable disable
            WriteLiteral(@"       
       <link href=""/_content/BlogModule/Quill/Quill.css"" rel=""stylesheet"" />
       <link href=""/_content/BlogModule/Quill/Highlight.css"" rel=""stylesheet"" />
       
       
       
       <a style=""float:left;margin-left:50px"" href=""/Editor/index"">بازگشت به لیست</a>
       <div style=""padding: 50px"">
       
           <div class=""form-group"">
               
               
               <label>عنوان</label>
               <input");
            BeginWriteAttribute("name", " name=\"", 801, "\"", 808, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"titleTemp\"");
            BeginWriteAttribute("value", " value=\"", 824, "\"", 844, 1);
#nullable restore
#line 27 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
WriteAttributeValue("", 832, Model.Title, 832, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n           </div>\r\n           \r\n           \r\n           \r\n       \r\n       \r\n           <div class=\"form-group\">\r\n");
#nullable restore
#line 35 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
                 
                   int type = (int)@Model.Type;
               

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n       \r\n       ");
#nullable restore
#line 40 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
  Write(Html.DropDownList("Type", 
           Html.GetEnumSelectList<BlogType>(),
           "انتخاب صفحه",new { @class = "form-control",@id = "type" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
       
       
               <br/>
               <small style=""color:orange"">در صورت تعریف بیش از یک مطلب برای یک صفحه ، تمامی صفحات نمایش داده خواهند شد</small>
           </div>
     
           
           <div class=""form-group"">
              
");
#nullable restore
#line 52 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
                               
                                 var selectlist= new SelectList(ApplicationDbContext.Categories.ToList(), "Id", "Name", Model.CategoryId);
                             

#line default
#line hidden
#nullable disable
            WriteLiteral("                             ");
#nullable restore
#line 55 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
                        Write(Html.DropDownListFor(b=>b.CategoryId,selectlist
                                  ,"دسته بندی", new
                                 {
                                     @class="form-control"
                                 } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </div>\r\n       \r\n           <div class=\"form-group\">\r\n       \r\n               <div id=\"editor\" style=\"height:350px\">\r\n       \r\n                  ");
#nullable restore
#line 66 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
             Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
               </div>
           </div>
       
       
           <div class=""form-group"">
       
               <button class=""btn btn-info"" onclick=""Save()"">ذخیره</button>
           </div>
       
       
       
       
       
       </div>
       
       <form style=""display:none"" id=""myfo"" method=""post"" action=""/Editor/Save"">
           <input name=""Title"" id=""Title""");
            BeginWriteAttribute("value", " value=\"", 2552, "\"", 2572, 1);
#nullable restore
#line 83 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
WriteAttributeValue("", 2560, Model.Title, 2560, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n           <input name=\"Type\" id=\"Type\"");
            BeginWriteAttribute("value", " value=\"", 2617, "\"", 2625, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n           <input name=\"Id\" id=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 2666, "\"", 2683, 1);
#nullable restore
#line 85 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
WriteAttributeValue("", 2674, Model.Id, 2674, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n           <input name=\"Content\" id=\"Content\"");
            BeginWriteAttribute("value", " value=\"", 2734, "\"", 2756, 1);
#nullable restore
#line 86 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
WriteAttributeValue("", 2742, Model.Content, 2742, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n           <input name=\"CategoryId\" id=\"_CategoryId\"");
            BeginWriteAttribute("value", " value=\"", 2814, "\"", 2839, 1);
#nullable restore
#line 87 "D:\mohammad\workplace\1400\shared\BlogModule\Views\Editor\Detail.cshtml"
WriteAttributeValue("", 2822, Model.CategoryId, 2822, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n       \r\n       \r\n           <input type=\"submit\" />\r\n       </form>\r\n       \r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
       
           <script src=""/_content/BlogModule/Quill/Highlight.js"" type=""text/javascript""></script>
           <script src=""/_content/BlogModule/Quill/Quill.js"" type=""text/javascript""></script>
           <script>
               var quill = new Quill('#editor', {
                   bounds: '#editor',
                   modules: {
                       'syntax': true,
                       'toolbar': [
                           ['bold', 'italic', 'underline', 'strike'],
                           [{ 'color': [] }, { 'background': [] }],
                           [{ 'script': 'super' }, { 'script': 'sub' }],
                           [{ 'header': '1' }, { 'header': '2' }, 'blockquote', 'code-block'],
                           [{ 'list': 'ordered' }, { 'list': 'bullet' }, { 'indent': '-1' }, { 'indent': '+1' }],
                           [{ 'direction': 'rtl' }, { 'align': [] }],
                           ['link', 'image', 'video', 'formula'],
                           ['clean']");
                WriteLiteral(@"
                       ],
                   },
                   theme: 'snow'
               });
       
               function Save() {
       
                   $('#Title').val($('#titleTemp').val())
                   $('#Type').val($('#type').val())
                   
                   
                   
                   
                   
                   $('#_CategoryId').val($('select[name=""CategoryId""]').val())
                   $('#Content').val(quill.root.innerHTML)
       
                   console.log('typpppppppppppppe', $('#myfo').serialize())
       
                   debugger;
                   $('#myfo').submit();
               }
           </script>
       
       
       ");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalRMVCChat.Models.weblog.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
