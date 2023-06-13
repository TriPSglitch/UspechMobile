using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal interface IExerciseForStudentPageModel
    {
        string Title { get; set; }
        string Description { get; set; }
        ObservableCollection<ExerciseFiles> Files { get; set; }
        string Answer { get; set; }
        int Grade { get; set; }
        string Comments { get; set; }

        void DownloadFile(string IDFile);

        void AddAnswer();

        void EditAnswer();

        void GoBack();
    }
}