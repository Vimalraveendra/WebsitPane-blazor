#pragma checksum "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/SideBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2022dbac736ea64266119f12fe3fe6cf214d0dd6"
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
#line 1 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/SideBar.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class SideBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "side-section");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<ul class=\"side-list\">\n        <li>\n            <button class=\"side-btn\">Open</button>\n            <input type=\"file\" id=\"getFile\" style=\"display:none\">\n        </li>\n        <li><a>How</a></li>\n        <li><a>Here</a></li>\n    </ul>\n    ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "side-list");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<li><a>Hello</a></li>\n        ");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/SideBar.razor"
                      HandleList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "<button>Hello</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.AddMarkupContent(12, "<li>\n            <button class=\"side-btn2\">OpenMutiple</button>\n            <input type=\"file\" id=\"getFiles\" multiple style=\"display:none\">\n        </li>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    <input type=\"file\" id=\"files\" name=\"files[]\" multiple>\n \n\n        ");
            __builder.AddMarkupContent(14, "<ul class=\"render-side\">\n        </ul>\n    \n\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/SideBar.razor"
                                          
    public async void HandleList()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/SideBar.razor"
                                    
            await JSRuntime.InvokeVoidAsync("showListItems");
            StateHasChanged();
        

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
