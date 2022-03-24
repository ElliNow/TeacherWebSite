using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherWebSiteApp.Page.CMS.MainPage
{
    public partial class MainPage
    {
        string[] validationMessages = new string[] { };

        private bool Validate()
        {
            var messages = new List<string>();
            if (string.IsNullOrEmpty(selectedProfile.Name)) messages.Add(@"'Название профиля' должно быть заполнено");
            else if (selectedProfile.Name.Length > 50) messages.Add(@"'Название' должно быть не более 50 символов.");

            if (selectedProfile.IsBannerEnabled)
            {
                if (selectedProfile.BigPictureTitle != null && selectedProfile.BigPictureTitle.Length > 100) messages.Add(@"'В заголовке' должно быть не более 100 символов.");
                if (selectedProfile.BigPictureTitle != null && selectedProfile.BigPictureText.Length > 500) messages.Add(@"'Описание' должно быть не более 500 символов.");
                if (selectedProfile.BigPictureData == null) messages.Add(@"Необходимо загрузить изображение баннера");
            }

            if (selectedProfile.IsCardsEnabled)
            {
                if (selectedProfile.Block1Title == null) messages.Add(@"'Заголовок' (карточка 1) должно быть заполнено");
                else if (selectedProfile.Block1Title.Length > 100) messages.Add(@"'Заголовок' (карточка 1) должно быть не более 100 символов.");
                if (selectedProfile.Block1Text == null) messages.Add(@"'Описание' (карточка 1) должно быть заполнено");
                else if (selectedProfile.Block1Text.Length > 500) messages.Add(@"'Описание' (карточка 1) должно быть не более 500 символов.");
                if (selectedProfile.Block1Data == null) messages.Add(@"Необходимо загрузить изображение карточки 1");
                if (selectedProfile.Link1Text != null && selectedProfile.Link1Sourse == null) messages.Add(@"Необходимо ввести ссылку (карточка 1)");
                if (selectedProfile.Link1Text == null && selectedProfile.Link1Sourse != null) messages.Add(@"Необходимо ввести текст кнопки (карточка 1)");

                if (selectedProfile.Block2Title == null) messages.Add(@"'Заголовок' (карточка 2) должно быть заполнено");
                else if (selectedProfile.Block2Title.Length > 100) messages.Add(@"'Заголовок' (карточка 2) должно быть не более 100 символов.");
                if (selectedProfile.Block2Text == null) messages.Add(@"'Описание' (карточка 2) должно быть заполнено");
                else if (selectedProfile.Block2Text.Length > 500) messages.Add(@"'Описание' (карточка 2) должно быть не более 500 символов.");
                if (selectedProfile.Block2Data == null) messages.Add(@"Необходимо загрузить изображение карточки 2");
                if (selectedProfile.Link2Text != null && selectedProfile.Link2Sourse == null) messages.Add(@"Необходимо ввести ссылку (карточка 2)");
                if (selectedProfile.Link2Text == null && selectedProfile.Link2Sourse != null) messages.Add(@"Необходимо ввести текст кнопки (карточка 2)");

                if (selectedProfile.Block3Title == null) messages.Add(@"'Заголовок' (карточка 3) должно быть заполнено");
                else if (selectedProfile.Block3Title.Length > 100) messages.Add(@"'Заголовок' (карточка 3) должно быть не более 100 символов.");
                if (selectedProfile.Block3Text == null) messages.Add(@"'Описание' (карточка 3) должно быть заполнено");
                else if (selectedProfile.Block3Text.Length > 500) messages.Add(@"'Описание' (карточка 3) должно быть не более 500 символов.");
                if (selectedProfile.Block3Data == null) messages.Add(@"Необходимо загрузить изображение карточки 3");
                if (selectedProfile.Link3Text != null && selectedProfile.Link3Sourse == null) messages.Add(@"Необходимо ввести ссылку (карточка 3)");
                if (selectedProfile.Link3Text == null && selectedProfile.Link3Sourse != null) messages.Add(@"Необходимо текст кнопки (карточка 3)");
            }

            validationMessages = messages.ToArray();
            return !validationMessages.Any();
        }
    }
}
