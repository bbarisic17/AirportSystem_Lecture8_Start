#pragma checksum "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\AddFlight.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b0f18a5dcc4b87f6d01e8ffac41d98e026d3e47"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddFlight")]
    public partial class AddFlight : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Flight</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\AddFlight.razor"
                  Flight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\AddFlight.razor"
                                          AddFlightAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<FlightManagementBlazorServer.Pages.FlightFields>(5);
                __builder2.AddAttribute(6, "Flight", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DomainModel.Models.Flight>(
#nullable restore
#line 7 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\AddFlight.razor"
                           Flight

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.AddMarkupContent(8, "<button type=\"submit\" class=\"btn btn-primary\"><span class=\"oi oi-pencil\"></span>\r\n        Add Flight\r\n    </button>\r\n    ");
                __builder2.OpenElement(9, "button");
                __builder2.AddAttribute(10, "type", "button");
                __builder2.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\AddFlight.razor"
                                    Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(12, "<span class=\"oi oi-media-skip-backward\"></span>\r\n        Close\r\n    ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\AddFlight.razor"
       
    public Flight Flight { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Flight = new Flight();
        Flight.FlightDate = DateTime.Now;
    }

    private async Task AddFlightAsync()
    {
        await _flightService.AddFlightAsync(Flight);
        Close();
    }

    private void Close()
    {
        _navigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlightService _flightService { get; set; }
    }
}
#pragma warning restore 1591
