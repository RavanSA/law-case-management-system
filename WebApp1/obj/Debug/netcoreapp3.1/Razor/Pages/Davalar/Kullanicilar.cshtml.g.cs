#pragma checksum "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac2a9ffe3261e29a6c98527c7a81edb872b5acb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp1.Pages.Davalar.Pages_Davalar_Kullanicilar), @"mvc.1.0.razor-page", @"/Pages/Davalar/Kullanicilar.cshtml")]
namespace WebApp1.Pages.Davalar
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
#line 1 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\_ViewImports.cshtml"
using WebApp1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac2a9ffe3261e29a6c98527c7a81edb872b5acb", @"/Pages/Davalar/Kullanicilar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d607b24827a0c29004a89eca4de0343ff91f4c8b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Davalar_Kullanicilar : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "KullaniciBilgileri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark h8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""form-row"">
    <div class=""form-group col-md-8"">
        <h4>Kullanıcı bilgileri</h4>
    </div>

</div>

<div class=""border container search-table"" style=""padding:30px;"">
    <div class=""search-scroll"">
            <div>
               
                <table class=""table table-striped"">
                    <thead style=""background: #0e1a35;"">
                        <tr>

                            <th class=""h8"">
                                Düzenle
                            </th>
                            <th class=""h8"">
                                <a>
                                    Email
                                </a>
                            </th>
                            <th class=""h8"">
                                <a>
                                    Kullanıcı Adı
                                </a>
                            </th>
                            <th class=""h8"">
                                <a>
           ");
            WriteLiteral(@"                         Telefon Numarası
                                </a>
                            </th>
                            <th class=""h8"">
                                <a>
                                    Kullanıcı Görevi
                                </a>
                            </th>
                            <th class=""h8"">
                                <a>
                                   Rol
                                </a>
                            </th>
                            
                        </tr>
                    </thead>
                    <tbody class=""h10"">
");
#nullable restore
#line 53 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                         foreach (var i in Model.userWithRoles)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n");
#nullable restore
#line 56 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                                  
                                    var disableButton = "";
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n");
#nullable restore
#line 60 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                                     if (i.Role != "Admin")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac2a9ffe3261e29a6c98527c7a81edb872b5acb6338", async() => {
                WriteLiteral("Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                                                                         WriteLiteral(i.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-dark h8\"  disabled>Düzenle</a>\r\n");
#nullable restore
#line 68 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 72 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                               Write(i.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 75 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                               Write(i.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 78 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                               Write(i.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 81 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                               Write(i.UserDuty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 84 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                               Write(i.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 88 "C:\Users\Lenovo\source\repos\WebApp1\WebApp1\Pages\Davalar\Kullanicilar.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp1.Pages.Davalar.KullanicilarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp1.Pages.Davalar.KullanicilarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp1.Pages.Davalar.KullanicilarModel>)PageContext?.ViewData;
        public WebApp1.Pages.Davalar.KullanicilarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591