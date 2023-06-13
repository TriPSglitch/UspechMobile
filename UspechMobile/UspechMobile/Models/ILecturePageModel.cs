using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal interface ILecturePageModel
    {
        string Title { get; set; }
        ObservableCollection<ExerciseFiles> Files { get; set; }
        string LectureText { get; set; }

        void DownloadFile(string IDFile);

        void GoBack();
    }
}