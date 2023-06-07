using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class AnswersExercise
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int IDStudent { get; set; }

        [ForeignKey(typeof(Exercises))]
        public int IDExercise { get; set; }
        public string Text { get; set; }
        public int Grade { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<AnswerExerciseFiles> AnswerExerciseFiles { get; set; }
    }
}