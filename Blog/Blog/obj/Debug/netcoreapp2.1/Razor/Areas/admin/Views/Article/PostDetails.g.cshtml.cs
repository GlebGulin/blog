#pragma checksum "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\PostDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0448da92d82a6edd16852532e05672063358cd4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Article_PostDetails), @"mvc.1.0.view", @"/Areas/admin/Views/Article/PostDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/admin/Views/Article/PostDetails.cshtml", typeof(AspNetCore.Areas_admin_Views_Article_PostDetails))]
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
#line 1 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#line 2 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0448da92d82a6edd16852532e05672063358cd4b", @"/Areas/admin/Views/Article/PostDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Article_PostDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Models.ViewModels.ArticleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\PostDetails.cshtml"
  
    ViewData["Title"] = "Предосмотр";

#line default
#line hidden
            BeginContext(96, 32, true);
            WriteLiteral("\r\n<h2>Предосмотр</h2>\r\n\r\n<div>\r\n");
            EndContext();
            BeginContext(163, 39, true);
            WriteLiteral("    <hr />\r\n    <div class=\"article\">\r\n");
            EndContext();
            BeginContext(483, 46, true);
            WriteLiteral("        <div class=\"header\">\r\n            <h1>");
            EndContext();
            BeginContext(530, 37, false);
#line 23 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\PostDetails.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(567, 54, true);
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"imgpost\">\r\n");
            EndContext();
#line 26 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\PostDetails.cshtml"
             if (Model.Urlimg != null)
            {

#line default
#line hidden
            BeginContext(676, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 696, "\"", 728, 1);
#line 28 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\PostDetails.cshtml"
WriteAttributeValue("", 702, Url.Content(Model.Urlimg), 702, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(729, 23, true);
            WriteLiteral(" style=\"width:600px\">\r\n");
            EndContext();
#line 29 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\PostDetails.cshtml"
            }

#line default
#line hidden
            BeginContext(767, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
            BeginContext(1456, 43, true);
            WriteLiteral("        <div class=\"content\">\r\n            ");
            EndContext();
            BeginContext(1500, 39, false);
#line 53 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\PostDetails.cshtml"
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
            BeginContext(1657, 44, true);
            WriteLiteral("        <div class=\"timepost\">\r\n            ");
            EndContext();
            BeginContext(1702, 40, false);
#line 59 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\PostDetails.cshtml"
       Write(Html.DisplayFor(model => model.Timepost));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 49, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1792, 67, false);
#line 64 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\PostDetails.cshtml"
Write(Html.ActionLink("Редактировать", "EditPost", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1867, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "672eb66a3af7484ebaf26538e03d4466", async() => {
                BeginContext(1889, 5, true);
                WriteLiteral("Назад");
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
            BeginContext(1898, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Models.ViewModels.ArticleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591