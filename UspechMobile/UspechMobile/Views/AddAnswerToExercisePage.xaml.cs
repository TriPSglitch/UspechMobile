using UspechMobile.ViewModels;
using Xamarin.Forms;

namespace UspechMobile.Views
{
    public partial class AddAnswerToExercisePage : ContentPage
    {
        public AddAnswerToExercisePage()
        {
            InitializeComponent();
            this.BindingContext = new AddAnswerToExercisePageViewModel();
        }
    }
}