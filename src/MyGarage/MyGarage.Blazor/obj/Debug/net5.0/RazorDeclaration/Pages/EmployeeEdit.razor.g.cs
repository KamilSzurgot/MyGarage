// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
using MyGarage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
using MyGarage.Blazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeedit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeedit/{EmployeeId}")]
    public partial class EmployeeEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
       
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        [Inject]
        public IJobCategoryDataService JobCategoryDataService { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }

    public Employee Employee { get; set; } = new Employee();

    public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

    protected string JobCategoryId = string.Empty;
    protected string Message = string.Empty;
    protected string StatusClass = string.Empty;
    protected bool Saved;

    protected async override Task OnInitializedAsync()
    {
        Saved = false;
        JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList();

        int.TryParse(EmployeeId, out var employeeId);

        if (employeeId == 0)
        {
            Employee = new Employee { JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now, JobCategory = { JobCategoryId=1}  };
        }
        else
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
        }

        JobCategoryId = Employee.JobCategoryId.ToString();
    }

    protected async Task HandleValidSubmit()
    {
        Saved = false;
        Employee.JobCategoryId = int.Parse(JobCategoryId);

        if (Employee.EmployeeId == 0)
        {
            var addedEmployee = await EmployeeDataService.AddEmployee(Employee);
            if (addedEmployee != null)
            {
                StatusClass = "alert-success";
                Message = "New employee added";
                Saved = true;
            }
            else
            {
                StatusClass = "alert-danger";
                Message = "Something went wrong";
                Saved = false;
            }
        }
        else
        {
            await EmployeeDataService.UpdateEmployee(Employee);
            StatusClass = "alert-success";
            Message = "Employee updated";
            Saved = true;
        }
    }

    protected void HandleInvalidSubmit()
    {
        StatusClass = "alert-danger";
        Message = "Validation error";
    }

    protected async Task DeleteEmployee()
    {
        await EmployeeDataService.DeleteEmployee(Employee.EmployeeId);

        StatusClass = "alert-success";
        Message = "Employee deleted";
        Saved = true;
    }

    protected void NavigateToOverview()
    {
        NavigationManager.NavigateTo("/employeeoverview");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
