#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "439c4a63c4db98c10d92ed0e4fb8a5bcb6b923a2"
// <auto-generated/>
#pragma warning disable 1591
namespace TeacherWebSiteApp.Pages
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/articles")]
    public partial class Articles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"display: flex; align-items: center; margin-top: 60px\" b-cglbnhxsmy><div style=\"text-align: center; display: block; width: 100%\" b-cglbnhxsmy><h3 b-cglbnhxsmy>Читайте наши статьи и новости</h3></div></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "target");
            __builder.AddAttribute(3, "style", "height:600vh;padding:8px;");
            __builder.AddAttribute(4, "b-cglbnhxsmy");
            __builder.OpenComponent<AntDesign.Row>(5);
            __builder.AddAttribute(6, "Style", "position: center");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 15 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
         foreach (var article in articles)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<AntDesign.Col>(8);
                __builder2.AddAttribute(9, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 17 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
                                 6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Style", "margin: auto; margin-top: 25px; margin-bottom: 25px; margin-right: 30px");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Card>(12);
                    __builder3.AddAttribute(13, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
                               article.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Style", "width:100%; min-height: 350px; border-radius: 20px;");
                    __builder3.AddAttribute(16, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(17, "div");
                        __builder4.AddAttribute(18, "style", "background-image:" + " url(data:image/png;base64," + (
#nullable restore
#line 20 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
                                                                                 Convert.ToBase64String(article.Blocks.FirstOrDefault()?.Image)

#line default
#line hidden
#nullable disable
                        ) + ");" + "\r\n                            height:" + " 200px;" + " background-size:" + " cover;" + " background-position:" + " center");
                        __builder4.AddAttribute(19, "b-cglbnhxsmy");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(20, "\r\n                        ");
                        __builder4.OpenElement(21, "div");
                        __builder4.AddAttribute(22, "style", "font-weight: 300");
                        __builder4.AddAttribute(23, "b-cglbnhxsmy");
                        __builder4.OpenElement(24, "div");
                        __builder4.AddAttribute(25, "class", "truncate");
                        __builder4.AddAttribute(26, "b-cglbnhxsmy");
                        __builder4.OpenElement(27, "p");
                        __builder4.AddAttribute(28, "b-cglbnhxsmy");
                        __builder4.AddContent(29, 
#nullable restore
#line 25 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
                                    article.Description

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(30, "\r\n                        ");
                        __builder4.OpenElement(31, "a");
                        __builder4.AddAttribute(32, "href", "/article/" + (
#nullable restore
#line 29 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
                                           article.Id

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "b-cglbnhxsmy");
                        __builder4.OpenComponent<AntDesign.Button>(34);
                        __builder4.AddAttribute(35, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
                                                     IconType.Outline.ArrowRight

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(37, "Читать ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 35 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
        }   

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n\r\n    ");
            __builder.OpenComponent<AntDesign.BackTop>(39);
            __builder.AddAttribute(40, "Style", "margin-bottom:60px");
            __builder.AddAttribute(41, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 38 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
                                                 OnClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<img src=\"https://img.icons8.com/fluency/48/000000/long-arrow-up.png\" b-cglbnhxsmy>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Articles.razor"
       
    
    List<Article> articles = new();

    protected override async Task OnInitializedAsync()
    {
        using TeacherContext context = DbFactory.CreateDbContext();
        articles = await context.Articles.Where(a => a.IsActive.Value).Include(a => a.Blocks).ToListAsync();
    }
    private void OnClick()
    {
        Console.WriteLine("TOP");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<TeacherContext> DbFactory { get; set; }
    }
}
#pragma warning restore 1591
