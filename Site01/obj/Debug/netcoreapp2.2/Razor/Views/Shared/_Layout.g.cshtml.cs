#pragma checksum "D:\Cursos\ASPDOTNETCOREMvc\ASPNETCoreMVC\seção 03\Projeto01\Site01\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf78bdf6f63428d3b9edb2cbbd8cba96502be84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "D:\Cursos\ASPDOTNETCOREMvc\ASPNETCoreMVC\seção 03\Projeto01\Site01\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf78bdf6f63428d3b9edb2cbbd8cba96502be84", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Cursos\ASPDOTNETCOREMvc\ASPNETCoreMVC\seção 03\Projeto01\Site01\Views\Shared\_Layout.cshtml"
  
    string Login = Context.Session.GetString("Login");

#line default
#line hidden
            BeginContext(98, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(125, 328, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddf78bdf6f63428d3b9edb2cbbd8cba96502be843302", async() => {
                BeginContext(131, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(204, 13, false);
#line 10 "D:\Cursos\ASPDOTNETCOREMvc\ASPNETCoreMVC\seção 03\Projeto01\Site01\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(217, 229, true);
                WriteLiteral("</title>\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css\" integrity=\"sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS\" crossorigin=\"anonymous\">\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(453, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(455, 2092, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddf78bdf6f63428d3b9edb2cbbd8cba96502be845162", async() => {
                BeginContext(461, 826, true);
                WriteLiteral(@"
    <header>
        <!-- Menu -->
        <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
            <a class=""navbar-brand"" href=""#"">Banco de palavras</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarNav"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/"">ínicio <span class=""sr-only"">(current)</span></a>
                    </li>
                    <!-- Todo - Apresentar este menu apenas se o usuario estiver logado -->

");
                EndContext();
#line 29 "D:\Cursos\ASPDOTNETCOREMvc\ASPNETCoreMVC\seção 03\Projeto01\Site01\Views\Shared\_Layout.cshtml"
                     if (Login != null)
                    {

#line default
#line hidden
                BeginContext(1351, 312, true);
                WriteLiteral(@"                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/palavra"">Palavras</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/home/logout"">Sair</a>
                        </li>
");
                EndContext();
#line 37 "D:\Cursos\ASPDOTNETCOREMvc\ASPNETCoreMVC\seção 03\Projeto01\Site01\Views\Shared\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1735, 157, true);
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\" href=\"/home/login\">Entrar</a>\r\n                        </li>\r\n");
                EndContext();
#line 43 "D:\Cursos\ASPDOTNETCOREMvc\ASPNETCoreMVC\seção 03\Projeto01\Site01\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
                BeginContext(1915, 315, true);
                WriteLiteral(@"
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Contato"">Contato</a>
                    </li>
                </ul>
            </div>
        </nav>
    </header>
    <div class=""container"">
        <div>
            <!-- Conteúdo - página -->
            ");
                EndContext();
                BeginContext(2231, 12, false);
#line 55 "D:\Cursos\ASPDOTNETCOREMvc\ASPNETCoreMVC\seção 03\Projeto01\Site01\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2243, 173, true);
                WriteLiteral("\r\n        </div>\r\n        <footer>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12\">\r\n                    Todos os direitos reservados &copy; 2010 - ");
                EndContext();
                BeginContext(2417, 17, false);
#line 61 "D:\Cursos\ASPDOTNETCOREMvc\ASPNETCoreMVC\seção 03\Projeto01\Site01\Views\Shared\_Layout.cshtml"
                                                          Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(2434, 106, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <!-- Footer -->\r\n        </footer>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2547, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591