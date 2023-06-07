using System.Collections.ObjectModel;
using UspechMobile.Models;

namespace UspechMobile.ViewModels
{
    internal class ProgressTablePageViewModel : BaseViewModel
    {
        private IProgressTablePageModel ProgressTablePageModel;

        public ObservableCollection<IAssessedAssignment> StudentTestGrade
        {
            get
            {
                return ProgressTablePageModel.StudentTestGrade;
            }
            set
            {
                ProgressTablePageModel.StudentTestGrade = value;
                NotifyPropertyChanged(nameof(StudentTestGrade));
            }
        }

        public ProgressTablePageViewModel()
        {
            ProgressTablePageModel = new ProgressTablePageModel();
        }
    }
}