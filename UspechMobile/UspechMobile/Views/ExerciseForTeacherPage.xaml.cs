using Xamarin.Forms;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    public partial class ExerciseForTeacherPage : ContentPage
    {
        public ExerciseForTeacherPage()
        {
            InitializeComponent();
            this.BindingContext = new ExerciseForStudentPageViewModel();
        }
    }
}