#pragma checksum "C:\Users\user\OneDrive\Рабочий стол\ASP LABS\SIS - AGAIN\SIS - AGAIN\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de3e52346ec2b91933d613c48feab929b6718302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\user\OneDrive\Рабочий стол\ASP LABS\SIS - AGAIN\SIS - AGAIN\Views\_ViewImports.cshtml"
using Laboratory6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\Рабочий стол\ASP LABS\SIS - AGAIN\SIS - AGAIN\Views\_ViewImports.cshtml"
using Laboratory6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de3e52346ec2b91933d613c48feab929b6718302", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18ccac39fe14cb210df24e286fe233f070c98dfb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Laboratory6.Controllers.PlanetController>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\OneDrive\Рабочий стол\ASP LABS\SIS - AGAIN\SIS - AGAIN\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Mars";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3e52346ec2b91933d613c48feab929b67183023761", async() => {
                WriteLiteral(@"
    <style>
        body {
            font-family: fantasy;
            background-image: url('Revenge.jpg');
            background-size: cover;
        }

        p {
            font-size: 20px;
            position: absolute;
            text-align: center;
            color: darkorange;
            top: 60%;
        }

        h1 {
            cursor: help;
            margin: 0;
            text-transform: uppercase;
            padding-bottom: 5px;
            border-bottom: 3px solid yellow;
            color: red;
            position: absolute;
            left: 45%;
        }

        form {
            margin: 0 auto;
            background: rgba(100,186,255,0,77);
            width: 430px;
            height: 500px;
            padding: 20px;
            color: yellow;
            box-shadow: 2px 2px 5px rgba(0,0,0,0.82);
        }

        .group {
            margin: 10px;
            padding: 5px;
            position: relative;
            top: 25%;");
                WriteLiteral(@"
            right: 5%;
        }

        label {
            padding-left: 10px;
            text-transform: uppercase;
        }

        input {
            margin-top: 10px;
            height: 40px;
            width: 400px;
            border-radius: 20px/20px;
            border: none;
            box-shadow: 2px 2px 5px rgba(0,0,0,0.82);
        }

            input:focus {
                border: 2px solid black;
                transform: translateX(15px);
                width: 150px;
            }

        button {
            cursor: pointer;
            padding: 10px 20px;
            height: 50px;
            color: #fff;
            background: #5200a5;
            border: none;
            text-transform: uppercase;
            font-size: 20px;
            box-shadow: 2px 2px 5px rgba(0,0,0,0.82);
        }

        .newbut {
            position: absolute;
            left: 30%;
            top: 40%;
        }

        button:hover {
            opa");
                WriteLiteral(@"city: .80;
            font-weight: bold;
            transform: scale(1.1);
        }

        #Zone51 {
            color: red;
            font-size: 20px;
            position: absolute;
            top: 80%;
            left: 30%;
            font-family: Tahoma;
        }

        a {
            color: yellow;
        }

        .nwbut {
            text-align: center;
            position: absolute;
            font-size: 20px;
            cursor: pointer;
            box-shadow: 2px 2px 5px rgba(0,0,0,0.82);
            top: 57%;
            left: 47.3%;
        }
    </style>
    <h1 title=""Форма регистрации на сайте"">ВОЙТИ В СЕТЬ</h1>
    <div class=""group"">
        <label");
                BeginWriteAttribute("for", " for=\"", 2879, "\"", 2885, 0);
                EndWriteAttribute();
                WriteLiteral(">ЛОГИН: </label>\r\n        <input type=\"text\">\r\n       \r\n\r\n    </div>\r\n    <div class=\"group\">\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 2995, "\"", 3001, 0);
                EndWriteAttribute();
                WriteLiteral(">ПАРОЛЬ: </label>\r\n        <input type=\"password\">\r\n      \r\n\r\n    </div>\r\n    <button type =\"submit\" value=\"Filter\" class=\"nwbut\"><a href =\"MarsControllers/Create\">ВОЙТИ</a></button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 133 "C:\Users\user\OneDrive\Рабочий стол\ASP LABS\SIS - AGAIN\SIS - AGAIN\Views\Home\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Laboratory6.Controllers.PlanetController> Html { get; private set; }
    }
}
#pragma warning restore 1591
