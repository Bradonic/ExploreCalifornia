#pragma checksum "C:\Users\Bradley\Desktop\LinkedIn Learning\ASP.NET core MVC\Test\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bcf10bc1755c2d4f7d14feb3bca9d4670826437"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Post), @"mvc.1.0.view", @"/Views/Shared/_Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Post.cshtml", typeof(AspNetCore.Views_Shared__Post))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bcf10bc1755c2d4f7d14feb3bca9d4670826437", @"/Views/Shared/_Post.cshtml")]
    public class Views_Shared__Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExploreCalifornia.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(98, 49, true);
            WriteLiteral("\r\n<article class=\"blog-post\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(148, 146, false);
#line 6 "C:\Users\Bradley\Desktop\LinkedIn Learning\ASP.NET core MVC\Test\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Post.cshtml"
   Write(Html.ActionLink(Model.Title, "Post", "Blog",
            new { year = Model.Posted.Year, month = Model.Posted.Month, key = Model.Key }
        ));

#line default
#line hidden
            EndContext();
            BeginContext(294, 61, true);
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"details\">\r\n        Posted <span>");
            EndContext();
            BeginContext(356, 35, false);
#line 11 "C:\Users\Bradley\Desktop\LinkedIn Learning\ASP.NET core MVC\Test\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Post.cshtml"
                Write(Format.AsReadableDate(Model.Posted));

#line default
#line hidden
            EndContext();
            BeginContext(391, 17, true);
            WriteLiteral("</span> by <span>");
            EndContext();
            BeginContext(409, 12, false);
#line 11 "C:\Users\Bradley\Desktop\LinkedIn Learning\ASP.NET core MVC\Test\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Post.cshtml"
                                                                     Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(421, 56, true);
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"content\">\r\n        ");
            EndContext();
            BeginContext(478, 10, false);
#line 14 "C:\Users\Bradley\Desktop\LinkedIn Learning\ASP.NET core MVC\Test\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Post.cshtml"
   Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(488, 26, true);
            WriteLiteral("\r\n    </div>\r\n</article>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ExploreCalifornia.Models.FormattingService Format { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExploreCalifornia.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
