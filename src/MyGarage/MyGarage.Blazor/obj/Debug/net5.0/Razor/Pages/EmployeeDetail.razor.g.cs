#pragma checksum "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51c6c957b335cce8d22b797f52c57496b617585"
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
#line 2 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
using MyGarage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
using MyGarage.Blazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{EmployeeId}")]
    public partial class EmployeeDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, "Details for ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                    Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                        Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12 row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-10 row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-xs-12 col-sm-8");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group row");
            __builder.AddMarkupContent(15, "<label class=\"col-sm-4 col-form-label\">Employee ID</label>\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-sm-8");
            __builder.OpenElement(18, "label");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control-plaintext");
            __builder.AddContent(21, 
#nullable restore
#line 14 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                       Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group row");
            __builder.AddMarkupContent(25, "<label class=\"col-sm-4 col-form-label\">First name</label>\r\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-sm-8");
            __builder.OpenElement(28, "label");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "readonly");
            __builder.AddAttribute(31, "class", "form-control-plaintext");
            __builder.AddContent(32, 
#nullable restore
#line 20 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-group row");
            __builder.AddMarkupContent(36, "<label class=\"col-sm-4 col-form-label\">Last name</label>\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-sm-8");
            __builder.OpenElement(39, "label");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "readonly");
            __builder.AddAttribute(42, "class", "form-control-plaintext");
            __builder.AddContent(43, 
#nullable restore
#line 27 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "form-group row");
            __builder.AddMarkupContent(47, "<label class=\"col-sm-4 col-form-label\">Birthdate</label>\r\n                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-sm-8");
            __builder.OpenElement(50, "label");
            __builder.AddAttribute(51, "type", "text");
            __builder.AddAttribute(52, "readonly");
            __builder.AddAttribute(53, "class", "form-control-plaintext");
            __builder.AddContent(54, 
#nullable restore
#line 34 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.BirthDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form-group row");
            __builder.AddMarkupContent(58, "<label class=\"col-sm-4 col-form-label\">Email</label>\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-sm-8");
            __builder.OpenElement(61, "label");
            __builder.AddAttribute(62, "type", "text");
            __builder.AddAttribute(63, "readonly");
            __builder.AddAttribute(64, "class", "form-control-plaintext");
            __builder.AddContent(65, 
#nullable restore
#line 41 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-group row");
            __builder.AddMarkupContent(69, "<label class=\"col-sm-4 col-form-label\">Street</label>\r\n                ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-sm-8");
            __builder.OpenElement(72, "label");
            __builder.AddAttribute(73, "type", "text");
            __builder.AddAttribute(74, "readonly");
            __builder.AddAttribute(75, "class", "form-control-plaintext");
            __builder.AddContent(76, 
#nullable restore
#line 48 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.Street

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n            ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "form-group row");
            __builder.AddMarkupContent(80, "<label class=\"col-sm-4 col-form-label\">Zip</label>\r\n                ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col-sm-8");
            __builder.OpenElement(83, "label");
            __builder.AddAttribute(84, "type", "text");
            __builder.AddAttribute(85, "readonly");
            __builder.AddAttribute(86, "class", "form-control-plaintext");
            __builder.AddContent(87, 
#nullable restore
#line 55 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n\r\n            ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "form-group row");
            __builder.AddMarkupContent(91, "<label class=\"col-sm-4 col-form-label\">City</label>\r\n                ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col-sm-8");
            __builder.OpenElement(94, "label");
            __builder.AddAttribute(95, "type", "text");
            __builder.AddAttribute(96, "readonly");
            __builder.AddAttribute(97, "class", "form-control-plaintext");
            __builder.AddContent(98, 
#nullable restore
#line 62 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n            ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "form-group row");
            __builder.AddMarkupContent(102, "<label class=\"col-sm-4 col-form-label\">Phone number</label>\r\n                ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "col-sm-8");
            __builder.OpenElement(105, "label");
            __builder.AddAttribute(106, "type", "text");
            __builder.AddAttribute(107, "readonly");
            __builder.AddAttribute(108, "class", "form-control-plaintext");
            __builder.AddContent(109, 
#nullable restore
#line 69 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\r\n            ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "form-group row");
            __builder.AddMarkupContent(113, "<label class=\"col-sm-4 col-form-label\">Experience</label>\r\n                ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "col-sm-8");
            __builder.OpenElement(116, "label");
            __builder.AddAttribute(117, "type", "text");
            __builder.AddAttribute(118, "readonly");
            __builder.AddAttribute(119, "class", "form-control-plaintext");
            __builder.AddContent(120, 
#nullable restore
#line 76 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.Comment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\r\n            ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "form-group row");
            __builder.AddMarkupContent(124, "<label class=\"col-sm-4 col-form-label\">Joined us</label>\r\n                ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "col-sm-8");
            __builder.OpenElement(127, "label");
            __builder.AddAttribute(128, "type", "text");
            __builder.AddAttribute(129, "readonly");
            __builder.AddAttribute(130, "class", "form-control-plaintext");
            __builder.AddContent(131, 
#nullable restore
#line 83 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.JoinedDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n\r\n            ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "form-group row");
            __builder.AddMarkupContent(135, "<label class=\"col-sm-4 col-form-label\">Left us</label>\r\n                ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "col-sm-8");
            __builder.OpenElement(138, "label");
            __builder.AddAttribute(139, "type", "text");
            __builder.AddAttribute(140, "readonly");
            __builder.AddAttribute(141, "class", "form-control-plaintext");
            __builder.AddContent(142, 
#nullable restore
#line 90 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                                                                Employee.ExitDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n");
            __builder.OpenElement(144, "a");
            __builder.AddAttribute(145, "class", "btn btn-outline-primary");
            __builder.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
                                              NavigateToOverview

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(147, "Back to overview");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeDetail.razor"
       
    [Parameter]
    public string EmployeeId { get; set; }

    public Employee Employee { get; set; } = new Employee();

    [Inject]
    public IEmployeeDataService EmployeeDataService { get; set; }

    protected async override Task OnInitializedAsync()
    {
        Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
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
