using System;

namespace UspechMobile.Models
{
    internal class TestForTeacherPageModel : ITestForTeacherPageModel
    {
        private string title;

        public string Title { get => title; set => title = value; }

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