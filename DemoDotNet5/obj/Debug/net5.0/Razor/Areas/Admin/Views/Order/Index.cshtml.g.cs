#pragma checksum "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bac465dd9c15d411f36f6ed20db608d43f89b6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Index.cshtml")]
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
#line 1 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\_ViewImports.cshtml"
using DemoDotNet5.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\_ViewImports.cshtml"
using DemoDotNet5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bac465dd9c15d411f36f6ed20db608d43f89b6a", @"/Areas/Admin/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b5654109d4820fdaaaf30cabe68258086956ce8", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowOrderDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0 text-dark"">Order</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Total List: ");
#nullable restore
#line 21 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                                      Write(ViewBag.totalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                        <div class=\"card-tools\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bac465dd9c15d411f36f6ed20db608d43f89b6a6046", async() => {
                WriteLiteral(@"
                                <div class=""input-group input-group-sm"" style=""width: 150px;"">
                                    <input type=""text"" name=""search"" class=""form-control float-right"" placeholder=""Search"">

                                    <div class=""input-group-append"">
                                        <button type=""submit"" class=""btn btn-default""><i class=""fas fa-search""></i></button>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body table-responsive p-0"">
                        <table class=""table table-hover text-nowrap"">
                            <thead>
                                <tr>
                                    <th>Customer</th>
                                    <th>Date</th>
                                    <th>Notes</th>
                                    <th>Address</th>
                                    <th>Status</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>

");
#nullable restore
#line 50 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                 foreach (var obj in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 53 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                       Write(obj.CustomerFullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 54 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                       Write(obj.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 55 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                       Write(obj.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                       Write(obj.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 58 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                             if (obj.Status == 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button class=\"btn btn-danger\">Processing</button>\r\n");
#nullable restore
#line 61 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button class=\"btn btn-danger\">Delivery</button>\r\n");
#nullable restore
#line 65 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bac465dd9c15d411f36f6ed20db608d43f89b6a11816", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                                                                                         WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 71 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </tbody>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
        </div>


        <div class=""row"">
            <div class=""col-2"">
                <div class=""form-group"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bac465dd9c15d411f36f6ed20db608d43f89b6a15011", async() => {
                WriteLiteral("\r\n                        <div class=\"input-group\">\r\n                            <input type=\"number\" name=\"pageSize\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3982, "\"", 4007, 1);
#nullable restore
#line 88 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 3990, ViewBag.pageSize, 3990, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\">\r\n                            <input type=\"hidden\" name=\"search\"");
                BeginWriteAttribute("value", " value=\"", 4081, "\"", 4104, 1);
#nullable restore
#line 89 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 4089, ViewBag.search, 4089, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""input-group-append"">
                                <button class=""btn btn-dark"" type=""submit"">
                                    OK
                                </button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-9\">\r\n                <ul class=\"pagination justify-content-end\">\r\n");
#nullable restore
#line 102 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                      
                        int totalPages = ViewBag.totalPages;
                        int currentPage = ViewBag.currentPage;
                        string search = ViewBag.search;
                        int pageSize = ViewBag.pageSize;
                        int totalItems = ViewBag.totalItems;


                        // Hiển thị nút < nếu pageCurrent lớn hơn 1 và ngược lại thỳ sẽ gán thuộc tính disabled
                        if (currentPage > 1)
                        {
                            int previousPage = currentPage - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link active\"");
            BeginWriteAttribute("href", " href=\"", 5228, "\"", 5295, 6);
            WriteAttributeValue("", 5235, "?currentPage=", 5235, 13, true);
#nullable restore
#line 114 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 5248, previousPage, 5248, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5261, "&search=", 5261, 8, true);
#nullable restore
#line 114 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 5269, search, 5269, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5276, "&pageSize=", 5276, 10, true);
#nullable restore
#line 114 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 5286, pageSize, 5286, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">❮</a></li>\r\n");
#nullable restore
#line 115 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link active\" disabled>❮</a></li>\r\n");
#nullable restore
#line 119 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                        }

                        // Hiển thị các page nếu page nào đang hiển thị sẽ để trạng thái active
                        int i;
                        for (i = 1; i <= totalPages; i++)
                        {
                            if (i == currentPage)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5899, "\"", 5955, 6);
            WriteAttributeValue("", 5906, "?currentPage=", 5906, 13, true);
#nullable restore
#line 127 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 5919, i, 5919, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5921, "&search=", 5921, 8, true);
#nullable restore
#line 127 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 5929, search, 5929, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5936, "&pageSize=", 5936, 10, true);
#nullable restore
#line 127 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 5946, pageSize, 5946, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 127 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 128 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\"><a");
            BeginWriteAttribute("id", " id=\"", 6122, "\"", 6127, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6146, "\"", 6202, 6);
            WriteAttributeValue("", 6153, "?currentPage=", 6153, 13, true);
#nullable restore
#line 131 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 6166, i, 6166, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6168, "&search=", 6168, 8, true);
#nullable restore
#line 131 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 6176, search, 6176, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6183, "&pageSize=", 6183, 10, true);
#nullable restore
#line 131 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 6193, pageSize, 6193, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 131 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                                                                                                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 132 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                            }
                        }

                        // Hiển thị nút > nếu pageCurrent lớn hơn 0 và pageCurrent < totalPages ngược lại thỳ sẽ gán thuộc tính disabled
                        if (currentPage > 0 && currentPage < totalPages)
                        {
                            int nextPage = currentPage + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link active\"");
            BeginWriteAttribute("href", " href=\"", 6654, "\"", 6717, 6);
            WriteAttributeValue("", 6661, "?currentPage=", 6661, 13, true);
#nullable restore
#line 139 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 6674, nextPage, 6674, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6683, "&search=", 6683, 8, true);
#nullable restore
#line 139 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 6691, search, 6691, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6698, "&pageSize=", 6698, 10, true);
#nullable restore
#line 139 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
WriteAttributeValue("", 6708, pageSize, 6708, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">❯</a></li>\r\n");
#nullable restore
#line 140 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link active\" disabled>❯</a></li>\r\n");
#nullable restore
#line 144 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Areas\Admin\Views\Order\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div><!-- /.container-fluid -->\r\n</section>\r\n\r\n\r\n");
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
