#pragma checksum "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\AddPonuda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4011976601627d877e4ce8aaed87576ffa8301aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROJEKAT_MONGODB.Pages.Pages_AddPonuda), @"mvc.1.0.razor-page", @"/Pages/AddPonuda.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4011976601627d877e4ce8aaed87576ffa8301aa", @"/Pages/AddPonuda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad01a6fbccda5a777b2a6608859c87dbe32df943", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AddPonuda : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cena"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("signupForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    #signupForm {\r\n        margin-left: 20px;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4011976601627d877e4ce8aaed87576ffa8301aa6157", async() => {
                WriteLiteral("\r\n    <br><br>\r\n    <div class=\"aranzman1\" >\r\n        <h3>UNESITE PODATKE O PONUDI za kruzer ");
#nullable restore
#line 13 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\AddPonuda.cshtml"
                                          Write(Model.kruzer.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral(" I  putovanje:</h3> \r\n    <h3>Prolazi kroz sledece gradove:</h3>\r\n");
#nullable restore
#line 15 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\AddPonuda.cshtml"
         foreach(var grad in Model.kruzer.Gradovi)
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("    <h3>\r\n        ");
#nullable restore
#line 19 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\AddPonuda.cshtml"
   Write(grad.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("     \r\n    </h3>\r\n");
#nullable restore
#line 21 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\AddPonuda.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h3>Prolazi kroz sledece drzave:</h3>\r\n");
#nullable restore
#line 23 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\AddPonuda.cshtml"
     foreach(var drzava in Model.kruzer.Drzave)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h3>");
#nullable restore
#line 25 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\AddPonuda.cshtml"
               Write(drzava.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 26 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\AddPonuda.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br><br>\r\n\r\n    </div><br><br>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4011976601627d877e4ce8aaed87576ffa8301aa8402", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 30 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\AddPonuda.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.kruzerID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <span class=""bi-city wow fadeInRight"">
        <div class=""form-element-label"">Datum pocetka ponude*</div>
        <input type=""date"" id=""pickerStart"" name=""pocetak"">
    </span><br><br>
    <span class=""bi-city wow fadeInRight"">
        <div class=""form-element-label"">Datum kraja ponude*</div>
        <input type=""date"" id=""pickerEnd"" name=""kraj"">
    </span><br><br>
    <span class=""bi-city wow fadeInRight"">
        <div class=""form-element-label"">Cena ponude u evrima*</div>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4011976601627d877e4ce8aaed87576ffa8301aa10630", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 41 "C:\Users\Ivan\Desktop\PROJEKAT_MONGODB\PROJEKAT_MONGODB\Pages\AddPonuda.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.cena);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </span><br><br><br><br><br><br>\r\n    <button class=\"btn button-eff\" style=\"background-color:dodgerblue;\">Dodaj</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
    .aranzman1 {
        display: flex;
        flex-direction: column;
        align-items: center;
        width: 80%;
        margin: 0 auto;
    }

        .aranzman1 h3 {
            margin: 20px 0;
        }
</style>
<script>
document.addEventListener(""DOMContentLoaded"", ()=>{

document.querySelector(""#pickerStart"").min=new Date().toISOString().split(""T"")[0];
document.querySelector(""#pickerEnd"").min=new Date(new Date().getTime() + 86400000).toISOString().split('T')[0];
})

function allGood()
{
     if(document.querySelector(""#pickerStart"").value<new Date().toISOString().split(""T"")[0])
    return false;
    if(document.querySelector(""#pickerEnd"").value<new Date(new Date().getTime() + 86400000).toISOString().split('T')[0])
    return false;
    if(document.querySelector(""#pickerStart"").value>document.querySelector(""#pickerEnd"").value)
    return false;
    if(document.querySelector(""#cena"").value<1) return false;
    return true;
}

document.querySelector(""#sign");
            WriteLiteral("upForm\").onsubmit=()=>\r\n{\r\n   if(!allGood())\r\n   {\r\n       alert(\"Uneti podaci nisu ispravni\");\r\n       return false;\r\n   }\r\n}\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROJEKAT_MONGODB.Pages.AddPonudaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROJEKAT_MONGODB.Pages.AddPonudaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROJEKAT_MONGODB.Pages.AddPonudaModel>)PageContext?.ViewData;
        public PROJEKAT_MONGODB.Pages.AddPonudaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
