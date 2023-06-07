using SQLite;
using SQLiteNetExtensions.Attributes;

namespace UspechMobile.DBModels
{
    public class AnswersQuestion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int IDStudent { get; set; }

        [ForeignKey(typeof(Questions))]
        public int IDQuestion { get; set; }
        public int IDAnswerOption { get; set; }
        public string Text { get; set; }
    }
}