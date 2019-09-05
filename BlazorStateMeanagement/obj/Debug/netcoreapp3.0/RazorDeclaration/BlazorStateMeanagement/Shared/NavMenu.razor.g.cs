#pragma checksum "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ee6dcf511035a1ec89c4a90db7cfd9056bffe40"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorStateManagement.BlazorStateMeanagement.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\_Imports.razor"
using BlazorStateManagement;

#line default
#line hidden
#line 9 "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\_Imports.razor"
using BlazorStateManagement.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 35 "d:\temp\badRepro\BlazorStateManagement\BlazorStateMeanagement\BlazorStateMeanagement\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    // This method is called when the control is initialized
    protected override void OnInitialized()
    {
        // Subscribe to the StateChanged EventHandler
        CounterState.StateChanged +=
        OnCounterStateAdvancedStateChanged;
    }
    // This method is fired when the CounterState object
    // invokes its StateHasChanged() method
    // This will cause this control to invoke its own
    // StateHasChanged() method refreshing the page
    // and displaying the updated counter value
    void OnCounterStateAdvancedStateChanged(
        object sender, EventArgs e) => StateHasChanged();
    void IDisposable.Dispose()
    {
        // When this control is disposed of
        // unsubscribe from the StateChanged EventHandler
        CounterState.StateChanged -=
        OnCounterStateAdvancedStateChanged;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorStateManagement.SessionState.CounterState CounterState { get; set; }
    }
}
#pragma warning restore 1591
