#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b6867bcff1d6c6a3a553a4cb207adcf737ca5bb"
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
#nullable restore
#line 5 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
  
    string cms = "/cms";
    string cmsNewsfeed = "/cms/publications";
    string cmsArticles = "/cms/articles";
    string cmsAbout = "/cms/about";
    string cmsContacts = "/cms/contacts";
    string newsfeed = "/newsfeed";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "style", "margin-bottom: 70px");
            __builder.OpenComponent<AntDesign.Layout>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Header>(5);
                __builder2.AddAttribute(6, "Style", "position: fixed; background: #00BFFF; width: 100%; margin-bottom:50px; z-index: 999999; ");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(8, "div");
                    __builder3.AddAttribute(9, "class", "container");
                    __builder3.AddMarkupContent(10, "<div class=\"logo\" style=\"width:100%\"></div>\r\n                ");
                    __builder3.OpenComponent<AntDesign.Menu>(11);
                    __builder3.AddAttribute(12, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuMode>(
#nullable restore
#line 19 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
                            MenuMode.Horizontal

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "DefaultSelectedKeys", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 19 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
                                                                       new[]{"/"}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.MenuItem>(15);
                        __builder4.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
                                        () => { Nav.NavigateTo(cms, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(18, "CMS");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(19, "\r\n                    ");
                        __builder4.OpenElement(20, "a");
                        __builder4.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
                                 () => { Nav.NavigateTo(newsfeed, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddMarkupContent(22, "<span class=\"badge badge-secondary\">На сайт</span>");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(23, "\r\n                    ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(24);
                        __builder4.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
                                        () => { Nav.NavigateTo(cmsNewsfeed, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(27, "Публикации");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(28, "\r\n                    ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(29);
                        __builder4.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
                                        () => { Nav.NavigateTo(cmsArticles, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(32, "Статьи");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(33, "\r\n                    ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(34);
                        __builder4.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
                                        () => { Nav.NavigateTo(cmsAbout, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(37, "О себе");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(38, "\r\n                    ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(39);
                        __builder4.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
                                        () => { Nav.NavigateTo(cmsContacts, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(42, "Контакты");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
            __builder.AddMarkupContent(44, "<style>\r\n    body {\r\n        background-size: contain;\r\n        background-repeat: repeat-y;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "container content");
            __builder.AddAttribute(47, "style", "padding: 60px 15px 60px;  height: 100%");
            __builder.AddContent(48, 
#nullable restore
#line 42 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Shared\CmsLayout.razor"
       
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
