#pragma checksum "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9668b8e795a087365192b9c277b05734745b6132"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_ShowComments), @"mvc.1.0.view", @"/Views/Blog/ShowComments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/ShowComments.cshtml", typeof(AspNetCore.Views_Blog_ShowComments))]
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
#line 1 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#line 2 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9668b8e795a087365192b9c277b05734745b6132", @"/Views/Blog/ShowComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_ShowComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog.Models.Data.Comments>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(47, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(58, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "939b628e2bdf4117b6e338006121f43b", async() => {
                BeginContext(81, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(95, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(188, 38, false);
#line 10 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(226, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(282, 40, false);
#line 13 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.DisplayNameFor(model => model.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(322, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(378, 43, false);
#line 16 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(421, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(477, 46, false);
#line 19 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.DisplayNameFor(model => model.ArticlesId));

#line default
#line hidden
            EndContext();
            BeginContext(523, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(579, 47, false);
#line 22 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.DisplayNameFor(model => model.Timecomment));

#line default
#line hidden
            EndContext();
            BeginContext(626, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(744, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(793, 37, false);
#line 31 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(830, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(886, 39, false);
#line 34 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(925, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(981, 42, false);
#line 37 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1079, 45, false);
#line 40 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArticlesId));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1180, 46, false);
#line 43 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Timecomment));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1282, 65, false);
#line 46 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1368, 71, false);
#line 47 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1460, 69, false);
#line 48 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\ShowComments.cshtml"
}

#line default
#line hidden
            BeginContext(1568, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog.Models.Data.Comments>> Html { get; private set; }
    }
}
#pragma warning restore 1591
