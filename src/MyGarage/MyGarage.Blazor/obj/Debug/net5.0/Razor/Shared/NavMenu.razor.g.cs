#pragma checksum "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1dfc91434430e247d15416919324fc00ced84f"
// <auto-generated/>
#pragma warning disable 1591
namespace MyGarage.Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using MyGarage.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using MyGarage.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using MyGarage.Blazor.Components;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light");
            __builder.AddAttribute(2, "id", "sidebar-wrapper");
            __builder.AddAttribute(3, "b-265a24v2r6");
            __builder.AddMarkupContent(4, "<div class=\"sidebar-logo\" b-265a24v2r6><img class=\"img-responsive\" id=\"logo\" src=\"images/bethanylogo.png\" b-265a24v2r6></div>\r\n    \r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "menu list-group list-group-flush");
            __builder.AddAttribute(7, "b-265a24v2r6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(8);
            __builder.AddAttribute(9, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(10, "href", "/");
            __builder.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 7 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Shared\NavMenu.razor"
                                                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-265a24v2r6></span> Home\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(17, "href", "/employeeoverview");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-265a24v2r6></span> Employees\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(23, "href", "/employeeedit");
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-265a24v2r6></span> Add new employee\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
