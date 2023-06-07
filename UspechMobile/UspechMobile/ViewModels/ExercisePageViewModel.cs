using System.Collections.ObjectModel;
using System.Windows.Input;
using UspechMobile.DBModels;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class ExercisePageViewModel : BaseViewModel
    {
        private IExercisePageModel ExercisePageModel;

        public ICommand DownloadFileCommand { get; }
        public ICommand AddAnswerCommand { get; }
        public ICommand EditAnswerCommand { get; }
        public ICommand GoBackCommand { get; }

        public string Title
        {
            get
            {
                return ExercisePageModel.Title;
            }
            set
            {
                ExercisePageModel.Title = value;
                NotifyPropertyChanged(nameof(Title));
            }
        }

        public string Description
        {
            get
            {
                return ExercisePageModel.Description;
            }
            set
            {
                ExercisePageModel.Description = value;
                NotifyPropertyChanged(nameof(Description));
            }
        }

        public ObservableCollection<ExerciseFiles> Files
        {
            get
            {
                return ExercisePageModel.Files;
            }
            set
            {
                ExercisePageModel.Files = value;
                NotifyPropertyChanged(nameof(Files));
            }
        }

        public string Answer
        {
            get
            {
                return ExercisePageModel.Answer;
            }
            set
            {
                ExercisePageModel.Answer = value;
                NotifyPropertyChanged(nameof(Answer));
            }
        }

        public int Grade
        {
            get
            {
                return ExercisePageModel.Grade;
            }
            set
            {
                ExercisePageModel.Grade = value;
                NotifyPropertyChanged(nameof(Grade));
            }
        }

        public string Comments
        {
            get
            {
                return ExercisePageModel.Comments;
            }
            set
            {
                ExercisePageModel.Comments = value;
                NotifyPropertyChanged(nameof(Comments));
            }
        }

        public ExercisePageViewModel()
        {
            ExercisePageModel = new ExercisePageModel();

            // Инициализация команд
            DownloadFileCommand = new Command<string>(DownloadFile);
            AddAnswerCommand = new Command(AddAnswer);
            EditAnswerCommand = new Command(EditAnswer);
            GoBackCommand = new Command(GoBack);
        }

        private void DownloadFile(string IDFile)
        {
            ExercisePageModel.DownloadFile(IDFile);
        }

        private void AddAnswer()
        {
            ExercisePageModel.AddAnswer();
        }

        private void EditAnswer()
        {
            ExercisePageModel.EditAnswer();
        }

        private void GoBack()
        {
            ExercisePageModel.GoBack();
        }
    }
}
