#pragma checksum "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "712da9a749202f34e8ece2ceb62ee47289a666e0"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Shared
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
    public partial class ProductItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(2);
            __builder.AddAttribute(3, "href", 
#nullable restore
#line 4 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductItem.razor"
                    Href

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "class", "card mb-3 text-decoration-none");
            __builder.AddAttribute(5, "style", "max-width: 540px;");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row g-0");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-6");
                __builder2.OpenElement(11, "img");
                __builder2.AddAttribute(12, "src", 
#nullable restore
#line 8 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductItem.razor"
                           Item.ImgUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(13, "class", "img-fluid rounded-start");
                __builder2.AddAttribute(14, "alt", "...");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col col-md-6");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "card-body");
                __builder2.OpenElement(20, "h5");
                __builder2.AddAttribute(21, "class", "card-title");
                __builder2.AddContent(22, 
#nullable restore
#line 12 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductItem.razor"
                                            Item.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "p");
                __builder2.AddAttribute(25, "class", "card-text");
                __builder2.AddContent(26, 
#nullable restore
#line 13 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductItem.razor"
                                          Item.ShortDescription

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 14 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductItem.razor"
                     if (Item.InStock)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(27, "<p class=\"card-text\"><small class=\"text-success\">Item in stock</small></p>");
#nullable restore
#line 17 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductItem.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(28, "<p class=\"card-text\"><small class=\"text-danger\">Item out of stock</small></p>");
#nullable restore
#line 21 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductItem.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(29, "p");
                __builder2.AddAttribute(30, "class", "card-text text-danger");
                __builder2.AddContent(31, "$ ");
                __builder2.AddContent(32, 
#nullable restore
#line 23 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductItem.razor"
                                                        Item.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductItem.razor"
       
    [Parameter]
    public Product Item { get; set; }
    public string Href { get; set; }

    protected override void OnInitialized()
    {
        Href = "product/" + Item.Id.ToString();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
