#pragma checksum "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aab56720395485db2367d72497abce84dab4ddf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ListadoProductos), @"mvc.1.0.view", @"/Views/Product/ListadoProductos.cshtml")]
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
#line 1 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\_ViewImports.cshtml"
using DatabaseFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\_ViewImports.cshtml"
using DatabaseFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aab56720395485db2367d72497abce84dab4ddf9", @"/Views/Product/ListadoProductos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"444af83359856c60639081137879a33c8ebfff84", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ListadoProductos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table id=""listaProductos"" class=""table table-striped"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nombre Producto</th>
            <th>Cantidad</th>
            <th>Precio Unitario</th>
            <th>Paquete</th>
            <th>Esta Discontinuado</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml"
         foreach (var item in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml"
           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml"
           Write(item.SupplierId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml"
           Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml"
           Write(item.Package);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml"
           Write(item.IsDiscontinued);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <button data-id=\"");
#nullable restore
#line 24 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml"
                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger btnEliminarProducto\">Eliminar</button>\r\n                <button data-id=\"");
#nullable restore
#line 25 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml"
                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-warning btnEditarCliente\">Editar</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\ListadoProductos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
