#pragma checksum "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\Pages\SuperHero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f15ff7608561e5b5a8713ed33a0ece4240b74777"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/superhero/{id:int}")]
    public partial class SuperHero : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\Pages\SuperHero.razor"
 if (hero == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<span> Hero is Loading....</span>");
#nullable restore
#line 7 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\Pages\SuperHero.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "This Is ");
            __builder.AddContent(3, 
#nullable restore
#line 10 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\Pages\SuperHero.razor"
                 hero.HeroName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, ", also called ");
            __builder.AddContent(5, 
#nullable restore
#line 10 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\Pages\SuperHero.razor"
                                             hero.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 10 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\Pages\SuperHero.razor"
                                                             hero.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, "This Hero Belongs to ");
            __builder.AddContent(12, 
#nullable restore
#line 11 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\Pages\SuperHero.razor"
                                hero.Comic.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\Pages\SuperHero.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\gihan.c\source\repos\SuperHeroDB\SuperHeroDB\Client\Pages\SuperHero.razor"
       

    [Parameter]
    public int Id { get; set; }


    SuperHeroDB.Shared.SuperHero hero = null;
    protected override async Task OnInitializedAsync()
    {
        hero = await SuperHeroService.GetSuperHero(Id);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISuperHeroService SuperHeroService { get; set; }
    }
}
#pragma warning restore 1591
