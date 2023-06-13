namespace UspechMobile.Models
{
    internal class QuestionPageModel : IQuestionPageModel
    {
        private string text;
        private string answerText;

        public string Text { get => text; set => text = value; }
        public string AnswerText { get => answerText; set => answerText = value; }

        public void PreviousQuestion()
        {
            // Логика добавления ответа на задание
        }

        public void NextQuestion()
        {
            // Логика редактирования ответа на задание
        }
    }
}