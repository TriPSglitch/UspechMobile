using System;
using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class LecturePageModel : ILecturePageModel
    {
        private string title;
        private ObservableCollection<ExerciseFiles> files;
        private string lectureText;

        public string Title { get => title; set => title = value; }
        public ObservableCollection<ExerciseFiles> Files { get => files; set => files = value; }
        public string LectureText { get => lectureText; set => lectureText = value; }

        public void DownloadFile(string IDFile)
        {
            // Логика загрузки файла задания
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }
    }
}