#pragma checksum "/Users/momo/Desktop/CRUDelicious/Views/Home/Dish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ff7c51cefb45e81f9f6742115ac66c945759dc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dish), @"mvc.1.0.view", @"/Views/Home/Dish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dish.cshtml", typeof(AspNetCore.Views_Home_Dish))]
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
#line 1 "/Users/momo/Desktop/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "/Users/momo/Desktop/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff7c51cefb45e81f9f6742115ac66c945759dc6", @"/Views/Home/Dish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/momo/Desktop/CRUDelicious/Views/Home/Dish.cshtml"
  
    ViewData["Title"] = "Your Dish";

#line default
#line hidden
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(61, 75, true);
            WriteLiteral("\n<a class=\"button home\" href=\"/\">Home</a>\n<div class=\"Dish_title\">\n    <h1>");
            EndContext();
            BeginContext(137, 13, false);
#line 9 "/Users/momo/Desktop/CRUDelicious/Views/Home/Dish.cshtml"
   Write(Model[0].Name);

#line default
#line hidden
            EndContext();
            BeginContext(150, 35, true);
            WriteLiteral("</h1> \n    <h2 style=\"border:none\">");
            EndContext();
            BeginContext(186, 13, false);
#line 10 "/Users/momo/Desktop/CRUDelicious/Views/Home/Dish.cshtml"
                       Write(Model[0].Chef);

#line default
#line hidden
            EndContext();
            BeginContext(199, 71, true);
            WriteLiteral("</h2>\n</div>\n\n<div class=\"container\">\n    <p class=\"desc\">Description: ");
            EndContext();
            BeginContext(271, 20, false);
#line 14 "/Users/momo/Desktop/CRUDelicious/Views/Home/Dish.cshtml"
                            Write(Model[0].Description);

#line default
#line hidden
            EndContext();
            BeginContext(291, 40, true);
            WriteLiteral("</p>\n    <p class=\"bold desc\">Calories: ");
            EndContext();
            BeginContext(332, 17, false);
#line 15 "/Users/momo/Desktop/CRUDelicious/Views/Home/Dish.cshtml"
                              Write(Model[0].Calories);

#line default
#line hidden
            EndContext();
            BeginContext(349, 40, true);
            WriteLiteral("</p>\n    <p class=\"bold desc\">Tastiness:");
            EndContext();
            BeginContext(390, 18, false);
#line 16 "/Users/momo/Desktop/CRUDelicious/Views/Home/Dish.cshtml"
                              Write(Model[0].Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(408, 65, true);
            WriteLiteral("</p>\n</div>\n<div class=\"button_bar\">\n    <a class=\"button delete\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 473, "\"", 500, 2);
            WriteAttributeValue("", 480, "/delete/", 480, 8, true);
#line 19 "/Users/momo/Desktop/CRUDelicious/Views/Home/Dish.cshtml"
WriteAttributeValue("", 488, Model[0].Id, 488, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(501, 38, true);
            WriteLiteral(">Delete</a>\n    <a class=\"button edit\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 539, "\"", 564, 2);
            WriteAttributeValue("", 546, "/edit/", 546, 6, true);
#line 20 "/Users/momo/Desktop/CRUDelicious/Views/Home/Dish.cshtml"
WriteAttributeValue("", 552, Model[0].Id, 552, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(565, 16, true);
            WriteLiteral(">Edit</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
