#pragma checksum "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\Pages\Location.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eef9d00d9536131fd64b4e387688207c2ac0f1d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KulkovFrontend.Pages
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\_Imports.razor"
using KulkovFrontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\_Imports.razor"
using KulkovFrontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\Pages\Location.razor"
using Kulkov.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\Pages\Location.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\Pages\Location.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/loc")]
    public partial class Location : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\apcxo\source\repos\APIPostges\KulkovFrontend\Pages\Location.razor"
       

    public Kulkov.Data.Location location = new Kulkov.Data.Location();

    public List<Kulkov.Data.Location> locations;

    public bool[] vs;

    protected async Task Add()
    {
        await Service.AddLocation(location);
        location = new Kulkov.Data.Location();
        await UpdateTable();
    }

    protected async Task Update(int row)
    {
        await Service.UpdateLocation(locations[row].id_loc, locations[row]);
        //await UpdateTable();
    }

    protected async Task Delete()
    {
        for (int i = 0; i < vs.Length; i++)
        {
            if (vs[i])
                await Service.RemoveLocation(locations[i].id_loc);
        }
        await UpdateTable();
    }

    protected async Task UpdateTable()
    {
        var response = await Service.GetAllLocations();
        locations = response.ToList();
        vs = null;
        vs = new bool[locations.Count];
        response = null;
    }

    protected async override Task OnInitializedAsync()
    {
        var response = await Service.GetAllLocations();
        locations = response.ToList();
        vs = new bool[locations.Count];
        response = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocationRepository Service { get; set; }
    }
}
#pragma warning restore 1591
