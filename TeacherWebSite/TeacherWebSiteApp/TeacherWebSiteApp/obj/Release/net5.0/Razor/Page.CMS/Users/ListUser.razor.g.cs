#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01be2f92240f084d178eb3b189050a666cbc340c"
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
#nullable restore
#line 22 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CmsLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/cms/users")]
    public partial class ListUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-right: 485px; margin-left: 300px");
            __builder.AddMarkupContent(2, "<h3 style=\"padding-left: 250px\">Пользователи</h3>\r\n    ");
            __builder.OpenComponent<TeacherWebSiteApp.Components.ValidationBlock>(3);
            __builder.AddAttribute(4, "Messages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 12 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                               messages

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n    ");
            __Blazor.TeacherWebSiteApp.Page.CMS.Users.ListUser.TypeInference.CreateForm_0(__builder, 6, 7, 
#nullable restore
#line 13 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                 reg

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 14 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                        8

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 15 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                          16

#line default
#line hidden
#nullable disable
            , 10, (context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.FormItem>(11);
                __builder2.AddAttribute(12, "Label", "Имя пользователя");
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.TeacherWebSiteApp.Page.CMS.Users.ListUser.TypeInference.CreateInput_1(__builder3, 14, 15, 
#nullable restore
#line 17 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                 context.UserName

#line default
#line hidden
#nullable disable
                    , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.UserName = __value, context.UserName)), 17, () => context.UserName);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<AntDesign.FormItem>(19);
                __builder2.AddAttribute(20, "Label", "Логин");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.TeacherWebSiteApp.Page.CMS.Users.ListUser.TypeInference.CreateInput_2(__builder3, 22, 23, 
#nullable restore
#line 20 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                 context.Login

#line default
#line hidden
#nullable disable
                    , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Login = __value, context.Login)), 25, () => context.Login);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenComponent<AntDesign.FormItem>(27);
                __builder2.AddAttribute(28, "Label", "Password");
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.InputPassword>(30);
                    __builder3.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                         context.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Password = __value, context.Password))));
                    __builder3.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => context.Password));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenComponent<AntDesign.FormItem>(35);
                __builder2.AddAttribute(36, "WrapperColOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 25 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                    8

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "WrapperColSpan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 25 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                                       16

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Style", "padding-left: 150px");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Button>(40);
                    __builder3.AddAttribute(41, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                     AntDesign.ButtonType.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                                                             Register

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "HtmlType", "submit");
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(45, "\r\n                Добавить\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n\r\n");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "style", "margin-right: 150px;  margin-left: 150px");
            __builder.AddMarkupContent(49, "<hr>\r\n    ");
            __builder.AddMarkupContent(50, "<h3 style=\"margin-top: 5px\">Список пользователей</h3>\r\n\r\n    ");
            __builder.OpenComponent<AntDesign.Table<User>>(51);
            __builder.AddAttribute(52, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<User>>(
#nullable restore
#line 38 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                     users

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "Style", "background-color: darkseagreen");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<User>)((context) => (__builder2) => {
                __Blazor.TeacherWebSiteApp.Page.CMS.Users.ListUser.TypeInference.CreateColumn_3(__builder2, 55, 56, "Имя пользователя", 57, 
#nullable restore
#line 39 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                                       context.Name

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Name = __value, context.Name)), 59, () => context.Name, 60, (__builder3) => {
                    __builder3.AddContent(61, 
#nullable restore
#line 40 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
             context.Name

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.AddMarkupContent(62, "\r\n        ");
                __Blazor.TeacherWebSiteApp.Page.CMS.Users.ListUser.TypeInference.CreateColumn_4(__builder2, 63, 64, "Логин", 65, 
#nullable restore
#line 42 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                            context.Login

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Login = __value, context.Login)), 67, () => context.Login, 68, (__builder3) => {
                    __builder3.AddContent(69, 
#nullable restore
#line 42 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                                            context.Login

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.AddMarkupContent(70, "\r\n        ");
                __Blazor.TeacherWebSiteApp.Page.CMS.Users.ListUser.TypeInference.CreateColumn_5(__builder2, 71, 72, "Пароль", 73, "padding-left: 25px", 74, 
#nullable restore
#line 43 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                             context.Password

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Password = __value, context.Password)), 76, () => context.Password, 77, (__builder3) => {
                    __builder3.AddMarkupContent(78, "<img src=\"https://img.icons8.com/material/24/000000/password--v1.png\">");
                }
                );
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.OpenComponent<AntDesign.ActionColumn>(80);
                __builder2.AddAttribute(81, "Title", " ");
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Space>(83);
                    __builder3.AddAttribute(84, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, (System.String, System.String)>>(
#nullable restore
#line 45 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                          "middle"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.SpaceItem>(86);
                        __builder4.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(88, "a");
                            __builder5.AddAttribute(89, "href", "/cms/password/" + (
#nullable restore
#line 47 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                            context.Id

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddMarkupContent(90, "Изменить пароль");
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(91, "\r\n                ");
                        __builder4.OpenComponent<AntDesign.SpaceItem>(92);
                        __builder4.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(94, "a");
                            __builder5.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
                                 () => DeleteAsync(context.Id)

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddMarkupContent(96, "Удалить");
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Users\ListUser.razor"
       
    bool loading = false;
    string[] messages = new string[] { };
    List<User> users = new List<User>();

    protected override async Task OnInitializedAsync()
    {
        using var context = DbFactory.CreateDbContext();
        users = await context.Users.ToListAsync();
    }

    private async Task DeleteAsync(int id)
    {
        using var context = DbFactory.CreateDbContext();
        if (context.Users.Count() == 1)
        {
            messages = new string[] { "Нельзя удалить последнего пользователя" };
            return;
        }
        var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);
        context.Users.Remove(user);
        await context.SaveChangesAsync();
        NavManager.NavigateTo("/cms/users", true);
    }

    RegisterVM reg = new();

    bool Validate()
    {
        List<string> problems = new List<string>();
        if (string.IsNullOrEmpty(reg.Login)) problems.Add(@"'Логин' должно быть заполнено");
        else if (reg.Login.Length > 50) problems.Add(@"'Логин' должно быть не более 50 символов");

        if (string.IsNullOrEmpty(reg.Password)) problems.Add(@"'Пароль' должно быть заполнено");

        if (!string.IsNullOrEmpty(reg.UserName) && reg.UserName.Length > 100)
            problems.Add(@"'Имя' должно быть не более 100 символов");

        messages = problems.ToArray();

        return !messages.Any();
    }

    public void Register()
    {
        if (!Validate()) return;
        ProducedAuthenticationStateProvider p = provider as ProducedAuthenticationStateProvider;
        var result = p.Register(reg.Login, reg.Password, reg.UserName);
        if (result == null)
        {
            using var context = DbFactory.CreateDbContext();
            users = context.Users.ToList();

            reg = new();
        }
        else
        {
            messages = new string[] { result };
        }

    }

    class RegisterVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<TeacherContext> DbFactory { get; set; }
    }
}
namespace __Blazor.TeacherWebSiteApp.Page.CMS.Users.ListUser
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateForm_0<TModel>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TModel __arg0, int __seq1, global::OneOf.OneOf<global::System.String, global::System.Int32> __arg1, int __seq2, global::OneOf.OneOf<global::System.String, global::System.Int32> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TModel> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Form<TModel>>(seq);
        __builder.AddAttribute(__seq0, "Model", __arg0);
        __builder.AddAttribute(__seq1, "LabelColSpan", __arg1);
        __builder.AddAttribute(__seq2, "WrapperColSpan", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInput_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInput_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateColumn_3<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TData __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "FieldChanged", __arg2);
        __builder.AddAttribute(__seq3, "FieldExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateColumn_4<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TData __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "FieldChanged", __arg2);
        __builder.AddAttribute(__seq3, "FieldExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateColumn_5<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TData __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Style", __arg1);
        __builder.AddAttribute(__seq2, "Field", __arg2);
        __builder.AddAttribute(__seq3, "FieldChanged", __arg3);
        __builder.AddAttribute(__seq4, "FieldExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591