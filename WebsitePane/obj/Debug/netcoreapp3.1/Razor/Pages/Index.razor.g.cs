#pragma checksum "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f04b4edc051571a3d9b213aad397d50250ea5a4"
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
                <div class=""image-container-section"">
                </div>
               

            </div>

        </div>

   

    </section>
    <section class=""side-section"">
        <ul class=""side-list"">
            <li>
                <button class=""side-btn"">Open</button>
                <input type=""file"" id=""getFile"" style=""display:none"">
            </li>
            <li><a>How</a></li>
            <li><a>Here</a></li>
        </ul>
        <ul class=""side-list"">
            <li><a>Hello</a></li>
            <li><a>How</a></li>
            <li>
                <button class=""side-btn2"">OpenMutiple</button>
                <input type=""file"" id=""getFiles"" multiple style=""display:none"">
            </li>
        </ul>
        <input type=""file"" id=""files"" name=""files[]"" multiple>
        
    </section>
</main>");
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "/Users/vimalraveendran/Desktop/blazor/WebsitePane/WebsitePane/Pages/Index.razor"
 
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
