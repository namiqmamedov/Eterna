#pragma checksum "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\PortfolioDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bae510c2980c20633bbb2e6fee19f690b82854fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortfolioDetail_Index), @"mvc.1.0.view", @"/Views/PortfolioDetail/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae510c2980c20633bbb2e6fee19f690b82854fd", @"/Views/PortfolioDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45025a40f2e229589622f664f7ec2539e25bd081", @"/Views/_ViewImports.cshtml")]
    public class Views_PortfolioDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\PortfolioDetail\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">

        <ol>
            <li><a href=""index.html"">Home</a></li>
            <li>Portfolio Details</li>
        </ol>
        <h2>Portfolio Details</h2>

    </div>
</section><!-- End Breadcrumbs -->
<!-- ======= Portfolio Details Section ======= -->
<section id=""portfolio-details"" class=""portfolio-details"">
    <div class=""container"">

        <div class=""row gy-4"">

            <div class=""col-lg-8"">
                <div class=""portfolio-details-slider swiper"">
                    <div class=""swiper-wrapper align-items-center"">

                        <div class=""swiper-slide"">
                            <img src=""assets/img/portfolio/portfolio-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 805, "\"", 811, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n\r\n                        <div class=\"swiper-slide\">\r\n                            <img src=\"assets/img/portfolio/portfolio-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 976, "\"", 982, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n\r\n                        <div class=\"swiper-slide\">\r\n                            <img src=\"assets/img/portfolio/portfolio-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1147, "\"", 1153, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                    </div>
                    <div class=""swiper-pagination""></div>
                </div>
            </div>

            <div class=""col-lg-4"">
                <div class=""portfolio-info"">
                    <h3>Project information</h3>
                    <ul>
                        <li><strong>Category</strong>: Web design</li>
                        <li><strong>Client</strong>: ASU Company</li>
                        <li><strong>Project date</strong>: 01 March, 2020</li>
                        <li><strong>Project URL</strong>: <a href=""#"">www.example.com</a></li>
                    </ul>
                </div>
                <div class=""portfolio-description"">
                    <h2>This is an example of portfolio detail</h2>
                    <p>
                        Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit no");
            WriteLiteral(@"n officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.
                    </p>
                </div>
            </div>

        </div>

    </div>
</section><!-- End Portfolio Details Section -->
");
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
