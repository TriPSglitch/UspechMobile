using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class Lectures
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Lecture { get; set; }

        [Column("IsPassed")]
        public bool IsPassed { get; set; }

        [ForeignKey(typeof(Courses))]
        public int IDCourse { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<LectureFiles> LectureFiles { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<LectureImages> LectureImages { get; set; }
    }
}