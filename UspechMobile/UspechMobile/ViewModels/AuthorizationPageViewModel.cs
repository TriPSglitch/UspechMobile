using System.Windows.Input;
using Xamarin.Forms;
using UspechMobile.Models;

namespace UspechMobile.ViewModels
{
    internal class AuthorizationPageViewModel : BaseViewModel
    {
        public IAuthorizationModel AuthorizationModel;
        public ICommand AuthorizeCommand { get; private set; }
        public ICommand RegistrationCommand { get; private set; }

        public string Login
        {
            get
            {
                return AuthorizationModel.Login;
            }
            set
            {
                AuthorizationModel.Login = value;
                NotifyPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get
            {
                return AuthorizationModel.Password;
            }
            set
            {
                AuthorizationModel.Password = value;
                NotifyPropertyChanged(nameof(Password));
            }
        }

        public AuthorizationPageViewModel()
        {
            AuthorizeCommand = new Command(OnAuthorizeClick);
            RegistrationCommand = new Command(OnRegistrationClick);

            AuthorizationModel = new AuthorizationModel();
        }

        public void OnAuthorizeClick()
        {
            AuthorizationModel.Authorize();
        }

        public void OnRegistrationClick()
        {
            AuthorizationModel.Registration();
        }
    }
}
