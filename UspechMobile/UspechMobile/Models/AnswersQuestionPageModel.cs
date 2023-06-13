using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class AnswersQuestionPageModel : IAnswersQuestionPageModel
    {
        private string fio;
        private ObservableCollection<AnswersQuestion> answers;

        public string FIO { get => fio; set => fio = value; }
        public ObservableCollection<AnswersQuestion> Answers { get => answers; set => answers = value; }

        public void GoBack()
        {
            // Логика возврата к предыдущему окну
        }
    }
}
