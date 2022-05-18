using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherWebSiteApp.Components;
using TeacherWebSiteApp.Data;
using TeacherWebSiteApp.Data.Models;
using AntDesign;



namespace TeacherWebSiteApp.Page.CMS.Publications
{
    public partial class PublicationEdit
    {
        private bool ValidationPublication()
        {
            var messages = new List<string>();

            if (string.IsNullOrEmpty(publication.Name)) messages.Add(@"'Название' не должно быть пусто.");
            else if (publication.Name.Length > 50) messages.Add(@"'Название' не должно превышать длину 50 символов.");
            if (string.IsNullOrEmpty(publication.Text)) messages.Add(@"'Описание' не должно быть пусто.");
            else if (publication.Text.Length > 200) messages.Add(@"'Описание' не должно превышать длину 200 символов.");
            if (!publication.Attachments.Any()) messages.Add(@"Публикация должна содержать минимум 1 вложение.");

            validationMessages = messages.ToArray();
            return !validationMessages.Any();
        }

        private bool ValidateAttachment()
        {
            var messages = new List<string>();

            if (string.IsNullOrEmpty(attachment.Name)) messages.Add(@"'Название' не должно быть пусто.");
            else if (attachment.Name.Length > 50) messages.Add(@"'Название не должно превышать длину в 50 символов.'");
            if (string.IsNullOrEmpty(attachment.Link)) messages.Add(@"'Ссылка' не должно быть пусто.");
            if (attachment.ContentType <= 0) messages.Add(@"Необходимо выбрать тип вложения");

            validationMessages = messages.ToArray();
            return !validationMessages.Any();
        }


        // установление типа вложения
        private void GetStatus(int contentType)
        {
            attachment.ContentType = (ContentType)contentType;
        }


        protected override async Task OnInitializedAsync()
        {
            if (Id != 0)
            {
                using TeacherContext context = DbFactory.CreateDbContext();
                publication = await context.Publications.Include(a => a.Attachments).FirstOrDefaultAsync(p => p.Id == Id);
                attachments = context.Attachments.Where(item => item.PublicationId == Id).ToList();
                if (publication == null)
                {
                    _message.Error("Публикация не найдена!");
                    NavManager.NavigateTo("/cms/publication/0");
                }
            }
        }

        // Сохранение
        private async Task SaveAsync()
        {
            if (!publication.Attachments.Any())
            {
                _message.Error("Публикация должна содержать хотя бы одно вложение!");
            }

            try
            {
                using TeacherContext context = DbFactory.CreateDbContext();
                var selectedPublication = await context.Publications.Include(a => a.Attachments).FirstOrDefaultAsync(p => p.Id == Id);

                if (selectedPublication != null)
                {
                    selectedPublication.Id = publication.Id;
                    selectedPublication.Name = publication.Name;
                    selectedPublication.Text = publication.Text;
                    selectedPublication.Attachments = publication.Attachments;
                    selectedPublication.Date = publication.Date;

                    var delAttachments = selectedPublication.Attachments.Where(b => !publication.Attachments.Any(x => x.Id == b.Id));

                    var newAttachments = publication.Attachments.Where(b => !selectedPublication.Attachments.Any(x => x.Id == b.Id));

                    var updBlocks = selectedPublication.Attachments.Where(b => publication.Attachments.Any(x => x.Id == b.Id))
                    .Select(db => new { Source = publication.Attachments.FirstOrDefault(x => x.Id == db.Id), Target = db });

                    context.Attachments.RemoveRange(delAttachments);
                    await context.Attachments.AddRangeAsync(newAttachments);
                    updBlocks.ForEach(x =>
                    {
                        x.Target.Id = x.Source.Id;
                        x.Target.Name = x.Source.Name;
                        x.Target.Link = x.Source.Link;
                        x.Target.PublicationId = x.Source.PublicationId;
                        x.Target.ContentType = x.Source.ContentType;
                    });
                    await context.SaveChangesAsync();
                    _message.Success("Публикация сохранена!");
              
                }
                else
                {
                    publication.Date = DateTime.Now;
                    publication.IsActive = false;
                    var attach = publication.Attachments.FirstOrDefault(a => a.Link == null && a.Name == null && a.ContentType <= 0);
                    publication.Attachments.Remove(attach);
                    context.Publications.Add(publication);
                    await context.SaveChangesAsync();
                    _message.Success("Публикация добавлена!");
                }
                NavManager.NavigateTo($"/cms/publication/{publication.Id}");
            }
            catch (Exception ex)
            {
                validationMessages = new string[] { ex.Message, ex.InnerException?.Message };
                ValidationPublication();
            }
            
           
        }

        // Добавление вложения
        private void AddAttachment()
        {
            bool flag = ValidateAttachment();
            if(flag == true)
            {
                using TeacherContext context = DbFactory.CreateDbContext();
                if (attachment!=null)
                {
                    publication.Attachments.Add(attachment);
                    attachments.Add(attachment);
                    attachment = new();
                    context.SaveChanges();
                    _message.Success("Вложение успешно добавлено!");
                }    
            }    
        }


        // Удаление вложения
        private void DeleteAttachment(string name, string link)
        {
            using TeacherContext context = DbFactory.CreateDbContext();
            var selectedAttachment = publication.Attachments.FirstOrDefault(x => x.Name == name && x.Link == link);
            publication.Attachments.Remove(selectedAttachment);
            attachments.Remove(selectedAttachment);
            context.SaveChanges();
            _message.Success("Вложение успешно удалено!");
        }


        // Удаление публикации
        private void DeletePublication()
        {
            using TeacherContext context = DbFactory.CreateDbContext();
            context.Publications.Remove(publication);
            context.SaveChanges();
            NavManager.NavigateTo($"/cms/publications");
        }
    }
}
