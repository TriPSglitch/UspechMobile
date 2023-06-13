using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class AccountPageModel : IAccountPageModel
    {
        private Persons person;

        public Persons Person { get => person; set => person = value; }

        public void Edit()
        {
            // Логика добавления файла
        }

        public void Logout()
        {
            // Логика сохранения ответа
        }

        public void GoBack()
        {
            // Логика возврата к предыдущему окну
        }
    }
}