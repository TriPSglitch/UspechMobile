using System.Collections.ObjectModel;
using System.Windows.Input;
using UspechMobile.DBModels;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class ExerciseForStudentPageViewModel : BaseViewModel
    {
        private IExerciseForStudentPageModel ExerciseForStudentPageModel;

        public ICommand DownloadFileCommand { get; }
        public ICommand AddAnswerCommand { get; }
        public ICommand EditAnswerCommand { get; }
        public ICommand GoBackCommand { get; }

        public string Title
        {
            get
            {
                return ExerciseForStudentPageModel.Title;
            }
            set
            {
                ExerciseForStudentPageModel.Title = value;
                NotifyPropertyChanged(nameof(Title));
            }
        }

        public string Description
        {
            get
            {
                return ExerciseForStudentPageModel.Description;
            }
            set
            {
                ExerciseForStudentPageModel.Description = value;
                NotifyPropertyChanged(nameof(Description));
            }
        }

        public ObservableCollection<ExerciseFiles> Files
        {
            get
            {
                return ExerciseForStudentPageModel.Files;
            }
            set
            {
                ExerciseForStudentPageModel.Files = value;
                NotifyPropertyChanged(nameof(Files));
            }
        }

        public string Answer
        {
            get
            {
                return ExerciseForStudentPageModel.Answer;
            }
            set
            {
                ExerciseForStudentPageModel.Answer = value;
                NotifyPropertyChanged(nameof(Answer));
            }
        }

        public int Grade
        {
            get
            {
                return ExerciseForStudentPageModel.Grade;
            }
            set
            {
                ExerciseForStudentPageModel.Grade = value;
                NotifyPropertyChanged(nameof(Grade));
            }
        }

        public string Comments
        {
            get
            {
                return ExerciseForStudentPageModel.Comments;
            }
            set
            {
                ExerciseForStudentPageModel.Comments = value;
                NotifyPropertyChanged(nameof(Comments));
            }
        }

        public ExerciseForStudentPageViewModel()
        {
            ExerciseForStudentPageModel = new ExerciseForStudentPageModel();

            DownloadFileCommand = new Command<string>(DownloadFile);
            AddAnswerCommand = new Command(AddAnswer);
            EditAnswerCommand = new Command(EditAnswer);
            GoBackCommand = new Command(GoBack);
        }

        private void DownloadFile(string ID)
        {
            ExerciseForStudentPageModel.DownloadFile(ID);
        }

        private void AddAnswer()
        {
            ExerciseForStudentPageModel.AddAnswer();
        }

        private void EditAnswer()
        {
            ExerciseForStudentPageModel.EditAnswer();
        }

        private void GoBack()
        {
            ExerciseForStudentPageModel.GoBack();
        }
    }
}