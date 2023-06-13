namespace UspechMobile.Models
{
    internal interface ITestForTeacherPageModel
    {
        string Title { get; set; }

        void Grade();

        void OpenAttendanceTable();

        void GoBack();
    }
}