namespace UspechMobile.Models
{
    internal interface IQuestionPageModel
    {
        string Text { get; set; }
        string AnswerText { get; set; }

        void PreviousQuestion();

        void NextQuestion();
    }
}