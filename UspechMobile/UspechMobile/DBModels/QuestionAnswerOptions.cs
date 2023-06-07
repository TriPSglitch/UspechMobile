using SQLite;
using SQLiteNetExtensions.Attributes;

namespace UspechMobile.DBModels
{
    public class QuestionAnswerOptions
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Questions))]
        public int IDQuestion { get; set; }
        public string Answer { get ; set; }

        [Column("IsCorrect")]
        public bool IsCorrect { get; set; }
    }
}