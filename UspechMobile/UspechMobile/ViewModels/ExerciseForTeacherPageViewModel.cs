using System.Collections.ObjectModel;
using System.Windows.Input;
using UspechMobile.DBModels;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class ExerciseForTeacherPageViewModel : BaseViewModel
    {
        private IExerciseForTeacherPageModel ExerciseForTeacherPageModel;

        public ICommand DownloadFileCommand { get; }
        public ICommand GradeCommand { get; }
        public ICommand AttendanceTableCommand { get; }
        public ICommand GoBackCommand { get; }

        public string Title
        {
            get
            {
                return ExerciseForTeacherPageModel.Title;
            }
            set
            {
                ExerciseForTeacherPageModel.Title = value;
                NotifyPropertyChanged(nameof(Title));
            }
        }

        public string Description
        {
            get
            {
                return ExerciseForTeacherPageModel.Description;
            }
            set
            {
                ExerciseForTeacherPageModel.Description = value;
                NotifyPropertyChanged(nameof(Description));
            }
        }

        public ObservableCollection<ExerciseFiles> Files
        {
            get
            {
                return ExerciseForTeacherPageModel.Files;
            }
            set
            {
                ExerciseForTeacherPageModel.Files = value;
                NotifyPropertyChanged(nameof(Files));
            }
        }
        public string Answer
        {
            get
            {
                return ExerciseForTeacherPageModel.Answer;
            }
            set
            {
                ExerciseForTeacherPageModel.Answer = value;
                NotifyPropertyChanged(nameof(Answer));
            }
        }

        public string Comments
        {
            get
            {
                return ExerciseForTeacherPageModel.Comments;
            }
            set
            {
                ExerciseForTeacherPageModel.Comments = value;
                NotifyPropertyChanged(nameof(Comments));
            }
        }

        public ExerciseForTeacherPageViewModel()
        {
            ExerciseForTeacherPageModel = new ExerciseForTeacherPageModel();

            DownloadFileCommand = new Command<string>(DownloadFile);
            GradeCommand = new Command(Grade);
            AttendanceTableCommand = new Command(OpenAttendanceTable);
            GoBackCommand = new Command(GoBack);
        }

        private void DownloadFile(string ID)
        {
            ExerciseForTeacherPageModel.DownloadFile(ID);
        }

        private void Grade()
        {
            ExerciseForTeacherPageModel.Grade();
        }

        private void OpenAttendanceTable()
        {
            ExerciseForTeacherPageModel.OpenAttendanceTable();
        }

        private void GoBack()
        {
            ExerciseForTeacherPageModel.GoBack();
        }
    }
}