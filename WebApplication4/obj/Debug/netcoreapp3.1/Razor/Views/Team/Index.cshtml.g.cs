#pragma checksum "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45f9cf61bc38298ba97464d298b0938670f3cbef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
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
#line 2 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.DAL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f9cf61bc38298ba97464d298b0938670f3cbef", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45025a40f2e229589622f664f7ec2539e25bd081", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Trainer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- ======= Breadcrumbs ======= -->
<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">

        <ol>
            <li><a href=""index.html"">Home</a></li>
            <li>Team</li>
        </ol>
        <h2>Team</h2>

    </div>
</section><!-- End Breadcrumbs -->

<!-- ======= Team Section ======= -->
<section id=""team"" class=""team"">
    <div class=""container"">

        <div class=""row"">
");
#nullable restore
#line 25 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
             foreach (Trainer item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\n                    <div class=\"member\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45f9cf61bc38298ba97464d298b0938670f3cbef4497", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 683, "~/img/team/", 683, 11, true);
#nullable restore
#line 29 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
AddHtmlAttributeValue("", 694, item.Image, 694, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 705, "", 706, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <h4>");
#nullable restore
#line 30 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                                  Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                        <span>");
#nullable restore
#line 31 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                         Write(item.Position.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        <p>\n                            ");
#nullable restore
#line 33 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n                        <div class=\"social\">\n");
#nullable restore
#line 36 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                             if (item.FacebookURL != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1102, "\"", 1126, 1);
#nullable restore
#line 38 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
WriteAttributeValue("", 1109, item.FacebookURL, 1109, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\n");
#nullable restore
#line 39 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                             if (item.TwitterURL != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1315, "\"", 1338, 1);
#nullable restore
#line 42 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
WriteAttributeValue("", 1322, item.TwitterURL, 1322, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\n");
#nullable restore
#line 43 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                             if (item.InstagramURL != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1528, "\"", 1553, 1);
#nullable restore
#line 46 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
WriteAttributeValue("", 1535, item.InstagramURL, 1535, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\n");
#nullable restore
#line 47 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                             if (item.LinkedinURL != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1744, "\"", 1768, 1);
#nullable restore
#line 50 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
WriteAttributeValue("", 1751, item.LinkedinURL, 1751, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-linkedin\"></i></a>\n");
#nullable restore
#line 51 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 56 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Team\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </div>\n\n    </div>\n</section><!-- End Team Section -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Trainer>> Html { get; private set; }
    }
}
#pragma warning restore 1591