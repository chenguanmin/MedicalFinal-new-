#pragma checksum "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09d7113f8197d31cb6d5269b1254e8fe364a80c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_ListTest), @"mvc.1.0.view", @"/Views/Doctor/ListTest.cshtml")]
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
#line 1 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d7113f8197d31cb6d5269b1254e8fe364a80c1", @"/Views/Doctor/ListTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_ListTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.Models.Doctor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-top w-100 dcimg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:204px;height:204px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
  
    ViewData["Title"] = "ListTest";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral(@"
    <style>
        .listFCN {
            color: #366ba8;
            font-size: 20px;
            font-weight: bold;
            margin-bottom: 10px;
            color: #00EEFF;
        }

        .listFCS {
            font-size: 18px;
            height: 18px;
            line-height: 18px;
            margin-bottom: 6px;
            overflow: hidden;
            color: white;
        }

        .listFCC {
            color: white;
            font-size: 18px;
            height: 54px;
            line-height: 18px;
            overflow: hidden;
        }

        .container img {
            width: 100%;
        }

        .body {
            font-size: 18px;
            font-family: ""微軟正黑體"";
            font-weight: bold;
        }

        .listFCP {
            font-size: 0px;
            line-height: 0px;
            margin-bottom: 10px;
        }

        .input-selector {
            outline: none;
            border: none;
        }

        .muti-s");
                WriteLiteral(@"elector {
            width: max-content;
            float: left;
            padding-right: 4px
        }

        .select-field {
            border: 1px solid black;
        }

        .select-field, .task, .list {
            width: 100%;
            background-color: white;
        }

        .list {
            box-shadow: 0px 30px 60px rgb(0,0,0,0.2);
            display: none;
            position: absolute;
            width: 214.16px;
            z-index: 10;
        }

        .down-arrow {
            font-size: 1.2rem;
            cursor: pointer;
            display: inline-block;
            transition: 0.2s linear;
        }

        .task {
            display: block;
            padding-left: 0;
        }

            .task span {
                float: right;
                font-size: 0.6rem;
                padding-top: 6px;
            }

                .task span:hover {
                    background-color: aliceblue;
                }

  ");
                WriteLiteral(@"      .show {
            display: block;
        }

        .rotate180 {
            transform: rotate(180deg);
        }

        .detail {
            margin-left: 60px;
            margin-right: 60px;
        }

        .slideInUp {
            background-color: #171117;
            border: 0.2px #666;
            border-radius: 25px 25px 25px 25px;
            margin: 10px 5px 10px 5px;
        }

        #hateboot img {
            border-radius: 25px 25px 25px 25px !important;
            margin-top: 17px !important;
            position: relative;
        }

        .container .detail {
            color: #BCF7DA !important;
        }
    </style>

