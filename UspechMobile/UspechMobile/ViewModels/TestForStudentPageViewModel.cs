using System.Windows.Input;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class TestForStudentPageViewModel : BaseViewModel
    {
        private ITestForStudentPageModel TestForStudentPageModel;

        public ICommand StartTestCommand { get; }
        public ICommand GoBackCommand { get; }

        public string Title
        {
            get
            {
                return TestForStudentPageModel.Title;
            }
            set
            {
                TestForStudentPageModel.Title = value;
                NotifyPropertyChanged(nameof(Title));
            }
        }

        public string Description
        {
            get
            {
                return TestForStudentPageModel.Description;
            }
            set
            {
                TestForStudentPageModel.Description = value;
                NotifyPropertyChanged(nameof(Description));
            }
        }

        public TestForStudentPageViewModel()
        {
            TestForStudentPageModel = new TestForStudentPageModel();

            StartTestCommand = new Command(StartTest);
            GoBackCommand = new Command(GoBack);
        }

        private void StartTest()
        {
            TestForStudentPageModel.StartTest();
        }

        private void GoBack()
        {
            TestForStudentPageModel.GoBack();
        }
    }
}