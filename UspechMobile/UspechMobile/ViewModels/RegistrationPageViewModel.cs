using System.Windows.Input;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class RegistrationPageViewModel : BaseViewModel
    {
        public IRegistrationModel RegistrationModel;
        public ICommand RegistrationCommand { get; private set; }
        public ICommand BackCommand { get; private set; }

        public string Lastname
        {
            get
            {
                return RegistrationModel.Lastname;
            }
            set
            {
                RegistrationModel.Lastname = value;
                NotifyPropertyChanged(nameof(Lastname));
            }
        }

        public string Firstname
        {
            get
            {
                return RegistrationModel.Firstname;
            }
            set
            {
                RegistrationModel.Firstname = value;
                NotifyPropertyChanged(nameof(Firstname));
            }
        }
        public string Middlename
        {
            get
            {
                return RegistrationModel.Middlename;
            }
            set
            {
                RegistrationModel.Middlename = value;
                NotifyPropertyChanged(nameof(Middlename));
            }
        }

        public string PhoneNumber
        {
            get
            {
                return RegistrationModel.PhoneNumber;
            }
            set
            {
                RegistrationModel.PhoneNumber = value;
                NotifyPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string Email
        {
            get
            {
                return RegistrationModel.Email;
            }
            set
            {
                RegistrationModel.Email = value;
                NotifyPropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get
            {
                return RegistrationModel.Password;
            }
            set
            {
                RegistrationModel.Password = value;
                NotifyPropertyChanged(nameof(Password));
            }
        }

        public string Login
        {
            get
            {
                return RegistrationModel.Login;
            }
            set
            {
                RegistrationModel.Login = value;
                NotifyPropertyChanged(nameof(Login));
            }
        }

        public RegistrationPageViewModel()
        {
            RegistrationCommand = new Command(OnRegistrationClick);
            BackCommand = new Command(OnBackClick);

            RegistrationModel = new RegistrationModel();
        }

        public void OnRegistrationClick()
        {
            RegistrationModel.Registration();
        }

        public void OnBackClick()
        {
            RegistrationModel.Back();
        }
    }
}