");
            }
            );
            WriteLiteral(@"<!-- Hero Start -->
<div class=""container-fluid bg-primary py-5 hero-header mb-5"">
    <div class=""row py-3"">
        <div class=""col-12 text-center"">
            <h3 class=""display-3 text-white animated zoomIn"">醫生清單</h3>
        </div>
    </div>
</div>
<!-- Hero End -->
<br>

");
#nullable restore
#line 142 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <input type=\"button\" value=\"點我推薦醫生\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3268, "\"", 3329, 3);
            WriteAttributeValue("", 3278, "location.href=\'", 3278, 15, true);
#nullable restore
#line 145 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
WriteAttributeValue("", 3293, Url.ActionLink("SugDoc", "Doctor"), 3293, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3328, "\'", 3328, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"muti-selector\">\r\n        <div class=\"select-field\">\r\n            <input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 3446, "\"", 3453, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"篩選專長\" class=\"input-selector\" />\r\n            <span class=\"down-arrow\">&blacktriangledown;</span>\r\n\r\n        </div>\r\n        <div class=\"list\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 3630, "\"", 3636, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""task"">
                <input type=""checkbox"" class=""checkAll"" name=""123"" id=""c"" />
                全選
            </label>
        </div>
    </div>
    <div class=""muti-selector"">
        <div class=""select-field"" id=""select-field1"">
            <input type=""text""");
            BeginWriteAttribute("name", " name=\"", 3919, "\"", 3926, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"篩選醫生\" class=\"input-selector\" />\r\n            <span class=\"down-arrow\" id=\"down-arrow1\">&blacktriangledown;</span>\r\n        </div>\r\n        <div class=\"list\" id=\"list1\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 4129, "\"", 4135, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"task\">\r\n                <input type=\"checkbox\" class=\"checkAll\" />\r\n                全選\r\n            </label>\r\n        </div>\r\n    </div>\r\n    <input id=\"txtKeyword\" hidden=\"hidden\" type=\"text\" name=\"txtKeyword\"");
            BeginWriteAttribute("value", " value=\"", 4354, "\"", 4362, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"submit\" id=\"sub\" value=\"查詢\" />\r\n");
#nullable restore
#line 174 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div><br /></div>\r\n");
#nullable restore
#line 176 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
   int count = 0;
    foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div id=""hateboot"" class=""col-lg-4 wow slideInUp"" data-wow-delay=""0.3s"" style=""float:left;width:20%;"">
            <div class=""team-item"" style=""padding: 0 9px 25px 9px;"">
                <div class=""position-relative rounded-top  container listFCP"" style=""z-index: 1;"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09d7113f8197d31cb6d5269b1254e8fe364a80c111085", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4879, "~/images/", 4879, 9, true);
#nullable restore
#line 183 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
AddHtmlAttributeValue("", 4888, Html.DisplayFor(modelItem => item.PicturePath), 4888, 47, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"container\">\r\n                    <div class=\"listFCN\">");
#nullable restore
#line 187 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"listFCS\">");
#nullable restore
#line 188 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"listFCC\">學歷:");
#nullable restore
#line 189 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    ");
#nullable restore
#line 190 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
               Write(Html.ActionLink("詳細資料", "Detail", new { id = item.DoctorId }, new { @class = "btn btn-outline-success detail" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <button type=\"button\" id=\"buttonLoad\" class=\"btn btn-primary buttonLoad\" data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal\" data-docid=\"");
#nullable restore
#line 191 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
                                                                                                                                                      Write(item.DoctorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    查看評價\r\n                </button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 197 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"


    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div id=""tbdRatingList"" class=""modal-body"">
");
            WriteLiteral(@"            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">離開</button>
            </div>
        </div>
    </div>
</div>




<footer style=""clear:both""></footer>
}
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var docid = $(\'.buttonLoad\').attr(\"data-docid\");\r\n        console.log(docid);\r\n\r\n        $(\'.buttonLoad\').click(function () {\r\n            $(\'#tbdRatingList\').load(\'");
#nullable restore
#line 231 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
                                 Write(Url.Content("~/Doctor/RatingDoctorpartail/1"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' )\r\n             console.log(doctorid);\r\n        })\r\n\r\n\r\n\r\n\r\n");
                WriteLiteral(@"        document.querySelector('.select-field').addEventListener('click', () => {
        document.querySelector('.list').classList.toggle('show');
            document.querySelector('.down-arrow').classList.toggle('rotate180')

        })
        document.querySelector('#select-field1').addEventListener('click', () => {
            document.querySelector('#list1').classList.toggle('show');
            document.querySelector('#down-arrow1').classList.toggle('rotate180')
        })
        loadDep();

        function CCC() {
            if ($(event.target)[0].checked == true) {
                loadDoc();
            }
            else
                cancelDoc();
        }
        function DDD() {
            if ($(event.target)[0].checked == true) {
                $('#txtKeyword').val($(event.target)[0].name);
            }
            if ($(event.target)[0].checked != true)
                $('#txtKeyword').val="""";
        }
        $(function () {
            //全選被按
            $");
                WriteLiteral(@"("".checkAll"").click(function () {
                var isCheck = $(this).prop(""checked"");
                $(this).closest("".muti-selector"").find(""input[name='check']"").prop(""checked"", isCheck);
            });

            $("".checkAllWrap input[name='check']"").click(function () {

                var el_checkAll = $(this).closest("".muti-selector"").find("".checkAll"");

                var checkLength = $(this).closest("".muti-selector"").find(""input[name='check']:checked"").length;// 每區塊目前被V的有幾個

                var inputLength =
                    $(this).closest("".muti-selector"").find(""input[name='check']"").length; // 每區塊的核取框有多少


                if (!$(this).prop(""checked"")) {
                    el_checkAll.prop(""checked"", false);
                } else {
                    if (checkLength == inputLength) {
                        el_checkAll.prop(""checked"", true);
                    }
                }
            });

        });
");
                WriteLiteral("        async function loadDep() {\r\n\r\n            const deps = await fetch(\'");
#nullable restore
#line 294 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
                                 Write(Url.Content("~/Admin/AdminDoctor/Dep"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"').then(response => response.json())
            deps.forEach((DeptName) => {
                /*console.log(DeptName)*/
                name =`<label for="""" class=""task"">
                <input type=""checkbox"" class=""check"" onclick=""CCC()"" id=""${DeptName}"" name=""${DeptName}"" value=""${DeptName}""/>
                ${DeptName}
            </label>`;
                document.querySelector('.list').innerHTML += name;
            })

        }
");
                WriteLiteral("        async function loadDoc() {\r\n                depName = ($(event.target)[0].name);\r\n                const trtDs = await fetch(\'");
#nullable restore
#line 308 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
                                      Write(Url.Content("~/Admin/AdminDoctor/Doc"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + `?depName=${depName}`).then(response => response.json());
                trtDs.forEach((DoctorName) => {
                    name = `<label for="""" class=""task"" id=""${DoctorName}"">
                <input type=""checkbox"" class=""check1"" name=""${DoctorName}"" onclick=""DDD()"" value=""${DoctorName}""/>
                ${DoctorName}
            </label>`;
                    document.querySelector('#list1').innerHTML+= name;
                })
        }

");
                WriteLiteral("        async function cancelDoc() {\r\n                depName = ($(event.target)[0].name);\r\n                const trtDs = await fetch(\'");
#nullable restore
#line 321 "C:\Users\Student\Desktop\專題3.0 冠名\Medical\Views\Doctor\ListTest.cshtml"
                                      Write(Url.Content("~/Admin/AdminDoctor/Doc"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + `?depName=${depName}`).then(response => response.json());\r\n                trtDs.forEach((DoctorName) => {\r\n                    document.querySelector(`#${DoctorName}`).remove();\r\n                })\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.Models.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
