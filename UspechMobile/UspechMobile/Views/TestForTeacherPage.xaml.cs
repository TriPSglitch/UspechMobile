using UspechMobile.ViewModels;
using Xamarin.Forms;

namespace UspechMobile.Views
{
    public partial class TestForTeacherPage : ContentPage
    {
        public TestForTeacherPage()
        {
            InitializeComponent();
            this.BindingContext = new TestForTeacherPageViewModel();
        }
    }
}