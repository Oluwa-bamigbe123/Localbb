#pragma checksum "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca211da2e35af18563ac56072bd1af929eb20933"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetAllAssignedEquipment), @"mvc.1.0.view", @"/Views/Admin/GetAllAssignedEquipment.cshtml")]
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
#line 1 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\_ViewImports.cshtml"
using LocalBetBiga;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\_ViewImports.cshtml"
using LocalBetBiga.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca211da2e35af18563ac56072bd1af929eb20933", @"/Views/Admin/GetAllAssignedEquipment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec3c06dc0a026f3bdfa2c90e178675b07e27e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetAllAssignedEquipment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LocalBetBiga.Models.Entities.AdminEquipmentDistribution>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/FileSaver.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportToExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
   Layout = "_AdminDashboardLayout";
                 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca211da2e35af18563ac56072bd1af929eb209335903", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 11 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - InventorySystem</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca211da2e35af18563ac56072bd1af929eb209336567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca211da2e35af18563ac56072bd1af929eb209337745", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca211da2e35af18563ac56072bd1af929eb209338923", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
   ViewData["Title"] = "Title"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center \" style=\"margin-top: 50px\">\r\n    <h2 class=\"text-primary\">Activity List</h2>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <table class=""table"" id=""dataTable"">
            <thead>
                <tr>
                    <th>Equipment Name</th>
                    <th>Equipment Brand</th>
                    <th>Manager Name</th>
                    <th>Number Of Equipment Assigned</th>
                    <th>Date Assigned</th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 42 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
                   Write(obj.Equipments.EquipmentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
                   Write(obj.Equipments.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
                   Write(obj.Manager.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
                   Write(obj.NumberOfEquipmentAssigned);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
                   Write(obj.DateAssigned);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"



                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"text-center\">\r\n\r\n        <div class=\"card-footer foots\">\r\n            <div class=\"form-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca211da2e35af18563ac56072bd1af929eb2093314067", async() => {
                WriteLiteral("\r\n                    Export\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 82 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"


}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> Oops No Activity  Yet</p>\r\n");
#nullable restore
#line 88 "C:\Users\Laptop City\source\repos\TestLocalBetBiga\Views\Admin\GetAllAssignedEquipment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LocalBetBiga.Models.Entities.AdminEquipmentDistribution>> Html { get; private set; }
    }
}
#pragma warning restore 1591