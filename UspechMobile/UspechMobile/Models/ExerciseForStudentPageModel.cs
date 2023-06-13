using System;
using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class ExerciseForStudentPageModel : IExerciseForStudentPageModel
    {
        private string title;
        private string description;
        private ObservableCollection<ExerciseFiles> files;
        private string answer;
        private int grade;
        private string comments;

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public ObservableCollection<ExerciseFiles> Files { get => files; set => files = value; }
        public string Answer { get => answer; set => answer = value; }
        public int Grade { get => grade; set => grade = value; }
        public string Comments { get => comments; set => comments = value; }

        public void DownloadFile(string IDFile)
        {
            // Логика загрузки файла задания
        }

        public void AddAnswer()
        {
            // Логика добавления ответа на задание
        }

        public void EditAnswer()
        {
            // Логика редактирования ответа на задание
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }
    }
}