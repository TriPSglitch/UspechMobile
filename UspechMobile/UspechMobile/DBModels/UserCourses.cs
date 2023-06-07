using SQLite;
using SQLiteNetExtensions.Attributes;

namespace UspechMobile.DBModels
{
    public class UserCourses
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Users))]
        public int IDUser { get; set; }

        [ForeignKey(typeof(Courses))]
        public int IDCourse { get; set; }

        public float PassPercentage { get; set; }
    }
}