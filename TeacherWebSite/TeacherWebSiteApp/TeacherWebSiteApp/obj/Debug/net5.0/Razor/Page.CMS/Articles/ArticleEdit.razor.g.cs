#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c69bd7eff4b57bfa798072332a28b2efd88c80f"
// <auto-generated/>
#pragma warning disable 1591
namespace WoodsOak.Pages.CMS.Arcticles
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
#line 2 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
using System.Collections.Concurrent;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CmsLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/cms/article/{id:int}")]
    public partial class ArticleEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenComponent<AntDesign.Col>(2);
            __builder.AddAttribute(3, "Style", "margin-left:60px; margin-right:500px");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Col>(5);
                __builder2.AddAttribute(6, "Style", "margin-bottom:20px");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "<label>Заголовок</label>\r\n                ");
                    __Blazor.WoodsOak.Pages.CMS.Arcticles.ArticleEdit.TypeInference.CreateInput_0(__builder3, 9, 10, "Введите заголовок статьи", 11, 
#nullable restore
#line 16 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                     article.Name

#line default
#line hidden
#nullable disable
                    , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => article.Name = __value, article.Name)), 13, () => article.Name);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<AntDesign.Col>(15);
                __builder2.AddAttribute(16, "Style", "margin-bottom:20px");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "<label>Описание</label>\r\n                ");
                    __builder3.OpenComponent<AntDesign.TextArea>(19);
                    __builder3.AddAttribute(20, "Placeholder", "Введите описание статьи");
                    __builder3.AddAttribute(21, "AutoSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                                                              article.Description

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => article.Description = __value, article.Description))));
                    __builder3.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => article.Description));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "container");
                __builder2.AddAttribute(28, "style", "margin-right:200px");
