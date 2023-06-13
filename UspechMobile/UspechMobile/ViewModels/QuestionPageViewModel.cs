using System.Windows.Input;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class QuestionPageViewModel : BaseViewModel
    {
        private IQuestionPageModel QuestionPageModel;

        public ICommand PreviousQuestionCommand { get; }
        public ICommand NextQuestionCommand { get; }

        public string Text
        {
            get
            {
                return QuestionPageModel.Text;
            }
            set
            {
                QuestionPageModel.Text = value;
                NotifyPropertyChanged(nameof(Text));
            }
        }

        public string AnswerText
        {
            get
            {
                return QuestionPageModel.AnswerText;
            }
            set
            {
                QuestionPageModel.AnswerText = value;
                NotifyPropertyChanged(nameof(AnswerText));
            }
        }

        public QuestionPageViewModel()
        {
            QuestionPageModel = new QuestionPageModel();

            PreviousQuestionCommand = new Command(PreviousQuestion);
            NextQuestionCommand = new Command(NextQuestion);
        }

        private void PreviousQuestion()
        {
            QuestionPageModel.PreviousQuestion();
        }

        private void NextQuestion()
        {
            QuestionPageModel.NextQuestion();
        }
    }
}