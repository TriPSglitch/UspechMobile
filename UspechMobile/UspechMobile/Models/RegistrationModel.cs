using System;
using UspechMobile.DBModels;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace UspechMobile.Models
{
    internal class RegistrationModel : IRegistrationModel
    {
        private string lastname;
        private string firstname;
        private string middlename;
        private string phoneNumber;
        private string email;
        private string password;
        private string login;

        public string Lastname { get => lastname; set => lastname = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Middlename { get => middlename; set => middlename = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Login { get => login; set => login = value; }

        public void Back()
        {
            throw new NotImplementedException();
        }

        public async void Registration()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Lastname) || string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(PhoneNumber))
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Пустые поля", "OK");
                return;
            }
            List<Users> usersList = await App.Connection.db.Table<Users>().ToListAsync();
            if (usersList.Select(item => item.Login).Contains(Login))
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Пользователь с таким логином уже существует", "OK");
                return;
            }
            if (!IsValidEmail(Email))
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Неверный формат почты", "OK");
                return;
            }
            if (!IsValidPhone(PhoneNumber))
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Неверный формат номера телефона", "OK");
                return;
            }
            if (!IsValidFIO(Lastname + " " + Firstname + " " + Middlename))
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Неверный формат ФИО", "OK");
                return;
            }
            if (!IsValidPassword(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Неверный формат пароля", "OK");
                return;
            }
            if (!IsValidLogin(Login))
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Неверный форамт логина", "OK");
                return;
            }

            Persons person = new Persons()
            {
                Lastname = Lastname,
                Firstname = Firstname,
                Email = Email,
                Phone = PhoneNumber
            };
            if (!string.IsNullOrEmpty(Middlename))
            {
                person.Middlename = Middlename;
            }

            Users user = new Users()
            {
                Login = Login,
                Password = Encrypt.Hash(Password),
                IDRole = 2,
                IDPerson = person.ID
            };

            person.User = user;

            await App.Connection.db.InsertAsync(person);
            await App.Connection.db.InsertAsync(user);

            return;
        }

        private bool IsValidEmail(string email)
        {
            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(email, regex))
                return true;
            else
                return false;
        }

        private bool IsValidPhone(string phone)
        {
            string regex = @"^((\+7|7|8)+([0-9]){10})$";
            if (Regex.IsMatch(phone, regex))
                return true;
            else
                return false;
        }

        private bool IsValidFIO(string fio)
        {
            string regex = @"^([А-ЯЁ][а-яё]+)(-[А-ЯЁ][а-яё]+)?\s+([А-ЯЁ][а-яё]+)(-[А-ЯЁ][а-яё]+)?$";
            if (Regex.IsMatch(fio, regex))
                return true;
            else
                return false;
        }

        private bool IsValidPassword(string password)
        {
            string regex = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$";
            if (Regex.IsMatch(password, regex))
                return true;
            else
                return false;
        }

        private bool IsValidLogin(string login)
        {
            string regex = @"^[A-Za-z0-9][A-Za-z0-9_-]{2,15}$";
            if (Regex.IsMatch(login, regex))
                return true;
            else
                return false;
        }
    }
}