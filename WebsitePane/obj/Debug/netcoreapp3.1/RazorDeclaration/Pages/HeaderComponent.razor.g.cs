// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebsitePane.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/_Imports.razor"
using WebsitePane;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/_Imports.razor"
using WebsitePane.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/HeaderComponent.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class HeaderComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/HeaderComponent.razor"
       

 

    public async void HandleNotes()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/HeaderComponent.razor"
                                 
        await JSRuntime.InvokeVoidAsync("HandleEvents");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
