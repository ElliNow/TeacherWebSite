// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TeacherWebSiteApp.Page.CMS.MainPage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/CMS/MainPage")]
    public partial class MainPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 204 "C:\Users\Эля\Documents\GitHub\TeacherWebSite\TeacherWebSite\TeacherWebSiteApp\TeacherWebSiteApp\Page.CMS\MainPage\MainPage.razor"
       

    Data.PageModels.MainPage selectedProfile = null;
    List<Data.PageModels.MainPage> profiles = new List<Data.PageModels.MainPage>();

    protected override void OnInitialized()
    {
        using (TeacherContext context = DbFactory.CreateDbContext())
        {
            profiles = context.MainPages.ToList();
        }
    }

    private void AddProfile()
    {
        selectedProfile = new();
    }

    private void DeleteProfile()
    {
        using (TeacherContext context = DbFactory.CreateDbContext())
        {
            var profile = context.MainPages.FirstOrDefault(x => x.Id == selectedProfile.Id);
            context.MainPages.Remove(profile);
            selectedProfile = null;
            context.SaveChanges();
            NavManager.NavigateTo("/CMS/MainPage", true);
        }
    }

    private void SelectProfile(int id)
    {
        using (TeacherContext context = DbFactory.CreateDbContext())
        {
            profiles = context.MainPages.ToList();
        }
        selectedProfile = profiles.FirstOrDefault(profile => profile.Id == id);
    }

    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        var maxAllowedFiles = 10;
        var format = "image/jpg";

        foreach (var imageFile in e.GetMultipleFiles(maxAllowedFiles))
        {
            var resizedImageFile = await imageFile.RequestImageFileAsync(format,
                3000, 3000);
            var buffer = new byte[resizedImageFile.Size];
            await resizedImageFile.OpenReadStream(5000000).ReadAsync(buffer);

        }
    }

    private async Task SaveAsync()
    {
        if (Validate() == false) return;
        try
        {
            using (TeacherContext context = DbFactory.CreateDbContext())
            {
                if (selectedProfile.IsActive.HasValue && selectedProfile.IsActive.Value)
                {
                    var activeProfiles = context.MainPages.Where(x => x.IsActive.Value && x.Id != selectedProfile.Id).ToList();

                    foreach (var profile in activeProfiles)
                    {
                        profile.IsActive = false;
                    }
                }

                //добавление профиля
                if (selectedProfile.Id == 0)
                {
                    context.MainPages.Add(selectedProfile);
                }
                //редактирование профиля
                else if (selectedProfile.Id > 0)
                {
                    var profile = await context.MainPages.FirstOrDefaultAsync(x => x.Id == selectedProfile.Id);

                    if (profile == null)
                    {
                        return;
                    }

                    CopyTo(selectedProfile, profile);
                }
                context.SaveChanges();
                NavManager.NavigateTo("/CMS/MainPage", true);
                selectedProfile = null;
            }
        }
        catch (Exception ex)
        {
            validationMessages = new string[]
            {
                ex.Message,
                ex.InnerException?.Message
                };
        }
    }

    public void CopyTo(Data.PageModels.MainPage source, Data.PageModels.MainPage target)
    {
        target.IsActive = source.IsActive;

        target.Name = source.Name;

        target.IsBannerEnabled = source.IsBannerEnabled;
        target.IsCardsEnabled = source.IsCardsEnabled;

        target.BigPictureTitle = source.BigPictureTitle;
        target.BigPictureText = source.BigPictureText;
        target.BigPictureData = source.BigPictureData;

        target.Block1Title = source.Block1Title;
        target.Block1Text = source.Block1Text;
        target.Block1Data = source.Block1Data;
        target.Link1Text = source.Link1Text;
        target.Link1Sourse = source.Link1Sourse;

        target.Block2Title = source.Block2Title;
        target.Block2Text = source.Block2Text;
        target.Block2Data = source.Block2Data;
        target.Link2Text = source.Link2Text;
        target.Link2Sourse = source.Link2Sourse;

        target.Block3Title = source.Block3Title;
        target.Block3Text = source.Block3Text;
        target.Block3Data = source.Block3Data;
        target.Link3Text = source.Link3Text;
        target.Link3Sourse = source.Link3Sourse;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<TeacherContext> DbFactory { get; set; }
    }
}
#pragma warning restore 1591