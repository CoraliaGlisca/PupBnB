#pragma checksum "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44097fc232b5c5abda5c98f61d34b8b2795b3734"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Pagination), @"mvc.1.0.view", @"/Views/Shared/_Pagination.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Pagination.cshtml", typeof(AspNetCore.Views_Shared__Pagination))]
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
#line 1 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\_ViewImports.cshtml"
using PupBnB;

#line default
#line hidden
#line 2 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\_ViewImports.cshtml"
using PupBnB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44097fc232b5c5abda5c98f61d34b8b2795b3734", @"/Views/Shared/_Pagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeee7d3d57c5bd15be820dd4c0a5785c31b81164", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Pagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
  
    var recordsPerPage = Model;
    var totalRecords = ViewBag.TotalRecords == null ? 0 : ViewBag.TotalRecords;
    int numberOfButtons;
    if (totalRecords % recordsPerPage == 0)
    {
        numberOfButtons = totalRecords / recordsPerPage;
    }
    else
    {
        numberOfButtons = (totalRecords / recordsPerPage) + 1;
    }

#line default
#line hidden
            BeginContext(352, 25, true);
            WriteLiteral("<ul class=\"pagination\">\r\n");
            EndContext();
#line 15 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
     if (ViewBag.CurrentPage > 1)
    {

#line default
#line hidden
            BeginContext(419, 26, true);
            WriteLiteral("        <li>\r\n            ");
            EndContext();
            BeginContext(445, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dc364792c164bf6a0ffa59deeb69226", async() => {
                BeginContext(488, 4, true);
                WriteLiteral("Prev");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
                   WriteLiteral(ViewBag.CurrentPage-1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(496, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 20 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
    }

#line default
#line hidden
            BeginContext(520, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
     for (int i = 0; i < numberOfButtons; i++)
    {
        

#line default
#line hidden
#line 24 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
         if (ViewBag.CurrentPage < numberOfButtons)
        {

#line default
#line hidden
            BeginContext(641, 34, true);
            WriteLiteral("            <li>\r\n                ");
            EndContext();
            BeginContext(675, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7130b56abd04e398507ef255cef7c92", async() => {
                BeginContext(722, 23, false);
#line 27 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
                                                         Write(ViewBag.CurrentPage + i);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
                        WriteLiteral(ViewBag.CurrentPage+i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(750, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 29 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
        }

#line default
#line hidden
#line 29 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
         
    }

#line default
#line hidden
            BeginContext(789, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 31 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
     if (ViewBag.CurrentPage < numberOfButtons)
    {

#line default
#line hidden
            BeginContext(845, 26, true);
            WriteLiteral("        <li>\r\n            ");
            EndContext();
            BeginContext(871, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed09760f9f88406c89e5692c6a48f704", async() => {
                BeginContext(914, 4, true);
                WriteLiteral("Next");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
                   WriteLiteral(ViewBag.CurrentPage+1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(922, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 36 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Shared\_Pagination.cshtml"
    }

#line default
#line hidden
            BeginContext(946, 5, true);
            WriteLiteral("</ul>");
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
