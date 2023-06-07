using Xamarin.Forms;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    public partial class MyCoursesPage : ContentPage
    {
        public MyCoursesPage()
        {
            InitializeComponent();
            this.BindingContext = new MyCoursesPageViewModel();
        }
    }
}