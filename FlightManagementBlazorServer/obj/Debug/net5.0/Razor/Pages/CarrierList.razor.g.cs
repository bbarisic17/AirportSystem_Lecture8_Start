#pragma checksum "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd5ab1ad1ad248eb944f70f10ed2ded9407a17e3"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightManagementBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CarrierList")]
    public partial class CarrierList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Carrier List</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
                                ShowAddCarrierPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "<span class=\"oi oi-plus\"></span>\r\n    Add Carrier\r\n");
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
 if(Carriers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p>Loading...</p>");
#nullable restore
#line 13 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddMarkupContent(7, "<thead><tr><th>Name</th>\r\n                <th>Country</th></tr></thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 24 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
             foreach(var carrier in Carriers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
#nullable restore
#line 27 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
__builder.AddContent(11, carrier.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 28 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
__builder.AddContent(14, carrier.Country);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
                                                        () => OpenEditCarrierPage(carrier.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
                                                        () => DeleteCarrierAsync(carrier.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierList.razor"
       
    public List<Carrier> Carriers { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Carriers = await GetCarriersAsync();
    }
    private void ShowAddCarrierPage()
    {
        _navigationManager.NavigateTo("/AddCarrier");
    }

    private void OpenEditCarrierPage(int carrierId)
    {
        _navigationManager.NavigateTo($"/EditCarrier/{carrierId}");
    }

    private async Task DeleteCarrierAsync(int carrierId)
    {
        await _carrierService.DeleteCarrierAsync(carrierId);
        Carriers = await GetCarriersAsync();
    }

    private async Task<List<Carrier>> GetCarriersAsync()
    {
        return await _carrierService.GetCarriersAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CarrierService _carrierService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
