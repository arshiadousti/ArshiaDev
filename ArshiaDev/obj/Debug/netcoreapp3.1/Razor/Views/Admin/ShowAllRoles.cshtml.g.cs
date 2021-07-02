#pragma checksum "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\ShowAllRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a2b3f3ad3b1369cd660a8a4493640142f15ede0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ShowAllRoles), @"mvc.1.0.view", @"/Views/Admin/ShowAllRoles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2b3f3ad3b1369cd660a8a4493640142f15ede0", @"/Views/Admin/ShowAllRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4544f42a03de5bac8fdd2d7fac86f98053b793b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ShowAllRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ArshiaDev.DataAccessLayer.Entities.Role>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RolePermissions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\ShowAllRoles.cshtml"
  
    ViewData["Title"] = "نقش ها";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>نمایش نقش های سایت</h1>\r\n\r\n<p>\r\n    <a class=\"btn btn-primary\" onclick=\"AddRole()\">ایجاد نقش جدید </a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\ShowAllRoles.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>عملیات</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\ShowAllRoles.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 537, "\"", 555, 2);
            WriteAttributeValue("", 542, "role_", 542, 5, true);
#nullable restore
#line 24 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\ShowAllRoles.cshtml"
WriteAttributeValue("", 547, item.Id, 547, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>\r\n                ");
#nullable restore
#line 26 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\ShowAllRoles.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-xs btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 725, "\"", 753, 3);
            WriteAttributeValue("", 735, "EditRole(", 735, 9, true);
#nullable restore
#line 29 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\ShowAllRoles.cshtml"
WriteAttributeValue("", 744, item.Id, 744, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 752, ")", 752, 1, true);
            EndWriteAttribute();
            WriteLiteral("> ویرایش</a> | \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a2b3f3ad3b1369cd660a8a4493640142f15ede05817", async() => {
                WriteLiteral(" تعیین سطح دسترسی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\ShowAllRoles.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" | \r\n                <a class=\"btn btn-xs btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 948, "\"", 978, 3);
            WriteAttributeValue("", 958, "DeleteRole(", 958, 11, true);
#nullable restore
#line 31 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\ShowAllRoles.cshtml"
WriteAttributeValue("", 969, item.Id, 969, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 977, ")", 977, 1, true);
            EndWriteAttribute();
            WriteLiteral("> حذف</a> \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\ShowAllRoles.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""background-color:lavender"">
                <h5 class=""modal-title"" id=""modalTitle""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""ModalBody"">

                </div>
            </div>
");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Dev", async() => {
                WriteLiteral(@" 


   <script>
       function AddRole() {
           $.get(""/Admin/AddRole"", function (result) {
               $(""#myModal"").modal('show');
               $(""#ModalBody"").html(result);
               $(""#modalTitle"").html(""افزودن نقش جدید"");
           })
       }
   </script>

<script>
    function EditRole(id) {
        $.get(""/Admin/EditRole/"" + id, function (result) {
            $(""#myModal"").modal('show');
            $(""#ModalBody"").html(result);
            $(""#modalTitle"").html(""ویرایش نقش"");
        })
    }
</script>

<script>
    function DeleteRole(id) {

        if (confirm(""آیا از حذف مطمئن هستید؟"")) {
            $.get(""/Admin/DeleteRole/"" + id, function () {
                $(""#role_"" + id).hide('slow');
            })
        }
    }
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ArshiaDev.DataAccessLayer.Entities.Role>> Html { get; private set; }
    }
}
#pragma warning restore 1591
