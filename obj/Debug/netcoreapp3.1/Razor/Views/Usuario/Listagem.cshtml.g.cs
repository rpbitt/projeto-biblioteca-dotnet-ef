#pragma checksum "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e97d4634b85683545d37c3f46fe80df3e3cc09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listagem), @"mvc.1.0.view", @"/Views/Usuario/Listagem.cshtml")]
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
#line 1 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e97d4634b85683545d37c3f46fe80df3e3cc09", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 8 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
         if (Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Nome</th>
                        <th>Login</th>
                        <th>Senha</th>
                        <th>Tipo</th>
                        <th>Editar</th>
                        <th>Excluir</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                     foreach (Usuario u in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1001, "\"", 1036, 2);
            WriteAttributeValue("", 1008, "/Usuario/EditarUsuario/", 1008, 23, true);
#nullable restore
#line 31 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 1031, u.Id, 1031, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1089, "\"", 1125, 2);
            WriteAttributeValue("", 1096, "/Usuario/ExcluirUsuario/", 1096, 24, true);
#nullable restore
#line 32 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 1120, u.Id, 1120, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 37 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><strong>Nenhum registro encontrado!</strong></p>\r\n");
#nullable restore
#line 41 "C:\Users\rosan\Desktop\SENAC 2020\MODULO-02\UC-07\ATIVIDADES\ATIVIDADE-01\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\Listagem.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591