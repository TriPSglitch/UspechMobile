using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            this.BindingContext = new RegistrationPageViewModel();
        }
    }
}