using SQLite;
using SQLiteNetExtensions.Attributes;

namespace UspechMobile.DBModels
{
    public class LectureFiles
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public byte[] File { get; set; }
        public string FileName { get; set; }

        [ForeignKey(typeof(Courses))]
        public int IDLecture { get; set; }
    }
}