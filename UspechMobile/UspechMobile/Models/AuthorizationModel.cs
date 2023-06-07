using System;
using UspechMobile.DBModels;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;

namespace UspechMobile.Models
{
    internal class AuthorizationModel : IAuthorizationModel
    {
        private string login;
        private string password;

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public async void Authorize()
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Пустые поля", "OK");
                return;
            }
            List<Users> usersList = await App.Connection.db.Table<Users>().ToListAsync();
            if (usersList.Select(item => item.Login + " " + item.Password).Contains(Login + " " + Encrypt.Hash(Password)))
            {
                Users user = await App.Connection.db.Table<Users>().Where(users => users.Login == Login).FirstOrDefaultAsync();

                User.IDRole = user.IDRole;
                User.IDUser = user.ID;
                return;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Неверно введены логин/пароль", "OK");
                return;
            }
        }

        public void Registration()
        {
            throw new NotImplementedException();
        }
    }
}