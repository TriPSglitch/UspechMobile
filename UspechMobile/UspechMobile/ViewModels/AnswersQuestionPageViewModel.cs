using System.Collections.ObjectModel;
using System.Windows.Input;
using UspechMobile.DBModels;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class AnswersQuestionPageViewModel: BaseViewModel
    {
        private IAnswersQuestionPageModel AnswersQuestionPageModel;
        public ICommand BackCommand { get; }

        public string FIO
        {
            get => AnswersQuestionPageModel.FIO;
            set
            {
                AnswersQuestionPageModel.FIO = value;
                NotifyPropertyChanged(nameof(FIO));
            }
        }

        public ObservableCollection<AnswersQuestion> Answers
        {
            get => AnswersQuestionPageModel.Answers;
            set
            {
                AnswersQuestionPageModel.Answers = value;
                NotifyPropertyChanged(nameof(Answers));
            }
        }

        public AnswersQuestionPageViewModel()
        {
            AnswersQuestionPageModel = new AnswersQuestionPageModel();

            BackCommand = new Command(GoBack);
        }

        private void GoBack()
        {
            AnswersQuestionPageModel.GoBack();
        }
    }
}