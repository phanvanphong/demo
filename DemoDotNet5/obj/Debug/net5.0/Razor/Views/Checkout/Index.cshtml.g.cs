#pragma checksum "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e5960d4a2cb8a61529833423cee9b1f0ebdddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
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
#line 1 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\_ViewImports.cshtml"
using DemoDotNet5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\_ViewImports.cshtml"
using DemoDotNet5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e5960d4a2cb8a61529833423cee9b1f0ebdddc", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"906744715971c90226ceeb223efdb4d38725c44e", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Returning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostCheckout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/site/assets\\img\\visha\\papyel.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
  
    ViewData["Title"] = "Checkout";
    Layout = "~/Views/Shared/_Layout1.cshtml";
    var carts = ViewBag.carts;
    var customerViewModel = ViewBag.customerViewModel;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""Checkout_section"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""user-actions mb-20"">
                <h3>
                    <i class=""fa fa-file-o"" aria-hidden=""true""></i>
                    Returning home?
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6e5960d4a2cb8a61529833423cee9b1f0ebdddc7055", async() => {
                WriteLiteral("Click here to home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </h3>\r\n            </div>\r\n            <div class=\"user-actions mb-20\">\r\n                <h3>\r\n                    <i class=\"fa fa-file-o\" aria-hidden=\"true\"></i>\r\n                    Returning my cart?\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6e5960d4a2cb8a61529833423cee9b1f0ebdddc8773", async() => {
                WriteLiteral("Click here to my cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </h3>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"checkout_form\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6 col-md-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6e5960d4a2cb8a61529833423cee9b1f0ebdddc10448", async() => {
                WriteLiteral("\r\n                    <h3>Billing Details</h3>\r\n                    <div class=\"row\">\r\n                        <input type=\"hidden\" name=\"customerId\"");
                BeginWriteAttribute("value", " value=\"", 1269, "\"", 1298, 1);
#nullable restore
#line 36 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 1277, customerViewModel.Id, 1277, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <div class=\"col-lg-6 mb-30\">\r\n                            <label>Full Name<span>*</span></label>\r\n                            <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1472, "\"", 1507, 1);
#nullable restore
#line 39 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 1480, customerViewModel.Fullname, 1480, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                        </div>
                        <div class=""col-6 mb-30"">
                            <label>Phone <span>*</span></label>
                            <input type=""text"" value=""0909009009"" disabled>
                        </div>
                        <div class=""col-lg-12 mb-30"">
                            <label>Email <span>*</span></label>
                            <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 1943, "\"", 1975, 1);
#nullable restore
#line 47 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 1951, customerViewModel.Email, 1951, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n                        </div>\r\n                        <div class=\"col-12 mb-30\">\r\n                            <label>Address <span>*</span></label>\r\n                            <input type=\"text\" name=\"Address\"");
                BeginWriteAttribute("value", " value=\"", 2200, "\"", 2234, 1);
#nullable restore
#line 51 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 2208, customerViewModel.Address, 2208, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required>
                        </div>
                        <div class=""col-12"">
                            <div class=""order-notes"">
                                <label for=""order_note"">Order Notes</label>
                                <textarea placeholder=""Enter notes for shipper ...."" name=""notes"" rows=""3"" cols=""50"" required></textarea>
                            </div>
                        </div>
                    </div>
                    <div class=""order_button"">
                        <button type=""submit"">Proceed to PayPal</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6e5960d4a2cb8a61529833423cee9b1f0ebdddc15355", async() => {
                WriteLiteral(@"
                    <h3>Your order</h3>
                    <div class=""order_table table-responsive mb-30"">
                        <table>
                            <thead>
                                <tr>
                                    <th>Product</th>
                                    <th>Quantity</th>
                                    <th>Price</th>
                                    <th>Total</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 79 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
                                  
                                    var total = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
                                 foreach (var cart in carts)
                                {
                                    total += @cart.Quantity * @cart.Product.Price;
                                    var totalItem = @cart.Quantity * @cart.Product.Price;
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\r\n                                        <td>");
#nullable restore
#line 87 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
                                       Write(cart.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 88 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
                                       Write(cart.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 89 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
                                       Write(String.Format("{0:n0}", cart.Product.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 90 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
                                       Write(String.Format("{0:n0}", totalItem));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <sup>VNĐ</sup></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 92 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                            <tfoot>\r\n                                <tr>\r\n                                    <th colspan=\"3\">Cart Subtotal</th>\r\n                                    <td>");
#nullable restore
#line 97 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
                                   Write(String.Format("{0:n0}", total));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <sup>VNĐ</sup></td>
                                </tr>
                                <tr>
                                    <th colspan=""3"">Shipping</th>
                                    <td><strong>Freeship</strong></td>
                                </tr>
                                <tr class=""order_total"">
                                    <th colspan=""3"">Order Total</th>
                                    <td><strong>");
#nullable restore
#line 105 "D:\ASPNETCore\DemoDotNet5\Demo\DemoDotNet5\Views\Checkout\Index.cshtml"
                                           Write(String.Format("{0:n0}", total));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <sup>VNĐ</sup></strong></td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                    <div class=""payment_method"">
                        <div class=""panel-default"">
                            <input id=""payment"" name=""check_method"" type=""radio"" data-target=""createp_account"">
                            <label for=""payment"" data-toggle=""collapse"" data-target=""#method"" aria-controls=""method"">Payment on delivery ?</label>

                            <div id=""method"" class=""collapse one"" data-parent=""#accordion"">
                                <div class=""card-body1"">
                                    <p>Please check the item before paying.</p>
                                </div>
                            </div>
                        </div>

                        <div class=""panel-default"">
                            <input id=""payment_defult"" name=""check_method"" type=""radio"" data-");
                WriteLiteral("target=\"createp_account\">\r\n                            <label for=\"payment_defult\" data-toggle=\"collapse\" data-target=\"#collapsedefult\" aria-controls=\"collapsedefult\">Payment by Bank card ?  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c6e5960d4a2cb8a61529833423cee9b1f0ebdddc21012", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</label>

                            <div id=""collapsedefult"" class=""collapse one"" data-parent=""#accordion"">
                                <div class=""card-body1"">
                                    <p>We currently do not support payment by Bank card </p>
                                </div>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
