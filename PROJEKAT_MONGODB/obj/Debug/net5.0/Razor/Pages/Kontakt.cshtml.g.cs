#pragma checksum "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\Kontakt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afc25651b8b9de8d53dadc00dd7a587a81336252"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROJEKAT_MONGODB.Pages.Pages_Kontakt), @"mvc.1.0.razor-page", @"/Pages/Kontakt.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc25651b8b9de8d53dadc00dd7a587a81336252", @"/Pages/Kontakt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad01a6fbccda5a777b2a6608859c87dbe32df943", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Kontakt : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afc25651b8b9de8d53dadc00dd7a587a813362522864", async() => {
                WriteLiteral(@"
    <title>SEVENSEAS | Kontakt</title>
    <script src=""https://cdn.jsdelivr.net/gh/openlayers/openlayers.github.io@master/en/v6.3.1/build/ol.js""></script>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/gh/openlayers/openlayers.github.io@master/en/v6.3.1/css/ol.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<section class=""w3l-inner-banner-main"">
    <div class=""about-inner sear-1"">
        <div class=""container"">

            <ul class=""breadcrumbs-custom-path"">

                <li><a href=""/Index""><span class=""fa fa-home"" aria-hidden=""true""></span> <span class=""fa fa-angle-double-right"" aria-hidden=""true""></span></a></li>
                <li class=""active"">Kontakt</li>
            </ul>
        </div>
    </div>
</section>

<section class=""w3l-contact1"" id=""contact"">
    <div class=""contact1-bg section-gap py-5"">
        <div class=""container py-md-3"">
            <h3 class=""global-title""></h3>
            <div class=""heading text-center mx-auto"">
                <h3 class=""head"">Kontaktirajte nas</h3>

            </div>
            <div class=""contact-main row mt-5 pt-3"">
                <div class=""grid grid-column-2 col-md-6"">
                    <div class=""column"">
                        <h4 class=""header"">Mi smo ovde za vas</h4>

                    </div>
                ");
            WriteLiteral(@"    <div class=""column2"">
                        <p class=""mb-2""><span class=""fa fa-envelope""> </span><a href=""mailto:sevenseas@gmail.com"">sevenseas@gmail.com</a></p>
                        <p class=""mb-2""><span class=""fa fa-phone""></span>+381 65 123 456</p>
                        <p class=""contact-para""><span class=""fa fa-map-marker""></span>Adresa: Aleksandra Medvedeva,14</p>
                        <p class=""contact-para""><span class=""fa fa-map-marker""></span>Grad: Nis</p>
                        <p class=""contact-para""><span class=""fa fa-map-marker""></span>Drzava: Srbija</p>
                    </div>
                    <div class=""column3 mt-4"">
                        <h4 class=""header"">Zapratite nas </h4>
                        <a href=""#facebook"" class=""facebook""><span class=""fa fa-facebook""></span></a>
                        <a href=""#twitter"" class=""twitter""><span class=""fa fa-twitter""></span></a>
                        <a href=""#linkedin"" class=""linkedin""><span class=""fa fa-linkedi");
            WriteLiteral(@"n""></span></a>
                        <a href=""#instagram"" class=""instagram""><span class=""fa fa-instagram""></span></a>
                    </div>
                </div>
                <div class=""map col-md-6 mt-md-0 mt-5"">
                    <div class=""location1"">
                        <div id=""mapa""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<input id=""lat"" type=""hidden"" value=""43.319070"">
<input id=""lng"" type=""hidden"" value=""21.914260"">
<div class=""prazan""></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROJEKAT_MONGODB.Pages.KontaktModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROJEKAT_MONGODB.Pages.KontaktModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROJEKAT_MONGODB.Pages.KontaktModel>)PageContext?.ViewData;
        public PROJEKAT_MONGODB.Pages.KontaktModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
