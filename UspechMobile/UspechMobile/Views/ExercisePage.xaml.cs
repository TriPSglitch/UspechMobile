using Xamarin.Forms;
using UspechMobile.ViewModels;

namespace UspechMobile.Views
{
    public partial class ExercisePage : ContentPage
    {
        public ExercisePage()
        {
            InitializeComponent();
            this.BindingContext = new ExercisePageViewModel();
        }
    }
}