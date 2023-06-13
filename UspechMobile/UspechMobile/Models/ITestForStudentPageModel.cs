namespace UspechMobile.Models
{
    internal interface ITestForStudentPageModel
    {
        string Title { get; set; }
        string Description { get; set; }

        void StartTest();

        void GoBack();
    }
}