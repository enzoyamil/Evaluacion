#pragma checksum "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb13525096c319a5f22750f71962cb45105e8422"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb13525096c319a5f22750f71962cb45105e8422", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"444af83359856c60639081137879a33c8ebfff84", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""alert alert-primary"">
    <div class=""colm-md-4"">
        <h4>Productos</h4>
        <button class=""btn btn-primary"">Agregar Producto</button>
    </div>
</div>

<div id=""listadoProductos"">

</div>

<script>
    listarProductos();
    function listarProductos() {

        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 18 "D:\Cursos\QBinstitute\Evaluacion\DatabaseFirst\Views\Product\Index.cshtml"
             Write(Url.Action("ListadoProductos","Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            cache: false,
            success: function (dataHtml) {
                $(""#listadoProductos"").html(dataHtml);
            }
        });
    }
</script>











    /*$(""#listadoProductos"").on(""click"", "".btnEliminarProducto"", function () {
        let vIdProduct = $(this).attr(""data-id"");
        if (confirm(""Esta Seguro?"")) {
            $.ajax({
                type: ""POST"",
                url: Url.Action(""Eliminar"",""Product""),
                cache: false,
                data: {
                    idProduct: vIdProduct
                },
                success: function (exito) {
                    if (exito) {
                        alert(""Se elimino exitosamente"");
                        
                    } else {
                        alert(""No se elimino exitosamente"");
                    }
                }

            });
        }
        
    });
  * /


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
