#pragma checksum "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminClinicDetail\AddClinic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5314ac03093257e41b69e7581f09a9edfc2292ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminClinicDetail_AddClinic), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminClinicDetail/AddClinic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5314ac03093257e41b69e7581f09a9edfc2292ad", @"/Areas/Admin/Views/AdminClinicDetail/AddClinic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminClinicDetail_AddClinic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Medical.ViewModel.CClinicDetailAdminViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "6", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminClinicDetail\AddClinic.cshtml"
  
    ViewData["Title"] = "AddClinic";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">

    <div class=""col-3"">
        <div class=""card card-primary"">
            <div class=""card-header"">
                <h3 class=""card-title"">新增門診</h3>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""form-group sel"">
                            <label>門診類別</label>
");
            WriteLiteral(@"                            <select id=""selDept"" class=""form-control select2"" style=""width: 100%;"" name=""dept"">
                            </select>
                        </div>
                        <div class=""form-group sel"">
                            <label>醫生</label>
                            <select id=""selDoctor"" class=""form-control select2"" style=""width: 100%;"" name=""doctor"">
                            </select>
                        </div>
                        <div class=""form-group sel"">
                            <label>
                                診間
                            </label>
                            <select id=""selRoom"" class=""form-control select2"" style=""width: 100%;"" name=""room"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5314ac03093257e41b69e7581f09a9edfc2292ad6485", async() => {
                WriteLiteral("501");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5314ac03093257e41b69e7581f09a9edfc2292ad7673", async() => {
                WriteLiteral("502");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5314ac03093257e41b69e7581f09a9edfc2292ad8861", async() => {
                WriteLiteral("503");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5314ac03093257e41b69e7581f09a9edfc2292ad10049", async() => {
                WriteLiteral("504");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5314ac03093257e41b69e7581f09a9edfc2292ad11238", async() => {
                WriteLiteral("505");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5314ac03093257e41b69e7581f09a9edfc2292ad12427", async() => {
                WriteLiteral("506");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <div class=""col-12"">
                        <div class=""col-12"">
                            <div class=""form-group"">
                                <label>Date:</label>
                                <div class=""input-group date"" id=""reservationdateForm"" data-target-input=""nearest"">
                                    <input id=""selDateForm"" name=""selDateForm"" type=""text"" class=""form-control datetimepicker-input"" data-target=""#reservationdateForm"" />
                                    <div class=""input-group-append"" data-target=""#reservationdateForm"" data-toggle=""datetimepicker"">
                                        <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-12"">");
            WriteLiteral(@"
                            <div class=""form-group"">
                                <label>Date:</label>
                                <div class=""input-group date"" id=""reservationdateTo"" data-target-input=""nearest"">
                                    <input id=""selDateTo"" type=""text"" class=""form-control datetimepicker-input"" data-target=""#reservationdateTo"" />
                                    <div class=""input-group-append"" data-target=""#reservationdateTo"" data-toggle=""datetimepicker"">
                                        <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-12"">
                                    <label>星期</label>
                                    <div class=""input");
            WriteLiteral(@"-group"">
                                        <div class=""btn-group-toggle"" data-toggle=""buttons"" style=""margin-right:20px"">
                                            <label class=""btn btn-outline-primary "">
                                                <input id=""chkday1"" name=""chkDay"" type=""checkbox"" autocomplete=""off"" value=""1""> 一
                                            </label>
                                        </div>
                                        <div class=""btn-group-toggle"" data-toggle=""buttons"" style=""margin-right:20px"">
                                            <label class=""btn btn-outline-primary "">
                                                <input id=""chkday2"" name=""chkDay"" type=""checkbox"" autocomplete=""off"" value=""2""> 二
                                            </label>
                                        </div>
                                        <div class=""btn-group-toggle"" data-toggle=""buttons"" style=""margin-right:20px"">
                ");
            WriteLiteral(@"                            <label class=""btn btn-outline-primary "">
                                                <input id=""chkday3"" name=""chkDay"" type=""checkbox"" autocomplete=""off"" value=""3""> 三
                                            </label>
                                        </div>
                                        <div class=""btn-group-toggle"" data-toggle=""buttons"" style=""margin-right:20px"">
                                            <label class=""btn btn-outline-primary "">
                                                <input id=""chkday4"" name=""chkDay"" type=""checkbox"" autocomplete=""off"" value=""4""> 四
                                            </label>
                                        </div>
                                        <div class=""btn-group-toggle"" data-toggle=""buttons"" style=""margin-right:20px"">
                                            <label class=""btn btn-outline-primary "">
                                                <input id=""chkday5"" name=""ch");
            WriteLiteral(@"kDay"" type=""checkbox"" autocomplete=""off"" value=""5""> 五
                                            </label>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <label>時段</label>
                                    <div class=""input-group"">
                                        <div class=""btn-group-toggle"" data-toggle=""buttons"" style=""margin-right:20px"">
                                            <label class=""btn btn-outline-primary "">
                                                <input id=""chkm"" name=""chkTime"" type=""checkbox"" autocomplete=""off"" value=""1""> 早上
                                            </label>
                                        </div>
                                        <div class=""btn-group-toggle"" data-toggle=""buttons"" style=""margin-right:20px"">
                                            <label cl");
            WriteLiteral(@"ass=""btn btn-outline-primary "">
                                                <input id=""chka"" name=""chkTime"" type=""checkbox"" autocomplete=""off"" value=""2""> 下午
                                            </label>
                                        </div>
                                        <div class=""btn-group-toggle"" data-toggle=""buttons"" style=""margin-right:20px"">
                                            <label class=""btn btn-outline-primary "">
                                                <input id=""chkn"" name=""chkTime"" type=""checkbox"" autocomplete=""off"" value=""3""> 晚上
                                            </label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <hr />

                </div>
                <hr />
                <div class=""col-12"">
                    <butt");
            WriteLiteral(@"on id=""btnPreview"" type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"" style=""width:100%"">新增</button>
                </div>
            </div>

        </div>
    </div>

    <div class=""col-md-9"">
        <div class=""card card-primary"">
            <div class=""card-body p-0"">
                <div id=""calendar""></div>
            </div>
        </div>
    </div>

    <!-- Modal -->
    <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" data-bs-backdrop=""static"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable modal-xl"">
            <div class=""modal-content"">
                <div>
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel""></h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&time");
            WriteLiteral(@"s;</span>
                        </button>
                    </div>
                </div>
                <div class=""modal-body"" id=""modalbody"">
                </div>
                <div class=""modal-footer"">
                    <button id=""btnDelete"" type=""button"" class=""btn btn-danger"">
                        刪除已重覆 <span class=""badge badge-light"" id=""repeatCount""></span>
                    </button>
                    
                    <button id=""btnCreate"" type=""button"" class=""btn btn-primary"">新增</button>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        let selDept = document.querySelector('#selDept'),
            selDoctor = document.querySelector('#selDoctor'),
            selRoom = document.querySelector('#selRoom'),
            DateForm = document.querySelector('#selDateForm'),
            DateTo = document.querySelector('#selDateTo'),
            days = [], times = [];

        $(document).ready(function () {
            $('#selDept').select2();
            $.ajax({
                url: '/Admin/AdminClinicDetail/Dept',
                dataType: 'json',
                data: function (params) {
                    return {
                        q: params.term,
                        page: params.page
                    };
                }
            })
                .then(function (data) {
                    data.forEach((data) => {
                        const option = new Option(data[""deptName""], data[""departmentId""]);
                        $('#selDept').append(option).trigger('change');;
     ");
                WriteLiteral(@"               })

                    $('#selDept').trigger({
                        type: 'select2:select',
                        params: {
                            data: data
                        }
                    });
                })

            var date = new Date()
            var d = date.getDate(),
                m = date.getMonth(),
                y = date.getFullYear()


            var Calendar = FullCalendar.Calendar;
            var calendarEl = document.getElementById('calendar');

            fetch(""");
#nullable restore
#line 213 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminClinicDetail\AddClinic.cshtml"
              Write(Url.Content("~/Admin/AdminClinicDetail/loadData"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""")
                .then(
                        (respone) => {

                         var calendar = new Calendar(calendarEl, {
                            headerToolbar: {
                                left: 'prev,next today',
                                center: 'title',
                                right: 'dayGridMonth,timeGridWeek'
                            },
                             themeSystem: 'bootstrap',
                             events: respone,
                            editable: true,
                            droppable: true,
                            drop: function (info) {

                             },
                             eventRender: function (respone, element) {
                                 if (respone.extendedProps.periodName == ""上午時段"")
                                     element.children("".fc-event"").css({ 'background-color': '#2a7568' });
                                 if (respone.type == ""Y"")
                            ");
                WriteLiteral(@"         element.find("".fc-event-dot"").css('color', '#2a7568');
                             }
                        });

                        calendar.render();
                    })
        });

        $('#reservationdateForm').datetimepicker({
            format: 'yyyy/MM/DD',
        });
        $('#reservationdateTo').datetimepicker({
            format: 'yyyy/MM/DD',
        });

        $(""#myModal"").on('show.bs.modal', function () {

            $(""input[name='chkDay']:checked"").each(function (index, item) {
                days.push($(this).val());
            });

            $(""input[name='chkTime']:checked"").each(function (index, item) {
                times.push($(this).val());
            });

            let list = {
                DoctorId: selDoctor.value,
                DepartmentId: selDept.value,
                room: selRoom.value,
                dateForm: DateForm.value,
                dateTo: DateTo.value,
                day: days,
          ");
                WriteLiteral("      time: times\r\n            };\r\n\r\n            $.post(\'");
#nullable restore
#line 269 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminClinicDetail\AddClinic.cshtml"
               Write(Url.Content("~/Admin/AdminClinicDetail/Preview"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', list, function (data) {
                $('.modal-body').empty();
                $('.modal-body').html(data);
            }).then(function () {
                $('#repeatCount').html($('#repeatDefault').text());
            })

            $('#btnCreate').click(function () {
                let count = $('label[name=""count""]'),
                    doctorlist = $('label[name=""doctorName""]'),
                    deptlist = $('label[name=""deptName""]'),
                    periodlist = $('label[name=""periodName""]'),
                    Roomlist = $('label[name=""RoomId""]'),
                    Datelist = $('label[name=""ClinicDate""]'),
                    obj = [];

                $.each(count, function (key, value) {
                    var detail = {
                        doctorName: doctorlist[key].textContent,
                        deptName: deptlist[key].textContent,
                        periodName: periodlist[key].textContent,
                        room: Roomlist[key].textCo");
                WriteLiteral("ntent,\r\n                        dateForm: Datelist[key].textContent\r\n                    };\r\n                    obj.push(detail);\r\n                });\r\n                $.post(\'");
#nullable restore
#line 295 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Areas\Admin\Views\AdminClinicDetail\AddClinic.cshtml"
                   Write(Url.Content("~/Admin/AdminClinicDetail/Create"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', { obj: obj })
            })


            $('#btnDelete').on('click', function () {
                $('.repeat').parent().parent().remove();
                Swal.fire({
                    title: '刪除',
                    text: """",
                    icon: 'success'
                });
                $('#repeatCount').html("""");
                $(this).addClass(""disabled"");
            })

            //$('#btnDelete').click(function () {
            //    $('.repeat').parent().parent().remove();
            //    Swal.fire({
            //        title: '刪除',
            //        text: """",
            //        icon: 'success'
            //    });
            //    $('#repeatCount').html("""");
            //    $(this).addClass(""disabled"");
            //}) 
        });

        $(""#myModal"").on('hidden.bs.modal', function () {

            $(""input[name='chkDay']:checked"").each(function (index, item) {
                days.push($(this).val());
            });

        ");
                WriteLiteral(@"    $(""input[name='chkTime']:checked"").each(function (index, item) {
                times.push($(this).val());
            });

            $('#btnDelete').removeClass(""disabled"");
        });



        $('#selDept').change(function () {
            $('#selDoctor').select2();

            $.ajax({
                url: '/Admin/AdminClinicDetail/doctorList' + `?deptid=${selDept.value}`,
                dataType: 'json',
                data: function (params) {
                    console.log(params);
                    return {
                        q: params.term, // search term
                        page: params.page
                    };
                }
            }).then(function (data) {
                $('#selDoctor option').remove();
                data.forEach((data) => {
                    const option = new Option(data[""doctorName""], data[""doctorId""]);
                    $('#selDoctor').append(option).trigger('change');;
                })

                $");
                WriteLiteral("(\'#selDoctor\').trigger({\r\n                    type: \'select2:select\',\r\n                    params: {\r\n                        data: data\r\n                    }\r\n                });\r\n            })\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Medical.ViewModel.CClinicDetailAdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591