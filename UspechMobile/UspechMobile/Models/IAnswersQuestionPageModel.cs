using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal interface IAnswersQuestionPageModel
    {
        string FIO { get; set; }
        ObservableCollection<AnswersQuestion> Answers { get; set; }

        void GoBack();
    }
}