#pragma checksum "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f037a9f200f9e95996153ecc9e149ea156fe37"
// <auto-generated/>
#pragma warning disable 1591
namespace KulkovFrontend.Pages
{
    #line hidden
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
#line 3 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
using Kulkov.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
using Kulkov.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/empl")]
    public partial class Employee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Безработные</h1>\r\n\r\n");
            __builder.OpenElement(1, "label");
            __builder.AddAttribute(2, "for", "inp");
            __builder.AddAttribute(3, "class", "inp");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                    employee.last_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.last_name = __value, employee.last_name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.AddMarkupContent(10, "<span class=\"label\">Фамилия</span>\r\n    <span class=\"border\"></span>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "label");
            __builder.AddAttribute(13, "for", "inp");
            __builder.AddAttribute(14, "class", "inp");
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                    employee.first_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.first_name = __value, employee.first_name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.AddMarkupContent(21, "<span class=\"label\">Имя</span>\r\n    <span class=\"border\"></span>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "label");
            __builder.AddAttribute(24, "for", "inp");
            __builder.AddAttribute(25, "class", "inp");
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "text");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                    employee.patronymic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.patronymic = __value, employee.patronymic));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.AddMarkupContent(32, "<span class=\"label\">Отчество</span>\r\n    <span class=\"border\"></span>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.OpenElement(34, "label");
            __builder.AddAttribute(35, "for", "inp");
            __builder.AddAttribute(36, "class", "inp");
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "datetime");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                        employee.hire_date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.hire_date = __value, employee.hire_date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.AddMarkupContent(43, "<span class=\"label\">Дата найма</span>\r\n    <span class=\"border\"></span>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    <br>\r\n");
            __builder.OpenElement(45, "select");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                     employee.id_post

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.id_post = __value, employee.id_post));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(49, "\r\n\r\n    ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "value", "-1");
            __builder.AddMarkupContent(52, "Должность");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 42 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
     if (posts != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
         foreach (var post in posts)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "            ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", 
#nullable restore
#line 46 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                            post.id_post

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " ");
            __builder.AddContent(58, 
#nullable restore
#line 46 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                            post.post_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 47 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.OpenElement(61, "label");
            __builder.AddAttribute(62, "for", "inp");
            __builder.AddAttribute(63, "class", true);
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.AddMarkupContent(65, "<span class=\"inp label\">Пол</span>\r\n    ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "checkbox");
            __builder.AddAttribute(68, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                  employee.gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.gender = __value, employee.gender));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "type", "button");
            __builder.AddAttribute(74, "value", "Добавить");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                Add

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n");
#nullable restore
#line 57 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
 if (employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "    ");
            __builder.AddMarkupContent(78, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 60 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "    ");
            __builder.OpenElement(80, "table");
            __builder.AddAttribute(81, "class", "table");
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.AddMarkupContent(83, @"<thead>
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
            __builder.OpenElement(84, "tbody");
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 77 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
             for (int i = 0; i < employees.Count; i++)
            {
                var l = i; //local index

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "                ");
            __builder.OpenElement(87, "tr");
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 81 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                         employees[i].id_emp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.OpenElement(92, "td");
            __builder.OpenElement(93, "input");
            __builder.AddAttribute(94, "type", "text");
            __builder.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                                                                                       () => { Update(l).Wait(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                        employees[l].last_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employees[l].last_name = __value, employees[l].last_name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.OpenElement(99, "td");
            __builder.OpenElement(100, "input");
            __builder.AddAttribute(101, "type", "text");
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                                                                                        () => { Update(l).Wait(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                        employees[l].first_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employees[l].first_name = __value, employees[l].first_name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.OpenElement(106, "td");
            __builder.OpenElement(107, "input");
            __builder.AddAttribute(108, "type", "text");
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                                                                                        () => { Update(l).Wait(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 84 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                        employees[l].patronymic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employees[l].patronymic = __value, employees[l].patronymic));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                    ");
            __builder.OpenElement(113, "td");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "type", "checkbox");
            __builder.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                                                                            () => { Update(l).Wait(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 85 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                      employees[l].gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employees[l].gender = __value, employees[l].gender));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                    ");
            __builder.OpenElement(120, "td");
            __builder.OpenElement(121, "input");
            __builder.AddAttribute(122, "type", "datetime");
            __builder.AddAttribute(123, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                                                                                           () => { Update(l).Wait(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                            employees[l].hire_date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employees[l].hire_date = __value, employees[l].hire_date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.OpenElement(127, "td");
            __builder.AddMarkupContent(128, "\r\n                        ");
            __builder.OpenElement(129, "select");
            __builder.AddAttribute(130, "class", "");
            __builder.AddAttribute(131, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                                                                        () => { Update(l).Wait(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                 employees[l].id_post

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(133, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employees[l].id_post = __value, employees[l].id_post));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(134, "\r\n");
#nullable restore
#line 90 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                             if (posts != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                 foreach (var post in posts)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(135, "                                    ");
            __builder.OpenElement(136, "option");
            __builder.AddAttribute(137, "value", 
#nullable restore
#line 94 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                    post.id_post

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(138, " ");
            __builder.AddContent(139, 
#nullable restore
#line 94 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                                    post.post_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 95 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(141, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                    ");
            __builder.OpenElement(144, "td");
            __builder.OpenElement(145, "input");
            __builder.AddAttribute(146, "type", "checkbox");
            __builder.AddAttribute(147, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                      vs[l]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(148, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vs[l] = __value, vs[l]));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n");
#nullable restore
#line 101 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(151, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n    ");
            __builder.OpenElement(154, "input");
            __builder.AddAttribute(155, "type", "button");
            __builder.AddAttribute(156, "value", "Удалить записи");
            __builder.AddAttribute(157, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
                                                          Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n");
#nullable restore
#line 105 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\a7aro\source\repos\Kulkov\KulkovFrontend\Pages\Employee.razor"
       
    public List<Kulkov.Data.Employee> employees;

    public Kulkov.Data.Employee employee = new Kulkov.Data.Employee();

    public bool[] vs;

    private List<Kulkov.Data.Post> posts;

    protected async Task Add()
    {
        await Service.AddEmployee(employee);
        employee = new Kulkov.Data.Employee();
        await UpdateTable();
    }

    protected async Task Update()
    {
        var response = await Service.GetAllEmployees();
        var updateItems = (from item in employees.AsParallel()
                           join dbemp in response.AsParallel() on item.id_emp equals dbemp.id_emp
                           where !(item.id_post.Equals(dbemp.id_post) && item.last_name.Equals(dbemp.last_name) &&
                           item.first_name.Equals(dbemp.first_name) && item.gender.Equals(dbemp.gender) &&
                           item.patronymic.Equals(dbemp.patronymic) && item.hire_date.Equals(dbemp.hire_date))
                           select item).ToList();
        foreach (var item in updateItems)
        {
            await Service.UpdateEmployee(item.id_emp, item);
        }
        //await UpdateTable();
    }
    protected async Task Update(int row)
    {
        await Service.UpdateEmployee(employees[row].id_emp, employees[row]);
        //await UpdateTable();
    }

    protected async Task Delete()
    {
        for (int i = 0; i < vs.Length; i++)
        {
            if (vs[i])
                await Service.RemoveEmployee(employees[i].id_emp);
        }
        await UpdateTable();
    }

    protected async Task UpdateTable()
    {
        var response = await Service.GetAllEmployees();
        employees = response.ToList();
        vs = null;
        vs = new bool[employees.Count];
        response = null;
    }

    protected async override Task OnInitializedAsync()
    {
        var response = await Service.GetAllEmployees();
        employees = response.ToList();
        vs = new bool[employees.Count];
        response = null;
        posts = (await PostGetter.GetAllPosts()).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostRepository PostGetter { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeRepository Service { get; set; }
    }
}
#pragma warning restore 1591
