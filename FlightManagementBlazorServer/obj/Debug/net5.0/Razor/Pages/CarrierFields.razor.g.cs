#pragma checksum "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierFields.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02c1afde2d1587fef8110c801a2b817c47ee3e01"
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
    public partial class CarrierFields : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "carrierFields");
            __builder.AddMarkupContent(2, "<label for=\"carrierName\">Name</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(3);
            __builder.AddAttribute(4, "id", "carrierName");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierFields.razor"
                                              Carrier.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Carrier.Name = __value, Carrier.Name))));
            __builder.AddAttribute(8, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Carrier.Name));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.AddMarkupContent(10, "<label for=\"carrierCountry\">Country</label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
            __builder.AddAttribute(12, "id", "carrierCountry");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierFields.razor"
                                                 Carrier.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Carrier.Country = __value, Carrier.Country))));
            __builder.AddAttribute(16, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Carrier.Country));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Bojan\Desktop\AirportSystem_Lecture7_Start\FlightManagementBlazorServer\Pages\CarrierFields.razor"
       
    [Parameter]
    public Carrier Carrier { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
