#pragma checksum "C:\Users\PIPEX\Downloads\SIRAC\SIRAC\Pages\404Usuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54fdf5f1625cc64dd8621056b02f86ccc5ce5f23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test_Razor.Pages.Pages_404Usuario), @"mvc.1.0.razor-page", @"/Pages/404Usuario.cshtml")]
namespace Test_Razor.Pages
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
#line 1 "C:\Users\PIPEX\Downloads\SIRAC\SIRAC\Pages\_ViewImports.cshtml"
using Test_Razor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54fdf5f1625cc64dd8621056b02f86ccc5ce5f23", @"/Pages/404Usuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04500f2f49c9ae980eb49248b5422091a73fffa", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_404Usuario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\PIPEX\Downloads\SIRAC\SIRAC\Pages\404Usuario.cshtml"
  
    ViewData["Title"] = "404";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""background-image: url(img/fondoAnimales.jpg)"">
    <div class=""container"" id=""div"" style=""background:white"">
        <div class=""row"">
            <div class=""col-md-6 col-md-offset-3"">
                <div class=""blogs"">
                    <div class=""text-center"">
                        <h2>404 - Not Found</h2>
                    </div>
                    <hr>
                    <div class=""text-center"">
                        <p>No se ha encontrado el usuario que buscabas</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $('#div').height($(window).height() - 70);
</script>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test_Razor.Pages._404UsuarioModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test_Razor.Pages._404UsuarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test_Razor.Pages._404UsuarioModel>)PageContext?.ViewData;
        public Test_Razor.Pages._404UsuarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
