#pragma checksum "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9a7a7a336ce7035ad1bf7fcba5c3c413ed1d556"
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
#nullable restore
#line 8 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
 if (!Saved)
{



#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "employee-edit");
            __builder.OpenElement(2, "h1");
            __builder.AddAttribute(3, "class", "page-title");
            __builder.AddContent(4, "Details for ");
            __builder.AddContent(5, 
#nullable restore
#line 13 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 13 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                            Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                      Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group row");
                __builder2.AddMarkupContent(20, "<label for=\"lastName\" class=\"col-sm-3\">Last Name: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "id", "lastName");
                __builder2.AddAttribute(23, "class", "form-control col-sm-8");
                __builder2.AddAttribute(24, "placeholder", "Enter last name");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                                 Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group row");
                __builder2.AddMarkupContent(31, "<label for=\"firstName\" class=\"col-sm-3\">First name: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "id", "firstName");
                __builder2.AddAttribute(34, "class", "form-control col-sm-8");
                __builder2.AddAttribute(35, "placeholder", "Enter first name");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                                  Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group row");
                __builder2.AddMarkupContent(42, "<label for=\"birthdate\" class=\"col-sm-3\">Birthdate: </label>\r\n            ");
                __Blazor.MyGarage.Blazor.Pages.EmployeeEdit.TypeInference.CreateInputDate_0(__builder2, 43, 44, "birthdate", 45, "form-control col-sm-8", 46, "Enter birthdate", 47, 
#nullable restore
#line 31 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                                  Employee.BirthDate

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.BirthDate = __value, Employee.BirthDate)), 49, () => Employee.BirthDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n\r\n        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group row");
                __builder2.AddMarkupContent(53, "<label for=\"email\" class=\"col-sm-3\">Email: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "id", "email");
                __builder2.AddAttribute(56, "class", "form-control col-sm-8");
                __builder2.AddAttribute(57, "placeholder", "Enter email");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                              Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group row");
                __builder2.AddMarkupContent(64, "<label for=\"street\" class=\"col-sm-3\">Street: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(65);
                __builder2.AddAttribute(66, "id", "street");
                __builder2.AddAttribute(67, "class", "form-control col-sm-8");
                __builder2.AddAttribute(68, "placeholder", "Enter street");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                               Employee.Street

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Street = __value, Employee.Street))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Street));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n\r\n        ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group row");
                __builder2.AddMarkupContent(75, "<label for=\"zip\" class=\"col-sm-3\">Zip code: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "id", "zip");
                __builder2.AddAttribute(78, "class", "form-control col-sm-8");
                __builder2.AddAttribute(79, "placeholder", "Enter zip code");
                __builder2.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                            Employee.Zip

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Zip = __value, Employee.Zip))));
                __builder2.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Zip));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n\r\n        ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "form-group row");
                __builder2.AddMarkupContent(86, "<label for=\"city\" class=\"col-sm-3\">City: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(87);
                __builder2.AddAttribute(88, "id", "city");
                __builder2.AddAttribute(89, "class", "form-control col-sm-8");
                __builder2.AddAttribute(90, "placeholder", "Enter city");
                __builder2.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                             Employee.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.City = __value, Employee.City))));
                __builder2.AddAttribute(93, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.City));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group row");
                __builder2.AddMarkupContent(97, "<label for=\"phonenumber\" class=\"col-sm-3\">Phone number: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(98);
                __builder2.AddAttribute(99, "id", "phonenumber");
                __builder2.AddAttribute(100, "class", "form-control col-sm-8");
                __builder2.AddAttribute(101, "placeholder", "Enter phone number");
                __builder2.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                                    Employee.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.PhoneNumber = __value, Employee.PhoneNumber))));
                __builder2.AddAttribute(104, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n\r\n        ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-group row");
                __builder2.AddMarkupContent(108, "<label for=\"jobcategory\" class=\"col-sm-3\">Job category: </label>\r\n            ");
                __Blazor.MyGarage.Blazor.Pages.EmployeeEdit.TypeInference.CreateInputSelect_1(__builder2, 109, 110, "jobcategory", 111, "form-control col-sm-8", 112, 
#nullable restore
#line 71 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                                      JobCategoryId

#line default
#line hidden
#nullable disable
                , 113, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => JobCategoryId = __value, JobCategoryId)), 114, () => JobCategoryId, 115, (__builder3) => {
#nullable restore
#line 72 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                 foreach (var jobCategory in JobCategories)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(116, "option");
                    __builder3.AddAttribute(117, "value", 
#nullable restore
#line 74 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                    jobCategory.JobCategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(118, 
#nullable restore
#line 74 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                jobCategory.JobCategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 75 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n\r\n        ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-group row");
                __builder2.AddMarkupContent(122, "<label for=\"joineddate\" class=\"col-sm-3\">Joined on: </label>\r\n            ");
                __Blazor.MyGarage.Blazor.Pages.EmployeeEdit.TypeInference.CreateInputDate_2(__builder2, 123, 124, "joineddate", 125, "form-control col-sm-8", 126, "Enter date joined", 127, 
#nullable restore
#line 81 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                                   Employee.JoinedDate

#line default
#line hidden
#nullable disable
                , 128, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.JoinedDate = __value, Employee.JoinedDate)), 129, () => Employee.JoinedDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n\r\n        ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "form-group row");
                __builder2.AddMarkupContent(133, "<label for=\"exitdate\" class=\"col-sm-3\">Left on: </label>\r\n            ");
                __Blazor.MyGarage.Blazor.Pages.EmployeeEdit.TypeInference.CreateInputDate_3(__builder2, 134, 135, "exitdate", 136, "form-control col-sm-8", 137, "Enter exit date", 138, 
#nullable restore
#line 86 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                                 Employee.ExitDate

#line default
#line hidden
#nullable disable
                , 139, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.ExitDate = __value, Employee.ExitDate)), 140, () => Employee.ExitDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n\r\n        ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "form-group row");
                __builder2.AddMarkupContent(144, "<label for=\"comment\" class=\"col-sm-3\">Comment: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(145);
                __builder2.AddAttribute(146, "id", "comment");
                __builder2.AddAttribute(147, "class", "form-control col-sm-8");
                __builder2.AddAttribute(148, "placeholder", "Enter comment");
                __builder2.AddAttribute(149, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 91 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                                                    Employee.Comment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(150, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Comment = __value, Employee.Comment))));
                __builder2.AddAttribute(151, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Comment));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n\r\n        ");
                __builder2.AddMarkupContent(153, "<button type=\"submit\" class=\"btn btn-primary edit-btn\">Save</button>");
