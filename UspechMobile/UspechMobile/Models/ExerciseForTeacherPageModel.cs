using System;
using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class ExerciseForTeacherPageModel : IExerciseForTeacherPageModel
    {
        private string title;
        private string description;
        private ObservableCollection<ExerciseFiles> files;
        private string answer;
        private string comments;

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public ObservableCollection<ExerciseFiles> Files { get => files; set => files = value; }
        public string Answer { get => answer; set => answer = value; }
        public string Comments { get => comments; set => comments = value; }

        public void DownloadFile(string ID)
        {
            // Логика загрузки файла задания
        }

        public void Grade()
        {
            // Логика добавления ответа на задание
        }

        public void OpenAttendanceTable()
        {
            // Логика редактирования ответа на задание
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }
    }
}