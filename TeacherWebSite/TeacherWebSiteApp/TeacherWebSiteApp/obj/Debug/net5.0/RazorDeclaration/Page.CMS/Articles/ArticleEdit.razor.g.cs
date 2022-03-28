// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
