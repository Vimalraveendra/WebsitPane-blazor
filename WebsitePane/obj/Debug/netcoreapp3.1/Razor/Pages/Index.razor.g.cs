#pragma checksum "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ba7e25b780a49dd555b3d5690c5a9a2a97c58d"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/Index.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"navbar navbar-expand-sm bg-dark navbar-dark fixed\">\n\n</nav>\n\n\n");
            __builder.AddMarkupContent(1, @"<main class=""main-section"">
    <section class=""main-container"">
        <div class=""patient-container"">

            

            <div class=""list-container"">
                <ul class=""patient-list"">
                </ul>
            </div>

        </div>

        <div class=""split-bar"">&nbsp;</div>

        <div class=""card-container"">
            <div class=""patient-card"">

            </div>

        </div>


    </section>
    <section class=""side-section"">
        <ul class=""side-list"">
            <li><a>Hello</a></li>
            <li><a>How</a></li>
            <li><a>Here</a></li>
        </ul>
        <ul class=""side-list"">
            <li><a>Hello</a></li>
            <li><a>How</a></li>
            <li><a>Here</a></li>
        </ul>
    </section>
</main>");
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/Index.razor"
 
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("loadUser","Text after render");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
