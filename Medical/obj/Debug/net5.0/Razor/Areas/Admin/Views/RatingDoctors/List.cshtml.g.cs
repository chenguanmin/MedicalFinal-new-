#pragma checksum "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4f46ad4dd39e8facf4aca04282dcb7efa19623c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_RatingDoctors_List), @"mvc.1.0.view", @"/Areas/Admin/Views/RatingDoctors/List.cshtml")]
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
#line 1 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4f46ad4dd39e8facf4aca04282dcb7efa19623c", @"/Areas/Admin/Views/RatingDoctors/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_RatingDoctors_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModels.RatingDoctoeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>評論修改</h1>
<br>

<table class=""table"">
    <thead>
        <tr>
            <th>
                序
            </th>
            <th>
                醫生
            </th>
            <th>
                評分分數
            </th>
            <th>
                評語
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
          
            int count = 0;
            foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Doctor.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RatingTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(Html.ActionLink("修改", "Edit", new { id = item.ratingDoctor.RatingDoctorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 50 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(Html.ActionLink("刪除", "Delete", "RatingDoctor", new { id = item.ratingDoctor.RatingDoctorId },
                                new { onclick = "return confirm('確定要刪除嗎 ? ')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 54 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""card"">
    <div class=""card-header border-transparent"">
        <h3 class=""card-title""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">即時診間</font></font></h3>
    </div>
    <div class=""card-body p-0"">
        <div class=""table-responsive"">
            <table class=""table m-0"">
                <thead>
                    <tr>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">診間編號</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">看診醫師</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">科別</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">現在號碼</font></font></th>
                    </tr>
                </thead>
                <tbody>
                   ");
            WriteLiteral(@" <tr>
                        <td><a href=""pages/examples/invoice.html""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">501</font></font></a></td>
                        <td><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">使命召喚IV</font></font></td>
                        <td><span class=""badge badge-success""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">已發貨</font></font></span></td>
                        <td>
                            <div class=""sparkbar"" data-color=""#00a65a"" data-height=""20""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">90,80,90,-70,61,-83,63</font></font></div>
                        </td>
                    </tr>
                    <tr>
                        <td><a href=""pages/examples/invoice.html""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">502</font></font></a></td>
                        <td><font style=""vert");
            WriteLiteral(@"ical-align: inherit;""><font style=""vertical-align: inherit;"">三星智能電視</font></font></td>
                        <td><span class=""badge badge-warning""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">待辦的</font></font></span></td>
                        <td>
                            <div class=""sparkbar"" data-color=""#f39c12"" data-height=""20""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">90,80,-90,70,61,-83,68</font></font></div>
                        </td>
                    </tr>
                    <tr>
                        <td><a href=""pages/examples/invoice.html""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">503</font></font></a></td>
                        <td><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">iPhone 6 加</font></font></td>
                        <td><span class=""badge badge-danger""><font style=""vertical-align: inherit;""><font style=""vertical-align: inh");
            WriteLiteral(@"erit;"">發表</font></font></span></td>
                        <td>
                            <div class=""sparkbar"" data-color=""#f56954"" data-height=""20""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">90,-80,90,70,-61,83,63</font></font></div>
                        </td>
                    </tr>
                    <tr>
                        <td><a href=""pages/examples/invoice.html""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">504</font></font></a></td>
                        <td><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">三星智能電視</font></font></td>
                        <td><span class=""badge badge-info""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">加工</font></font></span></td>
                        <td>
                            <div class=""sparkbar"" data-color=""#00c0ef"" data-height=""20""><font style=""vertical-align: inherit;""><font style=""vertical-align: inher");
            WriteLiteral(@"it;"">90,80,-90,70,-61,83,63</font></font></div>
                        </td>
                    </tr>
                    <tr>
                        <td><a href=""pages/examples/invoice.html""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">505</font></font></a></td>
                        <td><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">三星智能電視</font></font></td>
                        <td><span class=""badge badge-warning""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">待辦的</font></font></span></td>
                        <td>
                            <div class=""sparkbar"" data-color=""#f39c12"" data-height=""20""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">90,80,-90,70,61,-83,68</font></font></div>
                        </td>
                    </tr>
                    <tr>
                        <td><a href=""pages/examples/invoice.html""><font style=""vertical-ali");
            WriteLiteral(@"gn: inherit;""><font style=""vertical-align: inherit;"">506</font></font></a></td>
                        <td><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">iPhone 6 加</font></font></td>
                        <td><span class=""badge badge-danger""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">發表</font></font></span></td>
                        <td>
                            <div class=""sparkbar"" data-color=""#f56954"" data-height=""20""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">90,-80,90,70,-61,83,63</font></font></div>
                        </td>
                    </tr>

                </tbody>
            </table>
        </div>

    </div>

    <div class=""card-footer clearfix"">
        <a href=""javascript:void(0)"" class=""btn btn-sm btn-info float-left""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">刷新</font></font></a>
        <a href=""javascript:void(0)"" clas");
            WriteLiteral("s=\"btn btn-sm btn-secondary float-right\"><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">查看所有訂單</font></font></a>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModels.RatingDoctoeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591