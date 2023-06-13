using System;
using System.Collections.ObjectModel;

namespace UspechMobile.Models
{
    internal class GradingPageModel : IGradingPageModel
    {
        private ObservableCollection<IAssessedAssignment> students;

        public ObservableCollection<IAssessedAssignment> Students { get => students; set => students = value; }

        public void GoBack()
        {
            throw new NotImplementedException();
        }
    }
}