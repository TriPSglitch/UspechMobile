using SQLite;
using SQLiteNetExtensions.Attributes;
using System;

namespace UspechMobile.DBModels
{
    public class ExerciseComments
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Exercises))]
        public int IDExercise { get; set; }

        public int IDUser { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}