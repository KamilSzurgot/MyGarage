#pragma checksum "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "831653db82ec51ed1bfbddee1228f95e0500f770"
// <auto-generated/>
#pragma warning disable 1591
namespace MyGarage.Blazor.Pages
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
#nullable restore
#line 12 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\_Imports.razor"
using MyGarage.Blazor.Config;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
using MyGarage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
using MyGarage.Blazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeoverview")]
    public partial class EmployeeOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">All employees</h1>");
#nullable restore
#line 8 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
}

else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Employee ID</th>\r\n                <th>First Name</th>\r\n                <th>Last Name</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 24 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
             foreach (var employee in Employees)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 27 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
                         employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 28 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
                         employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", 
#nullable restore
#line 31 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
                                   $"employeedetail/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "table-btn");
            __builder.AddMarkupContent(21, "<i class=\"fas fa-info-circle\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", 
#nullable restore
#line 34 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
                                   $"employeeedit/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(26, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "btn btn-outline-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
                                              NavigateToCreateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Add new employee");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
                  QuickAddEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "btn btn-dark table-btn quick-add-btn");
            __builder.AddContent(35, "  +  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.OpenComponent<MyGarage.Blazor.Components.AddEmployeeDialog>(37);
            __builder.AddAttribute(38, "CloseEventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 45 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
                                                                 AddEmployeeDialog_OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(39, (__value) => {
#nullable restore
#line 45 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
                         AddEmployeeDialog = (MyGarage.Blazor.Components.AddEmployeeDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeOverview.razor"
       
    public IEnumerable<Employee> Employees { get; set; }

    [Inject]
    public IEmployeeDataService EmployeeDataService { get; set; }

    protected AddEmployeeDialog AddEmployeeDialog { get; set; }

    protected async override Task OnInitializedAsync()
    {
        Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
    }

    protected void QuickAddEmployee()
    {
        AddEmployeeDialog.Show();
    }

    public async void AddEmployeeDialog_OnDialogClose()
    {
        Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        StateHasChanged();
    }

    protected void NavigateToCreateEmployee()
    {
        NavigationManager.NavigateTo("/employeeedit");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
