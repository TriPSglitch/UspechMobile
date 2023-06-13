using Xamarin.Forms;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    public partial class TestForStudentPage : ContentPage
    {
        public TestForStudentPage()
        {
            InitializeComponent();
            this.BindingContext = new TestForStudentPageViewModel();
        }
    }
}