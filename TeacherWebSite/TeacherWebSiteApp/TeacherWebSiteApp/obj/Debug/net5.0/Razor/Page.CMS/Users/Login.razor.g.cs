#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e922c472544e0927ccd6d75150201d260966cb5b"
// <auto-generated/>
#pragma warning disable 1591
namespace TeacherWebSiteApp.Page.CMS.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Data.PageModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Data.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-left: 450px; margin-top: 150px");
            __builder.AddAttribute(2, "b-ljfnra0jtq");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddAttribute(5, "b-ljfnra0jtq");
            __builder.OpenComponent<AntDesign.Row>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-offset-3 col-md-6");
                __builder2.AddAttribute(10, "b-ljfnra0jtq");
                __builder2.OpenElement(11, "form");
                __builder2.AddAttribute(12, "class", "form-horizontal");
                __builder2.AddAttribute(13, "b-ljfnra0jtq");
                __builder2.AddMarkupContent(14, "<span class=\"heading\" b-ljfnra0jtq>Вход в CMS</span>\r\n                    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddAttribute(17, "b-ljfnra0jtq");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "id", "inputfield");
                __builder2.AddAttribute(22, "placeholder", "Логин");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\Login.razor"
                                                                             login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => login = __value, login));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(25, "b-ljfnra0jtq");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                        <i class=\"fa fa-user\" b-ljfnra0jtq></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group help");
                __builder2.AddAttribute(30, "b-ljfnra0jtq");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "type", "password");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "id", "inputPassword");
                __builder2.AddAttribute(35, "placeholder", "Пароль");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\Login.razor"
                                                                                 password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(38, "b-ljfnra0jtq");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                        <i class=\"fa fa-lock\" b-ljfnra0jtq></i>\r\n                        <a href=\"#\" class=\"fa fa-question-circle\" b-ljfnra0jtq></a>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddAttribute(43, "b-ljfnra0jtq");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\Login.razor"
                                          LogIn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "type", "submit");
                __builder2.AddAttribute(47, "class", "btn btn-default");
                __builder2.AddAttribute(48, "b-ljfnra0jtq");
                __builder2.AddMarkupContent(49, "ВХОД");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\Login.razor"
       

    string login;
    string password;

    string[] messages = new string[] { };

    void LogIn()
    {
        ProducedAuthenticationStateProvider p = provider as ProducedAuthenticationStateProvider;
        var result = p.Login(login, password);

        if (result == null)
        {
            NavManager.NavigateTo("/cms", true);
        }
        else messages = new string[] { result };

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider provider { get; set; }
    }
}
#pragma warning restore 1591