#nullable restore
#line 96 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
         if (Employee.EmployeeId > 0)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(154, "a");
                __builder2.AddAttribute(155, "class", "btn btn-danger");
                __builder2.AddAttribute(156, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                         DeleteEmployee

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(157, "Delete");
                __builder2.CloseElement();
#nullable restore
#line 99 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(158, "a");
                __builder2.AddAttribute(159, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(160, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                                      NavigateToOverview

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(161, "Back to overview");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 106 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
}

else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(162, "div");
            __builder.AddAttribute(163, "class", "alert" + " " + (
#nullable restore
#line 110 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                           StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(164, 
#nullable restore
#line 110 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
                                         Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 111 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "C:\Users\kamil\Desktop\szkola\4 rok\7 semestr\inzynierka\MyGarage\src\MyGarage\MyGarage.Blazor\Pages\EmployeeEdit.razor"
       
    [Inject]
    public IEmployeeDataService EmployeeDataService { get; set; }

    [Inject]
    public ICountryDataService CountryDataService { get; set; }

    [Inject]
    public IJobCategoryDataService JobCategoryDataService { get; set; }

    [Parameter]
    public string EmployeeId { get; set; }

    public Employee Employee { get; set; } = new Employee();

    //public List<Country> Countries { get; set; } = new List<Country>();

    public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

    //protected string CountryId = string.Empty;

    protected string JobCategoryId = string.Empty;

    protected string Message = string.Empty;
    protected string StatusClass = string.Empty;
    protected bool Saved;

    protected async override Task OnInitializedAsync()
    {
        Saved = false;
        //Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
        //Countries = (await CountryDataService.GetAllCountries()).ToList();
        JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList();

        int.TryParse(EmployeeId, out var employeeId);

        if (employeeId == 0)
        {
            Employee = new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
        }
        else
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
        }


        //CountryId = Employee.CountryId.ToString();
        JobCategoryId = Employee.JobCategoryId.ToString();
    }

    protected async Task HandleValidSubmit()
    {
        Saved = false;
        //Employee.CountryId = int.Parse(CountryId);
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
namespace __Blazor.MyGarage.Blazor.Pages.EmployeeEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
