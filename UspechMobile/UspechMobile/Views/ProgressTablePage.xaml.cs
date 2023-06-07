using Xamarin.Forms;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    public partial class ProgressTablePage : ContentPage
    {
        public ProgressTablePage()
        {
            InitializeComponent();
            this.BindingContext = new ProgressTablePageViewModel();
        }
    }
}