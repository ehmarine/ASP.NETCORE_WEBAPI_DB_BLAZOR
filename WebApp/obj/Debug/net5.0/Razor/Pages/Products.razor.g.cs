#pragma checksum "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93fb7f11dc8cf791e6569d15e94d997e149792fd"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5");
            __builder.OpenElement(2, "div");
            __builder.OpenComponent<WebApp.Shared.ProductList>(3);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591