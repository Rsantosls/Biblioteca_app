#pragma checksum "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c30c566672daf80eca6c428e158d2ce3b39f1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listagem), @"mvc.1.0.view", @"/Views/Home/Listagem.cshtml")]
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
#line 1 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c30c566672daf80eca6c428e158d2ce3b39f1f", @"/Views/Home/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Login>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Livros";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 9 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
         if (Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br>\r\n            <h3 style=\"text-align: center;\">Nenhum registro encontrado.</h3>\r\n");
#nullable restore
#line 13 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Nome</th>
                        <th>Usuario</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 26 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
                     foreach (Login l in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 29 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
                           Write(l.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
                           Write(l.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
                           Write(l.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                            \r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 968, "\"", 993, 2);
            WriteAttributeValue("", 975, "/Home/Edicao/", 975, 13, true);
#nullable restore
#line 32 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
WriteAttributeValue("", 988, l.Id, 988, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n");
#nullable restore
#line 33 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
                             if(l.Id != 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1125, "\"", 1154, 2);
            WriteAttributeValue("", 1132, "/Home/Remover?Id=", 1132, 17, true);
#nullable restore
#line 35 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
WriteAttributeValue("", 1149, l.Id, 1149, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Exluir</a></td>\r\n");
#nullable restore
#line 36 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
                            }     

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 38 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 41 "D:\Senac CURSO\Modulo02\UC07\Biblioteca_app\Views\Home\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Login>> Html { get; private set; }
    }
}
#pragma warning restore 1591
