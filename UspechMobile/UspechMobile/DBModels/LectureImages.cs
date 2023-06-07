using SQLite;
using SQLiteNetExtensions.Attributes;

namespace UspechMobile.DBModels
{
    public class LectureImages
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public byte[] Image { get; set; }

        [ForeignKey(typeof(Courses))]
        public int IDLecture { get; set; }
    }
}