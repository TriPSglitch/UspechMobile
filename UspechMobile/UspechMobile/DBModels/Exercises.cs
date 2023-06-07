using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class Exercises
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Exercise { get ; set; }

        [Column("IsPassed")]
        public bool IsPassed { get; set; }

        [ForeignKey(typeof(Courses))]
        public int IDCourse { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ExerciseComments> ExerciseComments { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ExerciseFiles> ExerciseFiles { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<AnswersExercise> AnswersExercise { get; set; }
    }
}