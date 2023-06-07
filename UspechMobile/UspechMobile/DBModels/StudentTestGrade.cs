using SQLite;
using SQLiteNetExtensions.Attributes;

namespace UspechMobile.DBModels
{
    public class StudentTestGrade
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Tests))]
        public int IDTest { get; set; }
        public int IDStudent { get; set; }
        public int Grade { get; set; }
    }
}