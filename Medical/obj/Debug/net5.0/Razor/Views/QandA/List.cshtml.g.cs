#pragma checksum "C:\medical-3.0\Medical\Views\QandA\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be4f44804b2109d39ee0f4b61a21610f5e70c858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_List), @"mvc.1.0.view", @"/Views/QandA/List.cshtml")]
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
#line 1 "C:\medical-3.0\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\medical-3.0\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4f44804b2109d39ee0f4b61a21610f5e70c858", @"/Views/QandA/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QandA_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.Models.Question>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\medical-3.0\Medical\Views\QandA\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid bg-primary py-5 hero-header mb-5"">
    <div class=""row py-3"">
        <div class=""col-12 text-center"">
            <h3 class=""display-3 text-white animated zoomIn"">Q&A常見問題</h3>
        </div>
    </div>
</div>

<div style=""padding: 40px 40px 40px 40px"" id=""change"">
");
#nullable restore
#line 16 "C:\medical-3.0\Medical\Views\QandA\List.cshtml"
      
        int count = 0;
        foreach (var item in Model)
        {
            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div>
            <div class=""card bg-light mb-3 collapsed-card"" style=""border: 2px solid #32a1ce; border-radius:20px ;cursor:pointer"">
                <div class=""card-header "" style=""display: flex; border:none;"" data-card-widget=""collapse"">
                    <h3 class=""card-title"">");
#nullable restore
#line 24 "C:\medical-3.0\Medical\Views\QandA\List.cshtml"
                                      Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" . ");
#nullable restore
#line 24 "C:\medical-3.0\Medical\Views\QandA\List.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.QuestionContain));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n\r\n                <div class=\"card-body\" style=\"display: none; font-size:20px\">\r\n                    ");
#nullable restore
#line 28 "C:\medical-3.0\Medical\Views\QandA\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <hr>\r\n");
#nullable restore
#line 33 "C:\medical-3.0\Medical\Views\QandA\List.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"../dist/js/adminlte.min.js?v=5.0.0\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.Models.Question>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
