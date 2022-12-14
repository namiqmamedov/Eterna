#pragma checksum "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b342253b72064fed5011a9ba6d3c8b68af61c15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pricing_Index), @"mvc.1.0.view", @"/Views/Pricing/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b342253b72064fed5011a9ba6d3c8b68af61c15", @"/Views/Pricing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45025a40f2e229589622f664f7ec2539e25bd081", @"/Views/_ViewImports.cshtml")]
    public class Views_Pricing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pricing>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
  
    ViewData["Title"] = "Index";
    List<PRService> PRServices = ViewBag.PRServices;
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ======= Breadcrumbs ======= -->
<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">

        <ol>
            <li><a href=""index.html"">Home</a></li>
            <li>Pricing</li>
        </ol>
        <h2>Pricing</h2>

    </div>
</section><!-- End Breadcrumbs -->
<!-- ======= Pricing Section ======= -->
<section id=""pricing"" class=""pricing"">
    <div class=""container"">

        <div class=""row no-gutters"">

");
#nullable restore
#line 25 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
             foreach (Pricing item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 633, "\"", 690, 3);
            WriteAttributeValue("", 641, "col-lg-4", 641, 8, true);
            WriteAttributeValue(" ", 649, "box", 650, 4, true);
#nullable restore
#line 27 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
WriteAttributeValue(" ", 653, item.isFeatured ? "featured" : "", 654, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <h3>");
#nullable restore
#line 28 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <h4>$ ");
#nullable restore
#line 29 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>per month</span></h4>\n                    <ul>\n");
#nullable restore
#line 31 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
                         foreach (PRService service in PRServices)
                        {
                            if (item.PricingServices.Exists(ps => ps.PRServiceId == service.Id))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><i class=\"bx bx-check\"></i>");
#nullable restore
#line 35 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
                                                          Write(service.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 36 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"na\"><i class=\"bx bx-x\"></i> <span>");
#nullable restore
#line 39 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
                                                                        Write(service.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n");
#nullable restore
#line 40 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n");
#nullable restore
#line 43 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
                     if (item.IsBuy)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\" class=\"buy-btn\">Buy Now</a>\n");
#nullable restore
#line 46 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\" class=\"buy-btn\">Buy Now</a>\r\n");
#nullable restore
#line 50 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n");
#nullable restore
#line 52 "C:\Users\ACER\source\repos\C#\eternaa-master\WebApplication4\Views\Pricing\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \n\n        </div>\n\n    </div>\n</section><!-- End Pricing Section -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pricing>> Html { get; private set; }
    }
}
#pragma warning restore 1591
