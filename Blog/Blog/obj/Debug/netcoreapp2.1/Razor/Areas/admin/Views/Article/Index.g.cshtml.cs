#pragma checksum "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc09a2774b2a3aecb510b784cf338b7f005d875"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Article_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Article/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/admin/Views/Article/Index.cshtml", typeof(AspNetCore.Areas_admin_Views_Article_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc09a2774b2a3aecb510b784cf338b7f005d875", @"/Areas/admin/Views/Article/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Article_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog.Models.ViewModels.ArticleViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(104, 31, true);
            WriteLiteral("\r\n<h2>Заметки</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(135, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e3543b9a32f4ab7a263ff57451bbc58", async() => {
                BeginContext(159, 14, true);
                WriteLiteral("Добавить новую");
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
            BeginContext(177, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
#line 12 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
 if (TempData["NotFound"] != null)
{

#line default
#line hidden
            BeginContext(224, 74, true);
            WriteLiteral("    <div class=\"alert alert-danger\">Запись удалена либо не создана</div>\r\n");
            EndContext();
#line 15 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
}

#line default
#line hidden
#line 16 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
 if (TempData["Del"] != null)
{

#line default
#line hidden
            BeginContext(335, 67, true);
            WriteLiteral("    <div class=\"alert alert-success\">Запись успешно удалена</div>\r\n");
            EndContext();
#line 19 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
}

#line default
#line hidden
#line 20 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
            BeginContext(428, 31, true);
            WriteLiteral("    <h2>Посты не созданы</h2>\r\n");
            EndContext();
#line 23 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(471, 84, true);
            WriteLiteral("    <table class=\"table sorting\" id=\"articles\">\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
            BeginContext(673, 22, true);
            WriteLiteral("                <th>\r\n");
            EndContext();
            BeginContext(763, 84, true);
            WriteLiteral("                    <h3>Название</h3>\r\n                </th>\r\n                <th>\r\n");
            EndContext();
            BeginContext(914, 60, true);
            WriteLiteral("                    <h3>Ссылка</h3>\r\n                </th>\r\n");
            EndContext();
            BeginContext(1219, 22, true);
            WriteLiteral("                <th>\r\n");
            EndContext();
            BeginContext(1311, 83, true);
            WriteLiteral("                    <h3>Отрывок</h3>\r\n                </th>\r\n                <th>\r\n");
            EndContext();
            BeginContext(1465, 88, true);
            WriteLiteral("                    <h3>Опубликовано</h3>\r\n                </th>\r\n                <th>\r\n");
            EndContext();
            BeginContext(1624, 143, true);
            WriteLiteral("                    <h3>Действия</h3>\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 62 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1824, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1843, "\"", 1859, 2);
            WriteAttributeValue("", 1848, "id_", 1848, 3, true);
#line 64 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
WriteAttributeValue("", 1851, item.Id, 1851, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1860, "\"", 1878, 1);
#line 64 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
WriteAttributeValue("", 1868, item.Slug, 1868, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1879, 42, true);
            WriteLiteral(" title=\"Потяните чтобы отсортировать\">\r\n\r\n");
            EndContext();
            BeginContext(2034, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2085, 40, false);
#line 70 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2125, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2205, 39, false);
#line 73 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Slug));

#line default
#line hidden
            EndContext();
            BeginContext(2244, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(2508, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2559, 42, false);
#line 82 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(2601, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2681, 43, false);
#line 85 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Timepost));

#line default
#line hidden
            EndContext();
            BeginContext(2724, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2804, 61, false);
#line 88 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
                   Write(Html.ActionLink("Изменить", "EditPost", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2865, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2894, 66, false);
#line 89 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
                   Write(Html.ActionLink("Предосмотр", "PostDetails", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2960, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2989, 89, false);
#line 90 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
                   Write(Html.ActionLink("Удалить", "PostDelete", new { id = item.Id }, new { @class = "delete" }));

#line default
#line hidden
            EndContext();
            BeginContext(3078, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 93 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3145, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 96 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Areas\admin\Views\Article\Index.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(3197, 820, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.4.1.js""></script>
    <script src=""https://code.jquery.com/ui/1.12.0/jquery-ui.js""></script>
    <script>
        $(function () {

            $("".delete"").click(function () {
                if (!confirm(""Вы уверенны?"")) return false;


            });
            $(""table#articles tbody"").sortable({
                //item: ""tr:not(.home)"",
                item: ""tr"",
                placeholder: ""ui-state-heighlight"",
                update: function () {
                    var ids = $(""table#articles tbody"").sortable(""serialize"");
                    var url = ""/admin/Article/RewriteList"";
                    $.post(url, ids, function (data) {

                    })
                }
            });
        });
    </script>
    ");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog.Models.ViewModels.ArticleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
