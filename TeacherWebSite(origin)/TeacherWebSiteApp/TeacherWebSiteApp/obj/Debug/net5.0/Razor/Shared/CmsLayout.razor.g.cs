#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01e619eec5cf4b7859a04060e15f8cc2f5121df4"
// <auto-generated/>
#pragma warning disable 1591
namespace TeacherWebSiteApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Data.PageModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
    public partial class CmsLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.OpenElement(1, "nav");
            __builder.AddAttribute(2, "class", "navbar navbar-expand-sm navbar-toggleable-sm position-static navbar-dark bg-dark border-bottom box-shadow mb-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
#nullable restore
#line 8 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
               string newsfeed = "/newsfeed"; 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<a class=\"navbar-brand text-light\" href=\"/cms\">CMS</a>\n            ");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
                         () => { Nav.NavigateTo(newsfeed, true); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "<span class=\"badge badge-secondary\">На сайт</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "navbar-collapse" + " " + (
#nullable restore
#line 14 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
                                         NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " d-sm-inline-flex" + " justify-content-between");
            __builder.AddMarkupContent(12, @"<ul class=""navbar-nav flex-grow-1""><li class=""nav-item""><a class=""nav-link text-white"" href=""/cms/category"">Публикации</a></li>
                    <li class=""nav-item""><a class=""nav-link text-white"" href=""/cms/products"">Статьи</a></li>
                    <li class=""nav-item""><a class=""nav-link text-white"" href=""/cms/calculator"">О себе</a></li>
                    <li class=""nav-item""><a class=""nav-link text-white"" href=""/cms/articles"">Контакты</a></li>
                    <li class=""nav-item dropdown""><a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Настройки
                        </a>
                        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown""><a class=""dropdown-item"" href=""/cms/mainPage"">&laquo;Главная&raquo; настройка</a>
                            <a class=""dropdown-item"" href=""/cms/infoPage"">&laquo;Контакты&raquo; настройка</a></div></li></ul>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "container content");
            __builder.AddAttribute(16, "style", "margin-bottom:60px");
            __builder.AddContent(17, 
#nullable restore
#line 44 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591
