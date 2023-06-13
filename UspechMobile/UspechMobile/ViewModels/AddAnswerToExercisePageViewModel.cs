using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using UspechMobile.DBModels;
using UspechMobile.Models;

namespace UspechMobile.ViewModels
{
    internal class AddAnswerToExercisePageViewModel : BaseViewModel
    {
        private IAddAnswerToExercisePageModel AddAnswerToExercisePageModel;

        public ICommand AddFileCommand { get; private set; }
        public ICommand DeleteFileCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }
        public ICommand GoBackCommand { get; private set; }

        public Exercises Exercise
        {
            get => AddAnswerToExercisePageModel.Exercise;
            set
            {
                AddAnswerToExercisePageModel.Exercise = value;
                NotifyPropertyChanged(nameof(Exercise));
            }
        }

        public string Answer
        {
            get => AddAnswerToExercisePageModel.Answer;
            set
            {
                AddAnswerToExercisePageModel.Answer = value;
                NotifyPropertyChanged(nameof(Answer));
            }
        }

        public ObservableCollection<File> AttachedFiles
        {
            get => AddAnswerToExercisePageModel.AttachedFiles;
            set
            {
                AddAnswerToExercisePageModel.AttachedFiles = value;
                NotifyPropertyChanged(nameof(AttachedFiles));
            }
        }

        public AddAnswerToExercisePageViewModel()
        {
            AddFileCommand = new Command(AddFile);
            DeleteFileCommand = new Command<string>(DeleteFile);
            SaveCommand = new Command(Save);
            GoBackCommand = new Command(GoBack);

            AddAnswerToExercisePageModel = new AddAnswerToExercisePageModel();
        }

        private void AddFile()
        {
            AddAnswerToExercisePageModel.AddFile();
        }

        private void DeleteFile(string ID)
        {
            AddAnswerToExercisePageModel.DeleteFile(ID);
        }

        private void Save()
        {
            AddAnswerToExercisePageModel.Save();
        }

        private void GoBack()
        {
            AddAnswerToExercisePageModel.GoBack();
        }
    }
}