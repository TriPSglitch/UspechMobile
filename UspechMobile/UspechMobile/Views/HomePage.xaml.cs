using Xamarin.Forms;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = new HomePageViewModel();
        }
    }
}