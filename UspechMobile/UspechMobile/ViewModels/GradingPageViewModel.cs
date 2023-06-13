using System.Collections.ObjectModel;
using System.Windows.Input;
using UspechMobile.Models;
using Xamarin.Forms;

namespace UspechMobile.ViewModels
{
    internal class GradingPageViewModel : BaseViewModel
    {
        private IGradingPageModel GradingPageModel;
        public ICommand GoBackCommand { get; }

        public ObservableCollection<IAssessedAssignment> Students
        {
            get => GradingPageModel.Students;
            set
            {
                GradingPageModel.Students = value;
                NotifyPropertyChanged(nameof(Students));
            }
        }

        public GradingPageViewModel()
        {
            GradingPageModel = new GradingPageModel();

            GoBackCommand = new Command(GoBack);
        }

        private void GoBack()
        {
            GradingPageModel.GoBack();
        }
    }
}