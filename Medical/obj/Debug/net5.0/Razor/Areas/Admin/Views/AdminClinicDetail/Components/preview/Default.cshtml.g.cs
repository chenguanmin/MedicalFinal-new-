#pragma checksum "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17be847cf63c9a4673035ac3cf83b175b4bf7cdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminClinicDetail_Components_preview_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminClinicDetail/Components/preview/Default.cshtml")]
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
#line 1 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17be847cf63c9a4673035ac3cf83b175b4bf7cdd", @"/Areas/Admin/Views/AdminClinicDetail/Components/preview/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminClinicDetail_Components_preview_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.CClinicDetailAdminViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table id=""tbl_result"" class=""table table-bordered table-striped"" width=""100%"" border=""1"" cellpadding=""0"" cellspacing=""0"" bordercolor=""#CCCCCC"" style=""border-collapse: collapse;"">
    <tr class=""ti_blue titHeight"">
        <td class=""ti_green"">序號</td>
        <td class=""ti_green"">醫生</td>
        <td class=""ti_green"">科目</td>
        <td class=""ti_green"">時段</td>
        <td class=""ti_green"">診間</td>
        <td class=""ti_green"">開診日期</td>
        <td>是否重覆開診</td>
    </tr>
");
#nullable restore
#line 17 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
     if (Model != null)
    {
        int i = 0;
        foreach (var item in Model)
        {
            i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n\r\n                <td>\r\n                    <label name=\"count\">");
#nullable restore
#line 27 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label name=\"doctorName\">");
#nullable restore
#line 30 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
                                        Write(item.doctorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label name=\"deptName\">");
#nullable restore
#line 33 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
                                      Write(item.deptName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label name=\"periodName\">");
#nullable restore
#line 36 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
                                        Write(item.periodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label name=\"RoomId\">");
#nullable restore
#line 39 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
                                    Write(item.RoomId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label name=\"ClinicDate\">");
#nullable restore
#line 42 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
                                        Write(item.ClinicDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 45 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
                      
                        if (@item.repeat)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-pill badge-warning repeat\">已重覆</span>\r\n");
#nullable restore
#line 50 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"f_word_left\" colspan=\"7\">\r\n                查無資料！\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<span class=\"badge badge-light\" id=\"repeatDefault\" hidden=\"hidden\">");
#nullable restore
#line 68 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminClinicDetail\Components\preview\Default.cshtml"
                                                              Write(TempData["repeatKey"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n<script>\r\n    //$(\'.btnDEL\').click(function () {\r\n    //    Swal.fire({\r\n    //        title: \'刪除\',\r\n    //        text: \"\",\r\n    //        icon: \'success\'\r\n    //    })\r\n    //});\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.CClinicDetailAdminViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
