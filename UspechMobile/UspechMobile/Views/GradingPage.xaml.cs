using Xamarin.Forms;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    public partial class GradingPage : ContentPage
    {
        public GradingPage()
        {
            InitializeComponent();
            this.BindingContext = new GradingPageViewModel();
        }
    }
}