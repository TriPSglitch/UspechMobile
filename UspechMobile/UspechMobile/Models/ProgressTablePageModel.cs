using System.Collections.ObjectModel;

namespace UspechMobile.Models
{
    internal class ProgressTablePageModel : IProgressTablePageModel
    {
        private ObservableCollection<IAssessedAssignment> studentTestGrade;

        public ObservableCollection<IAssessedAssignment> StudentTestGrade { get => studentTestGrade; set => studentTestGrade = value; }

        //public ProgressTablePageModel(IProgressTablePageModel assignmen)
        //{

        //}
    }
}