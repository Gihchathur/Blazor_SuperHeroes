#pragma checksum "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61025609922b2b6f998462323c61cd4ff0a0a645"
// <auto-generated/>
#pragma warning disable 1591
namespace SuperHeroDB.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/superheroes")]
    public partial class SuperHeroes : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Super Heroes</h3>");
#nullable restore
#line 10 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
 if(SuperHeroService.Heroes.Count ==0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<span>Loading Super Heroes.....</span>");
#nullable restore
#line 13 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>First Name</th>\r\n                <th>Last Name</th>\r\n                <th>Hero Name</th>\r\n                <th>Comic</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 26 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
             foreach(var hero in SuperHeroService.Heroes)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 29 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
                     hero.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 30 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
                     hero.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 31 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
                     hero.HeroName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 32 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
                     hero.Comic.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
                                                               (() => ShowHero(hero.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<SuperHeroDB.Client.Shared.EditSuperHero>(24);
            __builder.CloseComponent();
#nullable restore
#line 42 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\blazor\Blazor_SuperHeroes\SuperHeroDB\Client\Pages\SuperHeroes.razor"
             
    //List<SuperHeroDB.Shared.SuperHero> heroes = new List<SuperHeroDB.Shared.SuperHero>();
    protected override async Task OnInitializedAsync()
    {

        await SuperHeroService.GetSuperHeroes();
        SuperHeroService.Onchange += StateHasChanged;
    }

    void ShowHero(int id)
    {
        NavigationManager.NavigateTo($"superhero/{id}");
    }

    public void Dispose()
    {
        SuperHeroService.Onchange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISuperHeroService SuperHeroService { get; set; }
    }
}
#pragma warning restore 1591
