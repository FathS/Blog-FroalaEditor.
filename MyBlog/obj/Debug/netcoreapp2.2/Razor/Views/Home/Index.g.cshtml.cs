#pragma checksum "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64d2aeca460d03fbd26ccd7b848d9632f006b6d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\_ViewImports.cshtml"
using MyBlog;

#line default
#line hidden
#line 2 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\_ViewImports.cshtml"
using MyBlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64d2aeca460d03fbd26ccd7b848d9632f006b6d6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b889b3f4308041dc292b61010b9c4781c7386c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.Models.View.WriteModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 34, true);
            WriteLiteral("\r\n<h3 class=\"text-center\">Merhaba ");
            EndContext();
            BeginContext(161, 15, false);
#line 7 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Home\Index.cshtml"
                           Write(ViewBag.session);

#line default
#line hidden
            EndContext();
            BeginContext(176, 277, true);
            WriteLiteral(@" Blog Sayfama Hoş Geldiniz. Umuyorum Aradığınızı Bulacaksınız. <i class=""far fa-smile-beam""></i> </h3>
<div>
    Buralarda yazılar olacak........
</div>

<table class=""table table-bordered table-hover"">
    <tr>
        <th>Id</th>
        <th>Mesaj</th>
    </tr>

");
            EndContext();
#line 18 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Home\Index.cshtml"
     foreach (var item in Model.WriteList)
    {

#line default
#line hidden
            BeginContext(504, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(535, 7, false);
#line 21 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Home\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(542, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(566, 10, false);
#line 22 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Home\Index.cshtml"
           Write(item.Mesaj);

#line default
#line hidden
            EndContext();
            BeginContext(576, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
#line 23 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Home\Index.cshtml"
                   WriteLiteral(@item.Mesaj); 

#line default
#line hidden
            BeginContext(630, 24, true);
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 26 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(661, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.Models.View.WriteModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
