#pragma checksum "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\Lookpost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7222a0fe2c4bc857530952b1cf09788b818280d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Lookpost), @"mvc.1.0.view", @"/Views/Blog/Lookpost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Lookpost.cshtml", typeof(AspNetCore.Views_Blog_Lookpost))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7222a0fe2c4bc857530952b1cf09788b818280d", @"/Views/Blog/Lookpost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Lookpost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Models.Data.Articles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\Lookpost.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
            BeginContext(79, 11, true);
            WriteLiteral("\r\n\r\n<div>\r\n");
            EndContext();
            BeginContext(125, 39, true);
            WriteLiteral("    <hr />\r\n    <div class=\"article\">\r\n");
            EndContext();
            BeginContext(445, 46, true);
            WriteLiteral("        <div class=\"header\">\r\n            <h1>");
            EndContext();
            BeginContext(492, 37, false);
#line 21 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\Lookpost.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(529, 54, true);
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"imgpost\">\r\n");
            EndContext();
#line 24 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\Lookpost.cshtml"
             if (Model.Urlimg != null)
            {

#line default
#line hidden
            BeginContext(638, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 658, "\"", 690, 1);
#line 26 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\Lookpost.cshtml"
WriteAttributeValue("", 664, Url.Content(Model.Urlimg), 664, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(691, 23, true);
            WriteLiteral(" style=\"width:600px\">\r\n");
            EndContext();
#line 27 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\Lookpost.cshtml"
            }

#line default
#line hidden
            BeginContext(729, 61, true);
            WriteLiteral("        </div>\r\n\r\n        <div class=\"content\">\r\n            ");
            EndContext();
            BeginContext(791, 39, false);
#line 31 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\Lookpost.cshtml"
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(830, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
            BeginContext(948, 44, true);
            WriteLiteral("        <div class=\"timepost\">\r\n            ");
            EndContext();
            BeginContext(993, 40, false);
#line 37 "G:\LearnProgramming\Execution\Core\blog-reserv\Blog\Blog\Views\Blog\Lookpost.cshtml"
       Write(Html.DisplayFor(model => model.Timepost));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 49, true);
            WriteLiteral("\r\n        </div>\r\n       \r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Models.Data.Articles> Html { get; private set; }
    }
}
#pragma warning restore 1591