#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2c39d3d6d3895705a35f89ec7c7f125c9bcbee5"
// <auto-generated/>
#pragma warning disable 1591
namespace TeacherWebSiteApp.Page_CMS.Publication
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CmsLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/cms/publications")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AntDesign.Title>(0);
            __builder.AddAttribute(1, "Level", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
              3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "Публикации");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 10 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
   string add = "/cms/publication/0"; 

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.InputGroup>(4);
            __builder.AddAttribute(5, "Style", "margin-bottom: 20px");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Button>(7);
                __builder2.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                      () => NavManager.NavigateTo(add)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "Добавить");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n\n");
            __builder.OpenComponent<AntDesign.Table<TeacherWebSiteApp.Data.Models.Publication>>(12);
            __builder.AddAttribute(13, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TeacherWebSiteApp.Data.Models.Publication>>(
#nullable restore
#line 16 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                   publications

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "HidePagination", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                                                                                                   false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<TeacherWebSiteApp.Data.Models.Publication>)((context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.Column<string>>(16);
                __builder2.AddAttribute(17, "Title", "Название");
                __builder2.AddAttribute(18, "Sortable", true);
                __builder2.AddAttribute(19, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 17 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                                           context.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "FieldChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Name = __value, context.Name))));
                __builder2.AddAttribute(21, "FieldExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => context.Name));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(23, "a");
                    __builder3.AddAttribute(24, "href", "/cms/publication/" + (
#nullable restore
#line 18 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                                   context.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(25, 
#nullable restore
#line 18 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                                                context

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(26, ".");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n    ");
                __builder2.OpenComponent<AntDesign.Column<string>>(28);
                __builder2.AddAttribute(29, "Title", "Описание");
                __builder2.AddAttribute(30, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 20 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                                           context.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "FieldChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Text = __value, context.Text))));
                __builder2.AddAttribute(32, "FieldExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => context.Text));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n    ");
                __Blazor.TeacherWebSiteApp.Page_CMS.Publication.List.TypeInference.CreateColumn_0(__builder2, 34, 35, "Дата создания", 36, "yyyy-MM-dd", 37, true, 38, 
#nullable restore
#line 21 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                                                context.Date

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Date = __value, context.Date)), 40, () => context.Date);
                __builder2.AddMarkupContent(41, "\n    ");
                __builder2.OpenComponent<AntDesign.Column<bool?>>(42);
                __builder2.AddAttribute(43, "Title", "Активный");
                __builder2.AddAttribute(44, "Sortable", true);
                __builder2.AddAttribute(45, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool?>(
#nullable restore
#line 22 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                                           context.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "FieldChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.IsActive = __value, context.IsActive))));
                __builder2.AddAttribute(47, "FieldExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool?>>>(() => context.IsActive));
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Switch>(49);
                    __builder3.AddAttribute(50, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                          context.IsActive.Value

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 23 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
                                                            async (val) => await SwitchActive(context.Id, val)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite(origin)\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Publication\List.razor"
        
    List<TeacherWebSiteApp.Data.Models.Publication> publications;

    protected override void OnInitialized()
    {
        Reload();
    }

    private void Reload()
    {
        using TeacherContext context = DbFactory.CreateDbContext();
        publications = context.Publications.ToList();
    }

    private async Task SwitchActive(int Id, bool? value)
    {
        using var context = DbFactory.CreateDbContext();
        var publication = await context.Publications.FirstOrDefaultAsync(p => p.Id == Id);
        if (publication != null)
        {
            publication.IsActive = value;
            await context.SaveChangesAsync();
            string state = (publication.IsActive.Value) ? "активированa" : "деактивированa";
            _message.Info($"Публикация {publication.Name} {state}.");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService _message { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<TeacherContext> DbFactory { get; set; }
    }
}
namespace __Blazor.TeacherWebSiteApp.Page_CMS.Publication.List
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateColumn_0<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, TData __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Format", __arg1);
        __builder.AddAttribute(__seq2, "Sortable", __arg2);
        __builder.AddAttribute(__seq3, "Field", __arg3);
        __builder.AddAttribute(__seq4, "FieldChanged", __arg4);
        __builder.AddAttribute(__seq5, "FieldExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
