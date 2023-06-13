using System.Windows.Input;
using UspechMobile.DBModels;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class AccountPageViewModel : BaseViewModel
    {
        private IAccountPageModel AccountPageModel;

        public ICommand EditCommand { get; private set; }
        public ICommand LogoutCommand { get; private set; }
        public ICommand GoBackCommand { get; private set; }

        public Persons Person
        {
            get => AccountPageModel.Person;
            set
            {
                AccountPageModel.Person = value;
                NotifyPropertyChanged(nameof(Person));
            }
        }

        public AccountPageViewModel()
        {
            EditCommand = new Command(Edit);
            LogoutCommand = new Command(Logout);
            GoBackCommand = new Command(GoBack);

            AccountPageModel = new AccountPageModel();
        }

        private void Edit()
        {
            AccountPageModel.Edit();
        }

        private void Logout()
        {
            AccountPageModel.Logout();
        }

        private void GoBack()
        {
            AccountPageModel.GoBack();
        }
    }
}