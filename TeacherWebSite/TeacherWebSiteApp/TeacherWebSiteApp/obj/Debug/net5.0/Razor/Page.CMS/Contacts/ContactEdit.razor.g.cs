#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77991ff56330a3a1387c44b8783cc7dfcd1ae96a"
// <auto-generated/>
#pragma warning disable 1591
namespace TeacherWebSiteApp.Page.CMS.Publications
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
#line 17 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CmsLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/cms/contacts")]
    public partial class ContactEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "style", "margin-left:80px; margin-right:40%");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6");
            __builder.AddMarkupContent(5, "<label>Контакты</label>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-block");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-2");
            __builder.AddAttribute(12, "style");
            __builder.AddMarkupContent(13, "<label>Ключ</label>\r\n                    ");
            __Blazor.TeacherWebSiteApp.Page.CMS.Publications.ContactEdit.TypeInference.CreateInput_0(__builder, 14, 15, "text", 16, "form-control", 17, "Введите ключ", 18, 
#nullable restore
#line 17 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                    contact.Key

#line default
#line hidden
#nullable disable
            , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Key = __value, contact.Key)), 20, () => contact.Key);
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "  \r\n                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-md-2");
            __builder.AddMarkupContent(24, "<label>Значение</label>\r\n                    ");
            __Blazor.TeacherWebSiteApp.Page.CMS.Publications.ContactEdit.TypeInference.CreateInput_1(__builder, 25, 26, "text", 27, "form-control", 28, "Введите значение", 29, 
#nullable restore
#line 21 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                    contact.Value

#line default
#line hidden
#nullable disable
            , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Value = __value, contact.Value)), 31, () => contact.Value);
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-md-2");
            __builder.AddMarkupContent(35, @"<span><label>Ссылка</label>
                        <svg onclick=""alert('Инструкция')"" xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-question-circle"" viewBox=""0 0 16 16""><path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z""></path>
                            <path d=""M5.255 5.786a.237.237 0 0 0 .241.247h.825c.138 0 .248-.113.266-.25.09-.656.54-1.134 1.342-1.134.686 0 1.314.343 1.314 1.168 0 .635-.374.927-.965 1.371-.673.489-1.206 1.06-1.168 1.987l.003.217a.25.25 0 0 0 .25.246h.811a.25.25 0 0 0 .25-.25v-.105c0-.718.273-.927 1.01-1.486.609-.463 1.244-.977 1.244-2.056 0-1.511-1.276-2.241-2.673-2.241-1.267 0-2.655.59-2.75 2.286zm1.557 5.763c0 .533.425.927 1.01.927.609 0 1.028-.394 1.028-.927 0-.552-.42-.94-1.029-.94-.584 0-1.009.388-1.009.94z""></path></svg></span>
                    ");
            __Blazor.TeacherWebSiteApp.Page.CMS.Publications.ContactEdit.TypeInference.CreateInput_2(__builder, 36, 37, "text", 38, "form-control", 39, "Введите ссылку", 40, 
#nullable restore
#line 31 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                    contact.Link

#line default
#line hidden
#nullable disable
            , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Link = __value, contact.Link)), 42, () => contact.Link);
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-md-2");
            __builder.OpenComponent<TeacherWebSiteApp.Components.UploadImage>(46);
            __builder.AddAttribute(47, "Text", "Загрузите значок");
            __builder.AddAttribute(48, "ImageData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Byte[]>(
#nullable restore
#line 34 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                      contact.Badge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "ImageDataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Byte[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Byte[]>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Badge = __value, contact.Badge))));
            __builder.CloseComponent();
#nullable restore
#line 35 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                         if (contact.Badge != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "img");
            __builder.AddAttribute(51, "src", "data:image/png;base64," + (
#nullable restore
#line 37 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                             Convert.ToBase64String(contact.Badge)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "height", "40");
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "form-block");
            __builder.AddAttribute(56, "style", "margin-top: 20px; margin-bottom:20px");
            __builder.OpenComponent<AntDesign.Button>(57);
            __builder.AddAttribute(58, "Type", "button");
            __builder.AddAttribute(59, "Class", "btn btn-success");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                                     AddContact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(62, "Добавить");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenComponent<TeacherWebSiteApp.Components.ValidationBlock>(64);
            __builder.AddAttribute(65, "Messages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 45 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                       validationMessages

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-block");
            __builder.OpenComponent<AntDesign.Table<Contact>>(69);
            __builder.AddAttribute(70, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Contact>>(
#nullable restore
#line 49 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                               contacts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "HidePagination", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                                         false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Contact>)((context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.Column<string>>(73);
                __builder2.AddAttribute(74, "Title", "Значок");
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(76, "img");
                    __builder3.AddAttribute(77, "src", "data:image/png;base64," + (
#nullable restore
#line 51 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                     Convert.ToBase64String(context.Badge)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "height", "40");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.OpenComponent<AntDesign.Column<string>>(80);
                __builder2.AddAttribute(81, "Title", "Ключ");
                __builder2.AddAttribute(82, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 53 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                   context.Key

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "FieldChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Key = __value, context.Key))));
                __builder2.AddAttribute(84, "FieldExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => context.Key));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                ");
                __builder2.OpenComponent<AntDesign.Column<string>>(86);
                __builder2.AddAttribute(87, "Title", "Значение");
                __builder2.AddAttribute(88, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 54 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                       context.Value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "FieldChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Value = __value, context.Value))));
                __builder2.AddAttribute(90, "FieldExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => context.Value));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                ");
                __builder2.OpenComponent<AntDesign.Column<string>>(92);
                __builder2.AddAttribute(93, "Title", "Ссылка");
                __builder2.AddAttribute(94, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 55 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                     context.Link

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "FieldChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Link = __value, context.Link))));
                __builder2.AddAttribute(96, "FieldExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => context.Link));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n                ");
                __builder2.OpenComponent<AntDesign.Column<bool?>>(98);
                __builder2.AddAttribute(99, "Title", " ");
                __builder2.AddAttribute(100, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool?>(
#nullable restore
#line 56 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                      context.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "FieldChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.IsActive = __value, context.IsActive))));
                __builder2.AddAttribute(102, "FieldExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool?>>>(() => context.IsActive));
                __builder2.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Button>(104);
                    __builder3.AddAttribute(105, "Danger", true);
                    __builder3.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                      () => DeleteContact(context.Key, context.Value)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(108, "\r\n                        Удалить\r\n                    ");
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
            __builder.AddMarkupContent(109, "\r\n\r\n        ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "form-block");
            __builder.OpenComponent<AntDesign.Button>(112);
            __builder.AddAttribute(113, "Type", "primary");
            __builder.AddAttribute(114, "Style", "margin-bottom:30px");
            __builder.AddAttribute(115, "HtmlType", "submit");
            __builder.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                                                                          SaveAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "Class", "btn btn-block");
            __builder.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(119, "Сохранить");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(120, "\r\n            ");
            __builder.OpenComponent<TeacherWebSiteApp.Components.ValidationBlock>(121);
            __builder.AddAttribute(122, "Messages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 68 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
                                       validationMessages

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Contacts\ContactEdit.razor"
       

    public TeacherWebSiteApp.Data.PageModels.Contact contact = new();
    string[] validationMessages = new string[] { };
    List<Contact> contacts;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            using var context = DbFactory.CreateDbContext();
            contacts = await context.Contacts.ToListAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


    private bool ValidateContact()
    {
        var messages = new List<string>();

        if (string.IsNullOrEmpty(contact.Key)) messages.Add(@"'Ключ' не должно быть пусто.");
        else if (contact.Key.Length > 50) messages.Add(@"'Ключ' должно быть не более 50 символов.");

        if (string.IsNullOrEmpty(contact.Value)) messages.Add(@"'Значение' не должно быть пусто.");
        else if (contact.Value.Length > 50) messages.Add(@"'Значение' должно быть не более 50 символов.");

        if (!contact.Badge.Any())
            messages.Add("Загрузите хотя бы одно изображение.");

        validationMessages = messages.ToArray();
        return !validationMessages.Any();
    }

    private void AddContact()
    {
        using var context = DbFactory.CreateDbContext();
        if (!ValidateContact()) return;
        contacts.Add(contact);
        context.Contacts.Add(contact);
        context.SaveChanges();
        _message.Success("Контакт успешно добавлен!");
        contact = new();
    }

    private void DeleteContact(string key, string value)
    {
        using var context = DbFactory.CreateDbContext();
        var selectedContact = contacts.FirstOrDefault(x => x.Key == key && x.Value == value);
        contacts.Remove(selectedContact);
        context.Contacts.Remove(selectedContact);
        context.SaveChanges();
        _message.Success("Контакт успешно удален!");
    }

    private async Task SaveAsync()
    {
        try
        {
            using var context = DbFactory.CreateDbContext();
            foreach (var _contact in contacts)
            {
                context.Contacts.Add(_contact);
            }

            context.SaveChangesAsync();
            NavManager.NavigateTo("/cms/contacts", true);

        }
        catch (Exception ex)
        {
            validationMessages = new string[] { ex.Message, ex.InnerException?.Message };
            ValidateContact();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService _message { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<TeacherContext> DbFactory { get; set; }
    }
}
namespace __Blazor.TeacherWebSiteApp.Page.CMS.Publications.ContactEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInput_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Type", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInput_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Type", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInput_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Type", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
