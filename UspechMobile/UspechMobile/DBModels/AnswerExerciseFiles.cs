using SQLite;
using SQLiteNetExtensions.Attributes;

namespace UspechMobile.DBModels
{
    public class AnswerExerciseFiles
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public byte[] File { get; set; }
        public string FileName { get; set; }

        [ForeignKey(typeof(AnswersExercise))]
        public int IDAnswer { get; set; }
    }
}