#pragma checksum "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Areas\Admin\Views\AdminDoctor\Email.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6be3d631a85eae402f0538e3b6be5290b00aa07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminDoctor_Email), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminDoctor/Email.cshtml")]
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
#line 1 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6be3d631a85eae402f0538e3b6be5290b00aa07", @"/Areas/Admin/Views/AdminDoctor/Email.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminDoctor_Email : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Areas\Admin\Views\AdminDoctor\Email.cshtml"
  
    ViewData["Title"] = "Email";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Email</h1>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://smtpjs.com/v3/smtp.js\"></script>     ");
                WriteLiteral(@"
    <script>
        Email.send({
            Host: ""smtp.yourisp.com"",
            Username: ""username"",
            Password: ""password"",
            To: 'them@website.com',
            From: ""you@isp.com"",
            Subject: ""This is the subject"",
            Body: ""And this is the body""
        }).then(
            message => alert(message)
        );
        Email.send({
            SecureToken: ""C973D7AD-F097-4B95-91F4-40ABC5567812"",
            To: 'them@website.com',
            From: ""you@isp.com"",
            Subject: ""This is the subject"",
            Body: ""And this is the body""
        }).then(
            message => alert(message)
        );
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
