#pragma checksum "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e40a9ccb5909f6ccc6395db71fe2cc7ea5fcba2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adoption_Adopt), @"mvc.1.0.view", @"/Views/Adoption/Adopt.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Adoption/Adopt.cshtml", typeof(AspNetCore.Views_Adoption_Adopt))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e40a9ccb5909f6ccc6395db71fe2cc7ea5fcba2d", @"/Views/Adoption/Adopt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeee7d3d57c5bd15be820dd4c0a5785c31b81164", @"/Views/_ViewImports.cshtml")]
    public class Views_Adoption_Adopt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PupBnB.Models.DogViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Adoption", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Appointments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml"
  
    ViewData["Title"] = "Adopt";

#line default
#line hidden
            BeginContext(89, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(95, 5660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b261342b66745899027a53a25b38df9", async() => {
                BeginContext(101, 206, true);
                WriteLiteral("\r\n\r\n        <h2>Choose the perfect pup for you and appoint a day to see it!</h2>\r\n        <p>Now you can find the dog that you like the most and choose a date when you wish to meet them!</p>\r\n        <hr>\r\n");
                EndContext();
                BeginContext(4548, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(4556, 1186, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "830db72ed49f44f38e611510c696789a", async() => {
                    BeginContext(4562, 33, true);
                    WriteLiteral("\r\n            <div class=\"row\">\r\n");
                    EndContext();
#line 108 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                    BeginContext(4660, 140, true);
                    WriteLiteral("                    <div class=\"column3\">\r\n                        <div class=\"card\">\r\n                            <img class=\"card-img-top\"");
                    EndContext();
                    BeginWriteAttribute("src", " src=\"", 4800, "\"", 4832, 1);
#line 112 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml"
WriteAttributeValue("", 4806, "/images/" + item.Image, 4806, 26, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(4833, 195, true);
                    WriteLiteral(" alt=\"Card image\" style=\"width:100%; text-align:center\" />\r\n                            <div class=\"container2\">\r\n                                <h2 class=\"card-title\" style=\"text-align:center\">");
                    EndContext();
                    BeginContext(5029, 9, false);
#line 114 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml"
                                                                            Write(item.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(5038, 86, true);
                    WriteLiteral("</h2>\r\n                                <p class=\"card-text\" style=\"text-align:center\">");
                    EndContext();
                    BeginContext(5125, 8, false);
#line 115 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml"
                                                                          Write(item.Age);

#line default
#line hidden
                    EndContext();
                    BeginContext(5133, 95, true);
                    WriteLiteral(" years old</p>\r\n                                <p class=\"card-text\" style=\"text-align:center\">");
                    EndContext();
                    BeginContext(5229, 11, false);
#line 116 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml"
                                                                          Write(item.Breeds);

#line default
#line hidden
                    EndContext();
                    BeginContext(5240, 85, true);
                    WriteLiteral("</p>\r\n                                <p class=\"card-text\" style=\"text-align:center\">");
                    EndContext();
                    BeginContext(5326, 12, false);
#line 117 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml"
                                                                          Write(item.Genders);

#line default
#line hidden
                    EndContext();
                    BeginContext(5338, 85, true);
                    WriteLiteral("</p>\r\n                                <p class=\"card-text\" style=\"text-align:center\">");
                    EndContext();
                    BeginContext(5424, 16, false);
#line 118 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml"
                                                                          Write(item.Description);

#line default
#line hidden
                    EndContext();
                    BeginContext(5440, 38, true);
                    WriteLiteral("</p>\r\n                                ");
                    EndContext();
                    BeginContext(5478, 110, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b36725f3d5b54d8eada926d1b1f2fcfa", async() => {
                        BeginContext(5576, 8, true);
                        WriteLiteral("Meet me!");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#line 119 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml"
                                     WriteLiteral(item.DogId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5588, 98, true);
                    WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
                    EndContext();
#line 123 "C:\Users\Cora\source\repos\PupBnB\PupBnB\Views\Adoption\Adopt.cshtml"
                }

#line default
#line hidden
                    BeginContext(5705, 30, true);
                    WriteLiteral("            </div>\r\n\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5742, 6, true);
                WriteLiteral("\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PupBnB.Models.DogViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
