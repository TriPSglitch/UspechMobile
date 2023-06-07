using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class Tests
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Column("IsPassed")]
        public bool IsPassed { get; set; }

        [ForeignKey(typeof(Courses))]
        public int IDCourse { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<TestComments> TestComments { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Questions> Questions { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<StudentTestGrade> StudentTestGrade { get; set; }
    }
}