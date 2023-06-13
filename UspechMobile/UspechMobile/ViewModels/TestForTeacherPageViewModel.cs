using System.Windows.Input;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class TestForTeacherPageViewModel : BaseViewModel
    {
        private ITestForTeacherPageModel TestForTeacherPageModel;

        public ICommand GradeCommand { get; }
        public ICommand AttendanceTableCommand { get; }
        public ICommand GoBackCommand { get; }

        public string Title
        {
            get
            {
                return TestForTeacherPageModel.Title;
            }
            set
            {
                TestForTeacherPageModel.Title = value;
                NotifyPropertyChanged(nameof(Title));
            }
        }

        public TestForTeacherPageViewModel()
        {
            TestForTeacherPageModel = new TestForTeacherPageModel();

            GradeCommand = new Command(Grade);
            AttendanceTableCommand = new Command(OpenAttendanceTable);
            GoBackCommand = new Command(GoBack);
        }

        private void Grade()
        {
            TestForTeacherPageModel.Grade();
        }

        private void OpenAttendanceTable()
        {
            TestForTeacherPageModel.OpenAttendanceTable();
        }

        private void GoBack()
        {
            TestForTeacherPageModel.GoBack();
        }
    }
}