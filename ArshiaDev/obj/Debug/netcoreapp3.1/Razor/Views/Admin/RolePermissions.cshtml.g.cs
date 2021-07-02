#pragma checksum "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\RolePermissions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0198b03d10875f7f0b4004ceb4bd56273187e1a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RolePermissions), @"mvc.1.0.view", @"/Views/Admin/RolePermissions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0198b03d10875f7f0b4004ceb4bd56273187e1a2", @"/Views/Admin/RolePermissions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4544f42a03de5bac8fdd2d7fac86f98053b793b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RolePermissions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ArshiaDev.DataAccessLayer.Entities.Persmissions>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowAllRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RolePermissions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\RolePermissions.cshtml"
  
    ViewData["Title"] = "تعیین دسترسی";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int roleId = ViewBag.roleId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\RolePermissions.cshtml"
 if (ViewBag.RolePermissionError == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <h3>لطفا حداقل یک دسترسی را انتخاب نمایید.</h3>\r\n    </div>\r\n");
#nullable restore
#line 14 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\RolePermissions.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">تعیین سطح دسترسی</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0198b03d10875f7f0b4004ceb4bd56273187e1a24922", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3 col-md-offset-2\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0198b03d10875f7f0b4004ceb4bd56273187e1a25271", async() => {
                    WriteLiteral(" بازگشت");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <input class=""float-left btn btn-primary"" type=""submit"" value=""ثبت"" />

        </div>
        <div class=""col-md-3 col-md-offset-1"">
            <input type=""text"" class=""form-control"" placeholder=""جستجو..."" id=""rolePermissionSearch"" onkeyup=""RolePermissionSearch()"" />
        </div> 
    </div>
    <div class=""row"">
        <div class=""col-md-6 col-md-offset-3"" style=""margin-top:30px;"">
            <ul style=""list-style:none"" id=""rolePersmissionUl"">
");
#nullable restore
#line 31 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\RolePermissions.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li style=\"background-color:lavender; margin:10px;padding:10px;\">\r\n                        <a style=\"color:black; font-size:16px;\">\r\n                            <input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1399, "\"", 1415, 1);
#nullable restore
#line 35 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\RolePermissions.cshtml"
WriteAttributeValue("", 1407, item.Id, 1407, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"permissionsId\" id=\"permissionsId\" style=\"margin-right:5px;\" ");
#nullable restore
#line 35 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\RolePermissions.cshtml"
                                                                                                                                  Write((await inject.ExsistRolePermission(roleId,item.Id)?"checked":""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n                            ");
#nullable restore
#line 36 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\RolePermissions.cshtml"
                       Write(item.PermissionName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 39 "F:\MyApplications\ArshiaDev\ArshiaDev\Views\Admin\RolePermissions.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Dev", async() => {
                WriteLiteral(@" 
<script>
    function RolePermissionSearch() {
        var input, filter, ul, a, li, txtValue;
        input = document.getElementById(""rolePermissionSearch"");
        filter = input.value.toUpperCase();
        ul = document.getElementById(""rolePersmissionUl"");
        li = ul.getElementsByTagName(""li"");

        for (var i = 0; i < li.length; i++) {
            a = li[i].getElementsByTagName(""a"")[0];
            if (a) {
                txtValue = a.innerHTML || a.textContent;

                if (txtValue.toUpperCase().indexOf(filter) >= 0) {
                    li[i].style.display = """";
                }
                else {
                    li[i].style.display = ""none"";
                }

            }
        }
    }
</script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ArshiaDev.Core.Classes.Injection inject { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ArshiaDev.DataAccessLayer.Entities.Persmissions>> Html { get; private set; }
    }
}
#pragma warning restore 1591