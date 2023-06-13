using System.Collections.ObjectModel;
using System.Windows.Input;
using UspechMobile.DBModels;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class LecturePageViewModel : BaseViewModel
    {
        private ILecturePageModel LecturePageModel;

        public ICommand DownloadFileCommand { get; }
        public ICommand GoBackCommand { get; }

        public string Title
        {
            get
            {
                return LecturePageModel.Title;
            }
            set
            {
                LecturePageModel.Title = value;
                NotifyPropertyChanged(nameof(Title));
            }
        }

        public ObservableCollection<ExerciseFiles> Files
        {
            get
            {
                return LecturePageModel.Files;
            }
            set
            {
                LecturePageModel.Files = value;
                NotifyPropertyChanged(nameof(Files));
            }
        }

        public string LectureText
        {
            get
            {
                return LecturePageModel.LectureText;
            }
            set
            {
                LecturePageModel.LectureText = value;
                NotifyPropertyChanged(nameof(LectureText));
            }
        }

        public LecturePageViewModel()
        {
            LecturePageModel = new LecturePageModel();

            DownloadFileCommand = new Command<string>(DownloadFile);
            GoBackCommand = new Command(GoBack);
        }

        private void DownloadFile(string ID)
        {
            LecturePageModel.DownloadFile(ID);
        }

        private void GoBack()
        {
            LecturePageModel.GoBack();
        }
    }
}