#pragma checksum "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1094ae35ace2308f9ad1d55301c0e3f398ec87af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urun_Index), @"mvc.1.0.view", @"/Views/Urun/Index.cshtml")]
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
#line 1 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\_ViewImports.cshtml"
using NicePageRestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\_ViewImports.cshtml"
using NicePageRestaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1094ae35ace2308f9ad1d55301c0e3f398ec87af", @"/Views/Urun/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04c97c4c142294358d4caf80acf31e900eb9fbba", @"/Views/_ViewImports.cshtml")]
    public class Views_Urun_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DTO.UrunListDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UrunDuzenle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Urun", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
  
    ViewData["Title"] = "Urun Listesi";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Icindekiler));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Fiyat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Kategori\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Icindekiler));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Fiyat));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Kategori.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1094ae35ace2308f9ad1d55301c0e3f398ec87af7492", async() => {
                WriteLiteral("Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-itemid=\"");
#nullable restore
#line 47 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
                                                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-target=\"#exampleModal\">\r\n                            Sil\r\n                        </button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Baris\source\YeniSayfa\NicePageRestaurant\NicePageRestaurant\Views\Urun\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>


<div class=""modal fade"" id=""exampleModal"" style=""display: none;"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content bg-danger""  tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"" >
            <div class=""modal-header"">
                <h5 class=""modal-title"">Silmek istediğinizden emin misiniz?</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            
            <div class=""modal-footer justify-content-between"">
                <button type=""button"" class=""btn btn-outline-light"" data-dismiss=""modal"">Kapat</button>
                <button type=""button"" id=""modal-btn-si"" class=""btn btn-outline-light"">Sil</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

        <script type=""text/javascript"">
            $('#exampleModal').on('show.bs.modal', function (event) {
                
                $(this).show();
                var button = $(event.relatedTarget)
                var itemId = button.data('itemid')

                $(""#modal-btn-si"").on(""click"", function () {
                    window.location.href = ""/Urun/UrunSil?id="" + itemId;
                });
            })
        </script>

    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DTO.UrunListDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
