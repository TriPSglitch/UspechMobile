using Xamarin.Forms;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            InitializeComponent();
            this.BindingContext = new AuthorizationPageViewModel();
        }
    }
}