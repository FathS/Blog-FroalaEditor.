#pragma checksum "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "299d1c99ba84f92238138c23630de759394eaae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299d1c99ba84f92238138c23630de759394eaae0", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b889b3f4308041dc292b61010b9c4781c7386c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.Models.View.UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 8, true);
            WriteLiteral("\r\n\r\n<h2>");
            EndContext();
            BeginContext(134, 13, false);
#line 8 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(147, 13, true);
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n");
            EndContext();
#line 12 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(195, 23, false);
#line 14 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(222, 120, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        \r\n       \r\n\r\n        <hr />\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(343, 99, false);
#line 23 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml"
       Write(Html.LabelFor(model => model.User.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(442, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(498, 99, false);
#line 25 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml"
           Write(Html.EditorFor(model => Model.User.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(597, 88, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(686, 102, false);
#line 31 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml"
       Write(Html.LabelFor(model => Model.User.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(788, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(844, 104, false);
#line 33 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml"
           Write(Html.PasswordFor(model => Model.User.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(948, 282, true);
            WriteLiteral(@"

            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Login"" formaction=""/Account/Login"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 43 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml"
}

#line default
#line hidden
            BeginContext(1233, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1247, 40, false);
#line 46 "C:\Users\granobra-007\Desktop\Granobra\Blog\MyBlog\MyBlog\Views\Account\Login.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.Models.View.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591