#pragma checksum "C:\Users\Student\Desktop\725最新版專題\Medical\Areas\Admin\Views\AdminProduct\ReturnOrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1336ac09ccea0e487ec0fd1956b967840ed9bcf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProduct_ReturnOrderList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProduct/ReturnOrderList.cshtml")]
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
#line 1 "C:\Users\Student\Desktop\725最新版專題\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Desktop\725最新版專題\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1336ac09ccea0e487ec0fd1956b967840ed9bcf0", @"/Areas/Admin/Views/AdminProduct/ReturnOrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminProduct_ReturnOrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AdminProduct/productManage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 25%; height: 100%; border-radius: 0%; margin-right: 1px; font-size: 26px "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AdminProduct/QueryAllOrders"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AdminProduct/DeleteReviews"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AdminProduct/ReturnOrderList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 25%; height: 100%; border-radius: 0%; font-size: 26px "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Student\Desktop\725最新版專題\Medical\Areas\Admin\Views\AdminProduct\ReturnOrderList.cshtml"
  
    ViewData["Title"] = "ReturnOrderList";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"" style="" margin: auto; "">

    <div style=""width: 1000px; height: 980px; background-color: rgb(234, 232, 232); margin: auto; margin-top: 20px; margin-bottom: 50px; border-radius: 15px; padding-top: 20px; "">

        <div style="" display: flex; width: 95%; margin: auto;height: 6%;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1336ac09ccea0e487ec0fd1956b967840ed9bcf06863", async() => {
                WriteLiteral("產品");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1336ac09ccea0e487ec0fd1956b967840ed9bcf08112", async() => {
                WriteLiteral("訂單");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1336ac09ccea0e487ec0fd1956b967840ed9bcf09361", async() => {
                WriteLiteral("評價");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1336ac09ccea0e487ec0fd1956b967840ed9bcf010610", async() => {
                WriteLiteral("退貨");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <div class=""row mt-3"" style=""height: 88%; width: 95%;margin: auto;"">

            <!-- ==============left Start==================== -->
            <div class=""col col-md-4 h-100"" style=""padding-left: 5px;padding-right: 5px;background-color: white; max-height: 100%;"">


                <div class=""row mt-1"" style="" width:100%;margin:auto;"">
                    <div class=""input-group rounded"" style=""padding: 0;"">
                        <input type=""search"" class=""form-control rounded"" placeholder=""搜尋.."" aria-label=""Search"" aria-describedby=""search-addon"" style=""margin-left: 0;"" />
                        <span class=""input-group-text border-0"" id=""search-addon"">
                            <i class=""fas fa-search""></i>
                        </span>
                    </div>
                </div>
                <div class=""mt-2"" style=""height: 90%;max-height: 90%; overflow-y:hidden ;"">
                    <input type=""checkbox"" style="" transform: scale(1.4); mar");
            WriteLiteral("gin-left: 9px;\"");
            BeginWriteAttribute("value", " value=\"", 2146, "\"", 2154, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span style=""margin-left: 10px;"">退款尚未處理</span>
                    <div style=""width: 100%;height: 100%; margin: auto; overflow-y: auto;"">

                        <table class=""table table-striped table-hover mt-2"">
                            <tr><td><input type=""checkbox"" style="" transform: scale(1.4);""");
            BeginWriteAttribute("value", " value=\"", 2467, "\"", 2475, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 2623, "\"", 2631, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 2779, "\"", 2787, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 2935, "\"", 2943, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 3091, "\"", 3099, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 3247, "\"", 3255, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 3403, "\"", 3411, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 3559, "\"", 3567, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 3715, "\"", 3723, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 3871, "\"", 3879, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 4027, "\"", 4035, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 4183, "\"", 4191, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 4339, "\"", 4347, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 4495, "\"", 4503, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 4651, "\"", 4659, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 4807, "\"", 4815, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 4963, "\"", 4971, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 5119, "\"", 5127, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 5275, "\"", 5283, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 5431, "\"", 5439, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 5587, "\"", 5595, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 5743, "\"", 5751, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 5899, "\"", 5907, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 6055, "\"", 6063, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 6211, "\"", 6219, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 6367, "\"", 6375, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 6523, "\"", 6531, 0);
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 10px;\">1234</span></td></tr>\r\n                            <tr><td><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 6679, "\"", 6687, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span style=""margin-left: 10px;"">777</span></td></tr>
                        </table>
                    </div>
                </div>
            </div>
            <!-- ==============left End==================== -->
            <!-- ==============right Start==================== -->
            <div class=""col col-m4-8"" style=""padding-left: 10px;padding-right: 0%;"">
                <div style=""height: 100%;width: 100%;margin: 0%;"">
                    <div style=""width: 100%;height: 26em;"">
                        <div style=""background-color: white;height: 100%; margin-top: 0;"">
                            <p style=""background-color: rgb(51, 51, 51); color: rgb(255, 255, 255);line-height: 40px;padding-left: 15px;margin-bottom: 0%;"">訂單細檔</p>
                            <div style=""height: 89%;"">
                                <div class=""row h-100"" style=""width: 100%;margin: auto;"">
                                    <!-- ==============  單筆 start  ============= -->
                       ");
            WriteLiteral(@"             <div class=""col col-md-12 h-100"">
                                        <div style=""height: 85%; overflow:hidden ;"">
                                            <div style=""overflow:auto ;height: 100%;"">
                                                <div class=""row"" style="" height: 3em;width: 100%;margin:0%;padding: 0%;"">
                                                    <p class=""col col-md-3"" style=""margin: auto;font-weight: bold;""> 訂單編號: <span>33</span></p>
                                                    <p class=""col col-md-4"" style=""margin: auto;font-weight: bold;""> 客戶姓名: <span>吳小明</span></p>
                                                    <p class=""col col-md-5"" style=""margin: auto;font-weight: bold;""> 客戶電話: <span>0934141121</span></p>
                                                </div>
                                                <hr style=""margin: 0; border-top: 1px solid rgb(0, 0, 0);"">
                                                <table class=""table"">
  ");
            WriteLiteral(@"                                                  <thead>
                                                        <tr>
                                                            <th scope=""col"" nowrap=""nowrap"">圖示</th>
                                                            <th scope=""col"" nowrap=""nowrap"">訂單細項</th>
                                                            <th scope=""col"" nowrap=""nowrap"">數量</th>
                                                            <th scope=""col"" nowrap=""nowrap"">單價</th>
                                                            <th scope=""col"" nowrap=""nowrap"">折扣號</th>
                                                            <th scope=""col"" nowrap=""nowrap"">小計</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr valign=""middle"" class=""margin:auto"">
          ");
            WriteLiteral("                                                  <td valign=\"middle\"><img src=\"images/樂敦-維他眼藥水.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 9860, "\"", 9866, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""40px"" height=""40px""></td>
                                                            <td valign=""middle"">樂敦-維他眼藥水</td>
                                                            <td align='center' valign=""middle"">2</td>
                                                            <td valign=""middle"">399</td>
                                                            <td align='center' valign=""middle"">79折</td>
                                                            <td align='center' valign=""middle"">798</td>
                                                        </tr>
                                                        <tr valign=""middle"" class=""margin:auto"">

                                                            <td valign=""middle""><img src=""images/樂敦眼藥水-舒視齡.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10674, "\"", 10680, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""40px"" height=""40px""></td>
                                                            <td valign=""middle"">海昌真水感日拋隱形眼鏡</td>
                                                            <td align='center' valign=""middle"">1</td>
                                                            <td valign=""middle"">588</td>
                                                            <td align='center' valign=""middle"">89折</td>
                                                            <td align='center' valign=""middle"">588</td>
                                                        </tr>
                                                        <tr valign=""middle"" class=""margin:auto"">
                                                            <td valign=""middle""><img src=""images/樂敦-維他眼藥水.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11488, "\"", 11494, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""40px"" height=""40px""></td>
                                                            <td valign=""middle"">樂敦-維他眼藥水</td>
                                                            <td align='center' valign=""middle"">2</td>
                                                            <td valign=""middle"">399</td>
                                                            <td align='center' valign=""middle"">79折</td>
                                                            <td align='center' valign=""middle"">798</td>
                                                        </tr>
                                                        <tr valign=""middle"" class=""margin:auto"">
                                                            <td valign=""middle""><img src=""images/樂敦眼藥水-舒視齡.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12300, "\"", 12306, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""40px"" height=""40px""></td>
                                                            <td valign=""middle"">海昌真水感日拋隱形眼鏡</td>
                                                            <td align='center' valign=""middle"">1</td>
                                                            <td valign=""middle"">588</td>
                                                            <td align='center' valign=""middle"">89折</td>
                                                            <td align='center' valign=""middle"">588</td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                        <div class=""mt-1"" style=""height: 13%;width: 100%;background-color: rgb(255, 255, 255); text-align: end;border: 1px solid transparent;"">
                            ");
            WriteLiteral(@"                <p class=""mt-2"" style=""font-weight: bold; color:rgb(0, 0, 0);"">總計: <span style=""margin-right: 20px;color: rgb(246, 58, 58);font-size:large;""> NT$1,999</span> </p>
                                        </div>
                                    </div>

                                    <!-- ==============  單筆 End  ============= -->

                                </div>
                            </div>

                        </div>
                    </div>

                    <!-- ==============  多筆 Start  ============= -->
                    <div class=""mt-4"" style=""width: 100%;height: 25em;"">
                        <div style=""background-color: white;height: 100%; margin-top: 0;border-radius:0 0 15px 15px ;"">
                            <p style=""background-color: rgb(51, 51, 51); color: white;line-height: 40px;padding-left: 15px;margin-bottom: 0%;"">多筆查詢器</p>
                            <div style=""height: 88%;"">
                                <div style=""heigh");
            WriteLiteral(@"t: 90%; overflow:hidden ;"">
                                    <div style=""overflow:auto ;height: 100%;"">
                                        <table class=""table"">
                                            <thead>
                                                <tr>
                                                    <th></th>
                                                    <th nowrap=""nowrap"" scope=""col"">編號</th>
                                                    <th nowrap=""nowrap"" scope=""col"">客戶姓名</th>
                                                    <th nowrap=""nowrap"" scope=""col"">訂單成立時間</th>
                                                    <th nowrap=""nowrap"" scope=""col"">訂單總金額</th>
                                                    <th nowrap=""nowrap"" scope=""col"">退款是否已處理</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                         ");
            WriteLiteral("       <tr>\r\n                                                    <td valign=\"middle\"><input type=\"checkbox\" style=\" transform: scale(1.4);\"");
            BeginWriteAttribute("value", " value=\"", 15518, "\"", 15526, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                                    <th valign=""middle"" scope=""row"">1</th>
                                                    <td valign=""middle"">王小明</td>
                                                    <td valign=""middle"">2011/11/11 12:30</td>
                                                    <td align='center' valign=""middle"">NT$1,999</td>
                                                    <td align='center' valign=""middle""><input type=""checkbox"" checked>是/否</td>
                                                </tr>
                                                <tr>
                                                    <td valign=""middle""><input type=""checkbox"" style="" transform: scale(1.4);""");
            BeginWriteAttribute("value", " value=\"", 16269, "\"", 16277, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                                    <th valign=""middle"" scope=""row"">2</th>
                                                    <td valign=""middle"">王小明</td>
                                                    <td valign=""middle"">2011/11/11 12:30</td>
                                                    <td align='center' valign=""middle"">NT$1,999</td>
                                                    <td align='center' valign=""middle""><input type=""checkbox"" checked>是/否</td>
                                                </tr>
                                                <tr>
                                                    <td valign=""middle""><input type=""checkbox"" style="" transform: scale(1.4);""");
            BeginWriteAttribute("value", " value=\"", 17020, "\"", 17028, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                                    <th valign=""middle"" scope=""row"">3</th>
                                                    <td valign=""middle"">王小明</td>
                                                    <td valign=""middle"">2011/11/11 12:30</td>
                                                    <td align='center' valign=""middle"">NT$1,999</td>
                                                    <td align='center' valign=""middle""><input type=""checkbox"" checked>是/否</td>
                                                </tr>
                                                <tr>
                                                    <td valign=""middle""><input type=""checkbox"" style="" transform: scale(1.4);""");
            BeginWriteAttribute("value", " value=\"", 17771, "\"", 17779, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                                    <th valign=""middle"" scope=""row"">4</th>
                                                    <td valign=""middle"">王小明</td>
                                                    <td valign=""middle"">2011/11/11 12:30</td>
                                                    <td align='center' valign=""middle"">NT$1,999</td>
                                                    <td align='center' valign=""middle""><input type=""checkbox"" checked>是/否</td>
                                                </tr>
                                                <tr>
                                                    <td valign=""middle""><input type=""checkbox"" style="" transform: scale(1.4);""");
            BeginWriteAttribute("value", " value=\"", 18522, "\"", 18530, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                                    <th valign=""middle"" scope=""row"">5</th>
                                                    <td valign=""middle"">王小明</td>
                                                    <td valign=""middle"">2011/11/11 12:30</td>
                                                    <td align='center' valign=""middle"">NT$1,999</td>
                                                    <td align='center' valign=""middle""><input type=""checkbox"" checked>是/否</td>
                                                </tr>
                                                <tr>
                                                    <td valign=""middle""><input type=""checkbox"" style="" transform: scale(1.4);""");
            BeginWriteAttribute("value", " value=\"", 19273, "\"", 19281, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                                    <th valign=""middle"" scope=""row"">6</th>
                                                    <td valign=""middle"">王小明</td>
                                                    <td valign=""middle"">2011/11/11 12:30</td>
                                                    <td align='center' valign=""middle"">NT$1,999</td>
                                                    <td align='center' valign=""middle""><input type=""checkbox"">是/否</td>
                                                </tr>
                                                <tr>
                                                    <td valign=""middle""><input type=""checkbox"" style="" transform: scale(1.4);""");
            BeginWriteAttribute("value", " value=\"", 20016, "\"", 20024, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                                    <th valign=""middle"" scope=""row"">6</th>
                                                    <td valign=""middle"">王小明</td>
                                                    <td valign=""middle"">2011/11/11 12:30</td>
                                                    <td align='center' valign=""middle"">NT$1,999</td>
                                                    <td align='center' valign=""middle""><input type=""checkbox"">是/否</td>
                                                </tr>
                                                <tr>
                                                    <td valign=""middle""><input type=""checkbox"" style="" transform: scale(1.4);""");
            BeginWriteAttribute("value", " value=\"", 20759, "\"", 20767, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                                    <th valign=""middle"" scope=""row"">6</th>
                                                    <td valign=""middle"">王小明</td>
                                                    <td valign=""middle"">2011/11/11 12:30</td>
                                                    <td align='center' valign=""middle"">NT$1,999</td>
                                                    <td align='center' valign=""middle""><input type=""checkbox"">是/否</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class=""text-end"" style=""width: 100%;height:12%;background-color: rgb(176, 176, 176);border-radius:0 0 15px 15px ;"">
                                    <button class=""btn btn-warning btn-sm mt-1"" type=""button"" style=""width: 20%;margin-right: 3e");
            WriteLiteral(@"m;"">確認核銷 </button>

                                </div>
                            </div>

                        </div>
                    </div>
                    <!-- ==============  多筆 End  ============= -->
                </div>
            </div>
            <!-- ==============right End==================== -->

        </div>



    </div>

</div>");
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
