#pragma checksum "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2cd3da0399a80ce08c36ee828bfde2a4d3217b2"
// <auto-generated/>
#pragma warning disable 1591
namespace TeacherWebSiteApp.Components
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
    public partial class Publication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-bottom: 25px");
            __builder.AddAttribute(2, "b-di6ixeogsq");
            __builder.OpenComponent<AntDesign.Collapse>(3);
            __builder.AddAttribute(4, "DefaultActiveKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 4 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                                  new[]{"1"}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String[]>(this, 
#nullable restore
#line 4 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                                                         Callback

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Panel>(7);
                __builder2.AddAttribute(8, "Header", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                        Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Key", "1");
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "style", "position: center");
                    __builder3.AddAttribute(13, "b-di6ixeogsq");
                    __builder3.OpenComponent<AntDesign.Row>(14);
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Col>(16);
                        __builder4.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(18, "img");
                            __builder5.AddAttribute(19, "src", 
#nullable restore
#line 9 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                                   Path

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddAttribute(20, "b-di6ixeogsq");
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(21, "\r\n                    ");
                        __builder4.OpenComponent<AntDesign.Col>(22);
                        __builder4.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Card>(24);
                            __builder5.AddAttribute(25, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                                      Name

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(26, "Style", "width: 500px");
                            __builder5.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(28, "p");
                                __builder6.AddAttribute(29, "style", "margin-bottom: 10px; padding-left: 10px");
                                __builder6.AddAttribute(30, "b-di6ixeogsq");
                                __builder6.AddContent(31, 
#nullable restore
#line 13 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                                                                                Text

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(32, "\r\n                            ");
                                __builder6.OpenElement(33, "p");
                                __builder6.AddAttribute(34, "style", "padding-left: 10px");
                                __builder6.AddAttribute(35, "b-di6ixeogsq");
                                __builder6.AddMarkupContent(36, "Опубликовано ");
                                __builder6.AddContent(37, 
#nullable restore
#line 14 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                                                                        Data.ToString("dd.MM.yyyy")

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
#nullable restore
#line 15 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                             foreach (var attachment in attachments)
                            {

#line default
#line hidden
#nullable disable
                                __builder6.OpenElement(38, "a");
                                __builder6.AddAttribute(39, "href", 
#nullable restore
#line 17 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                                          attachment.Link

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddAttribute(40, "b-di6ixeogsq");
                                __builder6.OpenComponent<AntDesign.CardGrid>(41);
                                __builder6.AddAttribute(42, "Style", "width:50%;text-align:center");
                                __builder6.AddAttribute(43, "Hoverable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenElement(45, "div");
                                    __builder7.AddAttribute(46, "class", "hiddenBlock");
                                    __builder7.AddAttribute(47, "b-di6ixeogsq");
                                    __builder7.OpenElement(48, "h4");
                                    __builder7.AddAttribute(49, "style", "color: cornflowerblue");
                                    __builder7.AddAttribute(50, "b-di6ixeogsq");
                                    __builder7.AddContent(51, 
#nullable restore
#line 20 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                                                                               attachment.Name

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.CloseElement();
                                    __builder7.CloseElement();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.CloseElement();
#nullable restore
#line 25 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
                            }

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
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
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Components\Publication.razor"
        
     [Parameter]
     public int Id { get; set; }
     [Parameter]
     public string Name { get; set; }
     [Parameter]
     public string Text { get; set; }
     [Parameter]
     public DateTime Data { get; set; }
     [Parameter]
     public string Path { get; set; }

     List<TeacherWebSiteApp.Data.Models.Attachment> attachments = new List<TeacherWebSiteApp.Data.Models.Attachment>();

     protected override async Task OnInitializedAsync()
     {
         var context = Context.CreateDbContext();
         attachments = await context.Attachments.Where(a => a.PublicationId == Id).ToListAsync();
     }

     void Callback(string[] keys)
     {
         Console.WriteLine(string.Join(',', keys));
     }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<TeacherContext> Context { get; set; }
    }
}
#pragma warning restore 1591
