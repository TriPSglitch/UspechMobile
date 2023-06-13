using UspechMobile.ViewModels;
using Xamarin.Forms;

namespace UspechMobile.Views
{
    public partial class AnswersQuestionPage : ContentPage
    {
        public AnswersQuestionPage()
        {
            InitializeComponent();
            this.BindingContext = new AnswersQuestionPageViewModel();
        }
    }
}