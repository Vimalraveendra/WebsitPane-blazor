#pragma checksum "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4043581b22855836f50eaa3236594c5a863a73de"
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
            __builder.OpenElement(0, "main");
            __builder.AddAttribute(1, "class", "main-section");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, @"<section class=""main-container"">
        <div class=""patient-container"">



            <div class=""list-container"">
                <ul class=""patient-list"">
                </ul>
            </div>

        </div>

        <div class=""split-bar"">&nbsp;</div>

        <div class=""card-container"">
            <div class=""patient-card"">
                <div class=""image-container-section"">
                </div>
               

            </div>

        </div>

   

    </section>
    ");
            __builder.OpenElement(4, "section");
            __builder.AddAttribute(5, "class", "side-section");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, @"<ul class=""side-list"">
            <li>
                <button class=""side-btn"">Open</button>
                <input type=""file"" id=""getFile"" style=""display:none"">
            </li>
            <li><a>How</a></li>
            <li><a>Here</a></li>
        </ul>
        ");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "side-list");
            __builder.AddMarkupContent(10, "\n            ");
            __builder.AddMarkupContent(11, "<li><a>Hello</a></li>\n            ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/Index.razor"
                          HandleList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "<button>Hello</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n            ");
            __builder.AddMarkupContent(16, "<li>\n                <button class=\"side-btn2\">OpenMutiple</button>\n                <input type=\"file\" id=\"getFiles\" multiple style=\"display:none\">\n            </li>\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n        <input type=\"file\" id=\"files\" name=\"files[]\" multiple>\n        ");
            __builder.AddMarkupContent(18, "<ul class=\"render-side\">\n        </ul>\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/Index.razor"
 
    static string[] list = new String[] { "Hello", "How", "Are", "You" };
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public static List<Patient> patientList = new List<Patient>(){
                new Patient {Id= 10001,Name= "Abraham"},
                    new Patient {Id=10002,Name= "Adam"},
                   new Patient {Id= 10003,Name= "Antony AdamGonslavas"},
                       new Patient {Id=  10004,Name=  "Bobby"},
                           new Patient {Id= 10005,Name= "Boss AntonyMarshell"},
                               new Patient {Id= 10006,Name=  "Bencher"},
                               new Patient {Id=10007,Name="Christopher Gonsalves"},
                                   new Patient {Id= 10008,Name="Calvin"},
                                       new Patient {Id= 10009,Name= "Christy Christopher"},
                                       new Patient {Id=  10010,Name=   "Don"},
                           new Patient {Id=  10011,Name="Danny ImmanuelBidenSalves"},
                               new Patient {Id= 10012,Name=  "Denver"},
                               new Patient {Id=10013,Name= "Eagle"},
                                   new Patient {Id= 10014,Name= "Entity"},
                                       new Patient {Id= 10015,Name="Elgar"},
                                       new Patient {Id= 10016,Name="Fedric"},
                               new Patient {Id=  10017,Name=   "Fernandes"},
                               new Patient {Id=10018,Name=  "Felix"},
                                   new Patient {Id= 10019,Name=  "Gangster"},
                                       new Patient {Id= 10020,Name="Gambler"},
                                       new Patient {Id=  10021,Name="Guardian"},
                               new Patient {Id= 10022,Name= "Harry"},
                               new Patient {Id=10023,Name="Hamilton" },
                                   new Patient {Id= 10024,Name= "Helen"},
                                       new Patient {Id= 10025,Name="Immanuel"},
                                       new Patient {Id= 10026,Name="Inker"},
                               new Patient {Id=  10027,Name=   "Ivan"},
                               new Patient {Id=10028,Name=  "Jennifer"},
                                   new Patient {Id= 10029,Name=  "James"},
                                       new Patient {Id= 10030,Name= "John"},
                                       new Patient {Id=  10031,Name=   "Kevin"},
                               new Patient {Id=10032,Name=   "Karl"},
                                   new Patient {Id= 10033,Name= "Kristopher" },
                                       new Patient {Id= 10034,Name= "Lenin"},


        };


    protected override async Task OnAfterRenderAsync(bool firstRender)

    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("loadUser","Text after render");
        }
    }

    [JSInvokable]
    public static Task<List<Patient>> GetPatientsList()
    {

        return Task.FromResult(patientList);
    }

    [JSInvokable]
    public static Task<string []> GetList()
    {

        return Task.FromResult(list);
    }
    public async void HandleList()
    {
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
