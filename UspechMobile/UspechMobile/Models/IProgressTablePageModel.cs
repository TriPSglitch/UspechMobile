using System.Collections.ObjectModel;

namespace UspechMobile.Models
{
    internal interface IProgressTablePageModel
    {
        ObservableCollection<IAssessedAssignment> StudentTestGrade { get; set; }
    }
}