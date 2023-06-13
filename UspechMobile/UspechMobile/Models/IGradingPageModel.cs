using System.Collections.ObjectModel;

namespace UspechMobile.Models
{
    internal interface IGradingPageModel
    {
        ObservableCollection<IAssessedAssignment> Students { get; set; }

        void GoBack();
    }
}