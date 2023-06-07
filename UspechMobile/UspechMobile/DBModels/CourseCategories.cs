using SQLite;
using SQLiteNetExtensions.Attributes;

namespace UspechMobile.DBModels
{
    public class CourseCategories
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Courses))]
        public int IDCourse { get; set; }

        [ForeignKey(typeof(Categories))]
        public int IDCategory { get; set; }
    }
}