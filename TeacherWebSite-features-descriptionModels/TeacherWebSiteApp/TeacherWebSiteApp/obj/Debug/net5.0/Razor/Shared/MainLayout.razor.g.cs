#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85a6100b9e50d04d50fc28d772ac956f3a57e097"
// <auto-generated/>
#pragma warning disable 1591
namespace TeacherWebSiteApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.EntityFrameworkCore.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.EntityFrameworkCore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Data.PageModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using TeacherWebSiteApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\Shared\MainLayout.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\Shared\MainLayout.razor"
   
    string root = "/";
    string newsfeed = "/newsfeed";
    string articles = "/articles";
    string about = "/about";
    string contacts = "/contacts";

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.Layout>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Header>(2);
                __builder2.AddAttribute(3, "Style", "position: fixed; background: #00BFFF; width: 100%; ");
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(5, "div");
                    __builder3.AddAttribute(6, "class", "container");
                    __builder3.AddAttribute(7, "b-6ufbj4ms84");
                    __builder3.AddMarkupContent(8, "<div class=\"logo\" style=\"width:100%\" b-6ufbj4ms84></div>\n            ");
                    __builder3.OpenComponent<AntDesign.Menu>(9);
                    __builder3.AddAttribute(10, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuMode>(
#nullable restore
#line 18 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\Shared\MainLayout.razor"
                        MenuMode.Horizontal

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "DefaultSelectedKeys", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 18 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\Shared\MainLayout.razor"
                                                                  new[]{"/"}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.MenuItem>(13);
                        __builder4.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\Shared\MainLayout.razor"
                                    () => { Nav.NavigateTo(root, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(16, "Главная");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\n                ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(18);
                        __builder4.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\Shared\MainLayout.razor"
                                    () => { Nav.NavigateTo(newsfeed, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(21, "Лента");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\n                ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(23);
                        __builder4.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\Shared\MainLayout.razor"
                                    () => { Nav.NavigateTo(articles, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(26, "Статьи");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\n                ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(28);
                        __builder4.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\Shared\MainLayout.razor"
                                    () => { Nav.NavigateTo(about, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(31, "О себе");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\n                ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(33);
                        __builder4.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite-features-descriptionModels\TeacherWebSiteApp\TeacherWebSiteApp\Shared\MainLayout.razor"
                                    () => { Nav.NavigateTo(contacts, true); }

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(36, "Контакты");
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
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<TeacherContext> Context { get; set; }
    }
}
#pragma warning restore 1591
