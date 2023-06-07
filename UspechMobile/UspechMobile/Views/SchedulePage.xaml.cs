using Xamarin.Forms;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    public partial class SchedulePage : ContentPage
    {
        public SchedulePage()
        {
            InitializeComponent();
            this.BindingContext = new SchedulePageViewModel();
        }
    }
}