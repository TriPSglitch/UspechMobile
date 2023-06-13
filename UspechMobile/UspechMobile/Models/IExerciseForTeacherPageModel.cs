using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal interface IExerciseForTeacherPageModel
    {
        string Title { get; set; }
        string Description { get; set; }
        ObservableCollection<ExerciseFiles> Files { get; set; }
        string Answer { get; set; }
        string Comments { get; set; }

        void DownloadFile(string IDFile);

        void Grade();

        void OpenAttendanceTable();

        void GoBack();
    }
}