#pragma checksum "D:\Progects\succus_shop\succus_shop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97b91ea540dd524e5fc3eb02c518b2e6162c6bdd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97b91ea540dd524e5fc3eb02c518b2e6162c6bdd", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<succus_shop.Models.SuccuModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Progects\succus_shop\succus_shop\Views\Home\Index.cshtml"
   

    ViewData["Title"] = "home page";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1>\r\n        Каталог\r\n    </h1>\r\n");
#nullable restore
#line 11 "D:\Progects\succus_shop\succus_shop\Views\Home\Index.cshtml"
     foreach (var succus in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h3>\r\n               ");
#nullable restore
#line 15 "D:\Progects\succus_shop\succus_shop\Views\Home\Index.cshtml"
          Write(succus.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               ");
#nullable restore
#line 16 "D:\Progects\succus_shop\succus_shop\Views\Home\Index.cshtml"
          Write(succus.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n            <p>\r\n                ");
#nullable restore
#line 19 "D:\Progects\succus_shop\succus_shop\Views\Home\Index.cshtml"
           Write(succus.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n");
#nullable restore
#line 22 "D:\Progects\succus_shop\succus_shop\Views\Home\Index.cshtml"
             if (succus.IsAvialible)
	         {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t                <button class=\"btn bnt-primary\"> подробнее </button>\t\r\n");
#nullable restore
#line 25 "D:\Progects\succus_shop\succus_shop\Views\Home\Index.cshtml"
	         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 27 "D:\Progects\succus_shop\succus_shop\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<succus_shop.Models.SuccuModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
