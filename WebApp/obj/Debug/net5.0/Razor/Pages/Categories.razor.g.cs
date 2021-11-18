#pragma checksum "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Pages\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93a7e215c75b98f6061d28b409bb592f83318ed5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/{id}")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Pages\Categories.razor"
 if (categories == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Loading..");
            __builder.AddContent(2, 
#nullable restore
#line 6 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Pages\Categories.razor"
                 Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Pages\Categories.razor"
}
else
{
    foreach (var cat in categories)
                {
                    if(cat.Id == Int32.Parse(Id))
                    {
                        if(cat.Products.Count > 0)
                        {
                            foreach (var product in cat.Products) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WebApp.Shared.ProductItem>(3);
            __builder.AddAttribute(4, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WebApp.Models.Product>(
#nullable restore
#line 17 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Pages\Categories.razor"
                                                    product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 18 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Pages\Categories.razor"
                            }
                        }
                    }
                }
} 

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Pages\Categories.razor"
       

    [Parameter]
    public string Id { get; set; }

    private Category[] categories;

    private async Task GetCategoriesAsync()
    {
        categories = await Http.GetFromJsonAsync<Category[]>("https://localhost:44345/api/categories");
        Console.WriteLine(categories);
        StateHasChanged();
    }

    public Product Item { get; set; } = new();
    public Category Cat { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        Cat = await Http.GetFromJsonAsync<Category>($"https://localhost:44345/api/categories/{Id}");
        Item = await Http.GetFromJsonAsync<Product>($"https://localhost:44345/api/products/{Id}");
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await GetCategoriesAsync();
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591