#pragma checksum "C:\Users\ayerj\source\repos\Northwind\WebApplication5\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef51dfba60a8cd51d64a17416a2bd4b0b9f96d6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Views.Product.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(Northwind.Views.Product.Views_Product_Index))]
namespace Northwind.Views.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ayerj\source\repos\Northwind\WebApplication5\Views\Product\Index.cshtml"
using Northwind.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef51dfba60a8cd51d64a17416a2bd4b0b9f96d6e", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f57cd9bf78b2c0f476a202f306d8a8d18ac628", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryProductsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 53, true);
            WriteLiteral("\r\n    <div class=\"bg-primary m-1 p-1 text-white\"><h4>");
            EndContext();
            BeginContext(109, 14, false);
#line 4 "C:\Users\ayerj\source\repos\Northwind\WebApplication5\Views\Product\Index.cshtml"
                                              Write(Model.category);

#line default
#line hidden
            EndContext();
            BeginContext(123, 32, true);
            WriteLiteral(" Products</h4></div>\r\n\r\n<ul>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\ayerj\source\repos\Northwind\WebApplication5\Views\Product\Index.cshtml"
         foreach (Product product in Model.Products)
{

#line default
#line hidden
            BeginContext(212, 26, true);
            WriteLiteral("        <li>\r\n            ");
            EndContext();
            BeginContext(239, 19, false);
#line 11 "C:\Users\ayerj\source\repos\Northwind\WebApplication5\Views\Product\Index.cshtml"
       Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(258, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(262, 17, false);
#line 11 "C:\Users\ayerj\source\repos\Northwind\WebApplication5\Views\Product\Index.cshtml"
                              Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(279, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(283, 20, false);
#line 11 "C:\Users\ayerj\source\repos\Northwind\WebApplication5\Views\Product\Index.cshtml"
                                                   Write(product.UnitsInStock);

#line default
#line hidden
            EndContext();
            BeginContext(303, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 13 "C:\Users\ayerj\source\repos\Northwind\WebApplication5\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(331, 17, true);
            WriteLiteral("</ul>\r\n\r\n\r\n<hr />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryProductsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
