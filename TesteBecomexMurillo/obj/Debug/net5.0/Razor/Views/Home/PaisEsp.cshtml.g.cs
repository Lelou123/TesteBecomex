#pragma checksum "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78a102d20ed177744104106388fee0e562d8b02c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PaisEsp), @"mvc.1.0.view", @"/Views/Home/PaisEsp.cshtml")]
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
#line 1 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\_ViewImports.cshtml"
using TesteBecomexMurillo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\_ViewImports.cshtml"
using TesteBecomexMurillo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
using RESTCountries.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a102d20ed177744104106388fee0e562d8b02c", @"/Views/Home/PaisEsp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c72ac787b48774bf3f00b5813f69358d88d776c0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PaisEsp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RESTCountries.Models.Country>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"text-center\">\r\n\t\t<img");
            BeginWriteAttribute("src", " src=\"", 144, "\"", 164, 1);
#nullable restore
#line 8 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
WriteAttributeValue("", 150, item.Flag.Png, 150, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"minha bandeira\">\r\n\t</div>\r\n");
#nullable restore
#line 10 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<table class=""table text-center mt-5"">
	<thead class=""thead-gray"">
		<tr>
			<th scope=""col"">
				<h4>País</h4>
			</th>
			<th scope=""col"">
				<h4>Sigla</h4>
			</th>
			<th scope=""col"">
				<h4>Moeda</h4>
			</th>
			<th scope=""col"">
				<h4>Blocos</h4>
			</th>
		</tr>
	</thead>
	<tbody>
");
#nullable restore
#line 32 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 36 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 39 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.Cioc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 42 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.Currencies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 46 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.RegionalBlocs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 49 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	</tbody>
</table>


<table class=""table text-center mt-5"">
	<thead class=""thead-dark"">
		<tr>
			<th scope=""col"">
				<h4>População</h4>
			</th>
			<th scope=""col"">
				<h4>Timezone</h4>
			</th>
			<th scope=""col"">
				<h4>Moedas</h4>
			</th>
			<th scope=""col"">
				<h4>Linguas</h4>
			</th>
			<th scope=""col"">
				<h4>Capital</h4>
			</th>
			<th scope=""col"">
				<h4>Blocos</h4>
			</th>
			<th scope=""col"">
				<h4>Fronteiras</h4>
			</th>
		</tr>
	</thead>
	<tbody>
");
#nullable restore
#line 81 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 85 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.Population));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 88 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.Timezones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 91 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.Currencies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 94 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.Languages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 97 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.Capital));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 100 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.RegionalBlocs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\t\t\t\t\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 103 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
               Write(Html.DisplayFor(modelItem=> item.Borders));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 106 "Z:\TesteBecomexMurillo\TesteBecomexMurillo\Views\Home\PaisEsp.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>\r\n\r\n<div class=\"center\">\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78a102d20ed177744104106388fee0e562d8b02c10167", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RESTCountries.Models.Country>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
