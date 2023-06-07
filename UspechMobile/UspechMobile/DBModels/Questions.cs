using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class Questions
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Tests))]
        public int IDTest { get; set; }
        public string Text { get; set; }
        public byte[] Image { get; set; }

        [ForeignKey(typeof(Types))]
        public int IDType { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<QuestionAnswerOptions> QuestionAnswerOptions { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<AnswersQuestion> AnswersQuestion { get; set; }
    }
}