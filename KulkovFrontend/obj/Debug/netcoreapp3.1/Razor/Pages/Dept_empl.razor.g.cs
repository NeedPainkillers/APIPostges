#pragma checksum "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3839cd965b0c6a10ea2b2e0ced2040524c79b9bb"
// <auto-generated/>
#pragma warning disable 1591
namespace KulkovFrontend.Pages
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\_Imports.razor"
using KulkovFrontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\_Imports.razor"
using KulkovFrontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
using Kulkov.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/depemp")]
    public partial class Dept_empl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Сотрудники отделов</h1>\r\n\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                                                                              UpdateTable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                                     id_dep

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => id_dep = __value, id_dep));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", "-1");
            __builder.AddMarkupContent(9, "Отдел");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 15 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
     if (departments != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
         foreach (var row in departments)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 19 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                            row.id_dept

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 19 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                                           row.dept_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 20 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 26 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
 if (employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.AddMarkupContent(19, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 29 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.OpenElement(21, "select");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                                         id_emp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => id_emp = __value, id_emp));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(25, "\r\n\r\n        ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "-1");
            __builder.AddMarkupContent(28, "Выберите сотрудника");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 35 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
         if (allEmployees != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
             foreach (var row in (from item in allEmployees
                                 join emp in employees on item.id_emp equals emp.id_emp into empGroup
                                 from empl in empGroup.DefaultIfEmpty()
                                 where empl is null
                                 select item))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", 
#nullable restore
#line 43 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                                row.id_emp

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, " ");
            __builder.AddContent(34, 
#nullable restore
#line 43 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                                              row.last_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 44 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.AddContent(38, "    ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "value", "Добавить");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                                                    Add

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "table");
            __builder.AddAttribute(45, "class", "table");
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.AddMarkupContent(47, @"<thead>
            <tr>
                <th>id</th>
                <th>Фамилия</th>
                <th>Имя</th>
                <th>Отчество</th>
                <th>Пол</th>
                <th>Дата найма</th>
                <th>id должности</th>
                <th>Удалить</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(48, "tbody");
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 63 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
             for (int i = 0; i < employees.Count; i++)
            {
                var l = i; //local index

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 67 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                         employees[i].id_emp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 68 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                         employees[l].last_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 69 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                         employees[l].first_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 70 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                         employees[l].patronymic

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 71 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                         employees[l].gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 72 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                         employees[l].hire_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 73 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                         posts.Where(x => x.id_post.Equals(employees[l].id_post)).Take(1).First().post_name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(73, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "td");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "type", "checkbox");
            __builder.AddAttribute(78, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                                                      vs[l]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vs[l] = __value, vs[l]));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 76 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "type", "button");
            __builder.AddAttribute(87, "value", "Удалить записи");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
                                                          Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 80 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Dept_empl.razor"
       

    [Parameter]
    public int id_dep { get; set; } = -1;
    [Parameter]
    public int id_emp { get; set; } = -1;

    public List<Kulkov.Data.Employee> employees;
    public List<Kulkov.Data.Department> departments;
    public List<Kulkov.Data.Post> posts;

    private List<Kulkov.Data.Employee> allEmployees;

    public bool[] vs;

    protected async Task Add()
    {
        await Service.AddEmployee(id_dep, id_emp);
        id_emp = -1;
        await UpdateTable();
    }

    //protected async Task Update(int row)
    //{
    //    await Service.UpdateLocation(employees[row].id_loc, employees[row]);
    //    //await UpdateTable();
    //}

    protected async Task Delete()
    {
        for (int i = 0; i < vs.Length; i++)
        {
            if (vs[i])
                await Service.DeleteEmployee(id_dep, employees[i].id_emp);
        }
        await UpdateTable();
    }

    protected async Task UpdateTable()
    {
        var response = await Service.GetEmployees(id_dep);
        employees = response.ToList();
        vs = null;
        vs = new bool[employees.Count];
        response = null;
    }

    protected async override Task OnInitializedAsync()
    {
        departments = (await Service.GetAllDepartments()).ToList();
        posts = (await GetterPost.GetAllPosts()).ToList();
        allEmployees = (await GetterEmp.GetAllEmployees()).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeRepository GetterEmp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostRepository GetterPost { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDepartmentRepository Service { get; set; }
    }
}
#pragma warning restore 1591