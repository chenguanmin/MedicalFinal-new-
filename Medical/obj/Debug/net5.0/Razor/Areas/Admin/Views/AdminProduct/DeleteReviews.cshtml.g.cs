#pragma checksum "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9e0e775726492d6ff19266cc0460178289139b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProduct_DeleteReviews), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProduct/DeleteReviews.cshtml")]
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
#nullable restore
#line 1 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
using Medical.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e0e775726492d6ff19266cc0460178289139b2", @"/Areas/Admin/Views/AdminProduct/DeleteReviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminProduct_DeleteReviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CReviewForEditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AdminProduct/productManage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 25%; height: 100%; border-radius: 0%; margin-right: 1px; font-size: 26px "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AdminProduct/QueryAllOrders"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AdminProduct/DeleteReviews"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AdminProduct/ReturnOrderList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" width: 25%; height: 100%; border-radius: 0%; font-size: 26px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
  
    ViewData["Title"] = "DeleteReviews";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />

    <style>
        .fa-star {
            color: goldenrod;
            font-size:xx-large;
        }
    </style>
");
            }
            );
            WriteLiteral(@"
<div class=""container-fluid"" style=""margin: auto; "">

    <div style=""width: 1000px; height: 980px; background-color: rgb(234, 232, 232); margin: auto; margin-top: 20px; margin-bottom: 50px; border-radius: 15px; padding-top: 20px; "">

        <div style="" display: flex; width: 95%; margin: auto;height: 6%;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9e0e775726492d6ff19266cc0460178289139b27620", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9e0e775726492d6ff19266cc0460178289139b28869", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9e0e775726492d6ff19266cc0460178289139b210118", async() => {
                WriteLiteral("評價");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9e0e775726492d6ff19266cc0460178289139b211368", async() => {
                WriteLiteral("退貨");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                    <div style=""width: 100%;height: 100%; margin: auto; overf");
            WriteLiteral("low-y: auto;\">\r\n                        <table class=\"table table-striped table-hover mt-2\">\r\n");
#nullable restore
#line 49 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
                              int i = 0;
                                foreach (var item in Model.reviewList.OrderBy(r => r.Product.ProductName).ThenBy(r=>r.RatingType.RatingTypeName))
                                {
                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr><td style=\"margin-right:0px;color:gray;width:1em;\">");
#nullable restore
#line 53 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td onclick=\"Selected(event)\"><input class=\"myCheckbox\" type=\"checkbox\" name=\"checkedB\" style=\" transform: scale(1.4);margin-right:1em;\"");
            BeginWriteAttribute("value", " value=\"", 3361, "\"", 3383, 1);
#nullable restore
#line 53 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
WriteAttributeValue("", 3369, item.ReviewId, 3369, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span style=\"margin-left: 0px;\">");
#nullable restore
#line 53 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
                                                                                                                                                                                                                                                                                             Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 53 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
                                                                                                                                                                                                                                                                                                                        Write(item.RatingType.RatingTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 顆星)</span></td></tr>\r\n");
#nullable restore
#line 54 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"

                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </table>
                    </div>
                </div>
            </div>
            <!-- ==============left End==================== -->
            <!-- ==============right Start==================== -->
            <div class=""col col-m4-8"" style=""padding-left: 10px;padding-right: 0%;"">
                <div style=""height: 100%;width: 100%;margin: 0%;"">
                    <div style=""width: 100%;height: 26em;"">
                        <div style=""background-color: white;height: 100%; margin-top: 0;"">
                            <p style=""background-color: rgb(51, 51, 51); color: rgb(255, 255, 255);line-height: 40px;padding-left: 15px;margin-bottom: 0%;"">產品查詢/修改</p>
                            <div style=""height: 89%;"">
                                <div class=""row h-100"" style=""width: 100%;margin: auto;"">

                                    <div class=""row"" style=""height: 47%; width: 100%;margin: auto;"">
                                        <!-- =============");
            WriteLiteral(@"=  left  ============= -->
                                        <div class=""col col-md-6 h-100"">
                                            <p class=""mt-3""> <span style=""margin-right: 10px;"">客戶姓名:</span><input size=""15"" type=""text"" id=""myMemberName"" readonly></p>
                                            <p class=""mt-2""> <span style=""margin-right: 10px;"">商品名稱:</span><input size=""15"" type=""text"" id=""myProductName"" readonly></p>
                                            <p class=""mt-2""> <span style=""margin-right: 10px;"">留言時間:</span><input size=""20"" type=""text"" id=""myReviewTime"" readonly></p>
                                            <input type=""hidden"" name=""reviewIdForDelete"" id=""myReviewId"" value=""0"" />
                                        </div>

                                        <!-- ==============  right  ============= -->
                                        <div class=""col col-md-6 h-100"">
                                            <p class=""mt-3"" style=""padding-bottom :");
            WriteLiteral(@" 15px;""> <span style=""margin-right: 10px;"">客戶評分:</span></p>
                                            <div class=""text-center"">
                                                <p id=""myReviewStars""></p>
                                            </div>
                                            <div>
                                                <p class=""mt-4""><span  style=""margin-right: 10px;color:red;"">顯示狀態:</span><input size=""5"" type=""text"" id=""myShade"" readonly></p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"" style=""height: 38%; width: 100%;margin: auto;"">
                                        <div style=""width: 100%;height: 100%;"">
                                            <p style=""margin-bottom: 3px;margin-left:5px;""> <span>留言內容:</span></p>
                                            <textarea class=""mt-2""");
            BeginWriteAttribute("name", " name=\"", 6611, "\"", 6618, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""myReviewContent"" cols=""40"" rows=""4"" style=""font-size: 14px;margin-left: 5em;"" readonly></textarea>
                                        </div>
                                    </div>
                                    <div class=""text-end"" style=""height: 15%; width: 95%;margin: auto;"">
                                        <button class=""btn btn-danger btn-sm mt-2"" id=""btnDel"" type=""button"" style=""width: 15%; margin-left: 2em;"">確認隱藏 </button>
                                        <button class=""btn btn-warning btn-sm mt-2"" id=""btnRelieve"" type=""button"" style=""width:15%;margin-left:2em;"">解除隱藏 </button>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>

                    <!-- ==============  多筆 Start  ============= -->
                    <div class=""mt-4"" style=""width: 100%;height: 25em;"">
                        <div style=""background-color: white;heigh");
            WriteLiteral(@"t: 100%; margin-top: 0;border-radius:0 0 15px 15px ;"">
                            <p style=""background-color: rgb(51, 51, 51); color: white;line-height: 40px;padding-left: 15px;margin-bottom: 0%;"">多筆修改</p>
                            <div style=""height: 88%;"">
                                <div style=""height: 90%; overflow:hidden ;"">
                                    <div style=""overflow:auto ;height: 100%;"">
                                        <table class=""table"" id=""myTable"">
                                            <thead>
                                                <tr>
                                                    <th nowrap=""nowrap"" scope=""col"">留言編號</th>
                                                    <th nowrap=""nowrap"" scope=""col"">客戶姓名</th>
                                                    <th nowrap=""nowrap"" scope=""col"">留言時間</th>
                                                    <th nowrap=""nowrap"" scope=""col"">留言內容</th>
                                      ");
            WriteLiteral(@"          </tr>
                                            </thead>
                                            <tbody>
        
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class=""text-end"" style=""width: 100%;height:12%;background-color: rgb(176, 176, 176);border-radius:0 0 15px 15px ;"">
                                    <button class=""btn btn-danger btn-sm mt-1"" type=""button"" style=""width: 20%;margin-right: 3em;"" id=""btnmultipleDel"">確認隱藏 </button>
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

</div>




");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>


        let myProductName = $(""#myProductName"");
        let myReviewStars = $(""#myReviewStars"");
        let myMemberName = $(""#myMemberName"");
        let myReviewContent = $(""#myReviewContent"");
        let myReviewTime = $(""#myReviewTime"");
        let myReviewId = $(""#myReviewId"");
        let myShade = $(""#myShade"");



        //=================== ajax解除隱藏 start===============

        $(""#btnRelieve"").click(() => {

            let singleR = myReviewId.val();
            $.ajax({
                    url: """);
#nullable restore
#line 173 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
                     Write(Url.Content("~/Admin/AdminProduct/SingleReviewRelieve"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" "",
                    type: 'POST',
                    data: { singleR: singleR },
                    success: function (message) {
                        if (message === ""成功"") {
                            let timerInterval
                            Swal.fire({
                                icon: 'success',
                                title: '成功',
                                html: '已將此評論顯示',
                                timer: 500,
                                timerProgressBar: true,
                                didOpen: () => {
                                    Swal.showLoading()
                                    const b = Swal.getHtmlContainer().querySelector('b')
                                    timerInterval = setInterval(() => {
                                        b.textContent = Swal.getTimerLeft()
                                    }, 100)
                                },
                                willClose: () => {
                    ");
                WriteLiteral(@"                clearInterval(timerInterval)
                                }
                            }).then((result) => {
                                myShade.val(""正常顯示"");
                            })
                        }

                        else
                            Swal.fire({
                                icon: 'error',
                                title: 'Oops...',
                                text: '請稍後再試!',
                            })
                    }
            })

        });


        // ====================CHECKBOX 多選 Start=============================
        $("".myCheckbox"").on(""change"", function () {
            console.log($(this).val())

            setTimeout(() => {
                if (this.checked) {
                    if ($(`.multipleP:contains(${$(this).val()})`).length == 0) {
                        $(""#myTable"").append(`<tr valign=""middle"" style=""margin:auto"" class=""cleartr""><td valign=""middle"" class=""multipleP"" >$");
                WriteLiteral(@"{$(this).val()}</td><td valign=""middle"">${myMemberName.val()}</td><td valign=""middle"">${myReviewTime.val()}</td> <td valign=""middle"">${myReviewContent.text()}</td></tr>`)
                    }
                }
                else
                    $(`.multipleP:contains(${$(this).val()})`).parents(""tr"").eq(0).remove()
            }, 200);
        })
        //======================多選下架 start=============================
        $(""#btnmultipleDel"").on(""click"", function () {

            var multipleD = new Array;

            $(':checkbox[name=""checkedB""]:checked').each(function (index) {
                console.log($(this).val());
                multipleD.push( $(this).val());
            });
            $.ajax({
                url: """);
#nullable restore
#line 236 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
                 Write(Url.Content("~/Admin/AdminProduct/MultipleShade"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" "",
                type: 'POST',
                data: { multipleD: multipleD },

                   success: function (message) {
                       $("":checkbox"").prop(""checked"", false)
                       $("".cleartr"").empty();
                       myShade.val(""隱藏中"");

                       if (message === ""成功"") {
                           let timerInterval
                           Swal.fire({
                               icon: 'success',
                               title: '隱藏成功',
                               html: '評論已全數隱藏!',
                               timer: 500,
                               timerProgressBar: true,
                               didOpen: () => {
                                   Swal.showLoading()
                                   const b = Swal.getHtmlContainer().querySelector('b')
                                   timerInterval = setInterval(() => {
                                       b.textContent = Swal.getTimerLeft()
           ");
                WriteLiteral(@"                        }, 100)
                               },
                               willClose: () => {
                                   clearInterval(timerInterval)
                               }
                           }).then((result) => {

                           })
                       }
                       else
                           Swal.fire({
                               icon: 'error',
                               title: 'Oops...',
                               text: '請先選擇評論...',
                           })

                }
            })

        })







        //  =========== 單擊 Ajax start ===========
        function Selected(event) {
            let targetId = $(event.target).parents(""tr"").children(""td"").children(""input"").val();

            GetSelected(targetId);
        }


        async function GetSelected(targetId) {
            const reponse = await fetch('");
#nullable restore
#line 294 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
                                    Write(Url.Content("~/Admin/AdminProduct/SelectedReview"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + `?id=${targetId}`);
            const datas = await reponse.json();
            myReviewStars.text("""");
            myProductName.val(datas.productName);
            myMemberName.val(datas.memberName);
            myReviewContent.text(datas.commentContent);

            let starCount = parseInt(datas.ratingtypeNum);
            let starString = """";
            for (let i = 0; i <= starCount-1; i++) {
                starString+=""<i class='fa-solid fa-star'>"";

            }
            myReviewStars.append(starString);
            myReviewTime.val(datas.datetimeStr);
            myReviewId.val(datas.revId);

            let mybool = datas.shade;
            if (mybool === true)
                myShade.val(""隱藏中"");
            else
                myShade.val(""正常顯示"");

        }

        // ajax-單筆隱藏 Start

        $('#btnDel').click(() => {

            let singleR = myReviewId.val();
                Swal.fire({
                    title: '確定要隱藏此評論嗎?',
                    te");
                WriteLiteral(@"xt: ""這項評論將被隱藏"",
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: '確定隱藏!',
                    cancelButtonText: '取消',
                }).then((result) => {
                    if (result.isConfirmed) {

                        $.ajax({
                            url: """);
#nullable restore
#line 337 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminProduct\DeleteReviews.cshtml"
                             Write(Url.Content("~/Admin/AdminProduct/SingleReviewDelete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" "",
                            type: 'POST',
                            data: { singleR: singleR },
                            success: function (message) {

                                if (message === ""成功"") {
                                    $("":checkbox"").prop(""checked"", false)
                                    $("".cleartr"").empty();

                                    myShade.val(""隱藏中"");

                                    Swal.fire(
                                        '成功!',
                                        '您已將此評論隱藏',
                                        'success'
                                    )
                                }
                            }
                        })
                    }
                })

        });

       //============= ajax-單筆刪除 End=================


    </script>
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CReviewForEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
