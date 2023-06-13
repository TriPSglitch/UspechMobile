using System;

namespace UspechMobile.Models
{
    internal class TestForStudentPageModel : ITestForStudentPageModel
    {
        private string title;
        private string description;

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }

        public void StartTest()
        {
            // Логика редактирования ответа на задание
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }
    }
}