#nullable restore
#line 23 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                 foreach (TeacherWebSiteApp.Data.PageModels.ArcticleBlock block in article.Blocks)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(29, "<hr>\r\n                    ");
                __builder2.OpenComponent<AntDesign.Col>(30);
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Col>(32);
                    __builder3.AddAttribute(33, "Style", "margin-bottom:20px");
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(35, "<label>Подзаголовок</label>\r\n                            ");
                        __Blazor.WoodsOak.Pages.CMS.Arcticles.ArticleEdit.TypeInference.CreateInput_1(__builder4, 36, 37, "Введите подзаголовок абзаца", 38, 
#nullable restore
#line 29 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                 block.Title

#line default
#line hidden
#nullable disable
                        , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => block.Title = __value, block.Title)), 40, () => block.Title);
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n                        ");
                    __builder3.OpenComponent<AntDesign.Col>(42);
                    __builder3.AddAttribute(43, "Style", "margin-bottom:20px");
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(45, "<label>Текст</label>\r\n                            ");
                        __builder4.OpenComponent<AntDesign.TextArea>(46);
                        __builder4.AddAttribute(47, "Placeholder", "Введите текст");
                        __builder4.AddAttribute(48, "AutoSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                                                                block.Text

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => block.Text = __value, block.Text))));
                        __builder4.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => block.Text));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col");
                __builder2.OpenComponent<AntDesign.Col>(55);
                __builder2.AddAttribute(56, "Style", "margin-bottom:20px");
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 38 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                             if (block.Image != null)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "ant-form-item-label");
                    __builder3.OpenElement(60, "label");
                    __builder3.AddAttribute(61, "style", "color:cornflowerblue; cursor:pointer");
                    __builder3.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                                                                  () => { block.Image = null; }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(63, "Удалить изображение");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\r\n                                ");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "ant-form-item-control");
                    __builder3.OpenElement(67, "div");
                    __builder3.AddAttribute(68, "style", "margin: auto");
                    __builder3.OpenElement(69, "img");
                    __builder3.AddAttribute(70, "src", "data:image/png;base64," + (
#nullable restore
#line 46 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                                         Convert.ToBase64String(block.Image)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "style", "width:100%");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 50 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "ant-form-item-label");
                    __builder3.OpenComponent<TeacherWebSiteApp.Components.UploadImage>(74);
                    __builder3.AddAttribute(75, "HtmlId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                                                        Guid.NewGuid().ToString()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "Text", "Загрузите изображение");
                    __builder3.AddAttribute(77, "imageData", 
#nullable restore
#line 54 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                                  block.Image

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(78, "imageDataChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => block.Image = __value, block.Image));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
#nullable restore
#line 56 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "ant-form-item-label");
                    __builder3.AddAttribute(81, "style", "margin-left: 110px; margin-bottom:20px");
                    __builder3.OpenElement(82, "label");
                    __builder3.AddAttribute(83, "style", "color:cornflowerblue; cursor:pointer");
                    __builder3.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                                                              () => { article.Blocks.Remove(block); }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(85, "Удалить абзац");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __builder2.OpenComponent<AntDesign.Col>(87);
                __builder2.AddAttribute(88, "Style", "margin-bottom:20px");
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.WoodsOak.Pages.CMS.Arcticles.ArticleEdit.TypeInference.CreateInput_2(__builder3, 90, 91, "https://www.youtube.com/embed/xxxxxxxx", 92, 
#nullable restore
#line 62 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                 block.Video

#line default
#line hidden
#nullable disable
                    , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => block.Video = __value, block.Video)), 94, () => block.Video);
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 65 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.OpenComponent<AntDesign.Col>(96);
                __builder2.AddAttribute(97, "Style", "margin-bottom:20px");
                __builder2.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(99, "div");
                    __builder3.OpenComponent<AntDesign.Button>(100);
                    __builder3.AddAttribute(101, "type", "button");
                    __builder3.AddAttribute(102, "class", "btn btn-block");
                    __builder3.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                      () => { article.Blocks.Add(new TeacherWebSiteApp.Data.PageModels.ArcticleBlock() {ArticleId = article.Id}); }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(105, "\r\n                        Добавить абзац\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 76 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
             if (Id <= 0)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<AntDesign.Col>(106);
                __builder2.AddAttribute(107, "Style", "margin-bottom:20px");
                __builder2.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Button>(109);
                    __builder3.AddAttribute(110, "Type", "primary");
                    __builder3.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                     SaveAsync

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(112, "HtmlType", "submit");
                    __builder3.AddAttribute(113, "class", "btn btn-block");
                    __builder3.AddAttribute(114, "style", "margin-bottom:20px");
                    __builder3.AddAttribute(115, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(116, "Сохранить");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 81 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<AntDesign.Row>(117);
                __builder2.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Col>(119);
                    __builder3.AddAttribute(120, "Style", "margin-bottom:20px");
                    __builder3.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Col>(122);
                        __builder4.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Button>(124);
                            __builder5.AddAttribute(125, "Type", "primary");
                            __builder5.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                                             SaveAsync

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(127, "HtmlType", "submit");
                            __builder5.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(129, "Сохранить");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(130, "\r\n                    ");
                    __builder3.OpenComponent<AntDesign.Col>(131);
                    __builder3.AddAttribute(132, "style", "margin-bottom:20px; margin-left: 55px");
                    __builder3.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Col>(134);
                        __builder4.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Button>(136);
                            __builder5.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
                                              DeleteArcticle

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(138, "Type", "primary");
                            __builder5.AddAttribute(139, "Danger", true);
                            __builder5.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(141, "Удалить");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 96 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\Articles\ArticleEdit.razor"
           
        [Parameter]
        public int Id { get; set; }

        public TeacherWebSiteApp.Data.PageModels.Article article = new() { Blocks = new List<TeacherWebSiteApp.Data.PageModels.ArcticleBlock>() { new() } };


        protected override async Task OnInitializedAsync()
        {
            if (Id != 0)
            {
                using TeacherWebSiteApp.Data.TeacherContext context = DbFactory.CreateDbContext();
                article = await context.Articles.Include(b => b.Blocks).FirstOrDefaultAsync(x => x.Id == Id);
                if (article == null)
                {
                    _message.Error("Статья не найдена!");
                    NavManager.NavigateTo("/cms/article/0");
                }
            }
        }

        private async Task SaveAsync()
        {
            if (!article.Blocks.Any())
            {
                _message.Error("Минимальное количество абзацев: 1");
                return;
            }

            if (!article.Blocks.Any(x => x.Image != null))
            {
                _message.Error("Минимальное количество картинок для статьи: 1");
                return;
            }

            try
            {
                using TeacherContext context = DbFactory.CreateDbContext();
                var selectedArcticle = context.Articles.Include(b => b.Blocks).FirstOrDefault(x => x.Id == Id);

                if (selectedArcticle != null)
                {
                    selectedArcticle.Name = article.Name;
                    selectedArcticle.Description = article.Description;
                    selectedArcticle.Date = article.Date;

                    var delBlocks = selectedArcticle.Blocks.Where(b => !article.Blocks.Any(x => x.Id == b.Id));

                    var newBlocks = article.Blocks.Where(b => !selectedArcticle.Blocks.Any(x => x.Id == b.Id));

                    var updBlocks = selectedArcticle.Blocks.Where(b => article.Blocks.Any(x => x.Id == b.Id))
                        .Select(db => new { Source = article.Blocks.FirstOrDefault(x => x.Id == db.Id), Target = db });

                    context.ArticleBlocks.RemoveRange(delBlocks);
                    await context.ArticleBlocks.AddRangeAsync(newBlocks);
                    updBlocks.ForEach(x =>
                    {
                        x.Target.Title = x.Source.Title;
                        x.Target.Image = x.Source.Image;
                        x.Target.Text = x.Source.Text;
                        x.Target.Video = x.Source.Video;
                        x.Target.ArticleId = x.Source.ArticleId;
                    });

                    await context.SaveChangesAsync();
                    _message.Success("Статья сохранена!");
                }
                else
                {
                    article.Date = DateTime.Now;
                    context.Articles.Add(article);
                    await context.SaveChangesAsync();
                    _message.Success("Статья добавлена!");
                }
                NavManager.NavigateTo($"/cms/article/{article.Id}");
            }
            catch (Exception ex)
            {
                _message.Error(ex.Message, 60);
                _message.Error(ex.InnerException?.Message, 60);
                _message.Error("Во время сохранения статьи произошла ошибка", 60);
            }
        }

        private void DeleteArcticle()
        {
            using TeacherContext context = DbFactory.CreateDbContext();
            context.Articles.Remove(article);
            context.SaveChanges();
            NavManager.NavigateTo($"/articles");
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService _message { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<TeacherContext> DbFactory { get; set; }
    }
}
namespace __Blazor.WoodsOak.Pages.CMS.Arcticles.ArticleEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInput_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInput_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInput_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
