#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f823f2883295c9a830353ecc0973e60a411d5f9"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/publications")]
    public partial class Publications : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatTabGroup>(0);
            __builder.AddAttribute(1, "Style", "z-index: 999999");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatTab>(3);
                __builder2.AddAttribute(4, "Label", "Все");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 8 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
         foreach (var publication in publications)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(6, "div");
                    __builder3.AddAttribute(7, "style", "margin-left: 65px; margin-top: 10px");
                    __builder3.OpenComponent<TeacherWebSiteApp.Components.Publication>(8);
                    __builder3.AddAttribute(9, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                      publication.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                             publication.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                                                      publication.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 11 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                                                                               publication.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
#nullable restore
#line 13 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatTab>(14);
                __builder2.AddAttribute(15, "Label", "Презентации");
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 16 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
         foreach (var publication in publications.Where(p => p.Attachments.Any(a => a.ContentType == ContentType.Presentation)))
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(17, "div");
                    __builder3.AddAttribute(18, "style", "margin-left: 65px; margin-top: 10px");
                    __builder3.OpenComponent<TeacherWebSiteApp.Components.Publication>(19);
                    __builder3.AddAttribute(20, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                  publication.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                         publication.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                                                  publication.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 19 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                                                                           publication.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
#nullable restore
#line 21 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatTab>(25);
                __builder2.AddAttribute(26, "Label", "Методички");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 24 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
         foreach (var publication in publications.Where(p => p.Attachments.Any(a => a.ContentType == ContentType.MethodicalBook)))
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(28, "div");
                    __builder3.AddAttribute(29, "style", "margin-left: 65px; margin-top: 10px");
                    __builder3.OpenComponent<TeacherWebSiteApp.Components.Publication>(30);
                    __builder3.AddAttribute(31, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                  publication.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                         publication.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                                                  publication.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 27 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                                                                           publication.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
#nullable restore
#line 29 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatTab>(36);
                __builder2.AddAttribute(37, "LabelContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "\r\n            Видео-уроки\r\n        ");
                }
                ));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 36 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
             foreach (var publication in publications.Where(p => p.Attachments.Any(a => a.ContentType == ContentType.Video)))
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "style", "margin-left: 65px; margin-top: 10px");
                    __builder3.OpenComponent<TeacherWebSiteApp.Components.Publication>(42);
                    __builder3.AddAttribute(43, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                      publication.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                             publication.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                                                      publication.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 39 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
                                                                                                               publication.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
#nullable restore
#line 41 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Pages\Publications.razor"
       
    List<TeacherWebSiteApp.Data.Models.Publication> publications;

    protected override void OnInitialized()
    {
        using var context = DbFactory.CreateDbContext();
        publications = context.Publications.Include(p => p.Attachments).Where(p => p.IsActive == true).ToList();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<TeacherContext> DbFactory { get; set; }
    }
}
#pragma warning restore 1591
