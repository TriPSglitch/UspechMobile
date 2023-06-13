using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal interface IAddAnswerToExercisePageModel
    {
        Exercises Exercise { get; set; }
        string Answer { get; set; }
        ObservableCollection<File> AttachedFiles { get; set; }

        void AddFile();

        void DeleteFile(string fileId);

        void Save();

        void GoBack();
    }
}