// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SuperHeroDB.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
using SuperHeroDB.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\_Imports.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\Pages\SuperHeroes.razor"
             
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
