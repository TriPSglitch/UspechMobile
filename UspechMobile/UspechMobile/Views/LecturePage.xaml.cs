using Xamarin.Forms;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    public partial class LecturePage : ContentPage
    {
        public LecturePage()
        {
            InitializeComponent();
            this.BindingContext = new LecturePageViewModel();
        }
    }
}