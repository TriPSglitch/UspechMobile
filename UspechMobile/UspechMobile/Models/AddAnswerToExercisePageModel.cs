using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class AddAnswerToExercisePageModel : IAddAnswerToExercisePageModel
    {
        private Exercises exercise;
        private string answer;
        private ObservableCollection<File> attachedFiles;

        public Exercises Exercise {  get => exercise; set => exercise = value; }
        public string Answer {  get => answer; set => answer = value; }
        public ObservableCollection<File> AttachedFiles { get => attachedFiles; set => attachedFiles = value; }

        public void AddFile()
        {
            // Логика добавления файла
        }

        public void DeleteFile(string fileId)
        {
            // Логика удаления файла
        }

        public void Save()
        {
            // Логика сохранения ответа
        }

        public void GoBack()
        {
            // Логика возврата к предыдущему окну
        }
    }
}