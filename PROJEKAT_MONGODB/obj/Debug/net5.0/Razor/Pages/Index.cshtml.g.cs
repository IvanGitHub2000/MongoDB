#pragma checksum "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bf2be8b8aa67f54367196d002a17e96deda806c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROJEKAT_MONGODB.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace PROJEKAT_MONGODB.Pages
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
#line 1 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\_ViewImports.cshtml"
using PROJEKAT_MONGODB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bf2be8b8aa67f54367196d002a17e96deda806c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad01a6fbccda5a777b2a6608859c87dbe32df943", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""w3l-main-slider"" id=""home"">
    <!-- main-slider -->
    <div class=""companies20-content"">
        <div class=""companies-wrapper""></div>
        <div class=""owl-one owl-carousel owl-theme"">
            <div class=""item"">
                <li>
                    <div class=""slider-info banner-view bg bg2"" data-selector="".bg.bg2"">
                        <div class=""banner-info"">
                            <div class=""container"">
                                <div class=""banner-info-bg"">
                                    <h6>Australia</h6>



                                    <a class=""btn btn-secondary btn-theme2 mt-5"" href=""/Destinacije""> BookYour Room Now!</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
            </div>
            <div class=""item"">
                <li>
                    <div class=""slider-info  banner-view banner-top1 bg bg2"" dat");
            WriteLiteral(@"a-selector="".bg.bg2"">
                        <div class=""banner-info"">
                            <div class=""container"">
                                <div class=""banner-info-bg"">
                                    <h6>Montenegro</h6>

                                    <a class=""btn btn-secondary btn-theme2 mt-5"" href=""/Destinacije""> BookYour Room Now!</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
            </div>
            <div class=""item"">
                <li>
                    <div class=""slider-info banner-view banner-top2 bg bg2"" data-selector="".bg.bg2"">
                        <div class=""banner-info"">
                            <div class=""container"">
                                <div class=""banner-info-bg"">
                                    <h6>Thaiwan</h6>

                                    <a class=""btn btn-secondary btn-theme2 mt-5"" href=""/Desti");
            WriteLiteral(@"nacije""> BookYour Room Now!</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
            </div>
            <div class=""item"">
                <li>
                    <div class=""slider-info banner-view banner-top3 bg bg2"" data-selector="".bg.bg2"">
                        <div class=""banner-info"">
                            <div class=""container"">
                                <div class=""banner-info-bg"">
                                    <h6>Malta</h6>
                                    s
                                    <a class=""btn btn-secondary btn-theme2 mt-5"" href=""/Destinacije""> BookYour Room Now!</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
            </div>
        </div>
    </div>
    </div>

    <script src=""js/owl.carousel.js""></script>

  ");
            WriteLiteral(@"  <!-- script for -->
    <script>
        $(document).ready(function () {
            $('.owl-one').owlCarousel({
                loop: true,
                margin: 0,
                nav: false,
                responsiveClass: true,
                autoplay: false,
                autoplayTimeout: 5000,
                autoplaySpeed: 1000,
                autoplayHoverPause: false,
                responsive: {
                    0: {
                        items: 1,
                        nav: false
                    },
                    480: {
                        items: 1,
                        nav: false
                    },
                    667: {
                        items: 1,
                        nav: true
                    },
                    1000: {
                        items: 1,
                        nav: true
                    }
                }
            })
        })
    </script>
    <!-- //script -->
    <!-- /main-slid");
            WriteLiteral(@"er -->
</section>
<!---728x90--->




<section class=""grids-5"">
    <div id=""grids5-block"" class=""py-5"">
        <div class=""container py-md-3"">
            <div class=""heading text-center mx-auto"">
                <h3 class=""head"">TOP RATED KRUZERI</h3>

            </div>
            <div class=""row mt-5 pt-3"">



");
#nullable restore
#line 132 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Index.cshtml"
                 foreach (var Kruzer in Model.topRated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"grids4-info col-md-6\" style=\"width: 100px;\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4683, "\"", 4716, 2);
            WriteAttributeValue("", 4690, "Hotel-Single?id=", 4690, 16, true);
#nullable restore
#line 135 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Index.cshtml"
WriteAttributeValue("", 4706, Kruzer.Id, 4706, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 4722, "\"", 4747, 1);
#nullable restore
#line 135 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Index.cshtml"
WriteAttributeValue("", 4728, Kruzer.GlavnaSlika, 4728, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 4766, "\"", 4772, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        <div class=\"info-bg\">\r\n                            <h5><a");
            BeginWriteAttribute("href", " href=\"", 4861, "\"", 4894, 2);
            WriteAttributeValue("", 4868, "KruzerSingle?id=", 4868, 16, true);
#nullable restore
#line 137 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Index.cshtml"
WriteAttributeValue("", 4884, Kruzer.Id, 4884, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 137 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Index.cshtml"
                                                                Write(Kruzer.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ");
#nullable restore
#line 137 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Index.cshtml"
                                                                                Write(Kruzer.Grad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n");
            WriteLiteral("\r\n                            <a class=\"btn btn-theme1\"");
            BeginWriteAttribute("href", " href=\"", 5129, "\"", 5162, 2);
            WriteAttributeValue("", 5136, "KruzerSingle?id=", 5136, 16, true);
#nullable restore
#line 141 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Index.cshtml"
WriteAttributeValue("", 5152, Kruzer.Id, 5152, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> View Details</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 144 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>


<section class=""w3l-feature-3"">
    <div class=""grid top-bottom py-5"">
        <div class=""container py-md-3"">
            <div class=""middle-section grid-column text-center"">
                <div class=""three-grids-columns"">
                    <span class=""fa fa-envelope-o""></span>
                    <h4>MAIL US</h4>
                    <p> </p>
                    <a href=""/Kontakt"" class=""btn btn-secondary btn-theme3 mt-4"">Mail Me </a>
                </div>
                <div class=""three-grids-columns"">
                    <span class=""fa fa-globe""></span>
                    <h4>LOCATE US</h4>
                    <p></p>
                    <a href=""/ONama"" class=""btn btn-secondary btn-theme3 mt-4"">View Map </a>
                </div>
                <div class=""three-grids-columns"">
                    <span class=""fa fa-phone""></span>
                    <h4>NEED HELP</h4>
                    <p></p>
            ");
            WriteLiteral("        <a href=\"/Kontakt\" class=\"btn btn-secondary btn-theme3 mt-4\">Call Us</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
