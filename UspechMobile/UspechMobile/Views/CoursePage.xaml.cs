using Xamarin.Forms;
using UspechMobile.ViewModels;
using UspechMobile.DBModels;

namespace UspechMobile.Views
{
    public partial class CoursePage : ContentPage
    {
        public CoursePage(Courses course)
        {
            InitializeComponent();
            this.BindingContext = new CoursePageViewModel(course);
        }
    }
}