#pragma checksum "C:\Users\Administrator\source\repos\UniversityTutorManageSys\UniversityTutorManageSys\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bb4b498ffa526c48cd3863fa92c4aec8e30c711"
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
#line 1 "C:\Users\Administrator\source\repos\UniversityTutorManageSys\UniversityTutorManageSys\Views\_ViewImports.cshtml"
using UniversityTutorManageSys;

#line default
#line hidden
#line 2 "C:\Users\Administrator\source\repos\UniversityTutorManageSys\UniversityTutorManageSys\Views\_ViewImports.cshtml"
using UniversityTutorManageSys.Models;

#line default
#line hidden
#line 1 "C:\Users\Administrator\source\repos\UniversityTutorManageSys\UniversityTutorManageSys\Views\Home\Index.cshtml"
using UniversityTutorManageSys.HelperService;

#line default
#line hidden
#line 2 "C:\Users\Administrator\source\repos\UniversityTutorManageSys\UniversityTutorManageSys\Views\Home\Index.cshtml"
using System.IO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb4b498ffa526c48cd3863fa92c4aec8e30c711", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404eaacac9026944e407bfb60e3fb9cb6630e231", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Administrator\source\repos\UniversityTutorManageSys\UniversityTutorManageSys\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            DefineSection("head", async() => {
                BeginContext(127, 1445, true);
                WriteLiteral(@"
    <style type=""text/css"">
        /*非常重要的样式让背景图片100%适应整个屏幕*/
        .bg {
            display: table;
            width: 100%;
            height: 100%;
            padding: 100px 0;
            text-align: center;
            color: #fff;
            background: url(""/images/bg/reba4.jpg"") no-repeat bottom center;
            background-color: #000;
            background-size: cover;
        }

        .my-navbar {
            padding: 20px 0;
            transition: background 0.5s ease-in-out, padding 0.5s ease-in-out;
            background: #000000;
        }

            .my-navbar a {
                background: transparent !important;
                color: #fff !important
            }

                .my-navbar a:hover {
                    color: #45bcf9 !important;
                    background: transparent;
                    outline: 0
                }

            .my-navbar a {
                transition: color 0.5s ease-in-out;
            }
       ");
                WriteLiteral(@" /*-webkit-transition ;-moz-transition*/
        .top-nav {
            padding: 0;
            background: #000;
        }

        button.navbar-toggle {
            background-color: #fbfbfb;
        }
            /*整个背景都是transparent透明的，会看不到，所以再次覆盖一下*/
            button.navbar-toggle > span.icon-bar {
                background-color: #dedede
            }
    </style>
    <script>

    </script>
");
                EndContext();
            }
            );
            BeginContext(2495, 439, true);
            WriteLiteral(@"
<div class=""logo fl"">
    <img src = ""~/images/login/logo_cd.png"" />
</div>
<div class=""head clearfix"" id=""index_head"">
    <div class=""navbar menu fl"">
        <ul class=""nav"">
            <li class=""dropdown"">
                <a href=""javascript:;"" onclick=""addTab('0','首页', '/');"" class=""dropdown-toggle drop1"" data-toggle=""dropdown"" type=""button"">
                    首页
                </a>
            </li>
            ");
            EndContext();
            BeginContext(2935, 22, false);
#line 90 "C:\Users\Administrator\source\repos\UniversityTutorManageSys\UniversityTutorManageSys\Views\Home\Index.cshtml"
       Write(Html.Raw(ViewBag.Menu));

#line default
#line hidden
            EndContext();
            BeginContext(2957, 423, true);
            WriteLiteral(@"
        </ul>
    </div>
</div>

<div class=""bg""></div>
<br /><br /><br /><br /><br /><br /><br /><p><a href=""/Home/htmlpage"" target=""_blank"">闲蛋客</a></p>

<script type=""text/javascript"">
    $(window).scroll(function () {
        if ($("".navbar"").offset().top > 50) {
            $("".navbar-fixed-top"").addClass(""top-nav"");
        } else { $("".navbar-fixed-top"").removeClass(""top-nav""); }
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591