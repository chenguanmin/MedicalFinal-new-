#pragma checksum "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f4c88633029577b0cbfa6ae730b0f9108e72647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminDoctor_DoctorRatinglist), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminDoctor/DoctorRatinglist.cshtml")]
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
#line 1 "C:\medical-3.0\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\medical-3.0\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f4c88633029577b0cbfa6ae730b0f9108e72647", @"/Areas/Admin/Views/AdminDoctor/DoctorRatinglist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminDoctor_DoctorRatinglist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.CRatingDoctorViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DoctorRatinglist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminDoctorController", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
  
    ViewData["Title"] = "DoctorRatinglist";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>醫師評論管理--<strong>");
#nullable restore
#line 8 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
               Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  醫師</strong></h1>

<div class=""card"">
    <div class=""card-body p-0"">
        <div class=""table-responsive"">
            <table class=""table m-0"">
                <thead>
                    <tr>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">評論編號</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">評分</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">");
#nullable restore
#line 18 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
                                                                                                     Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</font></font></th>\r\n                        <th><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">遮蔽狀態</font></font></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 23 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
                      
                        int count = 0;
                        double total = 0;
                        string shade = "";
                        string sign = "";
                        double a = 0;
                        foreach (var item in Model)
                        {
                            count++;

                            if (item.Shade == true)
                            {
                                shade = "已遮蔽";
                                sign = "danger";
                            }
                            else if (item.Shade == false || item.Shade==null)
                            {
                                shade = "正常評論";
                                sign = "primary";

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><a href=\"pages/examples/invoice.html\"><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
#nullable restore
#line 45 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
                                                                                                                                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</font></font></a></td>\r\n                                <td><span><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
#nullable restore
#line 46 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
                                                                                                                   Write(Html.DisplayFor(modelItem => item.RatingType.RatingTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</font></font></span></td>\r\n                                <td>\r\n                                    <div class=\"sparkbar\" data-color=\"#00a65a\" data-height=\"20\"><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
#nullable restore
#line 48 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
                                                                                                                                                                         Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</font></font></div>\r\n                                </td>\r\n                                <td><span");
            BeginWriteAttribute("class", " class=\"", 2637, "\"", 2662, 3);
            WriteAttributeValue("", 2645, "badge", 2645, 5, true);
            WriteAttributeValue(" ", 2650, "badge-", 2651, 7, true);
#nullable restore
#line 50 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
WriteAttributeValue("", 2657, sign, 2657, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
#nullable restore
#line 50 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
                                                                                                                                             Write(shade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</font></font></span></td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 52 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
                               Write(Html.ActionLink("切換遮蔽狀態", "DoctorRatingEdit", new { id = item.RatingDoctorId }, new { onclick = "return confirm('是否切換遮蔽狀態?')", @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 56 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
                            total += Convert.ToDouble(item.RatingType.RatingTypeName);
                            a = total / count;
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"col-md-12 text-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f4c88633029577b0cbfa6ae730b0f9108e7264711655", async() => {
                WriteLiteral("\r\n                <div");
                BeginWriteAttribute("class", " class=\"", 3567, "\"", 3575, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-footer clearfix\">\r\n            <h2 style=\"vertical-align: inherit;\">平均分數: ");
#nullable restore
#line 88 "C:\medical-3.0\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
                                                  Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</h2>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f4c88633029577b0cbfa6ae730b0f9108e7264714267", async() => {
                WriteLiteral("回到上一頁");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.CRatingDoctorViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
